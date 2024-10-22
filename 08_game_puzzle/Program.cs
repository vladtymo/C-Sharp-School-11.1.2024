// Створення гри пятнашки
const int size = 4;

// створення масиву комірок
int zeroY = 2;
int zeroX = 1;

int[,] puzzle = new int[size, size] {
    { 4, 2, 9, 3 },
    { 8, 10, 7, 5 },
    { 11, 16, 14, 6 },
    { 1, 15, 12, 13 }
};

PrintPuzzle();

while (true)
{
    var key = Console.ReadKey().Key;

    switch (key)
    {
        case ConsoleKey.LeftArrow:
            if (zeroX == size - 1) break;
            // move left
            // swap 0 <> right cell
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX + 1]);
            ++zeroX;
            break;
        case ConsoleKey.RightArrow:
            // якщо порожня комірка на 1-й колонці
            if (zeroX == 0) break;
            // move right
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX - 1]);
            --zeroX;
            break;
        case ConsoleKey.UpArrow:
            if (zeroY == size - 1) break;
            // move up
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY + 1, zeroX]);
            ++zeroY;
            break;
        case ConsoleKey.DownArrow:
            if (zeroY == 0) break;
            // move up
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY - 1, zeroX]);
            --zeroY;
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
    for (int r = 0; r < size; r++)
    {
        for (int c = 0; c < size; c++)
        {
            if (puzzle[r, c] == r * size + c + 1)
                Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (puzzle[r, c] == 16)
                Console.Write("[  ] ");
            else
                Console.Write($"[{puzzle[r, c], 2}] ");

            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
