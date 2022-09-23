// Задайте двумерный массив размером mxn и заполните целыми числами

//--------ВВОД ДАННЫХ------------
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

// Создаем коллекцию цветов
ConsoleColor[] colorColl = new ConsoleColor[]{ ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
                                        ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Green,
                                        ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                                        ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.White, ConsoleColor.Gray};

// // Печатаем двумерный массив
// void Print2DArray(string prefix, int[,] array2D)
// {
//     Console.WriteLine(prefix);
//     for (byte i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (byte j = 0; j < array2D.GetLength(1); j++)
//         {
//             Console.Write($"{array2D[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Печатаем двумерный массив
void Print2DArrayColored(string prefix, int[,] array2D)
{
    Console.WriteLine(prefix);
    for (byte i = 0; i < array2D.GetLength(0); i++)
    {
        for (byte j = 0; j < array2D.GetLength(1); j++)
        {
            Console.ForegroundColor = colorColl[new System.Random().Next(0, 16)];
            Console.Write($"{array2D[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}



Print2DArrayColored("Двумерный массив: ", Fill2DArray(ReadDate("Кол-во строк: "), ReadDate("Кол-во столбцов: "),
                                                ReadDate("Числа от: "), ReadDate("Числа до: ")));
