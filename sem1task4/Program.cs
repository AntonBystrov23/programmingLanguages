// ====================================================================
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// ============================================================================

// First way

Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLineB = Console.ReadLine();           // Вводим данные (3 числа)
Console.Write("Введите третье число: ");
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)        // проверяем на null
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);          // приводим к целостным числам
    int inputNumberC = int.Parse(inputLineC);
    int maxNumber = inputNumberA;       // принимаем inputNumberA за max
    if (inputNumberB >= maxNumber)
    {
        maxNumber = inputNumberB;
        if (inputNumberC >= maxNumber)          // сравниваем два оставшихся числа с max и выводим результат
        {
            maxNumber = inputNumberC;
        }
        Console.WriteLine("A = " + inputNumberA + ", B = " + inputNumberB + ", C = " + inputNumberC + ", max = " + maxNumber);
    }
}
