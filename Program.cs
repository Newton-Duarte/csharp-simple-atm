try
{
  MainMenuView.Show();
}
catch (Exception e)
{
  Console.WriteLine($"{e.GetType()}: {e.Message}");
}