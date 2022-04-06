/*
Задача 62: Заполните спирально массив 4 на 4.
*/


int[,] SpiralArray(int beginningNumber)
{
    int[,] spiralArray = new int[4, 4];
    for (int i = 0; i < spiralArray.GetLength(1); i++)
    {
        spiralArray[0, i] = beginningNumber + i;
    }
    for (int i = 1; i < spiralArray.GetLength(0); i++)
    {
        spiralArray[i, 3] = beginningNumber + 3 + i;
    }
    for (int i = spiralArray.GetLength(1) - 2; i >= 0; i--)
    {
        spiralArray[3, i] = beginningNumber + 9 - i;
    }
    for (int i = spiralArray.GetLength(0) - 2; i >= 1; i--)
    {
        spiralArray[i, 0] = beginningNumber + 12 - i;
    }
    for (int i = 1; i <= spiralArray.GetLength(1) - 2; i++)
    {
        spiralArray[1, i] = beginningNumber + 11 + i;
    }
    spiralArray[2, 2] = beginningNumber + 14;
    spiralArray[2, 1] = beginningNumber + 15;
    return spiralArray;
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

Console.WriteLine("Введите начальное число: ");
int beginningNumberUser = Convert.ToInt32(Console.ReadLine());

int[,] spiralArrayUser = SpiralArray(beginningNumberUser);
Console.WriteLine("Спиральный массив: ");
Print2DArray(spiralArrayUser);