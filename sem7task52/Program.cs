// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.

// Заполняем массив случайными значениями
int[,] Fill2DArray(int row, int column)
{
    Random ranNum = new Random();
    int[,] array = new int[row, column];
    for (byte i = 0; i < row; i++)
    {
        for (byte j = 0; j < column; j++)
        {
            array[i, j] = ranNum.Next(10, 20);
        }
    }
    return array;
}

// Считаем Среднее арифметическое столбцов
double[] SumAverangeElem(int[,] array2D)
{
    double[] array1D = new double[array2D.GetLength(1)];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (byte i = 0; i < array2D.GetLength(0); i++)
        {
            array1D[j] = array1D[j] + array2D[i, j];
        }
        array1D[j] = array1D[j] / array2D.GetLength(0);
    }
    return array1D;
}

// Метод для вывода двумерного массива не экран
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

// Метод для вывода одномерного массива не экран
void Print1DArray(string line, double[] array)
{
    Console.Write(line);
    foreach (double value in array)
    {
        Console.Write($"{value} ");
    }
    Console.WriteLine();

}

 // Считаем сумму главной диагонали
int SumElemsOfMainDiagonal(int[,] arr2D)
{
    int sumLine = 0;
    for (byte i = 0; i < arr2D.GetLength(0); i++)
    {
        for (byte j = 0; j < arr2D.GetLength(1); j++)
        {
            if(i == j){sumLine = sumLine + arr2D[i , j];}
        }
    }
    return sumLine;
}

// Создаем и заполняем массив
int[,] array2D = Fill2DArray(10, 10);
// int result = SumElemsOfMainLine(array2D);

// Выводим двумерный массив и результат поиска 
Print2DArray("Двумерный массив: ", array2D);
Print1DArray("Среднее арифметическое чисел: ", SumAverangeElem(array2D));
Console.WriteLine($"Сумма элементов главной диагонали равна: {SumElemsOfMainDiagonal(array2D)}");





