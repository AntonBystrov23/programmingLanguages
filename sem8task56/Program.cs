// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов

// Заполняем массив случайными значениями
int[,] Fill2DArray(int[,] arr, int from, int to)
{
    for (byte i = 0; i < arr.GetLength(0); i++)
    {
        for (byte j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}

// Выводим двумерный массив
void Print2DArray(string prefix, int[,] array2D)
{
    Console.WriteLine(prefix);
    for (byte i = 0; i < array2D.GetLength(0); i++)
    {
        for (byte j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Ищем строку с наименьшей суммой
int FindMinRow(int[,] array)
{
    int outIndex = -1;
    int min = int.MaxValue;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if(min > sum)
        {
            min = sum;
            outIndex = i;
        }
    }
    return outIndex;
}

int[,] array2D = Fill2DArray(new int[5, 5], 0, 9);
Print2DArray("Исходный массив: ", array2D);
Console.WriteLine($"Номер строки с наименьшей суммой {FindMinRow(array2D)+1}");
