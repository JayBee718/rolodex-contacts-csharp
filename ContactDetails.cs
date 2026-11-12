/*
 * Name: Jerald Bradley
 * Date: 11/12/2026
 * Assignment: SDC320L Project Week 1
 * Purpose: Stores the phone number and email address for a contact.
 */

public class ContactDetails
{
    public string Phone { get; }
    public string Email { get; }

    public ContactDetails(string phone, string email)
    {
        Phone = phone;
        Email = email;
    }
}
