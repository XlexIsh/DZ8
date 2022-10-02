// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = CreateRandomArray(4, 4);
Print2DArray(array);

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();

int GetMinRow(int[,] array)
{
    int[] arrayRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayRow[i] += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки: {arrayRow[i]}");
    }
    int min = arrayRow[0];
    int indexMinRow = 1;
    for (int k = 0; k < arrayRow.Length; k++)
    {
        if (arrayRow[k] <= min)
        {
            indexMinRow = k + 1;
            min = arrayRow[k];
        }
    }
    return indexMinRow;
}

int indexMinRow = GetMinRow(array);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов: {indexMinRow} строка");