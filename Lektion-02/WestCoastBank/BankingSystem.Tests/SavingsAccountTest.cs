namespace BankingSystem.Tests;

public class SavingsAccountTest
{
    [Fact]
    public void ShouldCreateSavingsAccountWithBaseInterest()
    {
        // Arrange...
        SavingsAccount account = new(0.025M);

        // Assert...
        Assert.Equal(0.025M, account.InterestRate);

    }

    [Fact]
    public void ShouldCalculateCorrectBalance()
    {
        // Arrange...
        SavingsAccount account = new(0.025M);

        // Act...
        decimal amount = 100M;
        account.Deposit(amount);
        decimal balance = amount * (1 + account.InterestRate);

        // Assert...
        Assert.Equal(balance, account.GetBalance());
    }

    [Fact]
    public void ShouldCreateInstanceOfSavingsAccount()
    {
        // Arrange...
        SavingsAccount account = new(0.025M);

        // Act + Assert...
        Assert.IsType<SavingsAccount>(account);
        Assert.IsAssignableFrom<Account>(account);

    }
}
