// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int GetDate(string line)              // Получаем строку
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    //int number = int.Parse(Console.ReadLine() ?? "0");
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
int CountDigits1(int num)              // Ищем длинну   ПЕРЕВОД В СТРОКУ И ВОЗВРАТ ДЛИННЫ
{
    string count = num.ToString();
    return count.Length;
}
int CountDigits2(int num)              // Ищем длинну   ЦИКЛ ПЛЮС ДЕЛЕНИЕ
{
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count = count + 1;
    }
    return count;
}
int CountDigits3(int num)              // Ищем длинну   LOG10
{
    return (int)(Math.Log10(num)+1);
}

void PrintResult(int res)
{
    Console.WriteLine("Колличество цифр в числе равно: " + res);
}
int inputedNumber = GetDate("Введите число:");
PrintResult(CountDigits1(inputedNumber));   // Выводим результат
PrintResult(CountDigits2(inputedNumber));   // Выводим результат
PrintResult(CountDigits3(inputedNumber));   // Выводим результат