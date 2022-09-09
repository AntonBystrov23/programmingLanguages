// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// ====================================================================================

// ПЕРВЫЙ ВАРИАНТ

int ReadData(string line)   
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
double calculateLength (double num1, double num2, double num3, double num4, double num5, double num6) // Вычисляем длинну и округляем до 2-х цифр после запятой
{
   double result = Math.Round((Math.Sqrt(Math.Pow((num1 - num4), 2) + Math.Pow((num2 - num5), 2) + Math.Pow((num3 - num6), 2))), 2);
   return result;
}
void PrintResult(double number)
{
       Console.WriteLine("Длинна отрезка равна: " + number);
}
double x1 = ReadData("Введите координату x1: ");   //получаем данные от пользователя
double y1 = ReadData("Введите координату y1: ");
double z1 = ReadData("Введите координату z1: ");
double x2 = ReadData("Введите координату x2: ");
double y2 = ReadData("Введите координату y2: ");
double z2 = ReadData("Введите координату z2: ");
PrintResult(calculateLength(x1,y1,z1,x2,y2,z2));







