
using Application.DTOs;

namespace Application.Interfaces;

public interface IAccountService
{
    Task<List<AccountDto>> ListAllAccounts();
    Task<List<AccountDto>> ListAllAccounts(string owner);
}
