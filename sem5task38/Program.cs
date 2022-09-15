// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// * Дополнительно написать два метода: метод сортировки вставкой и метод сортировки подсчетом. Сравнить скорость работы двух алгоритмов.
// [3 7 22 2 78] -> 76


// Заполняем массив случайными значениями
double[] FillArray(int count, int from, int to)
{
    if (from > to)
    {
        int value = to;
        to = from;
        from = value;
    }
    Random ranNum = new Random();
    double[] array = new double[count];
    for (byte i = 0; i < array.Length; i++)
        array[i] = ranNum.Next(from, to);
    return array;
}

// Перемножаем пары чисел
double FindDiffMaxMin(double[] array)
{
    int indexOfMax = 0;
    int indexOfMin = 0;
    for (byte i = 1; i < array.Length; i++)
    {
        if (array[i] > array[indexOfMax])
        {
            indexOfMax = i;
        }
        else if (array[i] < array[indexOfMin])
        {
            indexOfMin = i;
        }
    }
    // Находим разницу двух элементов массива
    double diffMaxMin = array[indexOfMax] - array[indexOfMin];
    return diffMaxMin;
}

// Выводим получившийся массив
void Print1DArray(double[] array, string line)
{
    Console.Write(line);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

//Выводим разницу между max и min
void PrintResultDiff(double num, string line)
{
    Console.WriteLine("Разница между max и min = " + num);
}

double[] arrRandNum = FillArray(10, 0, 100);
Print1DArray(arrRandNum, "Массив: ");
PrintResultDiff(FindDiffMaxMin(arrRandNum), "Max и min значения массива: ");
