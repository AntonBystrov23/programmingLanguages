// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
string GetDate(string line)                           // Получаем данные от пользователя
{
    Console.WriteLine(line);                         // Выводим сообщение
    string number = Console.ReadLine() ?? "0";       // Считываем число
    return number;                                   // Возвращаем значение
}
int CalculateDate1(string numbers)                    // Метод подсчета суммы чисел (вычленяем каждый элемент строки и суммируем)
{
    int length = numbers.Length;                     // Выявляем длинну
    int sum = 0;
    for (int index = 0; index < length; index++)     // Цикл: 
    {
        string digit = numbers.Substring(index, 1);  // Берем поочереди каждый символ
        int number = int.Parse(digit);               // Приводим к целому числу
        sum = sum + number;                          // суммируем с предыдущим результатом
    }
    return sum;
}
void PrintResult(int calculateResult)                 // Метод: выводим результат
{
    Console.WriteLine("Сумма равна: " + calculateResult);
}
string inputedNumber = GetDate("Введите число: ");
DateTime d1 = DateTime.Now;
int resultOfCalculate = CalculateDate1(inputedNumber);
Console.WriteLine("Время, затраченное на решение: " + (DateTime.Now - d1));
PrintResult(resultOfCalculate);

