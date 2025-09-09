using Services.DTOs;
using Services.Interfaces;

namespace Service.Test.MockData;

public class AccountMockRepo : IAccountRepository
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
        List<AccountDto> accounts = [
            new(){CreatedDate = DateTime.Now,AccountNumber="111-222222",AccountType="Basic", Balance=0.00M,Owner="Michael Gustavsson"},
            new(){CreatedDate = DateTime.Now,AccountNumber="111-333333",AccountType="Savings", Balance=5000.00M,Owner="Michael Gustavsson"}
        ];

        // Simulerar att vi hämtar data asynkront...
        return await Task.FromResult<List<AccountDto>>(accounts);
    }

    public async Task<List<AccountDto>> ListAllAccounts(string owner)
    {
        List<AccountDto> accounts = [
            new(){CreatedDate = DateTime.Now,AccountNumber="111-222222",AccountType="Basic", Balance=0.00M,Owner="Michael Gustavsson"},
            new(){CreatedDate = DateTime.Now,AccountNumber="111-333333",AccountType="Savings", Balance=5000.00M,Owner="Michael Gustavsson"},
            new(){CreatedDate = DateTime.Now,AccountNumber="111-333333",AccountType="Basic", Balance=1000.00M,Owner="Olle Olsson"}
        ];

        var foundAccounts = accounts.Where(c => c.Owner.ToLower().Replace(" ", "") == owner.ToLower().Replace(" ", "")).ToList();

        // Simulerar att vi hämtar data asynkront...
        return await Task.FromResult<List<AccountDto>>(foundAccounts);
    }

    public Task WithDraw(string accountNumber, decimal amount)
    {
        throw new NotImplementedException();
    }
}
