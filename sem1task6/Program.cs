// ====================================================================
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
// ============================================================================

// First way

Console.Write("Введите число: ");
string? inputLineNumber = Console.ReadLine();
if (inputLineNumber != null)        // проверяем на null
{
    int inputNumber = int.Parse(inputLineNumber);          // приводим к целостным числам
    bool outResult = (inputNumber%2 == 0);
    Console.WriteLine("Число " + inputNumber + " является четным: " + outResult);
}
