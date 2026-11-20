/*
 * Name: Jerald Bradley
 * Date: 11/17/2026
 * Assignment: SDC320 Project Week 2
 * Purpose: Defines the information shared by all contact types.
 */

public abstract class Contact
{
    public string FirstName { get; }
    public string LastName { get; }
    public ContactDetails Details { get; }
    public abstract string ContactType { get; }
    protected abstract string ExtraInformation { get; }

    protected Contact(string firstName, string lastName, string phone, string email)
    {
        FirstName = firstName;
        LastName = lastName;

        // Composition: each contact creates and owns its contact details.
        Details = new ContactDetails(phone, email);
    }

    public override string ToString()
    {
        // Polymorphism: each derived contact supplies ContactType and ExtraInformation.
        return $"{FirstName} {LastName} ({ContactType})\n" +
               $"Phone: {Details.Phone}\nEmail: {Details.Email}\n{ExtraInformation}";
    }
}
