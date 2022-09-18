// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// запрашиваем данные у пользователя и конвертируем в double
double ReadDate(string line)
{
    Console.Write(line);
    double num = Convert.ToDouble(Console.ReadLine() ?? "0");
    return num;
}

// подставляем формулу и ищем точку пересечения двух прямых (результат кладем в строчку)
string FindNumbers(double countN)
{
    string fibNums = "";
    int beforeNum = -1;
    int actualNum = 1;
    int buffer = 0;
    for (int i = 0; i < countN; i++)
    {
        buffer = actualNum;
        actualNum = beforeNum + actualNum;
        beforeNum = buffer;
        fibNums = fibNums + Convert.ToString(actualNum) + " ";
    }
    return fibNums;
}

// печатаем результат
void PrintResult(string prefix, string date)
{
    Console.WriteLine(prefix + date);
}
DateTime d1 = DateTime.Now;
PrintResult("Введите предел чисел: ", FindNumbers(ReadDate("До какого числа просмотреть последовательность? ")));
Console.WriteLine(DateTime.Now - d1);
