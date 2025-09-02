namespace BankingSystem.Tests;

// Setup and Teardown...
public class AccountTest : IDisposable
{
    private readonly Account _account;

    // SetUp...
    public AccountTest()
    {
        _account = new Account(0);
    }

    [Fact]
    public void ShouldCreateCorrectTypeOfBankAccount()
    {
        // Arrange...
        // var account = new Account();

        // Assert...
        Assert.IsType<Account>(_account);
    }

    [Fact]
    public void ShouldCreateAnAccountWithZeroBalance()
    {
        // Arrange...
        // var account = new Account();

        // Act...

        // Assert...
        Assert.Equal(0, _account.Balance);
    }

    [Fact]
    public void ShouldIncreaseBalanceWhenDeposit()
    {
        // Arrange...
        // var account = new Account();

        // Act...
        _account.Deposit(100);

        // Assert...
        Assert.Equal(100, _account.Balance);
    }

    [Fact]
    public void ShouldDecreaseBalanceWhenWithdraw()
    {
        // Arrange...
        // var account = new Account();

        // Act...
        // _account.Deposit(100);
        _account.Withdraw(25);

        // Assert...
        Assert.Equal(75, _account.Balance);
    }

    [Fact]
    public void ShouldThrowExceptionWhenNotEnoughFunds()
    {
        // Arrange...
        // var account = new Account();

        // Act...
        _account.Deposit(100);

        // Assert...
        Assert.Throws<InvalidOperationException>(() => _account.Withdraw(250));
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}
