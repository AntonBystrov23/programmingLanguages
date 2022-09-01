// ====================================================================
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// ============================================================================

// First way

Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число: ");             // вводим данные, проверяем на null, и приводим к целостному виду
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int maxNumber = inputNumberA;        // принимаем inputNumberA за максимум  
    if (inputNumberA == inputNumberB)     // сравниваем числа
        {
            Console.WriteLine("A = " + inputNumberA + ", B = " + inputNumberB + ", числа равны");
        }
    else
        if (inputNumberA > inputNumberB) 
        {
            Console.WriteLine("A = " + inputNumberA + ", B = " + inputNumberB + ", max = " + maxNumber);
        }
        else
        {
            maxNumber = inputNumberB;
            Console.WriteLine("A = " + inputNumberA + ", B = " + inputNumberB + ", max = " + maxNumber);
        }
}