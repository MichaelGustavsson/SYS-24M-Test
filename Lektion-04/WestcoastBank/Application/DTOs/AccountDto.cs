namespace Application.DTOs;

public class AccountDto
{
    public string AccountNumber { get; set; } = "";
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public string Owner { get; set; } = "";
    public decimal Balance { get; set; }
    public string AccountType { get; set; } = "";
}
