/*
 * Name: Jerald Bradley
 * Date: 11/12/2026
 * Assignment: SDC320L Project Week 1
 * Purpose: Represents a business contact and stores the company detail.
 */

// Inheritance: BusinessContact uses the shared name and contact details from Contact.
public class BusinessContact : Contact
{
    public string Company { get; }
    public override string ContactType => "Business";
    protected override string ExtraInformation => $"Company: {Company}";

    public BusinessContact(string firstName, string lastName, string phone, string email,
        string company) : base(firstName, lastName, phone, email)
    {
        Company = company;
    }
}
