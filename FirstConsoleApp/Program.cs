// коментарі
// Ctrl + F5 - запуск програми

// робота з консолью
Console.WriteLine("Hello C# again!");

// cw + TAB = Console.WriteLine();
Console.WriteLine("This is text line...");

// WriteLine - ставить новий рядок вкінці
// Write - не ставить новий рядок після тексту

Console.Write("Red");
Console.Write("Green");
Console.Write("Blue");

// спец символи: \n \t \' \"

Console.Write("\nNew Line\tTab\t\tBye!!!\n\n");

// отримати значення від користувача
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Скільки ти маєш грошей? ");
int money = int.Parse(Console.ReadLine());

Console.WriteLine($"Ти має {money / 41} долірів)");