// Программа, которая сообщает пользователю, можно ли построить треугольник 
// из трех значений, которые введет пользователь. 

int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

bool TrglTest(int a, int b, int c)
{
    return (a + b > c && a + c > b && b + c > a);
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int a =ReadDate("Add point A: ");
int b = ReadDate("Add point B: ");
int c =ReadDate("Add point C: ");
PrintResult(TrglTest(a, b, c) ? "Такой треугольник есть!" : "Такого треугольника нет!");

