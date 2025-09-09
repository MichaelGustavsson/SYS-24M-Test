using Services.DTOs;
using Services.Interfaces;

namespace Application.Services;

public class AccountService(IAccountRepository accountRepository) : IAccountService
{
    public async Task<List<AccountDto>> ListAllAccounts()
    {
        return await accountRepository.ListAllAccounts();
    }

    public async Task<List<AccountDto>> ListAllAccounts(string owner)
    {
        return await accountRepository.ListAllAccounts(owner);
    }
}
