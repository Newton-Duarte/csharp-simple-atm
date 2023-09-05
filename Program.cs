System.Console.Write("Holder name: ");
var name = Console.ReadLine();

System.Console.Write("Pin: ");
var pin = Console.ReadLine();

var account = new Account(name, pin);

System.Console.WriteLine(account);