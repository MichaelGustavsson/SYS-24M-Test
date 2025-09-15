using Application.DTOs;
using Application.Interfaces;

namespace BankAccount.Tests.Mock;

public class MockAccountRepository : IAccountRepository
{
    public Task<AccountDto> CreateAccount(CreateAccountDto accountDto)
    {
        Random rnd = new();
        string prefix = "5578";
        int suffix = rnd.Next(1000000, 9999999);

        var bankAccount = new AccountDto()
        {
            Id = Guid.NewGuid().ToString().Replace("-", ""),
            AccountNumber = $"{prefix}-{suffix}",
            CreatedDate = accountDto.CreatedDate,
            Balance = accountDto.Balance,
            AccountType = string.IsNullOrEmpty(accountDto.AccountType) ? "Basic" : accountDto.AccountType,
            IsBlocked = false,
            Owner = accountDto.Owner
        };

        return Task.FromResult(bankAccount);
    }

    public Task<Task> Deposit(string accountNumber, decimal amount)
    {
        throw new NotImplementedException();
    }

    public Task<AccountDto> GetAccount(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<AccountDto>> ListAllAccounts()
    {
        var accounts = new List<AccountDto>
        {
            new() {
                Id = "31ed325b19014c179e6414299be64fef",
                IsBlocked = false,
                AccountNumber = "5578-3498916",
                CreatedDate = DateTime.Parse("2025-09-15T11:47:11.279357+02:00"),
                Owner = "Michael Gustavsson",
                Balance = 0.00M,
                AccountType = "Basic"
            },
            new() {
                Id = "41ed325b19014c179e6414299be64fef",
                IsBlocked = true,
                AccountNumber = "5578-3498921",
                CreatedDate = DateTime.Parse("2025-08-15T11:47:11.279357+02:00"),
                Owner = "Stig Gustavsson",
                Balance = 500.00M,
                AccountType = "Savings"
            }
        };

        return Task.FromResult(accounts);
    }

    public Task<List<AccountDto>> ListAllAccounts(string owner)
    {
        throw new NotImplementedException();
    }

    public Task WithDraw(string accountNumber, decimal amount)
    {
        throw new NotImplementedException();
    }
}
