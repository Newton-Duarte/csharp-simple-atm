static class AccountMenuView
{
  private static Account _account;

  public static void Enter()
  {
    TextUtils.Title("\tEnter");
    GetEnterValues();
  }

  private static void GetEnterValues()
  {
    Console.Write("Account number: ");
    string accountNumber = Console.ReadLine();
    
    Console.Write("Account PIN: ");
    string accountPIN = Console.ReadLine();
    
    var account = AccountsService.GetAccount(accountNumber);

    if (account is null)
    {
      throw new AccountException("Account does not exist");
    }

    if (account.Pin.Number != accountPIN)
    {
      throw new AccountException("Invalid credentials");
    }

    _account = account;

    AccountMenu();
  }

  public static void Register()
  {
    TextUtils.Title("\tRegister Account");
    GetRegisterValues();

    MainMenuView.Show();
  }

  private static void GetRegisterValues()
  {
    Console.Write("Holder name: ");
    string holderName = Console.ReadLine();

    Console.Write("Account PIN: ");
    string accountPIN = Console.ReadLine();
    
    AccountsService.AddAccount(holderName, accountPIN);
  }

  private static void AccountMenu()
  {
    TextUtils.Title($"Hello {_account.Holder}, what you want?");
    Console.WriteLine("1 - Deposit");
    Console.WriteLine("2 - Withdraw");
    Console.WriteLine("3 - Exit");
    GetOption();
  }

  private static void GetOption()
  {
    Console.Write("Option: ");
    int option = int.Parse(Console.ReadLine());
    HandleOption(option);
  }

  private static void HandleOption(int option)
  {
    switch(option)
    {
      case 1:
        TextUtils.Title("\tDeposit");
        Console.Write("Deposit amount: ");

        try
        {
          double depositAmount = double.Parse(Console.ReadLine());
          AccountService.Deposit(_account, depositAmount);
          Console.WriteLine("Deposit done successfully.");
          Console.WriteLine(_account);
          AccountMenu();
        }
        catch(Exception e)
        {
          Console.WriteLine($"{e.GetType()}: {e.Message}");
          AccountMenu();
        }
        break;
      case 2:
        TextUtils.Title("\tWithdraw");
        Console.Write("Withdraw amount: ");

        try
        {
          double withdrawAmount = double.Parse(Console.ReadLine());
          AccountService.Withdraw(_account, withdrawAmount);
          Console.WriteLine("Withdraw done successfully.");
          Console.WriteLine(_account);
          AccountMenu();
        }
        catch (Exception e)
        {
          Console.WriteLine($"{e.GetType()}: {e.Message}");
          AccountMenu();
        }
        break;
      case 3:
        TextUtils.Title("\tThank you");
        MainMenuView.Show();
        break;
      default:
        TextUtils.Title("\tInvalid option");
        GetOption();
        break;
    }
  }
}