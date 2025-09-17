using System.Threading.Tasks;
using Application.DTOs;
using Application.Repositories;
using BankAccount.Tests.Mock;

namespace BankAccount.Tests;

public class AccountTest
{
    [Fact]
    public void BankAccount_CreateAccountDto_ShouldReturn_CorrectType()
    {
        // Arrange...
        var account = new CreateAccountDto();

        // Assert...
        Assert.IsType<CreateAccountDto>(account);
    }

    [Fact]
    public async Task BankAccount_CreateAccount_ShouldReturn_AccountDto()
    {
        // Arrange...
        var repo = new MockAccountRepository();
        var dto = new CreateAccountDto
        {
            Owner = "Stig Karlsson"
        };

        // Act...
        var result = await repo.CreateAccount(dto);

        // Assert...
        Assert.IsType<AccountDto>(result);
    }

    [Fact]
    public async Task BankAccount_CreateAccount_ShouldContain_CreateDate()
    {
        // Arrange...
        var repo = new MockAccountRepository();
        var dto = new CreateAccountDto
        {
            Owner = "Stig Karlsson",
            CreatedDate = DateTime.Parse("2025-08-25")
        };

        // Act...
        var result = await repo.CreateAccount(dto);

        // Assert...
        Assert.IsType<AccountDto>(result);
        Assert.Equal("2025-08-25", result.CreatedDate.ToShortDateString());
    }

    [Fact]
    public async Task BankAccount_CreateAccount_ShouldContain_Balance()
    {
        // Arrange...
        var repo = new MockAccountRepository();
        var dto = new CreateAccountDto
        {
            Owner = "Stig Karlsson",
            Balance = 500
        };

        // Act...
        var result = await repo.CreateAccount(dto);

        // Assert...
        Assert.IsType<AccountDto>(result);
        Assert.Equal(500, result.Balance);
    }

    [Fact]
    public async Task BankAccount_CreateAccount_ShouldContainCorrect_AccountType()
    {
        // Arrange...
        var repo = new MockAccountRepository();
        var dto = new CreateAccountDto
        {
            Owner = "Stig Karlsson",
            AccountType = "Savings"
        };

        // Act...
        var result = await repo.CreateAccount(dto);

        // Assert...
        Assert.IsType<AccountDto>(result);
        Assert.Equal("Savings", result.AccountType, ignoreCase: true);
    }

    [Fact]
    public async Task BankAccount_CreateAccount_ShouldContainDefault_AccountType_WhenNotExists()
    {
        // Arrange...
        var repo = new MockAccountRepository();
        var dto = new CreateAccountDto
        {
            Owner = "Stig Karlsson",
        };

        // Act...
        var result = await repo.CreateAccount(dto);

        // Assert...
        Assert.IsType<AccountDto>(result);
        Assert.Equal("Basic", result.AccountType, ignoreCase: true);
    }

    [Fact]
    public async Task BankAccount_CreateAccount_IsBlocked_ShouldReturnFalse_WhenNotExists()
    {
        // Arrange...
        var repo = new MockAccountRepository();
        var dto = new CreateAccountDto
        {
            Owner = "Stig Karlsson",
        };

        // Act...
        var result = await repo.CreateAccount(dto);

        // Assert...
        Assert.IsType<AccountDto>(result);
        Assert.False(result.IsBlocked);
    }

    [Fact]
    public async Task BankAccount_CreateAccount_ShouldCreateCorrect_AccountNumber()
    {
        // Arrange...
        var repo = new MockAccountRepository();
        var dto = new CreateAccountDto
        {
            Owner = "Stig Karlsson",
        };

        // Act...
        var result = await repo.CreateAccount(dto);

        // Assert...
        Assert.IsType<AccountDto>(result);
        Assert.StartsWith("5578", result.AccountNumber);
    }
}
