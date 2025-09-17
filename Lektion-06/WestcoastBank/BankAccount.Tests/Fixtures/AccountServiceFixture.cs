using BankAccount.Tests.Mock;

namespace BankAccount.Tests.Fixtures;

public class AccountServiceFixture
{
    public BankAccountServiceMock Service => new();
}
