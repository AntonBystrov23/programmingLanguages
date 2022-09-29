// Задайте двумерный массив. Напишите программу которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// Сортируем строки массива
int[,] Sort2DArray(int[,] array)
{
    for (byte i = 0; i < array.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (byte j = 0; j < array.GetLength(1); j++)
        {
            Row.Add(array[i, j]);
        }
        Row.Sort();
        Row.Reverse();
        for (byte j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Row[j];
        }
    }

    return array;
}


int[,] array2D = Fill2DArray(new int[5, 5], 0, 9);
Print2DArray("Исходный массив: ", array2D);
Print2DArray("Отсортированный массив: ", Sort2DArray(array2D));
