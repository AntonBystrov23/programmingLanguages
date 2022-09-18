//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// *Найти все пары и вывести

// Заполняем массив 123-я элементами со случайными значениями
int[] FillArray(int count, int from, int to)
{
    if (from > to)
    {
        int value = to;
        to = from;
        from = value;
    }
    Random ranNum = new Random();
    int[] array = new int[count];
    for (byte i = 0; i < array.Length; i++)
        array[i] = ranNum.Next(from, to);
    return array;
}

// Перебираем массив с помощью foreach, ищем значения в отрезке [10, 99]
int FindSumNums(int[] array)
{
    int sum = 0;
    for (byte i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

// Выводим получившийся массив
void Print1DArray(int[] array, string line)
{
    Console.Write(line);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Выводим результат поиска(количество найденных элементов)
void PrintCountNums(int count, string line)
{
    Console.Write(line);
    Console.WriteLine(count);
}

// Поиск пар в массиве

int[] arrRandNum = FillArray(10, 0, 10);
Print1DArray(arrRandNum, "Массив чисел: ");
PrintCountNums(FindSumNums(arrRandNum), "Сумма элементов, стоящих на нечётных позициях: ");


