using Domain.Entities;

namespace Services.Interfaces;

public interface IAccountRepository
{
    public Task<List<Account>> ListAllAccounts();
}
