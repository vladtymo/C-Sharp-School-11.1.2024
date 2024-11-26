internal class Program
{
    public static void Main(string[] args)
    {
        Snake mainHero = new();

        mainHero.x = 20;
        mainHero.y = 9;
        
        mainHero.Print();
        mainHero.TurnRight();
        mainHero.Print();
        mainHero.TurnDowm();
        mainHero.Print();
        mainHero.TurnDowm();
        mainHero.Print();
        mainHero.TurnDowm();
        mainHero.Print();
    }
}

class Snake
{
    // properties
    public int x = 0;
    public int y = 0; 
    public int size = 1;
    public ConsoleColor color = ConsoleColor.Blue;
    public string symbol = "*";

    // methods
    public void Clear()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(" ");
    }
    public void Print()
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
        Console.ResetColor();
    }

    public void TurnRight()
    {
        x += 1;
    }
    public void TurnDowm()
    {
        if (y >= 10)
            color = ConsoleColor.Yellow;
        
        y += 1;
    }
}

