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
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You can buy a wine!");
    Console.ResetColor();
}

// Завдання: користувач вводить кількість товару, перевірити чи можна він його купити

int availableCount = 12;

Console.WriteLine("How many products you want to buy: ");
int count = int.Parse(Console.ReadLine()!);

// && (і) || (або)

if (count > 0 && count <= availableCount)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Congratulations!");
    availableCount -= count;
    Console.ResetColor();
}
else {
    Console.WriteLine("Not available!");
}

