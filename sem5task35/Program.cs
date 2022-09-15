// Задайте одномерный массив из 123 случайных чисел. 
// Найдите колличества элементов массива, значения которых лежат в отрезке [10, 99]

// Заполняем массив 123-я элементами со случайными значениями
int[] FillArray(int count, int from, int to)
{
    Random ranNum = new Random();
    int[] array = new int[count];
    for (byte i = 0; i < array.Length; i++)
        array[i] = ranNum.Next(from, to);
    return array;
}

// Перебираем массив с помощью foreach, ищем значения в отрезке [10, 99]
int FindCountNums(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 9 && el < 100)
            count++;
        continue;
    }
    return count;
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

int[] arrRandNum = FillArray(123, 0, 1000);
Print1DArray(arrRandNum, "Массив чисел: ");
PrintCountNums(FindCountNums(arrRandNum), "Колличество элементов из диапазона [10, 99]: ");




