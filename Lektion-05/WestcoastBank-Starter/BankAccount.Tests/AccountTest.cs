using Application.DTOs;
using Application.Repositories;

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

    // [Fact]
    // public async Task<string> BankAccount_CallToCreateAccount_ShouldBeCreateAccountDto()
    // {
    //     // Arrange...
    //     var repo = new AccountRepository();
    //     var account = new CreateAccountDto();

    //     // Act...
    //     var result = await repo.CreateAccount(account);

    //     // Assert...
    //     Assert.IsType<string>(result);
    // }
}
