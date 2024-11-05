internal class Program
{
    const int size = 8;
    static int[,] board = new int[size, size];
    
    public static void Main(string[] args)
    {
        PrintBoard();
    }

    static void PrintBoard()
    {
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size / 2; x++)
            {
                if (y % 2 == 0)
                    Console.Write("\u2591\u2591  ");
                else
                    Console.Write("  \u2591\u2591");
            }

            Console.WriteLine();
        }
    }
}

