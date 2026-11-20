/*
 * Name: Jerald Bradley
 * Date: 11/17/2026
 * Assignment: SDC320 Project Week 2
 * Purpose: Stores contacts in memory and searches by last-name initial.
 */

using System;
using System.Collections.Generic;

public class ContactDirectory : IContactDirectory
{
    private readonly List<Contact> contacts;

    public ContactDirectory(IEnumerable<Contact> contacts)
    {
        this.contacts = new List<Contact>(contacts);
    }

    public IEnumerable<Contact> GetAll()
    {
        return contacts.AsReadOnly();
    }

    public IEnumerable<Contact> FindByLastInitial(char initial)
    {
        string prefix = initial.ToString();

        foreach (Contact contact in contacts)
        {
            if (contact.LastName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                yield return contact;
            }
        }
    }
}
