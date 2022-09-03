// Задача №11: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет среднее из трех цифр

System.Random numberGenerator = new System.Random();
int numberRandom = numberGenerator.Next(100, 1000);            // получаем случайное двузначное число
Console.WriteLine("Результат рандома: " + numberRandom);
char[] arrayNumbers = numberRandom.ToString().ToCharArray();   // разобрал число и положил в массив
string digit1 = arrayNumbers[0].ToString();                     //Console.WriteLine("" + arrayNumbers[0] + arrayNumbers[2]);
string digit2 = arrayNumbers[2].ToString();

Console.WriteLine(digit1 + digit2);
