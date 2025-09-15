# 📝 ToDoList Console Application - CodVeda Internship Task

A simple **C# console application** that allows users to manage their daily tasks using a To-Do List.  
This project was developed as part of my **CodVeda Internship** tasks.  
It demonstrates **collections, file handling (import/export), LINQ for searching, and command-line arguments** in C#.

---

## 🚀 Features
- ➕ Add new tasks  
- 📋 List all tasks  
- 🔍 Search tasks by keyword  
- ❌ Remove a task by its number  
- 🧹 Clear all tasks  
- ✏️ Update an existing task  
- ✅ Mark a task as completed  
- 📤 Export tasks to a file (`tasks.txt`)  
- 📥 Import tasks from a file (`tasks.txt`)  

---

## 🛠️ Technologies Used
- **C#**  
- **.NET Console Application**  
- **Collections** (`List<string>`)  
- **LINQ** (searching/filtering tasks)  
- **File Handling** (import/export)  
- **Command-line arguments**  

---

## 📂 Project Structure
- **Program.cs** → Entry point, parses command-line arguments, implements all features  
- **tasks.txt** → Text file used for saving (export) and loading (import) tasks  
- **README.md** → Documentation file  

---

## 📥 Download & Run
You can download the latest version of the application from the Release section:

[Download ToDoList Console App v1.0](https://github.com/Ahmed-Ayman630/ToDoList-ConsoleApp/releases/download/v1.0/ToDoListConsole.zip)

---

## 🖥️ How to Run
1. Download the `.zip` file from the release link above.  
2. Extract it to a folder.  
3. Open **PowerShell** or **Command Prompt** in that folder.  
4. Run commands in the format:
   ```powershell
   ToDoListConsole.exe [command] [arguments]

## ⚡ Available Commands

| Command | Example | Description |
|---------|---------|-------------|
| ➕ **add** | `ToDoListConsole.exe add "Learn C#"` | Add a new task |
| 📋 **list** | `ToDoListConsole.exe list` | List all tasks |
| 🔍 **search** | `ToDoListConsole.exe search "C#"` | Search tasks by keyword |
| ❌ **remove** | `ToDoListConsole.exe remove 2` | Remove task #2 |
| 🧹 **clear** | `ToDoListConsole.exe clear` | Clear all tasks |
| ✏️ **update** | `ToDoListConsole.exe update 1 "Study C# in depth"` | Update task #1 |
| ✅ **mark** | `ToDoListConsole.exe mark 1` | Mark task #1 as completed |
| 📤 **export** | `ToDoListConsole.exe export` | Save tasks into `tasks.txt` |
| 📥 **import** | `ToDoListConsole.exe import` | Load tasks from `tasks.txt` |


## 🎯 Learning Outcomes
- By completing this project, I practiced and learned:
- ✅ Applying OOP concepts in C# (Encapsulation, Class Management)
- ✅ Handling user input/output via the command line
- ✅ Implementing file handling (export & import)
- ✅ Working with collections to manage tasks
- ✅ Building a practical CLI app with real-life usage


