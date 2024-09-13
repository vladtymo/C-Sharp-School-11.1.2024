// Завдання: написати програму, яка запитує в користувача к-сть мить та переводить в км

// 1. запитати значення
// 2. обрахунок значення
// 3. відобразити результат

Console.WriteLine("----------------- Convert Miles to Kilometers -----------------");
Console.Write("Enter miles: ");

// тип.Parse(рядок) - перетворення рядка до певного типу
float miles = float.Parse(Console.ReadLine());

Console.WriteLine($"Result: {miles * 1.60934} km");

// Завдання: написати програму, яка запитує радіус кола та визначає його площу

Console.WriteLine("----------------- Circle Area by Radius -----------------");
Console.Write("Enter radius (cm): ");

// тип.Parse(рядок) - перетворення рядка до певного типу
float r = float.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(r, 2);

Console.WriteLine($"Result: {area} cm^2");

Console.WriteLine($"Have a good day!");