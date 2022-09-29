// задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это не возможно, 
// программа сообщает пользователю

// Заполняем массив случайными значениями
int[,] Fill2DArray(int row, int column)
{
    Random ranNum = new Random();
    int[,] array = new int[row, column];
    for (byte i = 0; i < row; i++)
    {
        for (byte j = 0; j < column; j++)
        {
            array[i, j] = ranNum.Next(0, 10);
        }
    }
    return array;
}

// Меняем строки массива местами
int[,] ChangePlace(int[,] array)
{
    int[,] arr = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = array[j, i];
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

int[,] matrix = Fill2DArray(7, 5);
Print2DArray("Исходный массив: ", matrix);
Print2DArray("Измененный массив: ", ChangePlace(matrix));
