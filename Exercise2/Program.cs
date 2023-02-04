/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void GetAverage(int[,] array, int rows)
{
    Console.WriteLine("Среднее арифметическое всех значений каждого столбца: ");
    double a = 0;
    for (int b = 0;b <= rows; b++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            a = a + array[i, b];
        }
        Console.Write($"{Math.Round(a / rows, 2)}\t");
        a = 0;
    }
}

int[,] array = GetArray(3, 4, 0, 10);
PrintArray(array);
GetAverage(array, 3);















