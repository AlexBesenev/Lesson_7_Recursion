/**************************************
 Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.
пример:
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
***************************************/

void OutputArrayFromEnd(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        OutputArrayFromEnd(array, i + 1);
        if (i > 0)
        {
            System.Console.Write(array[i] + " ");
        }
        else
        {
            System.Console.WriteLine(array[i]);
        }
    }
    return;
}

int[] auf = { 1, 2, 5, 0, 10, 34 };
OutputArrayFromEnd(auf);