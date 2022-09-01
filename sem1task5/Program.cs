// ============================================================================
// Напишите программу, которая на вход принимает одно число N, а на выходе выдает все целые числа от -N до N
// ============================================================================

//   First way

Console.Write("Введите число: ");        // Выводим текст
string? inputLineN = Console.ReadLine(); // Вводим число 
if (inputLineN != null)  // Проверяем тот факт, что поля ввода не пусты
{
    int inputNumberN = int.Parse(inputLineN);
    int startNumber = inputNumberN * (-1);
    while (startNumber < inputNumberN)
    {
        Console.Write(startNumber + ",");
        startNumber += 1;
    }
    Console.Write(inputNumberN);

}
