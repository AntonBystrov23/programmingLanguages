// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Сортировка пузырьком
// [345, 897, 568, 234] -> 2


// Метод получения данных от пользователя
int GetDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод генерации массива
int[] GenerArray(int count)
{
    // Создаем случайную переменную
    Random numberGerarate = new Random();
    // создаем новый массив
    int[] randomArray = new int[count];
    // заполняем массив случайными значениями из диапазона, который укажет пользователь
    for (byte i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = numberGerarate.Next(100, 1000);
    }
    return randomArray;
}

// Метод сортировки пузырь
int[] BubblesSort(int[] array)
{
    for (int i = array.Length - 1; i >= 1; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int buffer = array[j];
                array[j] = array[j + 1];
                array[j + 1] = buffer;
            }
        }
    }
    return array;
}

// Метод для подсчета количества четных чисел
int EvenCount(int[] array)
{
    int count = 0;
    foreach (byte el in array)
    {
        if (el % 2 == 0)  // можно сделать bool test, а также перебрать циклом for
            count++;
        continue;
    }
    return count;
    //     int count = 0;
    // for (byte i = 0; i < array.Length; i++)   
    // {   
    //     if (testNumb(array[i]))
    //         count++;
    //     continue; 
    // }       
    // return count;
    // bool testNumb(int num)
    // {
    //     return (num%2 == 0);
    // }
}

// метод для вывода массива на экран
void PrintArray(int[] array, string line)
{
    Console.Write(line);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// метод для вывода суммы колличества четных чисел
void PrintSumEvenNums(int numbers)
{
    Console.WriteLine("Колличество четных чисел в массиве равно " + numbers);
}

int[] arrBeforInv = GenerArray(GetDate("Длинна массива: "));
PrintArray(arrBeforInv, "Массив: ");                           // Печать сгенерированного массива
PrintSumEvenNums(EvenCount(arrBeforInv));                      // Печать суммы колличества четных чисел
PrintArray(BubblesSort(arrBeforInv), "Сортировка пузырьком: ");// Печать отсорторованного массива
