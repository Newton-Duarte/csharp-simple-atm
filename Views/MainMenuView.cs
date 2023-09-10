static class MainMenuView
{
  public static void Show()
  {
    Welcome();
    Menu();
  }

  static void Welcome()
  {
    TextUtils.Title("\tWelcome to Simple ATM");
  }

  static void Menu()
  {
    Console.WriteLine("1 - Enter");
    Console.WriteLine("2 - Register");
    Console.WriteLine("3 - Exit");
    GetOption();
  }

  static void GetOption()
  {
    Console.Write("Option: ");
    try
    {
      int option = int.Parse(Console.ReadLine());
      HandleOption(option);
    }
    catch (Exception e)
    {
      Console.WriteLine($"Exception: {e.Message}");
    }
  }

  static void HandleOption(int option)
  {
    switch(option)
    {
      case 1:
        AccountMenuView.Enter();
        break;
      case 2:
        AccountMenuView.Register();
        break;
      case 3:
        TextUtils.Title("\tThank you");
        break;
      default:
        TextUtils.Title("\tInvalid option");
        GetOption();
        break;
    }
  }
}