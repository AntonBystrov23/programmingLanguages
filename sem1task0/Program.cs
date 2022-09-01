// ============================================================================
// Напишите программу, которая на вход принимает число и выдает его квадрат
// ============================================================================

//   First way

// string? inputLine = Console.ReadLine();
// if (inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);
//     int outNumber = inputNumber * inputNumber;
//     Console.WriteLine(outNumber);
// }

//  Second way

// Console.Write("Введите число: ");
// string? inputLineA = Console.ReadLine();
// Console.Write("Введите степень: ");
// string? inputLineB = Console.ReadLine();
// if (inputLineA != null && inputLineB != null)
// {
//     int inputNumber = int.Parse(inputLineA);
//     int inputExponent = int.Parse(inputLineB);
//     int outNumber = (int)Math.Pow(inputNumber, inputExponent);
//     Console.WriteLine("Результат: " + outNumber);
// }

//   Second way (with time)

Console.Write("Введите число: ");        // Выводим текст
string? inputLineA = Console.ReadLine(); // Вводим число 
Console.Write("Введите степень: ");      // Выводим текст
string? inputLineB = Console.ReadLine(); // Вводим степень
DateTime T1 = DateTime.Now;              // Устанавливаем время в начале операции
if (inputLineA != null && inputLineB != null)  // Проверяем тот факт, что поля ввода не пусты
{
    int inputNumber = int.Parse(inputLineA);
    int inputExponent = int.Parse(inputLineB);
    int outNumber = (int)Math.Pow(inputNumber, inputExponent);
    Console.WriteLine("Результат: " + outNumber);
}
DateTime T2 = DateTime.Now;
Console.Write("Время решения: " + (T2 - T1));

