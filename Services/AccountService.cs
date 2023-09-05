class AccountService
{
  private readonly Account _account;

  public AccountService(Account account)
  {
    _account = account;
  }

  public void Deposit(double amount)
  {
    if (amount <= 0)
    {
      throw new AccountException("Amount must be greater than zero");
    }

    _account.Balance += amount;
  }

  public void Withdraw(double amount)
  {
    if (_account.Balance < amount)
    {
      throw new AccountException("There's no enough balance");
    }
    else if (amount <= 0)
    {
      throw new AccountException("Amount must be greater than zero");
    }
    else if (amount > _account.WithdrawLimit)
    {
      throw new AccountException($"Amount must be less or equal to the withdraw limit of {_account.WithdrawLimit:F2}");
    }

    _account.Balance -= amount;
  }
}