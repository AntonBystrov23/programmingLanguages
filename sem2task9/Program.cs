// написать программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает максимальное из этих двух чисел

System.Random numberGenerator = new System.Random();
int numberRandom = numberGenerator.Next(10, 100);            // получаем случайное двузначное число
Console.WriteLine("Результат рандома: " + numberRandom);     // int number1 = new Random().Next(10, 100);

// Вариант с char (перевод числа в строку и запись его в массив)
Console.Write("Вариант с char (перевод числа в строку и запись его в массив: ");
char[] сharArrayNumbers = numberRandom.ToString().ToCharArray();
if (сharArrayNumbers[0] != сharArrayNumbers[1])
{
    if (сharArrayNumbers[0] > сharArrayNumbers[1])
    {
        Console.WriteLine(сharArrayNumbers[0] + " больше " + сharArrayNumbers[1]);
    }
    else
    {
        Console.WriteLine(сharArrayNumbers[1] + " больше " + сharArrayNumbers[0]);
    }
}
else
{
    Console.WriteLine("Числа равны");
}

// Вариант с делением на 10 и с остатком от деления
 Console.Write("Вариант с делением на 10 и с остатком от деления: ");
int digit1 = numberRandom / 10;  
int digit2 = numberRandom % 10;

if (digit1 != digit2)
{
    if (digit1 > digit2)
    {
        Console.WriteLine(digit1 + " больше " + digit2);
    }
    else 
    {
        Console.WriteLine(digit2 + " больше " + digit1);
    }
}
else
{
    Console.WriteLine("Числа равны");
}

// Вариант вывода с тернарным оператором
Console.Write("Вариант вывода с тернарным оператором: ");
// Console.Write(digit1 > digit2 ? "max = " + digit1 : "max = " + digit2 );
Console.Write((digit1 == digit2) ? "числа равны" : ((digit1 > digit2) ? "max = " + digit1 : "max = " + digit2));
