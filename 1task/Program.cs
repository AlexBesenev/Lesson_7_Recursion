/*
Задача 1: Задайте значения M и N. Напишите
программу, которая выведет все натуральные числа
в промежутке от M до N. Использовать рекурсию, не
использовать циклы.
Пример: 
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

void WriteSpanNaturNumbers(int M, int N, int i = 0)
{
    if (M > N)
    {
        System.Console.WriteLine("Первое число не может быть больше второго");
        return;
    }
    if (N == M)
    {
        System.Console.Write(N + ", ");
        return;
    }
    WriteSpanNaturNumbers(M, N - 1, i + 1);
    if (i == 0)
    {
        System.Console.WriteLine(N);
        return;
    }
    System.Console.Write(N + ", ");
}
WriteSpanNaturNumbers(4, 8);
