// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.Write("Введите свое имя: ");
string a = Console.ReadLine();
Console.WriteLine($"Привет, {a}");
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine("Хотите продолжить? (y/n)");
string b = Console.ReadLine();
if (b == "y")
{
    Console.WriteLine("Отлично!");
}
else if (b == "n")
{
    Console.WriteLine("Обидно(");
}