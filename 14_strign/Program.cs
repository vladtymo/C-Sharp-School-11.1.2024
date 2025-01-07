string text = "Hello World! How are you doing? I'm fine!";

Console.WriteLine("Enter password: ");
string password = Console.ReadLine()!;

Console.WriteLine($"Password: {password}");

if (password.Length >= 10)
    Console.WriteLine("Password is too long!");

Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());

Console.WriteLine(text.IndexOf('!'));
Console.WriteLine(text.LastIndexOf('!'));

if (password.Contains("user"))
    Console.WriteLine("Password is weak!");
else
    Console.WriteLine("Password is strong!");

if (password.Any(c => char.IsUpper(c)))
    Console.WriteLine("Password has upper letter!");
else
    Console.WriteLine("Password does not has upper letter!");
    
Console.WriteLine(password.StartsWith("A"));
Console.WriteLine(password.EndsWith("."));

Console.WriteLine(password.Remove(3, 1));
Console.WriteLine(text.Replace('!', ';'));

Console.WriteLine(password.Trim());

if (password.CompareTo(text) > 0)
{
    Console.WriteLine("Password is greater than text!");
}
