// See https://aka.ms/new-console-template for more information

var rand = new Random();
int score = 0; // кіл-ть зароблених балів
int count = 0; // кількість відгаданих підрят чисел

while (true)
{
    Console.Write("Enter your rate: ");
    
    if (!int.TryParse(Console.ReadLine(), out int rate))
        continue;
    
    Console.Clear();
    
    // генерація випадкового числа від 1 до 7 (не включно)
    int number = rand.Next(1, 7); 

    if (rate == number)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You won!");
        score += 10;
        count++; // збільшення на 1
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You loose!");
        score -= 5;
        count = 0;
    }

    if (count == 2)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Jackpot!");
        score += 50;
    }
    if (count == 3)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Super-puper lucky!");
        score += 100;
    }
    
    Console.ResetColor();
    Console.WriteLine("Score: " + score);
    
    //Console.ReadKey(); // пауза
}
