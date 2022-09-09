// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение 
    return number;
}
string generateTable(int X, int Y)
{   string table = string.Empty;
    for (int index = 1; index <= X; index++)
    {
        table = table + Math.Pow(index, Y) + "\t";
    }
    Console.WriteLine();
    return table;   
}
void printResult(string line)                                                              
{
    Console.Write(line);                          //Console.WriteLine(line);
}
int countN = ReadData("Введите число: ");
printResult(generateTable(countN, 1));
printResult(generateTable(countN, 2));
                     