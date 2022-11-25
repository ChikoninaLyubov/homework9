// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Clear();
int SumMN(int m, int n)
{
    if (m > n) return 0;
    return n + SumMN(m, n - 1);
}
System.Console.Write("Укажите начало промжутка(M): ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите конец промежутка(N): ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма натуральных элементов на промежутке от {m} до {n} равна {SumMN(m, n)}");

string[] in_mas = { "DayOfWeek", "devor", "del", "mar", "sam", "prokm", "end" };

string[] SearchForThrdCharString(string[] in_mas)
{
    string[] out_mas = new string[1];
    int j = 0;
    for (int i = 0; i < in_mas.Length; i++)
    {
        if (in_mas[i].Length <= 3)
        {
            Array.Resize(ref out_mas, 1 + j);
            out_mas[j] = in_mas[i];
            j++;
        }
    }
    return out_mas;
}
System.Console.WriteLine(String.Join("|", SearchForThrdCharString(in_mas)));
