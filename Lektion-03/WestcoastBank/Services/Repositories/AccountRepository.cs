using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Services.Interfaces;

namespace Services.Repositories;

public class AccountRepository(AppDbContext context) : IAccountRepository
{
    public async Task<string> CreateAccount(Account accountDto)
    {
        context.Accounts.Add(accountDto);
        var result = await context.SaveChangesAsync() > 0;

        if (!result) throw new Exception("Failed to create the account");
        return accountDto.Id;
    }

    public async Task<Task> Deposit(string accountNumber, decimal amount)
    {
        var account = await context.Accounts.SingleOrDefaultAsync(c => c.AccountNumber == accountNumber)
            ?? throw new Exception("No account found");

        account.Balance += amount;

        var result = context.SaveChanges() > 0;
        if (!result) throw new Exception("Error occurred when depositing the amount");

        return Task.CompletedTask;
    }

    public async Task<Account> GetAccount(string id)
    {
        var account = await context.Accounts.FindAsync(id)
            ?? throw new Exception("No account found");

        return account;
    }

    public async Task<List<Account>> ListAllAccounts()
    {
        var accounts = await context.Accounts.ToListAsync();
        return accounts;
    }

    public async Task<List<Account>> ListAllAccounts(string owner)
    {
        var predicate = owner.ToLower().Replace(" ", "");
        var accounts = await context.Accounts.Where(c => c.Owner.ToLower().Replace(" ", "") == predicate).ToListAsync();
        return accounts;
    }

    public async Task WithDraw(string accountNumber, decimal amount)
    {
        var account = context.Accounts.FirstOrDefault(c => c.AccountNumber == accountNumber) ?? throw new Exception("No account found");
        var balance = account.Balance;

        if (amount > 0)
        {
            amount = 0 - amount;
        }

        account.Balance += amount;

        if (account.Balance < 0) throw new Exception("Not enough fund for withdrawal");

        await context.SaveChangesAsync();
    }
}
