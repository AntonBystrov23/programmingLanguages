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

// Метод: поменять два элемента в массиве местами
void Swap(double[] array, int i, int j)
{
    double buffer = array[i];
    array[i] = array[j];
    array[j] = buffer;
}

// Метод сортировки вставками
double[] PasteSort(double[] array)
{
    double minNum;
    int indexMin;
    for (int i = 1; i < array.Length; i++)
    {
        minNum = array[i];
        indexMin = i;
        while (indexMin > 0 && array[indexMin - 1] > minNum)
        {
            Swap(array, indexMin, indexMin - 1);
            indexMin -= 1;
        }
        array[indexMin] = minNum;
    }
    return array;
}

// Метод сортировки подсчетом
double[] CalculateSort(double[] array)
{
    double[] changeArray = new double[array.Length];

    for (byte i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (byte j = 0; j < array.Length; j++)
        {
            if (array[i] > array[j] || (array[i] == array[j] && j > i))
                count++;
        }
        changeArray[count] = array[i];
    }

    return changeArray;
}

// Метод сортировки пузырь
double[] BubblesSort(double[] array)
{
    for (int i = array.Length - 1; i >= 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (array[j] > array[j + 1])
            {
                Swap(array, j, j + 1);
            }
        }
    }
    return array;
}

DateTime r0 = DateTime.Now;
double[] arrRandNum = FillArray(50, 0, 100);
Console.WriteLine("Время генерации массива: " + (DateTime.Now - r0));

Print1DArray(arrRandNum, "Массив: ");
PrintResultDiff(FindDiffMaxMin(arrRandNum), "Max и min значения массива: ");

DateTime d0 = DateTime.Now;
double[] PastSortArray = PasteSort(arrRandNum);
Console.WriteLine("Время, затраченное на решение методом 'вставки': " + (DateTime.Now - d0));
Print1DArray(PastSortArray, "Отсортированный методом 'вставки' массив: ");

DateTime d1 = DateTime.Now;
double[] BubbleSortArray = BubblesSort(arrRandNum);
Console.WriteLine("Время, затраченное на решение методом 'Bubbles': " + (DateTime.Now - d1));
Print1DArray(BubbleSortArray, "Отсортированный методом 'Bubbles' массив: ");

DateTime d2 = DateTime.Now;
double[] CalculateSortArray = CalculateSort(arrRandNum);
Console.WriteLine("Время, затраченное на решение методом 'подсчета': " + (DateTime.Now - d2));
Print1DArray(CalculateSortArray, "Отсортированный методом 'подсчета' массив: ");