// ---- створюємо файл
var file = File.CreateText("test.txt");

// ----- додаємо текст до файлу
file.WriteLine("Hello file!");
file.WriteLine($"Today: {DateTime.Now}");
file.WriteLine($"------------------------");

// ----- закриваємо файл, щоб можна було далі з ним працювати
file.Close();

// ----- копіюємо файл в ту ж саму папку
File.Copy("test.txt", "copy.txt", true);
// ----- копіюємо файл на робочий стіл
File.Copy("test.txt", $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/copy.txt", true);

// ----- читаємо текст з файлу
string text = File.ReadAllText("test.txt");
Console.WriteLine(text);

// ----- видаляємо файл
File.Delete("test.txt");

// ----- створити файл під назвою користувача
File.CreateText($"{Console.ReadLine()}.txt");