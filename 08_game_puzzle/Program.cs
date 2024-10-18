// Створення гри пятнашки

// створення масиву комірок
int zeroY = 2;
int zeroX = 1;

int[,] puzzle = new int[4, 4] {
    { 4, 10, 9, 3 },
    { 8, 2, 1, 5 },
    { 11, 0, 14, 6 },
    { 7, 15, 12, 13 }
};

PrintPuzzle();

while (true)
{
    var key = Console.ReadKey().Key;

    switch (key)
    {
        case ConsoleKey.LeftArrow:
            // move left
            // swap 0 <> right cell
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX + 1]);
            ++zeroX;
            break;
        case ConsoleKey.RightArrow:
            // move right
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX - 1]);
            --zeroX;
            break;
        case ConsoleKey.UpArrow:
            // move up
            break;
    }

    Console.Clear();
    PrintPuzzle();
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void PrintPuzzle()
{
    for (int r = 0; r < 4; r++)
    {
        for (int c = 0; c < 4; c++)
        {
            if (puzzle[r, c] == 0)
                Console.Write("[  ] ");
            else
                Console.Write($"[{puzzle[r, c], 2}] ");
        }
        Console.WriteLine();
    }
}
