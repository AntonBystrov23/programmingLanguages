//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// * Найти площадь треугольника, образованного тремя прямыми.

// ---------ПЕРВЫЙ ВАРИАНТ С ВЫВОДОМ МАССИВА (БОЛЕЕ ЗАТРАТНЫЙ)-------------

// запрашиваем данные у пользователя и конвертируем в double
// double ReadDate(string line)
// {
//     Console.Write(line);
//     double num =Convert.ToDouble(Console.ReadLine() ?? "0");
//     return num;
// }

// // подставляем формулу и ищем точку пересечения двух прямых (результат кладем в массив)
// double[] FindTouchPoint(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = ((k1 * x + b1) + (k2 * x + b2)) / 2;
//     double[] basePoint = new double[] { x, y };
//     return basePoint;
// }

// // печатаем массив
// void Print1DArray(double[] array, string line)
// {
//     Console.Write(line);
//     Console.WriteLine("[{0}]", string.Join(", ", array));
// }

// double b1 = ReadDate("Введите точку b1: ");
// double k1 = ReadDate("Введите точку k1: ");
// double b2 = ReadDate("Введите точку b2: ");
// double k2 = ReadDate("Введите точку k2: ");

// DateTime d = DateTime.Now;
// Print1DArray(FindTouchPoint(b1, k1, b2, k2), "Точка пересечения двух прямых: ");
// Console.WriteLine(DateTime.Now - d);

// ---------ВТОРОЙ ВАРИАНТ С ВЫВОДОМ СТРОКОЙ (ЧУТЬ МЕНЕЕ ЗАТРАТНЫЙ)-------------

// запрашиваем данные у пользователя и конвертируем в double
// double ReadDate(string line)
// {
//     Console.Write(line);
//     double num =Convert.ToDouble(Console.ReadLine() ?? "0");
//     return num;
// }

// // подставляем формулу и ищем точку пересечения двух прямых (результат кладем в строчку)
// string FindTouchPoint(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = ((k1 * x + b1) + (k2 * x + b2)) / 2;
//     string res = Convert.ToString(x) + ", " + Convert.ToString(y);
//     return res;
// }

// // печатаем результат
// void Print1DArray(string prefix, string date)
// {
//     Console.WriteLine(prefix + date);
// }

// double b1 = ReadDate("Введите точку b1: ");
// double k1 = ReadDate("Введите точку k1: ");
// double b2 = ReadDate("Введите точку b2: ");
// double k2 = ReadDate("Введите точку k2: ");
// double b3 = ReadDate("Введите точку b2: ");
// double k3 = ReadDate("Введите точку k2: ");

// DateTime d1 = DateTime.Now;
// Print1DArray("Точка пересечения двух прямых: ", FindTouchPoint(b1, k1, b2, k2));
// Console.WriteLine(DateTime.Now - d1);



// ---ПОИСК ПЛОЩАДИ ТРЕУГОЛЬНИКА, ОБРАЗОВАННОГО ТРЕМЯ ПРЯМЫМИ-------------

// Запрашиваем данные у пользователя и конвертируем в double 
double ReadDate(string line)
{
    Console.Write(line);
    double num = Convert.ToDouble(Console.ReadLine() ?? "0");
    return num;
}

// Поиск точки пересечения двух прямых (результат кладем в массив)
double[] FindTouchPoint(double a1, double c1, double a2, double c2)
{
    double x = (a2 - a1) / (c1 - c2);
    double y = ((c1 * x + a1) + (c2 * x + a2)) / 2;
    double[] basePoint = new double[] { x, y };
    return basePoint;
}

// Расчитываем длинну сторон
double CalculateLength(double[] firstLineCoordinat, double[] secondLineCoordinat) // Вычисляем длинну отрезка
{
    double result = (Math.Sqrt(Math.Pow((firstLineCoordinat[0] - secondLineCoordinat[1]), 2) + Math.Pow((firstLineCoordinat[0] - secondLineCoordinat[1]), 2)));
    return result;
}

// Проверка возможности построить треугольник по заданным параметрам 
bool TrglTest(double lineA, double lineB, double lineC)
{
    return (lineA + lineB > lineC && lineA + lineC > lineB && lineB + lineC > lineA);
}

// Расчитываем площадь треугольника
double FindAreaOfTriangle(double firstLength, double secondLength, double thirdLength)
{
    double p = (firstLength + secondLength + thirdLength) / 2;
    double areaOfTriangle = Math.Round(Math.Sqrt(p * (p - firstLength) * (p - secondLength) * (p - secondLength)), 2);
    return areaOfTriangle;
}

double b1 = ReadDate("Введите точку b1: ");
double k1 = ReadDate("Введите точку k1: ");
double b2 = ReadDate("Введите точку b2: ");
double k2 = ReadDate("Введите точку k2: ");             // Получаем координаты от пользователя.
double b3 = ReadDate("Введите точку b2: ");
double k3 = ReadDate("Введите точку k2: ");

double[] firstPoint = FindTouchPoint(b1, k1, b2, k2);
double[] secondPoint = FindTouchPoint(b2, k2, b3, k3); // Вычисляем точки пересечения прямых.
double[] thirdPoint = FindTouchPoint(b1, k1, b3, k3);

double lengthFirstLine = CalculateLength(firstPoint, secondPoint);
double lengthSecondLine = CalculateLength(secondPoint, thirdPoint);              // Вычисляем длинну прямых.
double lengthThirdLine = CalculateLength(firstPoint, thirdPoint);

FindAreaOfTriangle(lengthFirstLine, lengthSecondLine, lengthThirdLine);
Console.WriteLine(TrglTest(lengthFirstLine, lengthSecondLine, lengthThirdLine) ? ("Площадь треугольника равна: " +
                    FindAreaOfTriangle(lengthFirstLine, lengthSecondLine, lengthThirdLine)) : "Такого треугольника нет!");


