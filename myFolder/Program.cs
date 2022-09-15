using System; // библиотека
namespace programmingLanguages{// пространство имен
    class programmingLanguages{
        static void Main(){
            Console.Write("Введите первое число: ");

            // string inputNumber = Console.ReadLine();
            // int number = int.Parse(inputNumber);
                    // ===
            int numberFirst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int numberSecond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberFirst + ">" + numberSecond + "?");
            Console.WriteLine((numberFirst > numberSecond) ? "Первое число больше второго." : (numberFirst == numberSecond) ? "Числа равны." : "Второе число больше первого.");
            
            // Console.ReadLine();
            // Console.ReadKey();

        }
    }
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

// ---- КОНВЕРТАЦИЯ----------
void Convertation()
{
    int numberSecond = Convert.ToInt32(Console.ReadLine());

}


//----ПОИСК КВАДРАТА И ОКРУГЛЕНИЕ ДО ДВУХ ЦИФР ПОСЛЕ ЗАПЯТОЙ====
Math.Round(Math.Sqrt(num1), 2) == num2) 


// -----Вывод массива----------
void PrintArray()
{// печатаем массив
void Print1DArray(int[]array, string line)
{
    Console.Write(line);
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

}

//------Bool test-----
void BoolTest()
{ 
   //     int count = 0;
    // for (byte i = 0; i < array.Length; i++)   
    // {   
    //     if (testNumb(array[i]))
    //         count++;
    //     continue; 
    // }       
    // return count;
    bool testNumb(int num)
    {
        return (num%2 == 0);
    }


// Метод сортировки пузырем
void BubblesSort()
{
int[] array = new int[] { 6, 7, 2, 11, 7, 1, 6 };
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
Console.WriteLine("[{0}]", string.Join(", ", array));;
}





