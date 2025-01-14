// Dictionary - колекція яка зберігає елементи у вигляді пари (ключ, значення)

List<string> fruits = new() { "apple", "banana", "orange", "strawberry" };

fruits[1] = "lemon";

// створити словник, де ключ - string, значення - string
Dictionary<string, string> cars = new()
{
    { "AA4545BH", "Audi A7" },
    { "LM3424GG", "BMW X6 xDrive" },
    { "AA7777AA", "Toyota Yaris" },
    { "I777I", "Tesla Model Y" },
    { "IO8989PL", "Ferrari F12" },
};

// змінити існуюче значення
cars["I777I"] = "Tesla Cybertruck";

// додати новий елемент
cars["BK2288KB"] = "Opel Zafira";
cars.Add("BK2288KB", "Opel Zafira");

Console.WriteLine("Cars: " + cars.Count);

foreach (var car in cars)
{
    Console.WriteLine($"{car.Key}: {car.Value}");
}

cars.Remove("LM3424GG");
if (cars.ContainsKey("LM3424GG"))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Cars [LM3424GG] found!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Cars [LM3424GG] not found!");
}
Console.ResetColor();

cars.Clear();

Console.WriteLine("Cars: " + cars.Count);