//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//--- -ОСНОВНОЕ РЕШЕНИЕ-(два варианта)----------????? Почему-то если вместо double подставляю pow, 
//      формула Math.Pow(num1, num2) подсвечивается красным
// int GetDate(string line)                        // Получаем данные от пользователя
// {
//     //Выводим сообщение
//     Console.WriteLine(line);
//     //Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     //Возвращаем значение
//     return number;
// }
// double CalculateDate1(int num1, int num2)       // 1 Вариант "Math.Pow"
// {
//     double result = Math.Pow(num1, num2);
//     return result;
// }
// // double CalculateDate2(int num1, int num2)    // 2 Вариант с циклом "FOR"
// // {
// //     double result = num1;
// // for(int index = 1; index < num2; index++)
// // {
// //     result = result * num1;
// // }
// // return result;
// // }
// void PrintResult(double res)                    // Метод для вывода результата
// {
//     Console.WriteLine("Результат равен: " + res);
// }
// PrintResult(CalculateDate1(GetDate("Введите число:"), GetDate("Введите степень:")));

//----СРАВНИТЬ ВРЕМЯ ДЛЯ ДВУХ ВАРИАНТОВ----------

// int digit = GetDate("Введите число:");
// int powerOfDigit = GetDate("Введите число:");
// DateTime d1 = DateTime.Now;                      // Время старта
// PrintResult(CalculateDate1(digit, powerOfDigit));
// Console.WriteLine("Время, затраченное на первое решение: " + (DateTime.Now - d1));   // Итоговое время
// DateTime d2 = DateTime.Now;
// PrintResult(CalculateDate2(digit, powerOfDigit));
// Console.WriteLine("Время, затраченное на второе решение: " + (DateTime.Now - d2));

///---КАЛЬКУЛЯТОР 1----------

// string GetDate(string line)
// {
//     Console.WriteLine(line);  //Выводим сообщение
//     //int number = int.Parse(Console.ReadLine() ?? "0");
//     string number = Console.ReadLine() ?? "0";  //Считываем число
//     return number; //Возвращаем значение
// }
// long MainCalculate(string num1, string signOfOperate, string num2) // Полученные числа м символ в подходящую формулу
// { 
//      int number1 = Convert.ToInt32(num1); 
//      int number2 = Convert.ToInt32(num2); 
//      char sign = Convert.ToChar(signOfOperate);
//      long res = 0;
//     if(sign == '-')
//         res = number1 - number2;
//     else if(sign == '+')
//         res = number1 + number2;
//     else if(sign == '/')
//         res = number1 / number2;
//     else if(sign == '*')
//         res = number1 * number2;
//     else if(sign == '^')
//     {
//         double numberSqr1 = Convert.ToDouble(number1); 
//         double numberSqr2 = Convert.ToDouble(number2); 
//         double resultSqr = Math.Pow(number1, number2);
//         res = Convert.ToInt32(resultSqr);
//     }
// return res;
// }
// void PrintResult(long res)
// {
//     Console.WriteLine("Результат равен: " + res);
// }           
// PrintResult(MainCalculate(GetDate("First digit: "),GetDate("Input sign: "),GetDate("Second digit: ")));

///---КАЛЬКУЛЯТОР 2-- (with case)--------

// string GetDate(string line)
// {
//     Console.WriteLine(line);  //Выводим сообщение
//     string number = Console.ReadLine() ?? "0";  //Считываем число
//     return number; //Возвращаем значение
// }

// long MainCalculate(string num1, string signOfOperate, string num2) // Полученные числа м символ в подходящую формулу
// {
//     int number1 = Convert.ToInt32(num1);
//     int number2 = Convert.ToInt32(num2);
//     char sign = Convert.ToChar(signOfOperate);
//     long res = 0;
//     switch (signOfOperate)
//     {
//         case "-":
//             res = number1 - number2;
//             break;
//         case "+":
//             res = number1 + number2;
//             break;
//         case "/":
//             res = number1 / number2;
//             break;
//         case "*":
//             res = number1 * number2;
//             break;
//         case "^":
//             double numberSqr1 = Convert.ToDouble(number1);
//             double numberSqr2 = Convert.ToDouble(number2);
//             double resultSqr = Math.Pow(number1, number2);
//             res = Convert.ToInt32(resultSqr);
//             break;
//     }
//     return res;
// }

// void PrintResult(long res)
// {
//     Console.WriteLine("Результат равен: " + res);
// }

// PrintResult(MainCalculate(GetDate("First digit: "), GetDate("Input sign: "), GetDate("Second digit: ")));

///---КАЛЬКУЛЯТОР 1----------

string GetDate(string line)
{
    Console.WriteLine(line);  //Выводим сообщение
    //int number = int.Parse(Console.ReadLine() ?? "0");
    string number = Console.ReadLine() ?? "0";  //Считываем число
    return number; //Возвращаем значение
}
long MainCalculate(string num1, string signOfOperate, string num2) // Полученные числа м символ в подходящую формулу
{ 
     int number1 = Convert.ToInt32(num1); 
     int number2 = Convert.ToInt32(num2); 
     char sign = Convert.ToChar(signOfOperate);
     long res = 0;
     
    if(sign == '-')
        res = number1 - number2;
    else if(sign == '+')
        res = number1 + number2;
    else if(sign == '/')
        res = number1 / number2;
    else if(sign == '*')
        res = number1 * number2;
    else if(sign == '^')
    {
        double numberSqr1 = Convert.ToDouble(number1); 
        double numberSqr2 = Convert.ToDouble(number2); 
        double resultSqr = Math.Pow(number1, number2);
        res = Convert.ToInt32(resultSqr);
    }
return res;
}
void PrintResult(long res)
{
    Console.WriteLine("Результат равен: " + res);
}           
PrintResult(MainCalculate(GetDate("First digit: "),GetDate("Input sign: "),GetDate("Second digit: ")));


