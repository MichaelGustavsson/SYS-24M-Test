using Domain.Entities;

namespace Services.Interfaces;

public interface IAccountRepository
{
    public Task<string> CreateAccount(Account accountDto);
    public Task<List<Account>> ListAllAccounts();
    public Task<List<Account>> ListAllAccounts(string owner);
    public Task<Account> GetAccount(string id);
    public Task<Task> Deposit(string accountNumber, decimal amount);
    public Task WithDraw(string accountNumber, decimal amount);
}
