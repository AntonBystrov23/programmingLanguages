// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Читаем данные
long ReadDate(string line)
{
    Console.Write(line);
    long num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

///Метод вычисления функции Аккермана:
long AckermanFunction (long numberM, long numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunction(numberM - 1, AckermanFunction(numberM, numberN - 1));
return AckermanFunction(numberM, numberN);
}

// Вывод данных
void PrintResultString(string prefix, long data)
{
    Console.Write(prefix + data);
}

long numberM = ReadDate("Введите число M:");
long numberN = ReadDate("Введите число N:");

PrintResultString("Функция Аккермана: ", AckermanFunction (numberM, numberN));
