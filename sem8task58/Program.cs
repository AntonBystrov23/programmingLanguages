// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

// Перемножение матриц
int[,] MatrixMultiply(int[,] arrA, int[,] arrB)
{ 
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                arrC[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
    }

    return arrC;
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

int[,] array2D1 = Fill2DArray(new int[3, 2], 1, 4);
int[,] array2D2 = Fill2DArray(new int[2, 3], 1, 4);
Print2DArray("Первая матрица: ", array2D1);
Print2DArray("Вторая матрица: ", array2D2);
Print2DArray("Результат перемножения: ", MatrixMultiply(array2D1, array2D2));



