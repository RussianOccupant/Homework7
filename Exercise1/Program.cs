/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++) // бегает по строке
    {
        for (int j = 0; j < n; j++) //Бегает по столбцам
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Search(int[,] array, int M, int N)
{
    int c = 0;
    if (M < array.GetLength(0) && N < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[M, N] == array[i, j]) 
                {
                    c = 1;
                }
            }
        }
    }
    else Console.WriteLine($"Элемента с индексом [{M}, {N}] не существует в данном двумерном массиве");
    if (c == 1)
    {
        Console.WriteLine($"Элемент массива с индексом [{M}, {N}] существует и равен {array[M, N]}");
    }
}



void Main()
{
    Console.Write("Введите первый индекс М: ");
    int M = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второй индекс N: ");
    int N = int.Parse(Console.ReadLine()!);
    int[,] array = GetArray(4, 4, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    Search(array, M, N);
}
Main();