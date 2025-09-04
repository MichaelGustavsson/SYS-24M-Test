namespace BankingSystem;

public class Account()
{
    protected decimal _balance;
    public bool IsBlocked { get; set; } = false;

    virtual public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (_balance < amount) throw new InvalidOperationException("Not enough funds, stupid!");
        _balance -= amount;
    }
}
