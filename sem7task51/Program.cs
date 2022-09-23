// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//(с индексами (0,0); (1,1) и т.д.

 // Заполняем массив случайными значениями
int[,] Fill2DArray(int row, int column)
{
    Random ranNum = new Random();
    int[,] array = new int[row, column];
    for (byte i = 0; i < row; i++)
    {
        for (byte j = 0; j < column; j++)
        {
            array[i, j] = ranNum.Next(10, 100);
        }
    }
    return array;
}

 // Считаем сумму главной диагонали
int SumElemsOfMainLine(int[,] arr2D)
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

// Метод для вывода массива не экран
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

// Создаем и заполняем массив
int[,] array2D = Fill2DArray(4,4);
int result = SumElemsOfMainLine(array2D);

// Выводим двумерный массив и результат поиска 
Print2DArray("Двумерный массив: ", array2D);
Console.WriteLine($"Сумма элементов главной диагонали равна: {SumElemsOfMainLine(array2D)}");


