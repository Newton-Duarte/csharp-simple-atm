class AccountPin
{
  public string Number { get; set; }

  public AccountPin(string pin)
  {
    ArgumentException.ThrowIfNullOrEmpty(pin);
    if (pin.Length < 4 || pin.Length > 4)
      throw new ArgumentException("Pin must have 4 characters");

    Number = pin;
  }

  public override string ToString()
  {
    return Number;
  }
}