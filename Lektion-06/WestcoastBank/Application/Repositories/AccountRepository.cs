using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;

public class AccountRepository(AppDbContext context) : IAccountRepository
{
    public async Task<BankAccount> CreateAccount(BankAccount account)
    {
        context.BankAccounts.Add(account);
        await context.SaveChangesAsync();

        return account;
    }

    public Task<Task> Deposit(string accountNumber, decimal amount)
    {
        throw new NotImplementedException();
    }

    public async Task<BankAccount?> GetAccount(string id)
    {
        return await context.BankAccounts.FindAsync(id);
    }

    public async Task<List<BankAccount>> ListAllAccounts()
    {
        return await context.BankAccounts.ToListAsync();
    }

    public async Task<List<BankAccount>> ListAllAccounts(string owner)
    {
        return await context.BankAccounts.Where(c => c.Owner == owner).ToListAsync();
    }

    public Task WithDraw(string accountNumber, decimal amount)
    {
        throw new NotImplementedException();
    }
}
