// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//----ОСНОВНОЙ ВАРИАНТ----------

// int GetDate(string line)                   // получаем данные от пользователя 
// {
//     Console.WriteLine(line);
//     int countNumbers = int.Parse(Console.ReadLine() ?? "0");
//     return countNumbers;
// }
// void FillArray(int[] collection)           // метод заполнения массива случайными значениями от 0 до 100
// {
//     int length = collection.Length;
//     for (int index = 0; index < length; index++)
//     {
//         collection[index] = new Random().Next(0, 100);
//     }
// }
// void PrintArray(int[] finishedArray)       // метод печати массива
// {
//     for (int position = 0; position < finishedArray.Length - 1; position++)
//     {
//         Console.Write(finishedArray[position] + ", ");
//     }
//     Console.WriteLine(finishedArray[finishedArray.Length - 1] + "!");
// }
// int[] arrayRandom = new int[GetDate("Введите количество чисел в массиве: ")]; //создаем пустой массив
// FillArray(arrayRandom);                    // заполняем
// PrintArray(arrayRandom);                   // печатаем


//----ВАРИАНТ С ВЫБОРОМ ДЛИННЫ МАССИВА И ДИАПАЗОНА ЗНАЧЕНИЙ----------

// int GetDate(string line)                      // получаем данные от пользователя 
// {
//     Console.Write(line);
//     int countNumbers = int.Parse(Console.ReadLine() ?? "0");
//     return countNumbers;
// }
// int[] FillArray(int inputLength, int inputRangeFrom, int inputRangeTo)  // заполняем массив учитывая три парраметра
// {   
//     int[] arrayRandom = new int[inputLength];                               // создаем пустой массив с заранее указанной длинной
//     for (int index = 0; index < inputLength; index++)
//     {
//         arrayRandom[index] = new Random().Next(inputRangeFrom, inputRangeTo);    // заполняем массив числами из заранее указанного диапазона
//     }
// return arrayRandom;
// }
// void PrintArray(int[] finishedArray)          // метод печати массива
// {   
//     Console.Write("Результат: ");
//     int length = finishedArray.Length;
//     for (int position = 0; position < length - 1; position++)
//     {
//         Console.Write(finishedArray[position] + ", ");
//     }
//     Console.WriteLine(finishedArray[length - 1] + "!");
// }
// PrintArray(FillArray(GetDate("Введите длинну массива: "), GetDate("Диапазон от: "), GetDate("Диапазон до: ")));  // вывод результата  


// ----ЗАДАЧА С ИМЕНАМИ----------

string InputDate(string line)                   // получаем данные от пользователя 
{
    Console.Write(line);
    string lineNames = Console.ReadLine() ?? "0";
    return lineNames;
}

string CreatArray(string names)           // метод заполнения массива случайными значениями от 0 до 100
{
    string[] array = names.Split(",");
    int numRand = new Random().Next(0, array.Length);
    string nameRand = array[numRand];
    return nameRand;
}

void PrintArray(string finishedArray)       // метод печати массива
{
    {
        Console.Write(finishedArray + ", победитель!");
    } 
}

PrintArray(CreatArray(InputDate("Введите имена через запятую:")));