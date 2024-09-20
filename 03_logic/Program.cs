// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Enter your birth year: ");

int birthYear = int.Parse(Console.ReadLine()!);

int age = DateTime.Now.Year - birthYear;

// логічні оператори: > < >= <= == !=

if(age >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You can buy a wine!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You can buy a milk!");
    Console.ResetColor();
}
