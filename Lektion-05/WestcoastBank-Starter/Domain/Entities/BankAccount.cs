namespace Domain.Entities;

public class BankAccount
{
    public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    public required string AccountNumber { get; set; }
    public required DateTime CreatedDate { get; set; } = DateTime.Now;
    public required string Owner { get; set; }
    public required decimal Balance { get; set; }
    public required string AccountType { get; set; }
    public bool IsBlocked { get; set; } = false;
}
