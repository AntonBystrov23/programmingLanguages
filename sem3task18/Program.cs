// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение 
    return number;
}
string findQuarterNumber(int X)
{   
    string Base = (X == 1 ? "X > 0 и Y > 0" : X == 2 ? "X > 0 и Y < 0": X == 3 ? "X < 0 и Y < 0" : X == 4 ?  "X < 0 и Y > 0" : "Четверть указанна не корректно. Введите число от 1 до 4!)");
    return Base;
}   
void printResult(int X)                                       //void printResult(string line)                          
{
    Console.WriteLine(findQuarterNumber(X));                          //Console.WriteLine(line);
}
int quarterNumber = ReadData("Введите число от 1 до 4: ");    //int quarterNumber = ReadData("Введите число от 1 до 4: "); 
findQuarterNumber(quarterNumber);                                     //string result = findCount(quarterNumber); 
printResult(quarterNumber);                                   //printResult(result);;               //printResult(findCount(quarterNumber));
