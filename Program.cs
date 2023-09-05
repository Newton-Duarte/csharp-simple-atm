try
{
  MainMenuView.Show();
}
catch (Exception e)
{
  System.Console.WriteLine($"{e.GetType()}: {e.Message}");
}