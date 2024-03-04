/***********************************************
Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29 
(Ошибка в примере, по таблице из различных источников при данных значениях функция A(m,n) = 9, а не 29!)
************************************************/

int CalculateAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return CalculateAckermann(m - 1, 1);
        }
    }
    return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
}
int m = 3;
int n = 2;
System.Console.WriteLine(CalculateAckermann(m, n));