// створити метод: return_type name(parameters) { code }
// void - нічого не повертає

void PrintMessage(int count, string separator)
{
    for (int i = 0; i < count; ++i)
    {
        Console.Write("Hello" + separator);
    }
    Console.WriteLine();
}

PrintMessage(10, "."); // 10

// ... code

PrintMessage(4, "-");
PrintMessage(6, ", ");

void ConvertUahToUsd(double uah)
{
    const double USD = 41.67;
    Console.WriteLine($"You have: {uah / USD:0.##}$");
}

ConvertUahToUsd(1200);
ConvertUahToUsd(50000);
ConvertUahToUsd(5);
