/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
*/


int[,] Generate2DArray(int rows, int columns, int deviation)
{
    int[,] array2DCreate = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2DCreate[i, j] = new Random().Next(0, deviation + 1);
        }
    }
    return array2DCreate;
}

int[] SumElementRowsArray(int[,] array)
{
    int[] sumElement = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElement[i] += array[i, j];
        }
    }
    return sumElement;
}

void ComparisonSumRowsPrint(int[] array)
{
    int minSumRows = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (minSumRows > array[i])
        {
            minSumRows = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов = {minSumRows} под номером {minIndex}");
}


void Print2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("--------------------");
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
    Console.WriteLine("--------------------");
}

Console.WriteLine("Введите размеры массива и его диапазон: ");
int rowsUser = Convert.ToInt32(Console.ReadLine());
int columnsUser = Convert.ToInt32(Console.ReadLine());
int deviationUser = Convert.ToInt32(Console.ReadLine());

int[,] arrayUser = Generate2DArray(rowsUser, columnsUser, deviationUser);
int[] sumElement = SumElementRowsArray(arrayUser);

Console.WriteLine("Исходный массив: ");
Print2DArray(arrayUser);
Console.WriteLine("Массив сумм элементов: ");
PrintArray(sumElement);
ComparisonSumRowsPrint(sumElement);