/*
 * Name: Jerald Bradley
 * Date: 11/12/2026
 * Assignment: SDC320L Project Week 1
 * Purpose: Represents a friend contact and stores the how we met detail.
 */

// Inheritance: FriendContact uses the shared name and contact details from Contact.
public class FriendContact : Contact
{
    public string HowWeMet { get; }
    public override string ContactType => "Friend";
    protected override string ExtraInformation => $"How we met: {HowWeMet}";

    public FriendContact(string firstName, string lastName, string phone, string email,
        string howWeMet) : base(firstName, lastName, phone, email)
    {
        HowWeMet = howWeMet;
    }
}
