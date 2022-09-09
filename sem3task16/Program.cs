// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

//  ===================================================================
//  ПЕРВЫЙ ВАРИАНТ (ТЕРНАРНЫЙ ОПЕРАТОР)
// int inputDate(string line)
// {
// Console.WriteLine(line);
// int Number = Convert.ToInt32(Console.ReadLine());
// return Number;
// }
// void showDate(int num1, int num2)
// {
//  Console.WriteLine((num1 ==  num2 * num2) ? "Первое число является квадратом второго" : (num2 ==  num1 * num1) ? "Второе число является квадратом первого" : "Ни первое, ни второе не является квадратом другого!");
// }
// int firstNamber = inputDate();
// int secondNamber = inputDate();
// showDate(firstNamber, secondNamber);

//  ===================================================================
//  ВТОРОЙ ВАРИАНТ (BOOL)
int inputDate(string line)  // параметр string line отвечает за вывод текста в скобочках
{
Console.WriteLine(line);
int Number = int.Parse(Console.ReadLine()??"0");  // если пользователь ничего не введет выведем нолик
// int Number = Convert.ToInt32(Console.ReadLine());
return Number;
}
int firstNamber = inputDate("Введите первое число: "); 
int secondNamber = inputDate("Введите второе число: ");
bool testCondition(int firstNamber, int secondNamber)
{
if (firstNamber == secondNamber * secondNamber)
{
    return true;
}
else
{
    return false;
}
}
void showDate(int Namber1, int Namber2)
{
if (testCondition(Namber1, Namber2))//ПОИСК КВАДРАТА И ОКРУГЛЕНИЕ ДО ДВУХ ЦИФР ПОСЛЕ ЗАПЯТОЙ
{
    Console.WriteLine("Число " + Namber1 + " является квадратом числа " + Namber2 + "!");
} 
else
{
     Console.WriteLine("Число " + Namber1 + " не является квадратом числа " + Namber2 + "!");
}
}
showDate(firstNamber, secondNamber);
showDate(secondNamber, firstNamber);

