using API.Models;

namespace API.Interfaces;

public interface IAccountRepository
{
    public Task<List<Account>> ListAllAccounts();
    public Task<Account> FindAccount(string accountNumber);
}
