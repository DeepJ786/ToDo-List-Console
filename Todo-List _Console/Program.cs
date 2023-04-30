using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();
            string input;
            int choice;

            Console.WriteLine("Welcome to the To-Do List App!");

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Remove a task");
                Console.WriteLine("3. View tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                input = Console.ReadLine();
                choice = Convert.ToInt32(input);

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a task: ");
                        string task = Console.ReadLine();
                        todoList.Add(task);
                        Console.WriteLine("Task added.");
                        break;
                    case 2:
                        Console.Write("Enter the task number to remove: ");
                        int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (taskNumber >= 0 && taskNumber < todoList.Count)
                        {
                            todoList.RemoveAt(taskNumber);
                            Console.WriteLine("Task removed.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nTasks:");
                        for (int i = 0; i < todoList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {todoList[i]}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            } while (choice != 4);
        }
    }
}