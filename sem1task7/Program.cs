// ============================================================================
// Напишите программу, которая будет выдавать последнюю цифру трехзначного номера
// ============================================================================

//   First way

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);                     // сначала вводим число, проверяем на null и переводим его в целостный вид
    if (inputNumber > 99 && inputNumber < 1000)                // включаем диапазон всех трехзначных чисел
    {
        int lastDigit = inputNumber%10;              // вводим новую переменную "последнее число" и получаем ее с помощью остатка от деления на 10
        Console.WriteLine(lastDigit);
    }
    else
    {
    Console.WriteLine("Введите корректное число!");   
    }
}

   //   Second way (with time)

// Console.Write("Введите число: ");        // Выводим текст
// string? inputLineA = Console.ReadLine(); // Вводим число 
// Console.Write("Введите степень: ");      // Выводим текст
// string? inputLineB = Console.ReadLine(); // Вводим степень
// DateTime T1 = DateTime.Now;              // Устанавливаем время в начале операции
// if (inputLineA != null && inputLineB != null)  // Проверяем тот факт, что поля ввода не пусты
// {
//     int inputNumber = int.Parse(inputLineA);
//     int inputExponent = int.Parse(inputLineB);
//     int outNumber = (int)Math.Pow(inputNumber, inputExponent);
//     Console.WriteLine("Результат: " + outNumber);
// }
// DateTime T2 = DateTime.Now;
// Console.Write("Время решения: " + (T2 - T1));