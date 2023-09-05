class AccountPin
{
  public string Pin { get; set; }

  public AccountPin(string pin)
  {
    ArgumentException.ThrowIfNullOrEmpty(pin);
    if (pin.Length < 4 || pin.Length > 4)
      throw new ArgumentException("Pin must have 4 characters");

    Pin = pin;
  }
}