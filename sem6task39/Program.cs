// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

// Заполняем массив случайными значениями
int[] FillArray(int count, int from, int to)
{
    if (from > to)
    {
        int value = to;
        to = from;
        from = value;
    }
    Random ranNum = new Random();
    int[] array = new int[count];
    for (byte i = 0; i < array.Length; i++)
        array[i] = ranNum.Next(from, to);
    return array;
}

// Разворачиваем массив с помощью цикла for и создания нового массива
int[] ReverseToNewArray(int[] array)
{
int[] outArray = new int [array.Length];
for(int i = 0; i < array.Length; i++)
{
    outArray[i] = array[array.Length -1 - i];
}
return outArray;
}

// Разворачиваем массив с перемещения элементов внутри исходного массива
int[] ReverseSwapPos(int[] array)
{
for(int i = 0; i < array.Length / 2; i++)
{
    if (array[i] != array[array.Length - 1 - i])
    {
        int buffer = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = buffer;
    }
}
return array;
}

// Разворачиваем массив при помощи метода array.Reverse()
int[] ReverseArrFunc(int[] array)
{
array.Reverse();
return array;
}

// Выводим получившийся массив
void Print1DArray(int[] array, string line)
{
    Console.Write(line);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

int[] arrayD1 = FillArray(7, 0, 10);
Print1DArray(arrayD1, "Исходный массив: ");
Print1DArray(ReverseToNewArray(arrayD1), "Развернутый массив(последовательно заполняли новый массив): ");
Print1DArray(ReverseSwapPos(arrayD1), "Развернутый массив(с помощью перемещения внутри массива): ");
Print1DArray(ReverseArrFunc(arrayD1), "Развернутый массив(array.Reverse()): ");

