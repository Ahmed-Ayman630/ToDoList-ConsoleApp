using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoListApp
{
    class Program
    {
        static List<string> tasks = new List<string>();
        static string filePath = "tasks.txt";

        static void Main(string[] args)
        {
            LoadTasks();

            if (args.Length == 0)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("  dotnet run add \"Task name\"");
                Console.WriteLine("  dotnet run list");
                Console.WriteLine("  dotnet run search \"keyword\"");
                Console.WriteLine("  dotnet run remove <task number>");
                Console.WriteLine("  dotnet run clear");
                Console.WriteLine("  dotnet run update <task number> \"new task\"");
                Console.WriteLine("  dotnet run mark <task number>");
                return;
            }

            string command = args[0].ToLower();

            switch (command)
            {
                case "add":
                    if (args.Length < 2)
                        Console.WriteLine("❌ Please provide a task name.");
                    else
                    {
                        string task = string.Join(" ", args.Skip(1));
                        tasks.Add("[ ] " + task);
                        Console.WriteLine($"✅ Task added: {task}");
                        SaveTasks();
                    }
                    break;

                case "list":
                    if (tasks.Count == 0)
                        Console.WriteLine("📭 No tasks found.");
                    else
                    {
                        Console.WriteLine("📋 Your Tasks:");
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                    break;

                case "search":
                    if (args.Length < 2)
                        Console.WriteLine("❌ Please provide a keyword to search.");
                    else
                    {
                        string keyword = string.Join(" ", args.Skip(1));
                        var results = tasks.Where(t => t.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

                        if (results.Count == 0)
                            Console.WriteLine($"🔍 No tasks found matching: {keyword}");
                        else
                        {
                            Console.WriteLine($"🔍 Tasks matching '{keyword}':");
                            foreach (var task in results)
                                Console.WriteLine($"- {task}");
                        }
                    }
                    break;

                case "remove":
                    if (args.Length < 2 || !int.TryParse(args[1], out int indexRemove))
                        Console.WriteLine("❌ Please provide a valid task number.");
                    else if (indexRemove < 1 || indexRemove > tasks.Count)
                        Console.WriteLine("❌ Task number out of range.");
                    else
                    {
                        string removed = tasks[indexRemove - 1];
                        tasks.RemoveAt(indexRemove - 1);
                        Console.WriteLine($"🗑️ Removed: {removed}");
                        SaveTasks();
                    }
                    break;

                case "clear":
                    tasks.Clear();
                    Console.WriteLine("🧹 All tasks cleared!");
                    SaveTasks();
                    break;

                case "update":
                    if (args.Length < 3 || !int.TryParse(args[1], out int indexUpdate))
                        Console.WriteLine("❌ Usage: dotnet run update <task number> \"new task\"");
                    else if (indexUpdate < 1 || indexUpdate > tasks.Count)
                        Console.WriteLine("❌ Task number out of range.");
                    else
                    {
                        string newTask = string.Join(" ", args.Skip(2));
                        tasks[indexUpdate - 1] = "[ ] " + newTask;
                        Console.WriteLine($"✏️ Task {indexUpdate} updated to: {newTask}");
                        SaveTasks();
                    }
                    break;

                case "mark":
                    if (args.Length < 2 || !int.TryParse(args[1], out int indexMark))
                        Console.WriteLine("❌ Usage: dotnet run mark <task number>");
                    else if (indexMark < 1 || indexMark > tasks.Count)
                        Console.WriteLine("❌ Task number out of range.");
                    else
                    {
                        tasks[indexMark - 1] = tasks[indexMark - 1].Replace("[ ]", "[✔]").Trim();
                        Console.WriteLine($"✅ Task {indexMark} marked as done!");
                        SaveTasks();
                    }
                    break;

                default:
                    Console.WriteLine("❌ Unknown command. Use: add, list, search, remove, clear, update, mark");
                    break;
            }
        }

        static void LoadTasks()
        {
            if (File.Exists(filePath))
                tasks = File.ReadAllLines(filePath).ToList();
        }

        static void SaveTasks()
        {
            File.WriteAllLines(filePath, tasks);
            Console.WriteLine("💾 Changes saved to tasks.txt");
        }
    }
}
