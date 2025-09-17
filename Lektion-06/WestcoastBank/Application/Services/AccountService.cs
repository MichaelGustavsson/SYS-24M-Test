using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class AccountService(IMapper mapper, IAccountRepository accountRepository) : IAccountService
{
    public async Task<AccountDto> CreateAccount(CreateAccountDto accountDto)
    {
        Random rnd = new();
        string prefix = "5578";
        int suffix = rnd.Next(1000000, 9999999);
        accountDto.AccountNumber = $"{prefix}-{suffix}";
        accountDto.CreatedDate = DateTime.Now;

        var account = mapper.Map<BankAccount>(accountDto);
        var result = await accountRepository.CreateAccount(account);

        return mapper.Map<AccountDto>(result);
    }

    public Task<Task> Deposit(string accountNumber, decimal amount)
    {
        throw new NotImplementedException();
    }

    public async Task<AccountDto> GetAccount(string id)
    {
        var result = await accountRepository.GetAccount(id);
        return mapper.Map<AccountDto>(result);
    }

    public async Task<List<AccountDto>> ListAllAccounts()
    {
        var result = await accountRepository.ListAllAccounts();
        return mapper.Map<List<AccountDto>>(result);
    }

    public async Task<List<AccountDto>> ListAllAccounts(string owner)
    {
        var result = await accountRepository.ListAllAccounts(owner);
        return mapper.Map<List<AccountDto>>(result);
    }

    public Task WithDraw(string accountNumber, decimal amount)
    {
        throw new NotImplementedException();
    }
}
