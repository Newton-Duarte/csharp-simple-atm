class Account
{
  public string Number { get; private set; }
  public AccountName Holder { get; set; }
  public AccountPin Pin { get; private set; }
  public double Balance { get; set; }
  public double WithdrawLimit { get; private set; }

  public Account(string holder, string pin) {
    Number = AccountUtils.GenerateAccountNumber();
    Holder = new AccountName(holder);
    Pin = new AccountPin(pin);
    Balance = 0.00;
    WithdrawLimit = 1000.00;
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