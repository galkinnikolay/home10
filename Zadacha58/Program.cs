// Задача 58: Задайте два двумерных массива 
// (от 0 до 10). Напишите программу, которая будет 
// находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

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

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] Array1 = GetArray(rows, columns, 0, 10);
int[,] Array2 = GetArray(rows, columns, 0, 10);

int[,] GetSquareArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i,j] = array1[i,j] * array2[i,j];
        }

    }
    return result;
}

int[,] Array3 = GetSquareArray(Array1,Array2);

PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();
PrintArray(Array3);