using lab02;

ConsoleHelpers.Log("Program Started");

var account = new BankAccount();
var monitor = new AccountMonitor();

// Subscribe monitor method to both events
account.BalanceChangedDeposit += AccountMonitor.OnBalanceChanged;
account.BalanceChangedWithdraw += AccountMonitor.OnBalanceChanged;

account.Deposit(200);
account.Withdraw(50);
account.Withdraw(300);
account.Deposit(150);

ConsoleHelpers.Log($"Final balance: {account.Balance:C}");

ConsoleHelpers.Log("Program Finished. Press any key to exit.");
Console.ReadKey();