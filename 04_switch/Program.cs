// Завдання: користувач вводить номер дня в тижні (1-7). Показати його імя

Console.Write("Enter weekday (1-7): ");
int weekday = int.Parse(Console.ReadLine()!);

if (weekday == 1)
{
    Console.WriteLine("Today is Monday!");
}
else if (weekday == 2)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Today is Tuesday!");
    Console.ResetColor();
}
else if (weekday == 3)
    Console.WriteLine("Today is Wednesday!");

else if (weekday == 4)
    Console.WriteLine("Today is Thursday!");
else
    Console.WriteLine("Wrong day!");

//if (weekday < 1 || weekday > 7)

//....

// switch - конструкція множинного вибору
switch (weekday)
{
    case 1: Console.WriteLine("Today is Monday!"); break;
    case 2:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Today is Tuesday!");
        Console.ResetColor(); break;
    case 3: Console.WriteLine("Today is Wednesday!"); break;
    case 4: Console.WriteLine("Today is Thursday!"); break;
    case 5: Console.WriteLine("Today is Friday!"); break;
    default: Console.WriteLine("Wrong day!"); break;
} 