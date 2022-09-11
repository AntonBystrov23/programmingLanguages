// Сумма чисел от 1 до N

int GetDate(string line)              // Получаем число
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    //int number = int.Parse(Console.ReadLine() ?? "0");
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
int CalculateDate1(int numN)          // Считаем через цикл
{
    int sum = 0;
    for (int index = 1; index <= numN; index++)
    {
        sum = sum += index;
    }
    Console.Write("Результат цикла: ");
    return sum;
}
int CalculateDate2(int numN)          // Считаем по формуле
{
    int sum = (numN * (numN + 1)) / 2;
    Console.Write("Результат формулы Гауса: ");
    return sum;
}
void PrintResult(int res)
{
    Console.WriteLine(res);
}
int N = GetDate("Введите число:");
DateTime d1 = DateTime.Now;           // Сравним время двух методов
PrintResult(CalculateDate1(N));
Console.WriteLine("Время, затраченное на первое решение: " + (DateTime.Now - d1));   // Итоговое время
DateTime d2 = DateTime.Now;
PrintResult(CalculateDate2(N));
Console.WriteLine("Время, затраченное на второе решение: " + (DateTime.Now - d2));   // Итоговое время
