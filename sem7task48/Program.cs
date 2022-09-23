// Задайте двумерный массив размера mxn, каждый элемент в массиве находится по формуле: Amn = m+n. 
// Выведите полученный массив на экран.


int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Creating and filling an 2dArray with random numbers
int[,] GenerArray(int countRow, int countColumn, int fromNum, int toNum)
{
        if (fromNum > toNum)
    {
        int value = toNum;
        toNum = fromNum;
        fromNum = value;
    }
    // создаем новый массив
    int[,] random2DArray = new int[countRow, countColumn];
    // заполняем массив случайными значениями из диапазона, который укажет пользователь
    for (byte i = 0; i < countRow; i++)
    {
        for (byte j = 0; j < countColumn; j++)
        {
            random2DArray[i, j] = i + j;
        }
    }
    return random2DArray;
}

// Printing an 2dArray
void Print2DArrayColored(string prefix, int[,] array2D)
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


Print2DArrayColored("Двумерный массив вещественных чисел: ", GenerArray(ReadDate("Строки: "), ReadDate("Столбцы: "), ReadDate("От: "), ReadDate("До: ")));



