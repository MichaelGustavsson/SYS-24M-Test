using Application.Services;
using Domain.Entities;
using Moq;
using Services.DTOs;
using Services.Interfaces;

namespace Service.Test;

public class AccountTest
{
    private Mock<IAccountRepository> _mockRepo;
    private AccountService _accountService;

    public AccountTest()
    {
        _mockRepo = new Mock<IAccountRepository>();
        _accountService = new AccountService(_mockRepo.Object);
    }
    [Fact]
    public async Task ListAllAccounts_ShouldReturn_AllAccounts()
    {
        // Arrange...
        var accounts = new List<AccountDto>();
        _mockRepo.Setup(repo => repo.ListAllAccounts()).ReturnsAsync(accounts);

        // Act...
        var result = await _accountService.ListAllAccounts();

        // Assert...
        Assert.NotNull(result);
    }
}
