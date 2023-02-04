/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] GetArray(int M, int N)
{
    double[,] array = new double[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            array[i, j] = new Random().NextDouble() * 100; // здесь мы генерируем случайные вещественные числа, выражение подсмотрел в интернете
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(arr[i, j], 2)}\t"); // тут я округлил немного, так как выдавал слишком длинные вещественные числа
        }
        Console.WriteLine();
    }
}

void Main() // собственно создаем функцию, где будем взаимодействовать с пользователем и вызывать другие функциии
{
    Console.Clear();
    Console.Write("Enter rows: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Enter columns: ");
    int n = int.Parse(Console.ReadLine()!);
    double[,] array = GetArray(m, n);
    PrintArray(array);
}
Main();