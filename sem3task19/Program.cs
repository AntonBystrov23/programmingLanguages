// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// * 1) Решение для палиндрома любой длинны
// * 2) Решение через Dictionary
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// ===========================================================================================

// РЕШЕНИЕ ДЛЯ ПЯТИЗНАЧНОГО ЧИСЛА
// int inputDate(string line)  // параметр string line отвечает за вывод текста в скобочках
// {
//     Console.WriteLine(line);
//     int Number = int.Parse(Console.ReadLine() ?? "0");  // если пользователь ничего не введет выведем нолик
//                                                         // int Number = Convert.ToInt32(Console.ReadLine());
//     return Number;
// }
// int testCondition(int number)
// {
//     char[] charArray = number.ToString().ToCharArray();  // переводим число в массив
//     int length = charArray.Length;
//     int result = 0;
//     if (length != 5)
//     {
//         result = -1;
//     }
//     else
//     {
//         for (int index = 0; index < length / 2; index++)
//         {
//             if (charArray[index] == charArray[length - 1 - index])
//             {
//                 result = 1;
//             }
//             else
//             {
//                 result = 0;
//                 break;
//             }
//         }
//     }

//     return result;
// }
// void printDate(int resultTest, int inputedNumber)
// {
//     if (resultTest == -1)
//     {
//         Console.WriteLine("По условию задачи, нужно ввести пятизначное число!");
//     }
//     else
//     {
//         if (resultTest == 1)
//         {
//             Console.WriteLine("Число " + inputedNumber + " является палиндромом!");
//         }
//         else
//         {
//             Console.WriteLine("Число " + inputedNumber + " не является палиндромом!");
//         }
//     }

// }
// int inputNumber = inputDate("Введите пятизначное число: "); //получаем число 
// testCondition(inputNumber);
// printDate(testCondition(inputNumber), inputNumber);
// ===========================================================================================

//* РЕШЕНИЕ ДЛЯ ЧИСЛА ЛЮБОЙ ДЛИННЫ ЧЕРЕЗ СОЗДАНИЕ МАССИВА

int inputDate(string line)  // параметр string line отвечает за вывод текста в скобочках
{
    Console.WriteLine(line);
    int Number = int.Parse(Console.ReadLine() ?? "0");  // если пользователь ничего не введет выведем нолик
                                                        // int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
int testCondition(int number) // конвертирую строку в массив
{
    char[] charArray = number.ToString().ToCharArray();  // переводим число в массив
    int length = charArray.Length;                        
    int result = 0;
    for (int index = 0; index < length / 2; index++)     // ограничиваем счетчик до половины, так как сравниваем лишь первую половину со второй
    {
        if (charArray[index] == charArray[length - 1 - index]) // -1 т.к. отчет с 0 до 7
        {
            result = 1;
        }
        else
        {
            result = 0;
            break;
        }

    }

    return result;
}
void printDate(int resultTest, int inputedNumber)
{

    if (resultTest == 1)
    {
        Console.WriteLine("Число " + inputedNumber + " является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число " + inputedNumber + " не является палиндромом!");
    }


}
int inputNumber = inputDate("Введите число: "); //получаем число 
testCondition(inputNumber);
printDate(testCondition(inputNumber), inputNumber); 

//===========================================================================================





