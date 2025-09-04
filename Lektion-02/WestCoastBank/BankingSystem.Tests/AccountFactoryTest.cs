using BankingSystem.Factories;

namespace BankingSystem.Tests;

public class AccountFactoryTest
{
    [Fact]
    public void ShouldCreateStandardAccount()
    {
        // Arrange...
        AccountFactory factory = new();

        // Act...
        var account = factory.CreateAccount(null);

        // Assert...
        Assert.IsType<Account>(account);
    }

    [Fact]
    public void ShouldCreateSavingsAccount()
    {
        // Arrange...
        AccountFactory factory = new();

        // Act...
        var account = factory.CreateAccount(0.025M);

        // Assert...
        Assert.IsType<SavingsAccount>(account);
        Assert.IsAssignableFrom<Account>(account);
    }
}
