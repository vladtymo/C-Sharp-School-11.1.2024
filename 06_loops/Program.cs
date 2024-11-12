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

// -------------- цикли --------------
// 1 - for
Console.Write("Enter how many David say hello?");
int c = int.Parse(Console.ReadLine());

for (int i = 0; i < c; i++)
{
    Console.WriteLine("Hello David!");
}

// 2 - while
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

while (age < 0)
{
    Console.Write("Age is invalid. Please enter again: ");
    age = int.Parse(Console.ReadLine());
}

// 3 - do white
string name;
do
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    
} while (!char.IsUpper(name[0]));

// вічний цикл
while (true)
{
    Console.Write("Enter password: ");
    string pass = Console.ReadLine();
    
    if (pass == "admin")
        break; // вихід із циклу
}

Console.WriteLine("Have a nice day!");