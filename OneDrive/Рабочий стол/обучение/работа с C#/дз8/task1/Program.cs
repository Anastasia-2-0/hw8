// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

int[,] table = FillArray(rows, columns);
Console.WriteLine("Массив до изменения");
PrintArray(table);

Console.WriteLine();
Console.WriteLine("Массив после изменения");
SortingArray(table);
PrintSortingArray(table);

void SortingArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int l = 0; l < arr.GetLength(1) - 1; l++)
      {
        if (arr[i, l] < arr[i, l + 1])
        {
          int temp = arr[i, l + 1];
          arr[i, l + 1] = arr[i, l];
          arr[i, l] = temp;
        }
      }
    }
  }
}

void PrintSortingArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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
