/*
 * Name: Jerald Bradley
 * Date: 11/12/2026
 * Assignment: SDC320L Project Week 1
 * Purpose: Runs the console menu and displays the Week 1 sample contacts.
 */

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("SDC320L Project Week 1 - Rolodex/Contacts Application");
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

        while (true)
        {
            Console.WriteLine("\n1. Display all sample contacts");
            Console.WriteLine("0. Exit");
            Console.Write("Selection: ");
            string? selection = Console.ReadLine()?.Trim();

            switch (selection)
            {
                case "1":
                    DisplayContacts(contacts);
                    break;
                case null:
                case "0":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Please enter 1 or 0.");
                    break;
            }
        }
    }

    private static void DisplayContacts(Contact[] contacts)
    {
        for (int index = 0; index < contacts.Length; index++)
        {
            // Contact.ToString includes the detail supplied by each derived class.
            Console.WriteLine($"\n{index + 1}. {contacts[index]}");
        }
    }
}
