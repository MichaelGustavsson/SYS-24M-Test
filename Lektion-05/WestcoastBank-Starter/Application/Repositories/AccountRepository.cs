using Application.DTOs;
using Application.Interfaces;

namespace Application.Repositories;

public class AccountRepository : IAccountRepository
{
    public Task<AccountDto> CreateAccount(CreateAccountDto accountDto)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
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
