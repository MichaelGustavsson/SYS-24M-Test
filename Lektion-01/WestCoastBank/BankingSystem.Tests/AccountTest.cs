namespace BankingSystem.Tests;

// Setup and Teardown...
public class AccountTest {

    [Fact]
    public void ShouldCreateCorrectTypeOfBankAccount()
    {
        // Arrange...
        var account = new Account();

        // Assert...
        Assert.IsType<Account>(account);
    }

    [Fact]
    public void ShouldCreateAnAccountWithZeroBalance()
    {
        // Arrange...
        var account = new Account();

        // Act...

        // Assert...
        Assert.Equal(0, account.Balance);
    }

    [Fact]
    public void ShouldIncreaseBalanceWhenDeposit()
    {
        // Arrange...
        var account = new Account();

        // Act...
        account.Deposit(100);

        // Assert...
        Assert.Equal(100, account.Balance);
    }

    [Fact]
    public void ShouldDecreaseBalanceWhenWithdraw()
    {
        // Arrange...
        var account = new Account();

        // Act...
        account.Deposit(100);
        account.Withdraw(25);

        // Assert...
        Assert.Equal(75, account.Balance);
    }

    [Fact]
    public void ShouldThrowExceptionWhenNotEnoughFunds()
    {
        // Arrange...
        var account = new Account();

        // Act...
        account.Deposit(100);

        // Assert...
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(250));
    }
}
