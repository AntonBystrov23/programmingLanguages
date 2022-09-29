// задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строчки массива

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
void ChangePlace(int[,] array)
{
    int buffer;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        buffer = array[0, i];
        array[0,i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = buffer;
    }
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

int[,] matrix = Fill2DArray(5, 5);
Print2DArray("Исходный массив: ", matrix);
ChangePlace(matrix);
Print2DArray("Измененный массив: ", matrix);
