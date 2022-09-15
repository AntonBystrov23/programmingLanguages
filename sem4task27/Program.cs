// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//-----РЕШЕНИЕ С ПЕРЕВОДОМ В СТРОКУ:ВЫДЕРГИВАЮ ПО ЭЛЕМЕНТУ,КОНВЕРТИРУЮ,СУММИРУЮ.(ЗАТРАТНЫЙ ВАРИАНТ)

// string GetDate(string line)                           // Получаем данные от пользователя

// {
//     Console.WriteLine(line);                         // Выводим сообщение
//     string number = Console.ReadLine() ?? "0";       // Считываем число
//     return number;                                   // Возвращаем значение
// }
// int CalcDateFor(string numbers)                       // Метод подсчета суммы чисел (вычленяем каждый элемент строки и суммируем)              
// {
//     int length = numbers.Length;                     // Выявляем длинну
//     int sum = 0;
//     for (int index = 0; index < length; index++)     // Цикл: 
//     {
//         string digit = numbers.Substring(index, 1);  // Берем поочереди каждый символ
//         int number = int.Parse(digit);               // Приводим к целому числу
//         sum = sum + number;                          // суммируем с предыдущим результатом
//     }
//     return sum;
// }

// void PrintResult(int calculateResult)                 // Метод: выводим результат            
// {
//     Console.WriteLine("Сумма равна: " + calculateResult);
// }

// string inputedNumber = GetDate("Введите число: ");
// DateTime d1 = DateTime.Now;
// int resultOfCalculate = CalcDateFor(inputedNumber);
// Console.WriteLine("Время, затраченное на решение: " + (DateTime.Now - d1));
// PrintResult(resultOfCalculate);

//-----РЕШЕНИЕ С ДЕЛЕНИЕМ.(ОПТИМАЛЬНЫЙ ВАРИАНТ)


int GetDate(string line)                           // Получаем данные от пользователя

{
    Console.WriteLine(line);                         // Выводим сообщение
    int number = int.Parse(Console.ReadLine() ?? "0");       // Считываем число
    return number;                                   // Возвращаем значение
}

int CalcDateDiv(int numbers)                       // Метод подсчета суммы чисел. Остаток от деления на десять
{
    int sum = 0;
    int digit;
    while (numbers > 0)                            // Цикл: 
    {
        digit = numbers%10;
        sum = sum + digit;
        numbers = numbers / 10;                          // суммируем с предыдущим результатом
    }
    return sum;
}

void PrintResult(int calcResult)                   // Метод: выводим результат            
{
    Console.WriteLine("Сумма равна: " + calcResult);
}

int inputedNumber = GetDate("Введите число: ");
DateTime d1 = DateTime.Now;
int resultOfCalculate = CalcDateDiv(inputedNumber);
Console.WriteLine("Время, затраченное на решение: " + (DateTime.Now - d1));
PrintResult(resultOfCalculate);
