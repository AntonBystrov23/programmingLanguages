// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента. 
// Массив размером 2*2*2

// Заполняем массив случайными значениями
int[,,] Fill3DArray(int[,,] arr, int from, int to)
{
    for (byte i = 0; i < arr.GetLength(0); i++)
    {
        for (byte j = 0; j < arr.GetLength(1); j++)
        {
            for (byte k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(from, to + 1);
            }
        }
    }
    return arr;
}

// Выводим трехмерный массив
void Print3DArray(string prefix, int[,,] arr3D)
{
    Console.WriteLine(prefix);
    for (byte i = 0; i < arr3D.GetLength(0); i++)
    {
        for (byte j = 0; j < arr3D.GetLength(1); j++)
        {
            for (byte k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]} - " + (i, j, k) + " ");
            }
        Console.WriteLine();
        }
    }
}

int[,,]array3D = new int[2, 2, 2];

Print3DArray("Трехмерный массив: ", Fill3DArray(array3D, 10, 100));
