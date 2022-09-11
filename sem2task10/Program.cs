// Задача №10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
string? inputLineA = Console.ReadLine()?? "0"; // получаем трехзначное число
int lengthNumber = inputLineA.Length;
void showResult()          // проверка на соответствие вводимого числа.Перевод в массив. Вывод искомого
{
if (inputLineA != null && lengthNumber == 3)
{    
    int inputNumberA = int.Parse(inputLineA);
    char[] charArray = inputNumberA.ToString().ToCharArray();
    Console.WriteLine("Искомое число: " + charArray[1]);
}
else
{
    Console.Write("Введите трехзначное число! ");
}
}
showResult();

           


