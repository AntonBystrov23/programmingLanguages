// ============================================================================
// Напишите программу, которая будет принимать на вход цифру, и будет проверять, является ли этот день выходным
// ============================================================================

//First way


Console.Write("Введите день недели(число от 1 до 7): ");
string? inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);
string[] dayOfWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }; // создание массива
void showResult()               // для сдачи сделал с помощью тернарного оператора. позже разберусь 
{
        if (inputLine != null)
    {
        Console.WriteLine((inputNumber < 1 || inputNumber > 7) ? "Введите корректное значение!" : (inputNumber > 5) ? ((dayOfWeek[inputNumber - 1]) + " - выходной день") : (dayOfWeek[inputNumber - 1] + " - будний день"));
    }
}
showResult();                     // и добавлю вариант dictionary


