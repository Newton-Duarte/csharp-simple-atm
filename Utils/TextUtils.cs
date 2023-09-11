static class TextUtils
{
  public static void TextDivider()
  {
    Console.WriteLine("----------------------------------------");
  }

  public static void Title(string title)
  {
    TextDivider();
    Console.WriteLine(title);
    TextDivider();
  }

  public static void Success(string text)
  {
    var defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(text);
    Console.ForegroundColor = defaultColor;
  }

  public static void Error(string text)
  {
    var defaultColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ForegroundColor = defaultColor;
  }
}