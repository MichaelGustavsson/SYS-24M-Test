using API.Interfaces;

namespace Account.Tests;

public class AccountMockRepo : IAccountRepository
{
    public async Task<API.Models.Account> FindAccount(string accountNumber)
    {
        List<API.Models.Account> accounts = [
            new(){CreatedDate = DateTime.Now,AccountNumber="111-222222",AccountType="Basic", Balance=0.00M,IsBlocked=false,Owner="Michael Gustavsson"},
            new(){CreatedDate = DateTime.Now,AccountNumber="111-333333",AccountType="Savings", Balance=5000.00M,IsBlocked=false,Owner="Michael Gustavsson"}
        ];

        var result = accounts.SingleOrDefault(c => c.AccountNumber == accountNumber);

        // Simulerar att vi hämta ett kontoasynkront...
        return await Task.FromResult<API.Models.Account>(result);
    }

    public async Task<List<API.Models.Account>> ListAllAccounts()
    {
        List<API.Models.Account> accounts = [
            new(){CreatedDate = DateTime.Now,AccountNumber="111-222222",AccountType="Basic", Balance=0.00M,IsBlocked=false,Owner="Michael Gustavsson"},
            new(){CreatedDate = DateTime.Now,AccountNumber="111-333333",AccountType="Savings", Balance=5000.00M,IsBlocked=false,Owner="Michael Gustavsson"}
        ];

        // Simulerar att vi hämtar data asynkront...
        return await Task.FromResult<List<API.Models.Account>>(accounts);
    }
}
