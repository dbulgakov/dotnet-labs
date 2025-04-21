namespace lab02;

public sealed class BankAccount
{
    public int Balance { get; private set; }

    public delegate void BalanceChangedHandler(int newBalance);
    
    public event BalanceChangedHandler? BalanceChangedDeposit;
    public event BalanceChangedHandler? BalanceChangedWithdraw;

    public void Deposit(int amount)
    {
        Balance += amount;
        ConsoleHelpers.Log($"Deposited {amount:C}");
        BalanceChangedDeposit?.Invoke(Balance);
    }

    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            ConsoleHelpers.Log("Withdrawal failed: insufficient funds.");
            return;
        }

        Balance -= amount;
        ConsoleHelpers.Log($"Withdrew {amount:C}");
        BalanceChangedWithdraw?.Invoke(Balance);
    }
}