// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// // Запрашиваем данные у пользователя
// string ReadDate(string line)
// {
//     Console.Write(line);
//     string num = Console.ReadLine() ?? "0";
//     return num;
// }

// // Конвертируем число
// string ConvertDecToBin(string number)
// {
// String output = Convert.ToInt32(number, 2).ToString();
// return output;
// }

// // Выводим результат подсчета
// void PrintResult(string line)
// {
//     Console.Write(line);
// }

// string number = ReadDate("Введите число: ");
// PrintResult(ConvertDecToBin(number));

// Запрашиваем данные у пользователя
// int ReadDate(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// // Конвертируем число
// string ConvertDecToBin(int number)
// {
//     string res = String.Empty;
//     while( number > 0 )
//         {
//             res = number%2 + res;  //Поменяли местами и накапливаем строку в обратном порядке!
//             number = number / 2;
//         }
// return res;
// }

// // Выводим результат подсчета
// void PrintResult(string prefix, string data)
// {
//     Console.Write(prefix+data);
// }

// int number = ReadDate("Введите число: ");
// PrintResult($" Число {number} в двоичной системе = ", ConvertDecToBin(number));


int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

int numb = ReadData("Введите число: ");
string numbBin = Convert.ToString(numb, 2);       // string numbBin = Convert.ToString(Convert.ToInt32(numb, 10), 2); ЕСЛИ СНАЧАЛА БЫЛО STRING
Console.WriteLine($"Число {numb} в двоичной системе: {numbBin}");
//  numbBin = Convert.ToString(numb, 8);
// Console.WriteLine($"Число {numb} в восьмеричная системе: {numbBin}");

Console.WriteLine($"{ numbBin = Convert.ToString(ReadData("Введите число: "), ReadData("Введите необходимую систему исчисления: "))}");


