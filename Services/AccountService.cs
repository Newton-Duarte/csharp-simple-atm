static class AccountService
{
  public static void Deposit(Account account, double amount)
  {
    if (amount <= 0)
    {
      throw new AccountException("Amount must be greater than zero");
    }

    account.Balance += amount;
  }

  public static void Withdraw(Account account, double amount)
  {
    if (amount > account.WithdrawLimit)
    {
      throw new AccountException($"Withdraw denied. Your withdraw limit is {account.WithdrawLimit:F2}");
    }
    else if (amount <= 0)
    {
      throw new AccountException("Amount must be greater than zero");
    }
    else if (account.Balance < amount)
    {
      throw new AccountException("There's not enough balance");
    }

    account.Balance -= amount;
  }
}