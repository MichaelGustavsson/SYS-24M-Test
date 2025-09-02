namespace BankingSystem;

public class Customer(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    // Skrivskyddad egenskapen...
    // Computed property...
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}
