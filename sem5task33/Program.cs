// Задайте массив. Напишите программу которая определяет, присутствует ли заданное число в массиве

// Метод получения данных от пользователя
int GetDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Метод генерации массива
int[] GenerArray(int count, int from, int to)
{
    // Наименьшее указанное число ставим в начало диапазона
    if (from > to)
    {
        int rebasePos = to;
        to = from;
        from = rebasePos;
    }
    // Создаем случайную переменную
    Random numberGerarate = new Random();
    // создаем новый массив
    int[] randomArray = new int[count];
    // заполняем массив случайными значениями из диапазона, который укажет пользователь
    for (byte i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = numberGerarate.Next(from, to + 1);
    }
    return randomArray;
}
// Метод для проверки наличия искомого числа
int FindNumber(int[] array, int find)
{
    for (byte i = 0; i < array.Length; i++)   // можно перебрать с помощью foreach
    {
        if (array[i] == find)
        {
            return i;
            // return true;
        }

    }
    // return false;
    return -1;
}
// метод для вывода массива на экран
void PrintArray(int[] array, string line)
{
    // // строка для указания, какой массив будем выводить
    // Console.Write(line);
    // for (byte i = 0; i < array.Length - 1; i++)
    //     Console.Write(array[i] + ", ");
    // Console.WriteLine(array[array.Length - 1] + "!");
    Console.WriteLine("[{0}]", string.Join(", ", array));

}

void PrintNumIndex(int index)
{
    Console.WriteLine(index > 0 ? ("Число находится на позиции " + index) : "Такого числа нет");
}

int[] arrBeforInv = GenerArray(GetDate("Введите длинну массива: "), GetDate("Введите начало диапазона: "), GetDate("Введите конец диапазона: "));
PrintArray(arrBeforInv, "Массив: ");
// Console.WriteLine(FindNumber(arrBeforInv, findNum) ? "Число есть в массиве!" : "Числа нет в массиве!");
PrintNumIndex(FindNumber(arrBeforInv, GetDate("Какое число ищем? ")));
