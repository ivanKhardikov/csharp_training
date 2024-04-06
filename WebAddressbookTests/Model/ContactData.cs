namespace WebAddressbookTests
{
    public class ContactData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ContactData(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}