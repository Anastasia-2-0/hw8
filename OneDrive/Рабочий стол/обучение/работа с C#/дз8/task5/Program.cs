// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[,] spiralArray = new int[size, size];
FillArray(spiralArray);
PrintArray(spiralArray);

int[,] FillArray(int[,] array)
{
    int i = 0;
    int j = 0;
    int num = 1;
    while (num <= size * size)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
