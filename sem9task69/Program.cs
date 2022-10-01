// Напишите программу, которая на вход принимает два числа А и В. 
// Возведите число А в целую степень В с помощью рекурсии


// Читаем данные
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Возведение А в степень В
int RecPow (int A, int B)
{
    if(B == 1)return A;
    return (A * RecPow(A, B-1));
}

// Вывод данных
void PrintResultString(string prefix, int data)
{
    Console.Write(prefix + data);
}

int numA = ReadDate("Введите число A: ");
int numB = ReadDate("Введите число B: ");

PrintResultString("Результат возведения в степень: ", RecPow (numA, numB));
