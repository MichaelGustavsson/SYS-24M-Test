using System.Threading.Tasks;
using Application.DTOs;
using BankAccount.Tests.Mock;

namespace BankAccount.Tests;

public class AccountsTest
{
    [Fact]
    public async Task BankAccount_ListAllAccounts_ShouldReturn_ListOfAccountDto()
    {
        // Arrange...
        var repo = new MockAccountRepository();

        // Act...
        var result = await repo.ListAllAccounts();

        // Assert...
        Assert.IsType<List<AccountDto>>(result);
    }

    [Fact]
    public async Task BankAccount_ListAllAccounts_ShouldReturn_TwoAccountDtos()
    {
        // Arrange...
        var repo = new MockAccountRepository();

        // Act...
        var result = await repo.ListAllAccounts();

        // Assert...
        Assert.IsType<List<AccountDto>>(result);
        Assert.NotEmpty(result);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public async Task BankAccount_ListAllAccounts_ShouldReturn_CorrectFirstObject()
    {
        // Arrange...
        var repo = new MockAccountRepository();

        // Act...
        var result = await repo.ListAllAccounts();

        // Assert...
        Assert.IsType<List<AccountDto>>(result);
        Assert.NotEmpty(result);
        Assert.Equal("5578-3498916", result.First().AccountNumber);
    }
}
