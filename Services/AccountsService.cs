class AccountsService
{
  private List<Account> accounts = new();

  public AccountsService() {}

  public void AddAccount(Account account)
  {
    accounts.Add(account);
  }

  public Account? GetAccount(string number)
  {
    var account = accounts.Find(a => a.Number == number);
    return account;
  }
}