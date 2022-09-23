// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет
// 13 3 52 6
// 44 31 5 8
// 44 71 4 9
// 17 => такого числа в массиве нет

//----- * Заполнить числами фибоначи и выделить цветом найденную цифру--------------

 // Получаем данные от пользователя
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0") - 1;
    return num;
}

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

// Проверяем есть ли указанная строка и столбец.
bool FindNumberInMatrix(int row, int column)
{
    return (row >= 0 && row <=10 && column >= 0 && column <= 10);
}

// Создаем и заполняем массив
int[,] array2D = Fill2DArray(10,10);

// Пользователь вводит данные
int m = ReadDate("Строка: ");
int n = ReadDate("Столбец: ");

// Выводим двумерный массив и результат поиска 
Print2DArray("Двумерный массив: ", array2D);
Console.WriteLine(FindNumberInMatrix(m, n) ? array2D[m, n] : "Такого значения нет!");


