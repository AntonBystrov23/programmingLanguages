// Программа, которая принимает число N и выдает произведение чисел от 1 до N

int GetDate(string line)                         // получаем данные от пользователя 
{
    Console.WriteLine(line);
    int inputDate = int.Parse(Console.ReadLine() ?? "0");
    return inputDate;
}
long CalculateFactorial(int inputedNumber)       // метод подсчета
{
    long factorial = 1;
    for (int index = 1; index <= inputedNumber; index++)
    {
        factorial = factorial * index;
    }
    return factorial;
}
void PrintArray(long calculResult)               // метод печати 
{
    Console.WriteLine(calculResult);
}
long factorial = CalculateFactorial(GetDate("Введите число N: "));
PrintArray(factorial);