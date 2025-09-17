using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces;

public interface IAccountService
{
    public Task<AccountDto> CreateAccount(CreateAccountDto accountDto);
    public Task<List<AccountDto>> ListAllAccounts();
    public Task<List<AccountDto>> ListAllAccounts(string owner);
    public Task<AccountDto> GetAccount(string id);
    public Task<Task> Deposit(string accountNumber, decimal amount);
    public Task WithDraw(string accountNumber, decimal amount);
}
