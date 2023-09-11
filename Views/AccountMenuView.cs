static class AccountMenuView
{
  private static Account _account;

  public static void Enter()
  {
    TextUtils.Title("\t\tEnter");
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
      TextUtils.Error($"Account does not exist");
      MainMenuView.Show();
    }

    if (account.Pin.Number != accountPIN)
    {
      TextUtils.Error($"Invalid credentials");
      MainMenuView.Show();
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
        TextUtils.Title("\t\tDeposit");
        Console.Write("Deposit amount: ");

        try
        {
          double depositAmount = double.Parse(Console.ReadLine());
          AccountService.Deposit(_account, depositAmount);
          TextUtils.Success("Deposit done successfully.");
          Console.WriteLine(_account);
          AccountMenu();
        }
        catch(Exception e)
        {
          TextUtils.Error($"{e.GetType()}: {e.Message}");
          AccountMenu();
        }
        break;
      case 2:
        TextUtils.Title("\t\tWithdraw");
        Console.Write("Withdraw amount: ");

        try
        {
          double withdrawAmount = double.Parse(Console.ReadLine());
          AccountService.Withdraw(_account, withdrawAmount);
          TextUtils.Success("Withdraw done successfully.");
          Console.WriteLine(_account);
          AccountMenu();
        }
        catch (Exception e)
        {
          TextUtils.Error($"{e.GetType()}: {e.Message}");
          AccountMenu();
        }
        break;
      case 3:
        TextUtils.Title("\t\tThank you");
        MainMenuView.Show();
        break;
      default:
        TextUtils.Title("\t\tInvalid option");
        GetOption();
        break;
    }
  }
}