namespace BankingSystem;

public class SavingsAccount(decimal interestRate) : Account
{
    public decimal InterestRate { get; set; } = interestRate;

    public override decimal GetBalance()
    {
        return _balance *= 1 + InterestRate;
    }
}
