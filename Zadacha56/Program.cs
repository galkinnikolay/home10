// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

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
int[,] Array = GetArray(rows, columns, 0, 10);
PrintArray(Array);
Console.WriteLine();


int GetNumberMinimumLineSummary(int[,] array)
{
    int summ = 0;
    int memory = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = array[i, j] + summ;
        }
        Console.WriteLine(summ);
        if (i == 0)
        {
            memory = summ;
        }
        if (summ < memory)
        {
            memory = summ;
            result = i + 1;
        }
        summ = 0;
    }
    return result;
}
Console.WriteLine($"Строка {GetNumberMinimumLineSummary(Array)}");