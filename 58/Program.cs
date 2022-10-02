// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = CreateRandomArray1(3, 2);
Print2DArray(array1);

int[,] CreateRandomArray1(int m, int n)
{
    int[,] array1 = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = random.Next(0, 10);
        }
    }
    return array1;
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

int[,] array2 = CreateRandomArray2(2, 3);
Print2DArray(array2);

int[,] CreateRandomArray2(int m, int n)
{
    int[,] array2 = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = random.Next(0, 10);
        }
    }
    return array2;
}

Console.WriteLine();

void IsValid(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Ошибка!");
    }
}

IsValid(array1, array2);

int[,] GetMatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] arrayNew = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                arrayNew[i, j] += (array1[i, k] * array2[k, j]);
            }
        }
    }
    return arrayNew;
}

int[,] arrayNew = GetMatrixMultiplication(array1, array2);
Print2DArray(arrayNew);