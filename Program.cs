using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- TO DO LIST ---");
                Console.WriteLine("1. Lägg till uppgift");
                Console.WriteLine("2. Visa alla uppgifter");
                Console.WriteLine("3. Markera uppgift som klar");
                Console.WriteLine("4. Avsluta");
                Console.Write("\nVälj: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add a new task
                        Console.Write("Ange en uppgift: ");
                        string description = Console.ReadLine();

                        tasks.Add(new Task
                        {
                            Description = description,
                            Done = false
                        });

                        Console.WriteLine(
                            $"Uppgiften '{description}' har lagts till!"
                        );
                        break;

                    case "2":
                        // Show all tasks
                        Console.WriteLine("\nAlla uppgifter:");

                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Inga uppgifter.");
                        }
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                            {
                                string status = tasks[i].Done
                                    ? "Klar"
                                    : "Inte klar";

                                Console.WriteLine(
                                    $"{i + 1}. {tasks[i].Description} - {status}"
                                );
                            }
                        }
                        break;

                    case "3":
                        // Mark task as completed
                        Console.Write(
                            "Vilken uppgift är klar? Ange nummer: "
                        );

                        int number = int.Parse(Console.ReadLine());

                        if (number > 0 && number <= tasks.Count)
                        {
                            tasks[number - 1].Done = true;

                            Console.WriteLine(
                                $"Uppgiften '{tasks[number - 1].Description}' är klar!"
                            );
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt nummer.");
                        }
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Programmet avslutas.");
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val.");
                        break;
                }
            }
        }
    }
}