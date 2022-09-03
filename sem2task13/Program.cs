// Задача №13: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает третью цифру или сообщает, что нет такого числа.

Console.Write("Введите трехзначное число: ");    // получаем трехзначное число
string? inputLineNumber = Console.ReadLine();
int lengthNumber = inputLineNumber.Length;
void showResultString()         // создание массива из строки
{          
if (inputLineNumber != null)
{    
    if (lengthNumber > 2)    // проверяем подходит ли длинна числа под условие
    {
        char[] charArray = inputLineNumber.ToCharArray(); //  переводим строку в массив
        Console.WriteLine("Искомое число: " + charArray[2]);         
    }
    else
    {
    Console.WriteLine("1) Третьей цифры нет! ");
    }
}
}
void showResultInteger()        // переход к целочисленному значению
{          
if (inputLineNumber != null)
{    
    if (lengthNumber > 2)    // проверяем подходит ли длинна числа под условие
    {
        int Number = int.Parse(inputLineNumber);
        char[] charArray = Number.ToString().ToCharArray(); //  переводим строку в массив
        Console.WriteLine("Искомое число: " + charArray[2]);         
    }
    else
    {
    Console.Write("2) Третьей цифры нет! ");
    }
}
}
showResultString();
showResultInteger();


