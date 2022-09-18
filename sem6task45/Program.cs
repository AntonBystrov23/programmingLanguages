// Клонирование массива

// Заполняем массив случайными числами
int[] FillArray(int count, int from, int to)
{
    if (from > to)
    {
        int value = to;
        to = from;
        from = value;
    }
    Random random = new Random();
    int[] array = new int[count];
    for (byte i = 0; i < array.Length; i++)
        array[i] = random.Next(from, to);
    return array;
}

// Метод вывода массива на экран
void PrintArray(string prefix, int[] array)
{
    Console.Write(prefix);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Вариант клонирования при помощи цикла for
int[] FirstArrayClone(int[] array)
{
    int[] cloneArr = new int[array.Length];
    for (byte i = 0; i < array.Length; i++)
    {
        cloneArr[i] = array[i];
    }
    return cloneArr;
}

// Вариант клонирования при помощи функции (int[])array.Clone();  !!! САМЫЙ МАЛОЗАТРАТНЫЙ ВАРИАНТ
int[] SecondArrayClone(int[] array)             
{
    int[] cloneArr =  new int[array.Length];
    cloneArr = (int[])array.Clone();
    return cloneArr;
}

// Создаем, наполняем исходный массив и выводим его на экран
int[] firstArray = FillArray(200, 0, 11);
PrintArray("Исходный массив: ", firstArray);

// Клонируем исходный массив и сравниваем по времени два варианта методов клонирования
DateTime d = DateTime.Now;
PrintArray("Клон массива: ", FirstArrayClone(firstArray));
Console.WriteLine(DateTime.Now - d);
DateTime d1 = DateTime.Now;
PrintArray("Клон массива2: ", SecondArrayClone(firstArray));
Console.WriteLine(DateTime.Now - d1);


// DateTime d = DateTime.Now;
// PrintFirstArray(testArr);
// Console.WriteLine(DateTime.Now - d);



