/*
 * Name: Jerald Bradley
 * Date: 11/17/2026
 * Assignment: SDC320 Project Week 2
 * Purpose: Runs the console menu, creates sample contacts, and displays directory results.
 */

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("SDC320L Project Week 2 - Rolodex/Contacts Application");
        Console.WriteLine("Jerald Bradley");
        Console.WriteLine("Welcome! Type a menu number and press Enter.");

        // Each derived object can be stored as a Contact.
        Contact[] contacts =
        {
            new BusinessContact("Maya", "Bennett", "757-555-0104",
                "maya.bennett@example.com", "Harbor Design Studio"),
            new FamilyContact("Daniel", "Brooks", "757-555-0117",
                "daniel.brooks@example.com", "Cousin"),
            new FriendContact("Jordan", "Rivera", "757-555-0128",
                "jordan.rivera@example.com", "Running club")
        };

        // Interface polymorphism: the menu calls the interface, and ContactDirectory runs the lookup.
        IContactDirectory directory = new ContactDirectory(contacts);

        while (true)
        {
            Console.WriteLine("\n1. Display all sample contacts");
            Console.WriteLine("2. Display contacts by last-name initial");
            Console.WriteLine("0. Exit");
            Console.Write("Selection: ");
            string? selection = Console.ReadLine()?.Trim();

            switch (selection)
            {
                case "1":
                    DisplayContacts(directory.GetAll());
                    break;
                case "2":
                    char? initial = ReadInitial();
                    if (!initial.HasValue)
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }

                    DisplayContacts(directory.FindByLastInitial(initial.Value));
                    break;
                case null:
                case "0":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Please enter 1, 2, or 0.");
                    break;
            }
        }
    }

    private static char? ReadInitial()
    {
        while (true)
        {
            Console.Write("Enter the first letter of the last name: ");
            string? input = Console.ReadLine()?.Trim();

            if (input == null)
            {
                return null;
            }

            if (input.Length == 1 && char.IsLetter(input[0]))
            {
                return input[0];
            }

            Console.WriteLine("Please enter one letter.");
        }
    }

    private static void DisplayContacts(IEnumerable<Contact> contacts)
    {
        int count = 0;

        foreach (Contact contact in contacts)
        {
            count++;
            // Inheritance polymorphism: ToString uses the current contact type's overrides.
            Console.WriteLine($"\n{count}. {contact}");
        }

        if (count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
    }
}
