// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ArithmeticAverageColumn(int [,] massive)
{
    if (massive == null) goto Exit;
    Console.WriteLine("Среднее арифмитрическое чисел в каждом столбце:");
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        double sumColumn = 0; 
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            sumColumn += massive[i,j];
        }
        double averageColumn = sumColumn / (massive.GetLength(1));
        Console.WriteLine($"Столбец {j} среднее арифмитическое = {Math.Round(averageColumn, 2)}");        
    }
    Exit:
    if (massive == null) Console.WriteLine("Массив пуст!!");    
}

void Print2dArray(int [,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]}\t", -5);
        }
        Console.WriteLine();
    }
}

int [,] Create2dArray(int rows, int columns, int startValue, int finishValue)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(startValue, finishValue + 1);
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
int [,] array2D = Create2dArray(m, n, start, finish);
Console.WriteLine($"Сгенерирован массив [{m}x{n}] в диапазоне от {start} до {finish} !");
Print2dArray(array2D);
ArithmeticAverageColumn(array2D);
