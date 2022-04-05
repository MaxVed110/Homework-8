/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

int[,] GenerateMatrix(int rows, int columns, int deviation)
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


int[,] CompositionMatrix(int[,] oneMatrix, int[,] twoMatrix)
{
    int[,] compositionMatrix = new int[oneMatrix.GetLength(0), twoMatrix.GetLength(1)];
    if (oneMatrix.GetLength(1) == twoMatrix.GetLength(0))
    {
        int sumCompositionElement = 0;
        for (int k = 0; k < twoMatrix.GetLength(1); k++)
        {
            for (int i = 0; i < twoMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < oneMatrix.GetLength(1); j++)
                {
                    sumCompositionElement += oneMatrix[i, j] * twoMatrix[j, k];
                }
                compositionMatrix[i, k] = sumCompositionElement;
                sumCompositionElement = 0;
            }
        }
    }
    else
    {
        compositionMatrix = null;
    }
    return compositionMatrix;
}

void PrintMatrix(int[,] array)
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

/*
Console.WriteLine("Введите размеры первой матрицы и её диапазон: ");
int oneRowsUser = Convert.ToInt32(Console.ReadLine());
int oneColumnsUser = Convert.ToInt32(Console.ReadLine());
int oneDeviationUser = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размеры второй матрицы и её диапазон: ");
int twoRowsUser = Convert.ToInt32(Console.ReadLine());
int twoColumnsUser = Convert.ToInt32(Console.ReadLine());
int twoDeviationUser = Convert.ToInt32(Console.ReadLine());
*/

int[,] oneMatrixUser = GenerateMatrix(3, 3, 5);
int[,] twoMatrixUser = GenerateMatrix(3, 2, 5);

int[,] compositionUserMatrix = CompositionMatrix(oneMatrixUser, twoMatrixUser);

Console.WriteLine("Первая матрица: ");
PrintMatrix(oneMatrixUser);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(twoMatrixUser);

if (compositionUserMatrix != null)
{
    Console.WriteLine("Произведение матриц: ");
    PrintMatrix(compositionUserMatrix);
}
else
{
    Console.WriteLine("Произведение матриц вычислить невозможно");
}


