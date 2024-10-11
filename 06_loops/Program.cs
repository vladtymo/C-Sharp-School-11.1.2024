Console.Write("Enter product quantity: ");
int quantity = int.Parse(Console.ReadLine());

//if (quantity < 0)
//{
//    Console.WriteLine("Cannot be negative!");
//    Console.Write("Enter again: ");
//    quantity = int.Parse(Console.ReadLine());
//}

while (quantity < 0)
{
    Console.WriteLine("Cannot be negative!");
    Console.Write("Enter again: ");
    quantity = int.Parse(Console.ReadLine());
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Great!");
Console.ResetColor();

// Завдання: Показати на екран 10 разів слово "Привіт"

Console.Write("Enter count: ");
int n = int.Parse(Console.ReadLine());

int count = 0;

while (count < n)
{
    Console.WriteLine($"{count} - Hello!");
    ++count;
}
