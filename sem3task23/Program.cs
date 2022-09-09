// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * При выводе цифры должны находиться друг над другом
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int ReadData(string line)  //получаем данные от пользователя
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение 
    return number;
}
string generateTable(int X, int Y)      // план решения
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
printResult(generateTable(countN, 1));  // выводим результат для степени 1
printResult(generateTable(countN, 3));  // выводим результат для степени 3