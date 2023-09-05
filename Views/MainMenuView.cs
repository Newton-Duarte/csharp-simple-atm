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
    System.Console.WriteLine("1 - Enter");
    System.Console.WriteLine("2 - Register");
    System.Console.WriteLine("3 - Exit");
    GetOption();
  }

  static void GetOption()
  {
    System.Console.Write("Option: ");
    try
    {
      int option = int.Parse(Console.ReadLine());
      HandleOption(option);
    }
    catch (Exception e)
    {
      System.Console.WriteLine($"Exception: {e.Message}");
    }
  }

  static void HandleOption(int option)
  {
    switch(option)
    {
      case 1:
        TextUtils.Title("\t 1 - Enter");
        break;
      case 2:
        TextUtils.Title("\t 2 - Register");
        break;
      case 3:
        TextUtils.Title("\t Thank you");
        break;
      default:
        System.Console.WriteLine("Invalid option");
        GetOption();
        break;
    }
  }
}