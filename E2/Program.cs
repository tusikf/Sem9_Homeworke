// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите первое значение: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе значение: ");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел от {x} до {y} = {SummNumbers(x,y)}");

int SummNumbers( int start, int end)
{
    if (start == end) return start;

    return ( start + SummNumbers(start + 1, end));
}