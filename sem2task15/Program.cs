// ============================================================================
// Напишите программу, которая будет принимать на вход цифру, и будет проверять, является ли этот день выходным
// ============================================================================

//First way


Console.Write("Введите день недели(число от 1 до 7): ");
string? inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);
string[] dayOfWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }; // создание массива
void showResult()
{
        if (inputLine != null)
    {
        Console.WriteLine((inputNumber < 1 || inputNumber > 7) ? "Введите корректное значение!" : (inputNumber > 5) ? ((dayOfWeek[inputNumber - 1]) + " - выходной день") : (dayOfWeek[inputNumber - 1] + " - будний день"));
    }
}
showResult();
//     string[] dayOfWeek = new string[7];     // создание массива (string[] stringArray = new string[6];)

//     dayOfWeek[0] = "monday";
//     dayOfWeek[1] = "tuesday";
//     dayOfWeek[2] = "wednesday";
//     dayOfWeek[3] = "thursday";
//     dayOfWeek[4] = "friday";
//     dayOfWeek[5] = "saturday";
//     dayOfWeek[6] = "sunday";
//     if (inputNumber < 1 || inputNumber > 7)
//     {
//         Console.WriteLine("Введите корректное значение!");
//     }
//     else 
//     {
//        Console.WriteLine(dayOfWeek[inputNumber - 1]);
//     }
// }

// Second way

// Console.Write("Введите день недели(число от 1 до 7): ");
// string? inputLine = Console.ReadLine();

// if (inputLine != null)
// {
//     int inputDayOfWeek = int.Parse(inputLine);
//     string outDayOfWeek = ""; //создали пустую переменную, в которую положим результат работы switch (либо string outdayOfWeek = string.Empty;)
//     switch(inputDayOfWeek) 
//     {
//     case 1: outDayOfWeek = "monday"; break;
//     case 2: outDayOfWeek = "tuesday"; break;
//     case 3: outDayOfWeek = "wednesday"; break;
//     case 4: outDayOfWeek = "thursday"; break;
//     case 5: outDayOfWeek = "friday"; break;
//     case 6: outDayOfWeek = "saturday"; break;
//     case 7: outDayOfWeek = "sunday"; break;
//     default: outDayOfWeek = "Введите корректное значение!"; break;
//     }
//     // СУПЕР ФОРМУЛА: outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek));
//     Console.WriteLine(outDayOfWeek);
