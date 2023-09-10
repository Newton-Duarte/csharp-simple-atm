using System.Text;

static class AccountUtils
{
  private const int NumberSize = 4;
  public static string GenerateAccountNumber()
  {
    var rand = new Random();
    var randomNumber = new StringBuilder();

    int counter = 0;
    while (counter < NumberSize)
    {
      randomNumber.Append(rand.Next(10));

      counter++;
    }

    return randomNumber.ToString();
  }
}