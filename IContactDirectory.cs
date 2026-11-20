/*
 * Name: Jerald Bradley
 * Date: 11/17/2026
 * Assignment: SDC320 Project Week 2
 * Purpose: Defines the contact lookup operations used by the console menu.
 */

using System.Collections.Generic;

// Interface: any contact directory must provide both lookup operations.
public interface IContactDirectory
{
    IEnumerable<Contact> GetAll();
    IEnumerable<Contact> FindByLastInitial(char initial);
}
