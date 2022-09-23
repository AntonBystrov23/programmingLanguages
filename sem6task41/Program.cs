// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий с клавиатуры. Затем программа следит за нажатиями пользователя. В веденных
// данных на клавиатуре программа считает колличество чисел, которые были введены (больше ноля)

// // Запрашиваем данные у пользователя
// string ReadDate(string line)
// {
//     Console.Write(line);
//     string nums = Console.ReadLine() ?? "0";
//     return nums;
// }

// // Конвертируем набранные строки в массив с целочисленными значениями
// int[] ConvertToIntArr(string numbers)
// {
//     string[] bufferArray = numbers.Split(new char[] { ',' });
//     int[] convertArr = new int[bufferArray.Length];
//     for (int i = 0; i < bufferArray.Length; i++)
//     {
//         convertArr[i] = int.Parse(bufferArray[i]);
//     }
//     return convertArr;
// }

// // Считаем количество чисел выше ноля
// int CountNumsAboveZero(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el > 0)
//             count++;
//         continue;
//     }
//     return count;
// }

// // Выводим одномерный массив
// void Print1DArray(int[] array, string line)
// {
//     Console.WriteLine("[{0}]", string.Join(", ", array));
// }

// // Выводим результат подсчета
// void PrintResult(int num, string line)
// {
//     Console.Write(line);
//     Console.WriteLine(num);
// }

// string userInputNums = ReadDate("Введите через запятую целые числа и нажмите Enter: ");
// int[] convertArray = ConvertToIntArr(userInputNums);
// Print1DArray(convertArray, "Исходный массив: ");
// PrintResult(CountNumsAboveZero(convertArray), "Результат: ");

//========================================================================================================


// ---ОСНОВНОЕ РЕШЕНИЕ---

// Запрашиваем данные у пользователя
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Считаем количество чисел выше ноля
int CountNumsAboveZero(int count)
{
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        int number = ReadDate("Введите число: ");
        if ( number > 0)
            result++;
    }
    return result;
}

// Выводим результат подсчета
void PrintResult(string prefix, int value)
{
    Console.Write(prefix);
    Console.WriteLine(value);
}

PrintResult("Результат: ", CountNumsAboveZero(ReadDate("Введите колличество цифр: ")));


