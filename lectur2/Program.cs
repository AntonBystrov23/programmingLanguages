void PrintArray(int[] printAllElements)            // метод - печать массива
{
    int count = printAllElements.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(printAllElements[position]);
        position++;
    }
}
void FillArray(int[] fillRandom)                   // метод - заполнение массива случайными числами
{
    int Length = fillRandom.Length;
    int index = 0;
    while (index < Length)
    {
        fillRandom[index] = new Random().Next(1, 10);
        index++;
    }
}
int IndexOf(int[] nameArray, int findElement)     // метод - вывод индекса искомого числа
{
    int count = nameArray.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (nameArray[index] == findElement)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] randomDigits = new int[10];
FillArray(randomDigits);
PrintArray(randomDigits);
Console.WriteLine();
int findPosition = IndexOf(randomDigits,5);
Console.WriteLine(findPosition +1); //добавил 1, чтобы на выходе был счет от одного
