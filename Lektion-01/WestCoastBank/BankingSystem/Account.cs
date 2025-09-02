namespace BankingSystem;

public class Account(decimal initAmount)
{
    public decimal Balance { get; private set; } = initAmount;

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance < amount) throw new InvalidOperationException("Not enough funds, stupid!");
        Balance -= amount;
    }
}
