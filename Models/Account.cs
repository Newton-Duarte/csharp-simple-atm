using System.Text;

class Account
{
  public string Number { get; private set; }
  public AccountName Holder { get; set; }
  public AccountPin Pin { get; private set; }
  public double Balance { get; private set; }
  public double WithdrawLimit { get; private set; }
  private const int NumberSize = 4;

  public Account(string holder, string pin) {
    Number = GenerateAccountNumber();
    Holder = new AccountName(holder);
    Pin = new AccountPin(pin);
    Balance = 0.00;
    WithdrawLimit = 1000.00;
  }

  private string GenerateAccountNumber()
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

  public override string ToString()
  {
    return $@"
      Holder: {Holder}
      Number: {Number}
      Balance: {Balance:F2}
      Withdraw Limit: {WithdrawLimit:F2}
    ";
  }
}