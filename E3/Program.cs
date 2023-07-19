// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int x = -1;
int y = -1;

while ( x<0 || y <0)
{
    Console.WriteLine("Введите два неотрицательных числа: ");
    Console.Write("Введите первое значение: ");
    x = int.Parse(Console.ReadLine()!);

    Console.Write("Введите второе значение: ");
    y = int.Parse(Console.ReadLine()!);  
}


Console.WriteLine($"функция Аккермана от {x} и {y} = {Akkerman(x,y)}");

int Akkerman( int m, int n)
{
    if (m==0) return n+1;
    if (n==0) return Akkerman(m-1,1);

    return Akkerman( m-1, Akkerman(m,n-1));
}