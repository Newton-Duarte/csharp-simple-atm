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
}