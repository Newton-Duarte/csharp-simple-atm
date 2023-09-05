class AccountService
{
  private readonly Account _account;

  public AccountService(Account account)
  {
    _account = account;
  }

  public void Withdraw(double amount)
  {
    if (_account.Balance < amount)
    {
      throw new Exception("There's no enough balance");
    }
    else if (amount <= 0)
    {
      throw new ArgumentException("Amount must be greater than zero");
    }

    _account.Balance -= amount;
  }
}