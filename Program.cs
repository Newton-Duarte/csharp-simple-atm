try
{
  System.Console.Write("Holder name: ");
  var name = Console.ReadLine();

  System.Console.Write("Pin: ");
  var pin = Console.ReadLine();

  var account = new Account(name, pin);

  System.Console.WriteLine(account);

  var accountService = new AccountService(account);

  accountService.Deposit(2000);
  accountService.Withdraw(1000);

  System.Console.WriteLine(account);
}
catch (Exception e)
{
  System.Console.WriteLine($"{e.GetType()}: {e.Message}");
}