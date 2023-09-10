try
{
  MainMenuView.Show();
}
catch (Exception e)
{
  Console.WriteLine($"{e.GetType()}: {e.Message}");
  Console.WriteLine("Press any key to exit...");
  Console.ReadKey();
}