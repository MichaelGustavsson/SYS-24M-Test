namespace Account.Tests;

public class AccountTest
{
    [Fact]
    public async Task ShouldReturnListOfAccounts()
    {
        // Arrange + Act...
        var result = await new AccountMockRepo().ListAllAccounts();

        // Assert...
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public async Task ShouldReturnAccountOnAccountNumber()
    {
        // Arrange + Act...
        var result = await new AccountMockRepo().FindAccount("111-222222");

        // Assert...
        Assert.Equal("111-222222", result.AccountNumber);

    }
}
