using Application.DTOs;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;

public class AccountRepository(AppDbContext context) : IAccountRepository
{
    public Task<string> CreateAccount(AccountDto accountDto)
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

    public async Task<List<AccountDto>> ListAllAccounts()
    {
        // var accounts = await context.Accounts.ToListAsync();
        // return accounts;
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
