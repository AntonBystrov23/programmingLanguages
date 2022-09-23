// Задайте двумерный массив размером mxn, заполните случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета.

// Заполнение массива случайными вещественными числами.
double[,] FillArray(int countRow, int countColumn, int from, int to)
{
    // Создаем случайную переменную
    Random numberGerarate = new Random();
    // создаем новый массив
    double[,] random2DArray = new double[countRow, countColumn];
    // заполняем массив случайными значениями из диапазона, который укажет пользователь
    for (byte i = 0; i < countRow; i++)
    {
        for (byte j = 0; j < countColumn; j++)
        {
            random2DArray[i, j] = Math.Round((numberGerarate.NextDouble() * (from - to) + from), 2);
        }
    }
    return random2DArray;
}

// Создание цветовой коллекции
ConsoleColor[] colorColl = new ConsoleColor[]{ ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
                                        ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Green,
                                        ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                                        ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.White, ConsoleColor.Gray};

// Печать двумерного массива
void Print2DArrayColored(string prefix, double[,] array2D)
{
    Console.WriteLine(prefix);
    for (byte i = 0; i < array2D.GetLength(0); i++)
    {
        for (byte j = 0; j < array2D.GetLength(1); j++)
        {
            Console.ForegroundColor = colorColl[new System.Random().Next(0, 16)];  // Задаем новый цвет для каждого нового значения
            Console.Write($"{array2D[i, j]} ");
            Console.ResetColor();        // Сбрасываем настройки цвета до базового
        }
        Console.WriteLine();
    }
}

Print2DArrayColored("Двумерный массив вещественных чисел: ", FillArray(10, 10, 0, 10));


