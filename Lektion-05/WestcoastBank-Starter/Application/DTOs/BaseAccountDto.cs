using System;

namespace Application.DTOs;

public class BaseAccountDto
{
    public string AccountNumber { get; set; } = "";
    public DateTime CreatedDate { get; set; }
    public string Owner { get; set; } = "";
    public decimal Balance { get; set; }
    public string AccountType { get; set; } = "";
}
