using System.Collections.Generic;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Stack<string> students = new Stack<string>();

students.Push("Ivan");
students.Push("Nazar");
students.Push("Sofia");
students.Push("Vika");
students.Push("Vlad");

// повернути та видалити верхній елемент
Console.WriteLine("Top item: " + students.Pop());

// повернути верхній елемент
Console.WriteLine("Top item: " + students.Peek());

Console.WriteLine("Students: " + students.Count);

Console.WriteLine("Vlad: " + students.Contains("Vlad"));

while (students.Count > 0)
{
    Console.WriteLine("Item: " + students.Pop());
}