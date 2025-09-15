namespace Application.DTOs;

public class AccountDto
{
    public string Id { get; set; } = "";
    public string AccountNumber { get; set; } = "";
    public DateTime CreatedDate { get; set; }
    public string Owner { get; set; } = "";
    public decimal Balance { get; set; }
    public string AccountType { get; set; } = "";
    public bool IsBlocked { get; set; } = false;
}
