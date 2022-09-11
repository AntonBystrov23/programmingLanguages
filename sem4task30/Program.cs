// Программа выводит массив из 8 элементов из нолей и единиц в случайном порядке

//-------------ОСНОВНОЕ РЕШЕНИЕ-----------------

// int GetDate(string line)                                    // получаем данные от пользователя 
// {
//     Console.WriteLine(line);
//     int countNumbers = int.Parse(Console.ReadLine() ?? "0");
//     return countNumbers;
// }
// int[] FillArray(int num)                                    // метод заполнения массива случайными значениями от 0 до 1
// {
//     int[] arrayRandom = new int[num];
//     int length = arrayRandom.Length;
//     for (int index = 0; index < length; index++)
//     {
//         arrayRandom[index] = new Random().Next(0, 2);
//     }
// return arrayRandom;  
// }
// void PrintArray(int[] finishedArray)                        // метод печати массива
// {
//     for (int position = 0; position < finishedArray.Length - 1; position++)
//     {
//         Console.Write(finishedArray[position] + ", ");
//     }
//     Console.WriteLine(finishedArray[finishedArray.Length - 1] + "!");
// }
// PrintArray(FillArray(GetDate("Введите количество чисел в массиве: ")));                                     // печатаем


//----ВАРИАНТ С ВЫБОРОМ ДЛИННЫ МАССИВА И ДИАПАЗОНА ЗНАЧЕНИЙ----------

int GetDate(string line)                      // получаем данные от пользователя 
{
    Console.Write(line);
    int countNumbers = int.Parse(Console.ReadLine() ?? "0");
    return countNumbers;
}
int[] FillArray(int inputLength, int inputRangeFrom, int inputRangeTo)  // заполняем массив учитывая три парраметра
{   
    int[] arrayRandom = new int[inputLength];                               // создаем пустой массив с заранее указанной длинной
    for (int index = 0; index < inputLength; index++)
    {
        arrayRandom[index] = new Random().Next(inputRangeFrom, inputRangeTo);    // заполняем массив числами из заранее указанного диапазона
    }
return arrayRandom;
}
void PrintArray(int[] finishedArray)          // метод печати массива
{   
    Console.Write("Результат: ");
    int length = finishedArray.Length;
    for (int position = 0; position < length - 1; position++)
    {
        Console.Write(finishedArray[position] + ", ");
    }
    Console.WriteLine(finishedArray[length - 1] + "!");
}
PrintArray(FillArray(GetDate("Введите длинну массива: "), GetDate("Диапазон от: "), GetDate("Диапазон до: ")));  // вывод результата  

