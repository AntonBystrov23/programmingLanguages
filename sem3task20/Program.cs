// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 2D пространстве.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
// double calculateLength (double num1, double num2, double num3, double num4)
// {
//    double result = Math.Sqrt(Math.Pow((num1 - num3), 2) + Math.Pow((num2 - num4), 2));
//    return result;
// }
double calculateLength (double num1, double num2, double num3, double num4) // Вычисляем длинну и округляем до 2-х цифр после запятой
{
   double result = Math.Round((Math.Sqrt(Math.Pow((num1 - num3), 2) + Math.Pow((num2 - num4), 2))), 2);
   return result;
}
void PrintResult(double number)
{
       Console.WriteLine("Длинна отрезка равна: " + number);
}
double x1 = ReadData("Введите координату x1: ");
double y1 = ReadData("Введите координату y1: ");
double x2 = ReadData("Введите координату x2: ");
double y2 = ReadData("Введите координату y2: ");
PrintResult(calculateLength(x1,y1,x2,y2));

