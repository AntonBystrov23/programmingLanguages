// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.
// чтение данных из сонсоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение 
    return number;
}
string findPointBase(int X, int Y)
{   
    if (X == 0 || Y == 0)
    {
        return "Попал на координатную плоскость!)";
    }
        else
    {
        string pointBase = (X >= 0 ? (Y >= 0 ? ("1-ая четверть.") : ("2-ая четверть.")) : (Y <= 0 ? ("3-ая четверть.") : ("4-ая четверть.")));
        return pointBase;
    }
}   
void printResult(int X, int Y)
{
        Console.WriteLine(findPointBase( X, Y));
}
int poinX = ReadData("Введите первое число: ");
int pointY = ReadData("Введите второе число: ");
findPointBase(poinX, pointY);
printResult(poinX, pointY);



