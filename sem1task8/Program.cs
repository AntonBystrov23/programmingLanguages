// ====================================================================
// ННапишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// ============================================================================

// First way

Console.Write("Введите число: ");
string? inputLineNumber = Console.ReadLine();
if (inputLineNumber != null)        // проверяем на null
{
    int inputNumber = int.Parse(inputLineNumber);          // приводим к целостным числам                
    for (int countStart = 1; countStart <= inputNumber; countStart +=1)   // задаем цикл
    {
        if (countStart%2 == 0) // проверяем на четность/нечетность
        {
            Console.Write(countStart + ", "); // выводим рез-т
        }

    }

}
