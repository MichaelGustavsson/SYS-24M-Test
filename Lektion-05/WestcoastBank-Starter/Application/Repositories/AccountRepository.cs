using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories;

public class AccountRepository(AppDbContext context, IMapper mapper) : IAccountRepository
{
    public async Task<AccountDto> CreateAccount(CreateAccountDto accountDto)
    {
        Random rnd = new();
        string prefix = "5578";
        int suffix = rnd.Next(1000000, 9999999);
        accountDto.AccountNumber = $"{prefix}-{suffix}";
        accountDto.CreatedDate = DateTime.Now;

        // var account = new BankAccount
        // {
        //     AccountNumber = accountDto.AccountNumber,
        //     AccountType = string.IsNullOrEmpty(accountDto.AccountType) ? "Basic" : accountDto.AccountType,
        //     Balance = 0.00M,
        //     CreatedDate = accountDto.CreatedDate,
        //     Owner = accountDto.Owner
        // };

        var account = mapper.Map<BankAccount>(accountDto);

        context.BankAccounts.Add(account);
        await context.SaveChangesAsync();

        // var bankAccount = new AccountDto()
        // {
        //     Id = account.Id,
        //     AccountNumber = account.AccountNumber,
        //     Balance = account.Balance,
        //     AccountType = account.AccountType,
        //     CreatedDate = account.CreatedDate,
        //     IsBlocked = account.IsBlocked,
        //     Owner = account.Owner
        // };

        var bankAccount = mapper.Map<AccountDto>(account);

        return bankAccount;

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
        var result = await context.BankAccounts.ToListAsync();
        var accounts = mapper.Map<List<AccountDto>>(result);

        // var accounts = new List<AccountDto>();

        // foreach (var item in result)
        // {
        //     // Flytta all information till ett AccountDto objekt.
        //     var account = new AccountDto
        //     {
        //         Id = item.Id,
        //         AccountNumber = item.AccountNumber,
        //         AccountType = item.AccountType,
        //         CreatedDate = item.CreatedDate,
        //         Balance = item.Balance,
        //         Owner = item.Owner,
        //         IsBlocked = item.IsBlocked,
        //     };

        //     // Lägga objektet i en List<AccountDto>
        //     accounts.Add(account);
        // }

        // Returnera Listan...
        return accounts;
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
