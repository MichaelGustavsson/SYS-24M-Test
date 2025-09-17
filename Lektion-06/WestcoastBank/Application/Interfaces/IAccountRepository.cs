using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces;

public interface IAccountRepository
{
    public Task<BankAccount> CreateAccount(BankAccount account);
    public Task<List<BankAccount>> ListAllAccounts();
    public Task<List<BankAccount>> ListAllAccounts(string owner);
    public Task<BankAccount?> GetAccount(string id);
    public Task<Task> Deposit(string accountNumber, decimal amount);
    public Task WithDraw(string accountNumber, decimal amount);
}
