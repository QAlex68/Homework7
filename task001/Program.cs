// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print2dArray(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(massive[i,j],2)}\t", -5);
        }
        Console.WriteLine();
    }
}

double [,] Create2dArray(int rows, int columns, int startValue, int finishValue)
{
    double[,] matrix = new double [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().NextDouble() * (finishValue - startValue) + startValue;
        }
    }
    return matrix;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int start = GetInput("Введите начало диапазона значений элементов: ");
int finish = GetInput("Введите конец диапазона значений элементов: ");
double [,] array2D = Create2dArray(m, n, start, finish);
Print2dArray(array2D);

