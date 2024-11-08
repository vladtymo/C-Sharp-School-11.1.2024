internal class Program
{
    const int size = 8;
    const int white = 1;
    const int black = 2;

    private static int[,] board = new int[size, size]
    {
        { 0, 1, 0, 1, 0, 1, 0, 1 },
        { 1, 0, 1, 0, 1, 0, 1, 0 },
        { 0, 1, 0, 1, 0, 1, 0, 1 },
        { 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0 },
        { 2, 0, 2, 0, 2, 0, 2, 0 },
        { 0, 2, 0, 2, 0, 2, 0, 2 },
        { 2, 0, 2, 0, 2, 0, 2, 0 }
    };
    
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        
        PrintBoard();

        PrintFigures();

        Console.ReadKey();
    }

    static void PrintFigures()
    {
        Console.SetCursorPosition(1, 0);
        Console.Write("\u25C9");
        
        Console.SetCursorPosition(4, 0);
        Console.Write("\u25CC");
    }
    
    static void PrintBoard()
    {
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size / 2; x++)
            {
                if (y % 2 == 0)
                    Console.Write("\u2591\u2591\u2591\u2592\u2592\u2592");
                else
                    Console.Write("\u2592\u2592\u2592\u2591\u2591\u2591");
            }

            Console.WriteLine();
        }
    }
}

