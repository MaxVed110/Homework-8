/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
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

int[,] Sorted2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int buf = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = buf;
                }
            }
        }
    }
    return array;
}


Console.WriteLine("Введите размеры массива и его диапазон: ");
int rowsUser = Convert.ToInt32(Console.ReadLine());
int columnsUser = Convert.ToInt32(Console.ReadLine());
int deviationUser = Convert.ToInt32(Console.ReadLine());

int[,] arrayUser = Generate2DArray(rowsUser, columnsUser, deviationUser);
Console.WriteLine("Исходный массив: ");
Print2DArray(arrayUser);
int[,] sortedArrayUser = Sorted2DArray(arrayUser);
Console.WriteLine("Отсортированный массив: ");
Print2DArray(sortedArrayUser);
