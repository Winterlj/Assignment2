using System;
using System.Collections.Generic;
using System.Linq;

class ConsoleSystem
{
    private List<string> names;
    private bool loggedIn;
    private readonly string password;

    public ConsoleSystem()
    {
        names = new List<string> { "Alice", "Bob", "Charlie", "David" };
        loggedIn = false;
        password = "Colleges23";
    }

    public void Login()
    {
        while (!loggedIn)
        {
            Console.Write("Enter password to log in: ");
            string enteredPassword = Console.ReadLine();
            if (enteredPassword == password)
            {
                Console.WriteLine("Login successful!");
                loggedIn = true;
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }

    public void Logout()
    {
        Console.WriteLine("Logging out...");
        loggedIn = false;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\n===== Console System Menu =====");
        Console.WriteLine("1. Print Names");
        Console.WriteLine("2. Search Names");
        Console.WriteLine("3. Sort Names");
        Console.WriteLine("4. Add Name");
        Console.WriteLine("5. Logout");
        Console.WriteLine("==============================");
    }

    public void Run()
    {
        Login();

        while (loggedIn)
        {
            DisplayMenu();
            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintNames();
                    break;
                case "2":
                    SearchNames();
                    break;
                case "3":
                    SortNames();
                    break;
                case "4":
                    AddName();
                    break;
                case "5":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    public void PrintNames()
    {
        Console.WriteLine("List of Names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

    public void SearchNames()
    {
        Console.Write("Enter name to search: ");
        string searchTerm = Console.ReadLine();
        if (names.Contains(searchTerm))
        {
            Console.WriteLine(searchTerm + " found in the list.");
        }
        else
        {
            Console.WriteLine(searchTerm + " not found.");
        }
    }

    public void SortNames()
    {
        names = names.OrderBy(a => a).ToList();
        Console.WriteLine("Names sorted successfully.");
    }

    public void AddName()
    {
        Console.Write("Enter the name to add: ");
        string newName = Console.ReadLine();
        names.Add(newName);
        Console.WriteLine(newName + " added to the list.");
    }

    static void Main()
    {
        ConsoleSystem console = new ConsoleSystem();
        console.Run();
    }
}

