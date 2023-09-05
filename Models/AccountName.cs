class AccountName
{
  public string Name { get; set; }

  public AccountName(string name)
  {
    ArgumentException.ThrowIfNullOrEmpty(name);

    Name = name;
  }

  public override string ToString()
  {
    return Name;
  }
}