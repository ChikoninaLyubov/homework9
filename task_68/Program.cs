//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    if (n > 0 && m > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}
System.Console.WriteLine("Укажите m функции: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Укажите n функции: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Результат функции Аккермана для {m} и {n}  является {Akkerman(m, n)}");