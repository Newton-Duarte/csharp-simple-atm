static class AccountsService
{
  private static readonly List<Account> accounts = new();

  public static void AddAccount(string holderName, string accountPIN)
  {
    var account = new Account(holderName, accountPIN);
    accounts.Add(account);
    Console.WriteLine(account);
  }

  public static Account? GetAccount(string number)
  {
    var account = accounts.Find(a => a.Number == number);
    return account;
  }
}