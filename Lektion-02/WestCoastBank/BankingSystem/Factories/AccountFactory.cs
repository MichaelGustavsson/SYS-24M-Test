namespace BankingSystem.Factories;

public class AccountFactory
{
    public Account CreateAccount(decimal? interestRate)
    {
        if (interestRate is null) return new Account();
        return new SavingsAccount((decimal)interestRate);
    }
}
