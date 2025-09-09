
using Application.DTOs;
using Application.Interfaces;
using Application.Services;
using Moq;
using Xunit.Abstractions;

namespace Service.Test;

public class AccountTest
{
    private Mock<IAccountRepository> _mockRepo;
    private AccountService _accountService;
    private readonly ITestOutputHelper _testOutputHelper;

    public AccountTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
        _mockRepo = new Mock<IAccountRepository>();
        _accountService = new AccountService(_mockRepo.Object);
    }
    [Fact]
    public async Task ListAllAccounts_ShouldNotReturnNull_WhenAccountsExists()
    {
        // Arrange...
        var accounts = new List<AccountDto>();
        _mockRepo.Setup(repo => repo.ListAllAccounts()).ReturnsAsync(accounts);

        // Act...
        var result = await _accountService.ListAllAccounts();

        // Assert...
        Assert.NotNull(result);
    }

    [Fact]
    public async Task ListAllAccountsByCustomerName_ShouldReturnNull_WhenNoAccountsExists()
    {
        // Arrange...
        var accounts = new List<AccountDto>();

        _mockRepo.Setup(repo => repo.ListAllAccounts("Michael Gustavsson")).ReturnsAsync(accounts);

        // Act...
        var result = await _accountService.ListAllAccounts("Michael Gustavsson");

        // Assert...
        Assert.Empty(result);
    }

    [Fact]
    public async Task ListAllAccountsByCustomerName_ShouldNotReturnNull_WhenAccountsExists()
    {
        var accounts = new List<AccountDto>
        {
            new() { CreatedDate = DateTime.Now, AccountNumber = "111-222222", AccountType = "Basic", Balance = 0.00M, Owner = "Michael Gustavsson" },
            new() { CreatedDate = DateTime.Now, AccountNumber = "111-333333", AccountType = "Savings", Balance = 5000.00M, Owner = "Michael Gustavsson" }
        };

        _mockRepo.Setup(repo => repo.ListAllAccounts("Michael Gustavsson")).ReturnsAsync(accounts);

        var result = await _accountService.ListAllAccounts("Michael Gustavsson");
        _testOutputHelper.WriteLine($"Antal konton funna: {result.Count}");

        result.ForEach(a => _testOutputHelper.WriteLine(a.AccountNumber));

        Assert.NotNull(result);
    }
}
