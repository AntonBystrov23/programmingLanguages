// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Читаем данные
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Ссумируем числа от M до N
int SumRecNum(int M, int N)
{
    if (N < M)
    {
        int buf = M;
        M = N;
        N = buf;
    }
    if (M == N) return M;
    int sum = M + SumRecNum(M + 1, N);
    return sum;
}

// Вывод данных
void PrintResultString(string prefix, int data)
{
    Console.Write(prefix + data);
}

PrintResultString("Сумма натуральных чисел: ", SumRecNum(ReadDate("Введите число M: "),
                                                    ReadDate("Введите число N: ")));







