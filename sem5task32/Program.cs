// Сгенерировать массив и инвертировать значения(положительные в отрицательные и наоборот)

int[] GenArray(int count, int from, int to)
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

void PrintArray(int[] array, string line)
{
    // строка для указания, какой массив будем выводить
    Console.Write(line);
    for (byte i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "!");
}

int[] InvertArray(int[] array)
{
    int[] invertArray = new int[array.Length];
    for (byte i = 0; i < array.Length; i++)
        invertArray[i] = array[i] * -1;
    return invertArray;
}

int GetDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// собираем данные от пользователя
int countNumbers = GetDate("Введите длинну массива: ");
int fromNum = GetDate("Введите начало диапазона: ");
int ToNum = GetDate("Введите конец диапазона: ");

// создаем массив и подставляем указанные пользователем данные
int[] arrBeforInv = GenArray(countNumbers, fromNum, ToNum);
// выводим массив 
PrintArray(arrBeforInv, "Массив до преобразования: ");
PrintArray(InvertArray(arrBeforInv), "Массив после преобразования: ");



