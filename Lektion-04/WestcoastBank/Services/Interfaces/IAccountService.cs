

using Services.DTOs;

namespace Application.Services;

public interface IAccountService
{
    Task<List<AccountDto>> ListAllAccounts();
    Task<List<AccountDto>> ListAllAccounts(string owner);
}
