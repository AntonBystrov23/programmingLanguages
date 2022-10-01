//  Напишите программу, которая принимает на вход число N и возвращает сумму его чисел.


// Читаем данные
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывести числа от 1доN
int RecSumDigit (int num)
{
    if(num == 0)return 0;
    return num%10 + RecSumDigit(num/10);
}

// Вывод данных
void PrintResultString(string prefix, int data)
{
    Console.Write(prefix + data);
}

PrintResultString("Сумма чисел: ",RecSumDigit(ReadDate("Введите число N: ")));
