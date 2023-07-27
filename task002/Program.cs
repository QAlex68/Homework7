// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// с условием долго спорили, сделана еще проверка на наличие числа

void SeekNumber(int[,] massive, int number)
{
    int count = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i, j] == number) count++;
        }
    }
    if (count == 0) Console.WriteLine($"Число {number} в массиве ОТСУТСТВУЕТ!");
    else Console.WriteLine($"Число {number} в массиве ПРИСУТСТВУЕТ в количестве - {count} !");
}

void SeekElement(int[,] massive, int row, int column)
{
    if (row >= massive.GetLength(0) || column >= massive.GetLength(1))
    {
        Console.WriteLine($"Элемент с номером строки {row} и номером столбца {column} ОТСУТСТВУЕТ!");
    }
    else
    {
        Console.WriteLine($"Элемент с номером строки {row} и номером столбца {column} = {massive[row, column]} !");
    }
}

void Print2dArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t", -5);
        }
        Console.WriteLine();
    }
}

int[,] Create2dArray(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int start = GetInput("Введите начало диапазона значений элементов: ");
int finish = GetInput("Введите конец диапазона значений элементов: ");
int[,] array2D = Create2dArray(m, n, start, finish);
Console.WriteLine($"Сгенерирован массив [{m}x{n}] в диапазоне от {start} до {finish} !");
Print2dArray(array2D);
int row = GetInput("Введите номер строки элемента: ");
int column = GetInput("Введите номер столбца элемента: ");
SeekElement(array2D, row, column);
int number = GetInput("Введите число для проверки наличия в массиве: ");
SeekNumber(array2D, number);