// ============================================================================
// Напишите программу, которая будет принимать на вход цифру, и будет проверять, является ли этот день выходным
// ============================================================================

Console.Write("Введите день недели(число от 1 до 7): ");
string? inputLine = Console.ReadLine()?? "0";
int inputNumber = int.Parse(inputLine);
string[] dayOfWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }; // создание массива

//First way

void showResult1()
{
	Console.WriteLine("Первый вариант решения(тернарный оператор)");
    if (inputLine != null)
    {
        Console.WriteLine((inputNumber < 1 || inputNumber > 7) ? "Введите корректное значение!" : (inputNumber > 5) ? ((dayOfWeek[inputNumber - 1]) + " - выходной день") : (dayOfWeek[inputNumber - 1] + " - будний день"));
    }
}
showResult1();

//Second way

void showResult2()
{
	Console.WriteLine("Второй вариант решения(конструктор Dictionary)");
    if (inputNumber > 0 && inputNumber < 8)
    {
        IDictionary<int, string> dayOfWeek = new Dictionary<int, string>();
        dayOfWeek.Add(1, "Понедельник - Будний день"); //adding a key/value using the Add() method
        dayOfWeek.Add(2, "Вторник - Будний день");
        dayOfWeek.Add(3, "Среда - Будний день");
        dayOfWeek.Add(4, "Четверг - Будний день");
        dayOfWeek.Add(5, "Пятница - Будний день");
        dayOfWeek.Add(6, "Суббота - Выходной день");
        dayOfWeek.Add(7, "Воскресенье - Выходной день");
        Console.WriteLine(dayOfWeek[inputNumber]);
    }
    else
    {
        Console.WriteLine("Такого дня недели нет!");
    }
}
showResult2();