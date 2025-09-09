using Domain.Entities;
using Services.DTOs;

namespace Services.Interfaces;

public interface IAccountRepository
{
    public Task<string> CreateAccount(AccountDto accountDto);
    public Task<List<AccountDto>> ListAllAccounts();
    public Task<List<AccountDto>> ListAllAccounts(string owner);
    public Task<AccountDto> GetAccount(string id);
    public Task<Task> Deposit(string accountNumber, decimal amount);
    public Task WithDraw(string accountNumber, decimal amount);
}
