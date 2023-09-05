class AccountName
{
  public string Name { get; set; }

  public AccountName(string name)
  {
    ArgumentException.ThrowIfNullOrEmpty(name);

    Name = name;
  }
}