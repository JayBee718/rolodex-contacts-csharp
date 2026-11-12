/*
 * Name: Jerald Bradley
 * Date: 11/12/2026
 * Assignment: SDC320L Project Week 1
 * Purpose: Represents a family contact and stores the relationship detail.
 */

// Inheritance: FamilyContact uses the shared name and contact details from Contact.
public class FamilyContact : Contact
{
    public string Relationship { get; }
    public override string ContactType => "Family";
    protected override string ExtraInformation => $"Relationship: {Relationship}";

    public FamilyContact(string firstName, string lastName, string phone, string email,
        string relationship) : base(firstName, lastName, phone, email)
    {
        Relationship = relationship;
    }
}
