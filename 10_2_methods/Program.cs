Console.CursorVisible = false;

void Shot(string direction, int startX, int startY)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    while (true)
    {
        Console.SetCursorPosition(startX, startY);
        Console.Write("\u25cf");

        Thread.Sleep(100);
        
        Console.SetCursorPosition(startX, startY);
        Console.Write(" ");
        switch (direction)
        {
            case "RIGHT": startX++; break;
            case "LEFT": startX--; break;
            case "UP": startY--; break;
            case "DOWN": startY++; break;
        }
    }
    Console.ResetColor();
}

Parallel.Invoke([
    () => Shot("DOWN", 10, 0),
    () => Shot("DOWN", 34, 10),
    //() => Shot("DOWN", 0, 0),
    //() => Shot("DOWN", 57, 30)
]);