using Application.DTOs;
using BankAccount.Tests.Fixtures;
using Xunit.Abstractions;

namespace BankAccount.Tests;

public class BankAccountServiceTest(ITestOutputHelper testOutputHelper, AccountServiceFixture accountServiceFixture) : IClassFixture<AccountServiceFixture>
{
    private readonly AccountServiceFixture _accountFixture = accountServiceFixture;

    [Fact]
    public async Task BankAccountService_CreateAccount_ShouldReturn_AccountDto()
    {
        // Arrange...
        var account = new CreateAccountDto { Owner = "Åsa Eriksson" };

        // Act...
        var result = await _accountFixture.Service.CreateAccount(account);
        testOutputHelper.WriteLine(result.ToString());

        // Assert...
        Assert.IsType<AccountDto>(result);
    }

    [Fact]
    public async Task BankAccountService_CreateAccount_ShouldGenerate_AccountDto_Object()
    {
        // Arrange...
        var account = new CreateAccountDto
        {
            Owner = "Åsa Eriksson",
            CreatedDate = DateTime.Now
        };

        // Act...
        var result = await _accountFixture.Service.CreateAccount(account);
        testOutputHelper.WriteLine(result.AccountNumber);

        // Assert...        
        Assert.StartsWith("5578-", result.AccountNumber);
        Assert.Equal("Basic", result.AccountType);
        Assert.Equal("2025-09-17", result.CreatedDate.ToShortDateString());
        Assert.False(result.IsBlocked);
    }

    [Fact]
    public async Task BankAccountService_ListAllAccounts_WithoutOwner_ShouldReturn_AccountDtoList()
    {
        // Act..
        var result = await _accountFixture.Service.ListAllAccounts();

        // Assert...
        Assert.IsType<List<AccountDto>>(result);
    }
}
