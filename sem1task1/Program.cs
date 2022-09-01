// ============================================================================
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// ============================================================================

//  First way

// Console.Write("Введите первое число: ");
// string? inputLineA = Console.ReadLine();
// Console.Write("Введите второе число: ");
// string? inputLineB = Console.ReadLine();
// if (inputLineA != null && inputLineB != null)
// {
//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);
//         if (inputNumberA * inputNumberA == inputNumberB) // || (inputNumberB / inputNumberA == inputNumberA)
//             Console.WriteLine("Число '" + inputNumberA + "' является корнем числа '" + inputNumberB + "'");
//         else
//             Console.WriteLine("Число '" + inputNumberA + "' не является корнем числа '" + inputNumberB + "'");
// }

//   Second way

Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    // if (inputNumberA * inputNumberA == inputNumberB) // || (inputNumberB / inputNumberA == inputNumberA)
    //     Console.WriteLine("Число '" + inputNumberA + "' является корнем числа '" + inputNumberB + "'");
    // else
    //     Console.WriteLine("Число '" + inputNumberA + "' не является корнем числа '" + inputNumberB + "'");
    // bool outResult (inputNumberA * inputNumberA == inputNumberB) // (inputNumberB / inputNumberA == inputNumberA)
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA); // Ключевое слово типа bool — это псевдоним для типа структуры System.Boolean .NET, представляющий логическое значение: true или false.
    Console.WriteLine(outResult);
}