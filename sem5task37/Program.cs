// Найдите произведение пар чисел в одномерном массиве. Парой счимаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// Пример: [1 2 3 4 5] -> 5 8 3
//         [6 7 3 6] -> 36 21

// // Заполняем массив случайными значениями

// int[] FillArray(int count, int from, int to)
// {
//     if (from > to)
//     {
//         int value = to;
//         to = from;
//         from = value;
//     }
//     Random ranNum = new Random();
//     int[] array = new int[count];
//     for (byte i = 0; i < array.Length; i++)
//         array[i] = ranNum.Next(from, to);
//     return array;
// }

// // Перемножаем пары чисел
// string MultiplyPairs(int[] array)
// {   string multiplyNums = string.Empty;
//     int length = array.Length - 1;
//     for (int index = 0; index < length; index++)
//     {
//         multiplyNums = multiplyNums + (array[index] * array[length])+ ","; // "\t"
//         length--;
//     }
//     if (array.Length%2 != 0)
//         multiplyNums = multiplyNums + (array[array.Length / 2]);
//         return multiplyNums;   
// }

// // Выводим получившийся массив
// void Print1DArray(int[] array, string line)
// {
//     Console.Write(line);
//     Console.WriteLine("[{0}]", string.Join(", ", array));
// }

// // Выводим результат умножения
// void PrintMultiplyPairs(string result, string line)
// {
//     Console.Write(line);
//     // Console.WriteLine("[{0}]", string.Join(",", result));
//     Console.WriteLine(result);
// }

// int[] arrRandNum = FillArray(10, 2, 10);
// Print1DArray(arrRandNum, "Массив: ");
// PrintMultiplyPairs(MultiplyPairs(arrRandNum), "Результат умножения: ");



// Заполняем массив случайными значениями

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

// Перемножаем пары чисел
int[] MultiplyPairs(int[] array)
{   
    int[] changeArray = new int[array.Length / 2];
    for (int index = 0; index < array.Length / 2; index++)
    {
        changeArray[index] = array[index] * array[array.Length - 1 - index]; // "\t"
    }
    return changeArray;
}

// Выводим получившийся массив
void Print1DArray(int[] array, string line)
{
    Console.Write(line);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

int[] arrRandNum = FillArray(9, 2, 10);
Print1DArray(arrRandNum, "Массив: ");
int[] multiArr = MultiplyPairs(arrRandNum);
Print1DArray(multiArr, "Результат умножения: ");
