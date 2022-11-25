// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
string PrintN(int N)
{
    if (N == 1) return "1";
    return Convert.ToString(N) + ", " + PrintN(N - 1);
}
System.Console.Write("Укажите начало отсчета (N): ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"N = {N} -> \"{PrintN(N)}\"");