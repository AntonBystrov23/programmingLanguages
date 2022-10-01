// Задайте значение N. Напишите программу, которая выдает все натуральные числа от 1 до N.


// Читаем данные
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывести числа от 1доN
string LineGenRec (int num)
{
    if(num == 0)return "";
    string outLine =LineGenRec(num-1) + num + " ";
    return outLine;
}

// Вывод данных
void PrintResultString(string prefix, string data)
{
    Console.Write(prefix + data);
}

PrintResultString("Числа: ",LineGenRec(ReadDate("Введите число N: ")));
// PrintResultInt("Результат вычислений: ", SumGenRec (number));
