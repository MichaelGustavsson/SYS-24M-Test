namespace BankingSystem;

public class Account()
{
    public decimal Balance { get; private set; }
    public bool IsBlocked { get; set; } = false;

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
