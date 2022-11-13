// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите количество столбцов 1 массива: ");
int columnsFirstArray = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк 1 массива: ");
int rowsFirstArray = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов 2 массива: ");
int columnsSecondArray = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк 2 массива: ");
int rowsSecondArray = int.Parse(Console.ReadLine());

if (columnsFirstArray != rowsSecondArray)
{
    Console.WriteLine("Такие матрицы умножать нельзя!");
    return;
}
int[,] firstArray = GetArray(rowsFirstArray, columnsFirstArray, 0, 10);
int[,] secondArray = GetArray(rowsSecondArray, columnsSecondArray, 0, 10);
Console.WriteLine("Массив 1:");
PrintArray(firstArray);
Console.WriteLine();

Console.WriteLine("Массив 2:");
PrintArray(secondArray);
Console.WriteLine();

Console.WriteLine("Результирующий массив: ");
PrintArray(GetMultiplicationMatrix(firstArray, secondArray));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationMatrix(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayThree = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                arrayThree[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
        }
    }
    return arrayThree;
}
