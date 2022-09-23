// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.// 
// Выведите полученный массив на экран.


int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// // Заполняем массив случайными значениями
int[,] Fill2DArray(int countRow, int countColumn, int from, int to)
{
    if (from > to)
    {
        int value = to;
        to = from;
        from = value;
    }
    Random ranNum = new Random();
    int[,] array = new int[countRow, countColumn];
    for (byte i = 0; i < countRow; i++)
    {
        for (byte j = 0; j < countColumn; j++)
        {
            array[i, j] = ranNum.Next(from, to + 1);
        }
    }
    return array;
}


// Creating and filling an 2dArray with random numbers
int[,] ChangeArray(int[,] arr)
{
    for (byte i = 0; i < arr.GetLength(0); i+=2)
    {
        for (byte j = 0; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    }
    return arr;
}

// Printing an 2dArray
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


Print2DArray("Двумерный массив: ", ChangeArray(Fill2DArray(ReadDate("Строки: "),
                                                                 ReadDate("Столбцы: "), ReadDate("От: "), 
                                                                    ReadDate("До: "))));


