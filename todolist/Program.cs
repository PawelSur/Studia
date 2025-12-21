using System;
using System.Collections.Generic;

class ToDoItem
{
    public string description = "";
    public bool iscompleted = false;
}
class Program
{
    static void Main()
    {
       List<ToDoItem> toDoList = new List<ToDoItem>();
       ToDoItem item1 = new ToDoItem();
       item1.description = "Zrobić zakupy";
       toDoList.Add(item1);
        while(true)
        {
            Menu(toDoList);
        }

    }
    static void Menu(List<ToDoItem> toDoList)
    {
        Console.WriteLine("1. Wyświetl listę zadań");
        Console.WriteLine("2. Dodaj nowe zadanie");
        Console.WriteLine("3. Usuń zadanie");                 
        Console.WriteLine("4. Zaznacz zadanie jako ukończone");
        Console.WriteLine("5. Zakończ program");                 
        switch(Console.ReadLine())
        {
            case "1":
                DisplayTasks(toDoList);
                break;
            case "2":
                AddTask(toDoList);
                break;
            case "3":
                RemoveTask(toDoList);
                break;
            case "4":
                MarkTaskCompleted(toDoList);
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                Menu(toDoList);
                break;
        }
    }
    
    static void DisplayTasks(List<ToDoItem> todoList)
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("Brak zadań na liście.");
            return;
        }
        for(int i = 0; i < todoList.Count; i++)
        {
            string status = "[ ]";
            if(todoList[i].iscompleted == true){
                status = "[X]";
            }
            
            Console.WriteLine($"{i + 1}. {status} {todoList[i].description}");
        }
    }
    
    static void AddTask(List<ToDoItem> todoList)
    {
        Console.WriteLine("Podaj opis zadania:");
        string description = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(description))
        {
            ToDoItem newItem = new ToDoItem();
            newItem.description = description;
            todoList.Add(newItem);
            Console.WriteLine("Zadanie dodane!");
        }
        else
        {
            Console.WriteLine("Opis zadania nie może być pusty.");
        }
    }
    
    static void RemoveTask(List<ToDoItem> todoList)
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("Brak zadań do usunięcia.");
            return;
        }
        DisplayTasks(todoList);
        Console.WriteLine("Podaj numer zadania do usunięcia:");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList.RemoveAt(index - 1);
            Console.WriteLine("Zadanie usunięte!");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy numer zadania.");
        }
    }
    
    static void MarkTaskCompleted(List<ToDoItem> todoList)
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("Brak zadań do oznaczenia.");
            return;
        }
        DisplayTasks(todoList);
        Console.WriteLine("Podaj numer zadania do oznaczenia jako ukończone:");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            todoList[index - 1].iscompleted = true;
            Console.WriteLine("Zadanie oznaczone jako ukończone!");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy numer zadania.");
        }
    }
}
