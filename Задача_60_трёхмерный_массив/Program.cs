/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int[,,] Generate3DArray(int length, int width, int height)
{
    int[,,] array3DCreate = new int[length, width, height];
    var knownNumbers = new HashSet<int>();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < height; k++)
            {
                int newNumbers = new int();
                do
                {
                    newNumbers = new Random().Next(10, 100);
                }
                while (!knownNumbers.Add(newNumbers));
                array3DCreate[i, j, k] = newNumbers;
            }
        }
    }
    return array3DCreate;
}



void Print3DArray(int[,,] array) // вывод с элемента [0,0,0] [0,1,0] [0,2,0] затем [1,0,0] [1,1,0] [1,2,0] и т.д
{
    Console.WriteLine();
    int count = 0;
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine($"Вывод {count} строки");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}\t");
            }
            count ++;
            Console.WriteLine();
        }
    }
}


Console.WriteLine("Введите размеры массива: ");
int lengthUser = Convert.ToInt32(Console.ReadLine());
int widthUser = Convert.ToInt32(Console.ReadLine());
int heightUser = Convert.ToInt32(Console.ReadLine());

int[,,] array = Generate3DArray(lengthUser, widthUser, heightUser);
Print3DArray(array);