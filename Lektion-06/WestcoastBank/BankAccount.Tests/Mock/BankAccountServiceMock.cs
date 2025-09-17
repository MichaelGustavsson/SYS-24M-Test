using Application.DTOs;
using Application.Interfaces;

namespace BankAccount.Tests.Mock;

public class BankAccountServiceMock : IAccountService
{
    public Task<AccountDto> CreateAccount(CreateAccountDto accountDto)
    {
        Random rnd = new();
        string prefix = "5578";
        int suffix = rnd.Next(1000000, 9999999);

        var bankAccount = new AccountDto
        {
            AccountNumber = $"{prefix}-{suffix}",
            Owner = accountDto.Owner,
            CreatedDate = accountDto.CreatedDate
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
            new(){},
            new(){}
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
