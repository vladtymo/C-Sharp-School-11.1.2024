

List<string> colors = new() {"green", "blue", "red", "yellow"};

colors.Add("white");
colors.Insert(1, "black");

//foreach (var i in colors) Console.Write(i + ", ");
Console.WriteLine("Inserted: " + string.Join(", ", colors)); 

colors.RemoveAt(2);
colors.Remove("yellow");

Console.WriteLine("Removed: " + string.Join(", ", colors)); 

Console.Write("Enter color to find: ");
string color = Console.ReadLine();

if (colors.Contains(color))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Found color!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Color not found!");
}
Console.ResetColor();

colors.Sort();
Console.WriteLine("Sorted: " + string.Join(", ", colors));

colors.Reverse();
Console.WriteLine("Reversed: " + string.Join(", ", colors));

Console.WriteLine("Colors count: " + colors.Count);

colors.Exists(x => x.Length > 5);
colors.Exists(x => x[0] == 'A');

colors.Find(x => x.Length > 5);
colors.FindAll(x => x[0] == 'A');