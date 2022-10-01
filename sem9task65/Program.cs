// Задайте значение N. Напишите программу, которая выдает все натуральные числа от N до 1.

// ---------от N до 1--------

// Читаем данные
// int ReadDate(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// // Вывести числа от N до 1
// string LineGenRec (int num)
// {
//     if(num == 0)return "";
//     string outLine =num + " " + LineGenRec(num-1);
//     return outLine;
// }

// // Вывод данных
// void PrintResultString(string prefix, string data)
// {
//     Console.Write(prefix + data);
// }

// PrintResultString("Числа: ",LineGenRec(ReadDate("Введите число N: ")));


// ---------от M до N--------

// Читаем данные
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Вывести числа от M до N
string LineGenRec(int M, int N)
{
    if (N < M)
    {
        int buf = M;
        M = N;
        N = buf;
    }
    if (M >= N) return N.ToString();
    string outLine = M + " " + LineGenRec(M + 1, N);
    return outLine;
}

// Вывод данных
void PrintResultString(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

PrintResultString("Числа: ", LineGenRec(ReadDate("Введите число M: "), 
                                        ReadDate("Введите число N: ")));
