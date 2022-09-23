
//--------ВВОД ДАННЫХ------------
int ReadDate(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//--------ОТЛАВЛИВАЕМ ОШИБКИ------------
void TryCatch()
{
    try
    {
        Console.Write("Введите первое число: ");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");

        int numB = Convert.ToInt32(Console.ReadLine());
        int res = numA / numB;
        Console.WriteLine(res);
    }
    catch (FormatException) { Console.WriteLine("Вы ввели неверный формат!"); }
    catch (System.DivideByZeroException) { Console.WriteLine("Делить на ноль нельзя!"); }
    finally { } // прописать код (к примеру для закрытия баз)
}

//------GETTING И SETING (СОЗДАЕМ НАСТРОЙКИ ДОСТУПА К ДАННЫМ В КЛАССЕ ИЗ ВНЕ------------
class GetAndSet
{
    class User
    {
        private _id;
    private username;
    private password;
        constructor(username, password)
        {
            this._id = generateRandomId();
            this._username = _username;
            this.password = password;

        }

        get username()
        {
            return this._username;
        }
        set username(value)
        {
            this._username = _value;
        }
        get _password()
        {
            return this._password;
        }
        set password(value)
        {
            this._password = _value;
        }
        get id()    // Для id оставляем только get, т.к. он остается статичным и изменить его извне не получиться
        {
            return this.id;
        }
    }
    // создаем объект и пытаемся внести в него изменения
    const user = new User(username 'Tonny', password 'agdks;kl')
    user.id = 5;  // поменять не получиться, т.к. мы не сделали для него настройки set
    user.username = 55; // меняем без проблем

}


// -----ГЕНЕРАЦИЯ МАССИВА----
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

// ---ВВОД МАССИВА ЧЕРЕЗ ЗАПЯТУЮ---
int[] InputArray()
{
    Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
    string[] nums = Console.ReadLine().Split(new char[] { ',' });
    int[] intArray = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        intArray[i] = int.Parse(nums[i]);
    }
}

// -----ЗАПОЛНИТЬ МАССИВ----------
void[] FillArray()
{
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

// Заполнение массива случайными вещественными числами.
double[,] FillArray(int countRow, int countColumn, int from, int to)
{
    // Создаем случайную переменную
    Random numberGerarate = new Random();
    // создаем новый массив
    double[,] random2DArray = new double[countRow, countColumn];
    // заполняем массив случайными значениями из диапазона, который укажет пользователь
    for (byte i = 0; i < countRow; i++)
    {
        for (byte j = 0; j < countColumn; j++)
        {
            random2DArray[i, j] = Math.Round((numberGerarate.NextDouble() * (from - to) + from), 2);
        }
    }
    return random2DArray;
}

}


// -----РАЗВЕРНУТЬ МАССИВ----------
void ReverseArray()
{
    // Разворачиваем массив с помощью цикла for и создания нового массива
    int[] ReverseToNewArray(int[] array)
    {
        int[] outArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            outArray[i] = array[array.Length - 1 - i];
        }
        return outArray;
    }

    // Разворачиваем массив с перемещения элементов внутри исходного массива
    int[] ReverseSwapPos(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
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
}

// ----РАЗВОРОТ СТРОКИ ПРИ НАКОПЛЕНИИ В ПРОЦЕССЕ КОНВЕРТАЦИИ FROM DEC TO BIN-------------
string ConvertDecToBin(int number)
{
    string res = String.Empty;
    while (number > 0)
    {
        res = number % 2 + res;  //Поменяли местами и накапливаем строку в обратном порядке!
        number = number / 2;
    }
    return res;
}


//---- ПОИСК ДЛИННЫ----
void Length()
{
    int CountDigits1(int num)              // Ищем длинну   ПЕРЕВОД В СТРОКУ И ВОЗВРАТ ДЛИННЫ
    {
        string count = num.ToString();
        return count.Length;
    }
    int CountDigits2(int num)              // Ищем длинну   ЦИКЛ ПЛЮС ДЕЛЕНИЕ
    {
        int count = 0;
        while (num > 0)
        {
            num = num / 10;
            count = count + 1;
        }
        return count;
    }
    int CountDigits3(int num)              // Ищем длинну   LOG10
    {
        return (int)(Math.Log10(num) + 1);
    }

}

// -----ВЫВОД МАССИВА----------
void PrintArray()
{// печатаем массив                                      //САМЫЙ МАЛОЗАТРАТНЫЙ ВАРИАНТ
    void Print1DArray(int[] array, string line)
    {
        Console.Write(line);
        Console.WriteLine("[{0}]", string.Join(", ", array));
    }
    // ====================================================
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
    // ====================================================
    // печатаем массив
    Console.WriteLine("\r\nОтсортированный массив:");
    foreach (int value in arrRandNum)
    {
        Console.Write($"{value} ");
    }
    // ====================================================

}

// -----КЛОНИРОВАНИЕ МАССИВА----------
void CloneArray()
{
    int[] FirstArrayClone(int[] array)
    {
        int[] cloneArr = new int[array.Length];
        for (byte i = 0; i < array.Length; i++)
        {
            cloneArr[i] = array[i];
        }
        return cloneArr;
    }

    int[] SecondArrayClone(int[] array)             //САМЫЙ МАЛОЗАТРАТНЫЙ ВАРИАНТ
    {
        int[] cloneArr = new int[array.Length];
        cloneArr = (int[])array.Clone();
        return cloneArr;
    }
}


// -----ВЫВОД ДАННЫХ----------
void OutDate()
{
    void PrintResult(string prefix, string data)
    {
        Console.Write(prefix + data);
    }
    PrintResult($" Число {number} в двоичной системе = ", ConvertDecToBin(number));
    //=================================================
    void PrintResult(string line)
    {
        Console.Write(line);
    }
    PrintResult($" Число {number} в двоичной системе = {ConvertDecToBin(number)}");
}
void Variant// Примеры работы с методом Write без форматирования
{
    Console.Write("Текущая дата: ");
    Console.Write(DateTime.Now);
    Console.Write("\n");
    Console.Write($"Текущая дата: {DateTime.Now}\n");

    // Примеры работы с методом Write с использованием форматирования
    Console.Write("Текущая дата: {0}\n", DateTime.Now);
    Console.Write("Число: {0:E}\n", 123.456789);
}

// ---- СОРТИРОВКА МАССИВА----
void SortArray()
{
    // Метод сортировки вставками
    double[] PasteSort(double[] array)
    {
        double minNum;
        int indexMin;
        for (int i = 1; i < array.Length; i++)
        {
            minNum = array[i];
            indexMin = i;
            while (indexMin > 0 && array[indexMin - 1] > minNum)
            {
                Swap(array, indexMin, indexMin - 1);
                indexMin -= 1;
            }
            array[indexMin] = minNum;
        }
        return array;
    }

    // Метод сортировки подсчетом
    double[] CalculateSort(double[] array)
    {
        double[] changeArray = new double[array.Length];

        for (byte i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (byte j = 0; j < array.Length; j++)
            {
                if (array[i] > array[j] || (array[i] == array[j] && j > i))
                    count++;
            }
            changeArray[count] = array[i];
        }

        return changeArray;
    }

    // Метод сортировки пузырь
    double[] BubblesSort(double[] array)
    {
        for (int i = array.Length - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                }
            }
        }
        return array;
    }

}

// ---- КОНВЕРТАЦИЯ----------
void Convertation()
{
    int number1 = Convert.ToInt32(num1);
    // ===================================
    int numberSecond = Convert.ToInt32(Console.ReadLine());
    // =======================================================
    int inputNumberA = int.Parse(inputLineA);
    char[] charArray = inputNumberA.ToString().ToCharArray();
    // =========================================================
    char[] arrayNumbers = numberRandom.ToString().ToCharArray();   // разобрал число и положил в массив
    string digit1 = arrayNumbers[0].ToString();                     //Console.WriteLine("" + arrayNumbers[0] + arrayNumbers[2]);
    string digit2 = arrayNumbers[2].ToString();

    Console.WriteLine(digit1 + digit2);
    // ==========================================================
    char[] charArray = inputLineNumber.ToCharArray(); //  переводим строку в массив
                                                      // ==========================================================
    double ReadDate(string line)
    {
        Console.Write(line);
        double num = Convert.ToDouble(Console.ReadLine() ?? "0");
        return num;
    }
    // ===============================================



}

//---- КОНВЕРТАЦИЯ И ПЕРЕВОД В НЕОБХОДИМУЮ СИСТЕМУ ИСЧИСЛЕНИЯ----------
void ConvertationAndDecBin()
{
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

    numbBin = Convert.ToString(numb, 8);
    Console.WriteLine($"Число {numb} в восьмеричная системе: {numbBin}");

}

//----ПОИСК КВАДРАТА И ОКРУГЛЕНИЕ ДО ДВУХ ЦИФР ПОСЛЕ ЗАПЯТОЙ====
void Sqr()
{
    Math.Round(Math.Sqrt(num1), 2) == num2;

}


//------BOOL TEST-----
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
        return (num % 2 == 0);
    }
    // ===================================================================
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA); // Ключевое слово типа bool — это псевдоним для типа структуры System.Boolean .NET, представляющий логическое значение: true или false.
                                                                // =======================================================================
    int inputNumber = int.Parse(inputLineNumber);          // приводим к целостным числам
    bool outResult = (inputNumber % 2 == 0);
    Console.WriteLine("Число " + inputNumber + " является четным: " + outResult);
    // =============================================================
}


// ----ПОМЕНЯТЬ ЭЛЕМЕНТЫ МЕСТАМИ--------
void Swap(int[] array, int left, int right)
{
    if (left != right)
    {
        int buffer = array[left];
        array[left] = array[right];
        array[right] = buffer;
    }
}

// ---ТЕРНАРНЫЙ ОПЕРАТОР---
void TernarnOperator()
{
    void BoolFirst()
    {
        int ReadDate(string line)
        {
            Console.Write(line);
            int num = int.Parse(Console.ReadLine() ?? "0");
            return num;
        }

        bool TrglTest(int a, int b, int c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }

        void PrintResult(string line)
        {
            Console.WriteLine(line);
        }

        int a = ReadDate("Add point A: ");
        int b = ReadDate("Add point B: ");
        int c = ReadDate("Add point C: ");
        PrintResult(TrglTest(a, b, c) ? "Такой треугольник есть!" : "Такого треугольника нет!");

    }
    // ===============================
    string pointBase = (X >= 0 ? (Y >= 0 ? ("1-ая четверть.") : ("2-ая четверть.")) : (Y <= 0 ? ("3-ая четверть.") : ("4-ая четверть.")));


}


// ---ИСПОЛЬЗОВАНИЕ КЕЙСОВ SWITCH----
void Switch()
{
    Console.Write("Введите день недели(число от 1 до 7): ");
    string? inputLine = Console.ReadLine();

    if (inputLine != null)
    {
        int inputDayOfWeek = int.Parse(inputLine);
        string outDayOfWeek = ""; //создали пустую переменную, в которую положим результат работы switch (либо string outdayOfWeek = string.Empty;)
        switch (inputDayOfWeek)
        {
            case 1: outDayOfWeek = "monday"; break;
            case 2: outDayOfWeek = "tuesday"; break;
            case 3: outDayOfWeek = "wednesday"; break;
            case 4: outDayOfWeek = "thursday"; break;
            case 5: outDayOfWeek = "friday"; break;
            case 6: outDayOfWeek = "saturday"; break;
            case 7: outDayOfWeek = "sunday"; break;
            default: outDayOfWeek = "Введите корректное значение!"; break;
        }
    }
}

// ---RANDOM----
void Random()
{
    // ===================================================
    System.Random numberGenerator = new System.Random();
    int numberRandom = numberGenerator.Next(10, 100);
    // =======================================================
    //   ЗАПОЛНЯЕМ МАССИВ СЛУЧАЙНЫМИ ЧИСЛАМИ
    // Создаем случайную переменную
    Random numberGerarate = new Random();
    // создаем новый массив
    int[] randomArray = new int[count];
    // заполняем массив случайными значениями из диапазона, который укажет пользователь
    for (byte i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = numberGerarate.Next(0, 10);
    }
    return randomArray;
    // ===================================================================
    // Случайный цвет
Console.ForegroundColor = colorColl[new System.Random().Next(0, 16)];

}


// -----РАЗБОР DICTIONARY-----
void Dictionary()
{
    //Разбор конструктора Dictionary
    // 1) Создать новый словарь
    // 2) Заполнить словарь 8 элементами/вывести на экран(три варианта)
    // 3) Удалить третий элементам
    // 4) Заменить элемент 5
    // 5) Добавить два новых элементам
    // 6) Вывести весь список элементов
    // 7) Вывести конкретный элемент
    // 8) Вывести все ключи
    // 9) Вывести ценности

    // 1) СОЗДАТЬ НОВЫЙ СЛОВАРЬ

    // Dictionary<int, string> dayOfWeek = new Dictionary<int, string>(); 
    // --------------------------------------------------------------------------------------------------------


    Console.WriteLine("Введите день недели.");
    string? inputNumber = Console.ReadLine() ?? "0";
    int number = int.Parse(inputNumber);

    // 1)-------------
    // var dayOfWeek = new Dictionary<int, string>() {{1, "mon"}, {2, "tue"}, {3, "web"}, {4, "wed"}, {5, "thu"}, {6, "fri"}, {7, "sat"}, {8, "san"}};
    // 2)-------------
    // var dayOfWeek = new Dictionary<int, string>() {[1] = "mon", [2] = "tue", [3] = "web", [4] = "wed", [5] = "thu", [6] = "fri", [7] = "sat", [8] = "san"};
    // 3)-------------
    Dictionary<int, string> dayOfWeek = new Dictionary<int, string>();
    dayOfWeek.Add(1, "Понедельник - Будний день");
    dayOfWeek.Add(2, "Вторник - Будний день");
    dayOfWeek.Add(3, "Среда - Будний день");
    dayOfWeek.Add(4, "Четверг - Будний день");
    dayOfWeek.Add(5, "Пятница - Будний день");
    dayOfWeek.Add(6, "Суббота - Выходной день");
    dayOfWeek.Add(7, "Воскресенье - Выходной день");

    // =======================================================================================
    // 1)---------------------------
    // var justDay = new KeyValuePair<int, string>(1, "mon"); ////создаем один элемент и кладем его в список, который в дальнейшем будет инициализирован в словарь
    // var listOfDays = new List<KeyValuePair<int, string>>() {justDay}; ////создаем список
    // var dayOfWeek = new Dictionary<int, string>(listOfDays); ////кладем список в словарь

    // 2)---------------------------
    // var justDay = new KeyValuePair<int, string>(1, "mon"); 
    // var listOfDays = new List<KeyValuePair<int, string>>() {justDay}; 
    // var dayOfWeek = new Dictionary<int, string>(listOfDays) {[2] = "wed", [3] = "thu", [4] = "fr", [5] = "sat", [6] = "san"}; //// сразу добавляем другие элементы


    //Перебор словаря (применяем цикл foreach) Выводим весь список на экран.
    Console.WriteLine("Перебор словаря (применяем цикл foreach). Выводим список на экран.");
    foreach (var day in dayOfWeek)
    {
        Console.WriteLine($"key: {day.Key} value: {day.Value}");
    }

    // Добавляем элементы и удаляем.
    dayOfWeek[1] = "Понедельник";  // заменяем элемент
    dayOfWeek[2] = "Вторник";
    dayOfWeek[3] = "Среда";
    dayOfWeek[8] = "все!";   // добавляем новый элемент

    // Выводим список после изменений.
    Console.WriteLine("Выводим список после изменений.");
    foreach (var day in dayOfWeek)
    {
        Console.WriteLine($"key: {day.Key} value: {day.Value}");
    }

    Console.WriteLine("Выводим элемент и кладем его в переменную");
    string fri = dayOfWeek[4];       //  выводим элемент и кладем его в новую переменную
    Console.WriteLine(fri);

    Console.WriteLine("Выводим элемент по указанным параметрам");
    Console.WriteLine(dayOfWeek[number]); // просто выводим элемент

    // ========================================================

    // Методы и свойства Dictionary
    // void Add(KeyNotFoundException key, ValueTask value)
    // {

    // };



    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //19

    // * РЕШЕНИЕ ДЛЯ ЧИСЛА ЛЮБОЙ ДЛИННЫ ЧЕРЕЗ DICTIONARY
    void getDictionary(string line)
    {
        Console.WriteLine(line);
        int countOfNumbers = int.Parse(Console.ReadLine() ?? "0");
        IDictionary<int, int> numberNames = new Dictionary<int, int>();
        for (int index = 0; index < countOfNumbers; index++)
        {
            System.Random numberGenerator = new System.Random();
            int digit = new Random().Next(10, 1000000000);
        }
        foreach (KeyValuePair<int, int> kvp in numberNames)
            Console.WriteLine("Порядковый номер числа: {0}, Число: {1}", kvp.Key, kvp.Value);
    }

    getDictionary("Введите количество чисел для тестирования программы: ");
    // bool testCondition(int number) // конвертирую строку в массив
    // {
    //     char[] charArray = number.ToString().ToCharArray();  // переводим число в массив
    //     int length = charArray.Length;
    //     bool result = false;
    //     for (int index = 0; index < length / 2; index++)     // ограничиваем счетчик до половины, так как сравниваем лишь первую половину со второй
    //     {
    //         if (charArray[index] == charArray[length - 1 - index]) // -1 т.к. отчет с 0 до 7
    //         {
    //             result = true;
    //         }
    //         else
    //         {
    //             result = false;
    //             break;
    //         }

    //     }

    //     return result;
    // }

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //21

    // // * ВТОРОЙ ВАРИАНТ

    // string inputData(string line)
    // {
    //     Console.WriteLine(line);       //Выводим сообщение
    //     string inputedData = Console.ReadLine() ?? "0";
    //     return inputedData;
    // }
    // int getArray(string incomingData)
    // {
    //     // x(4,8,2);y(5,-1,0)
    //     char[] numbersArray = incomingData.ToString().ToCharArray();
    //     // string countDigits = string.Empty;
    //     int lengthFirst = incomingData.Length;
    //     int positionDigit = 0;
    //     for (int index = 0; index < lengthFirst; index++)
    //     {
    //         if (numbersArray[index] == '0' || numbersArray[index] == '1' || numbersArray[index] == '2' || numbersArray[index] == '3' || numbersArray[index] == '4' || numbersArray[index] == '5' || numbersArray[index] == '6'
    //         || numbersArray[index] == '7' || numbersArray[index] == '8' || numbersArray[index] == '9')
    //         {
    //             numbersArray[positionDigit] = numbersArray[index];
    //             // countDigits = countDigits + numbersArray[index];
    //             positionDigit++;
    //         }
    //         else
    //         {
    //             continue;
    //             // countDigits = countDigits + "";
    //         }
    //     }
    //     int digit = Convert.ToInt32(numbersArray);
    //     return digit;
    // }

    // void printFinalResult(int dig)
    // {
    //     Console.WriteLine(dig);
    // }
    // string res = inputData("Введите координаты: ");
    // getArray(res);
    // printFinalResult(getArray(res));

}


// РАССТОЯНИЕ МЕЖДУ ДВУМЯ ТОЧКАМИ В 2D ПРОСТРАНСТВЕ 
void Distation()
{
    double result = Math.Round((Math.Sqrt(Math.Pow((num1 - num3), 2) + Math.Pow((num2 - num4), 2))), 2);
}

// СЧЕТ ВРЕМЕНИ 
void CalculateTime()
{
    DateTime d1 = DateTime.Now;           // Сравним время двух методов
    PrintResult(CalculateDate1(N));
    Console.WriteLine("Время, затраченное на первое решение: " + (DateTime.Now - d1));   // Итоговое время
}


// ----- Substring РЕШЕНИЕ С ПЕРЕВОДОМ В СТРОКУ:ВЫДЕРГИВАЮ ПО ЭЛЕМЕНТУ,КОНВЕРТИРУЮ,СУММИРУЮ.(ЗАТРАТНЫЙ ВАРИАНТ)
void Substring()
{
    string GetDate(string line)                           // Получаем данные от пользователя

    {
        Console.WriteLine(line);                         // Выводим сообщение
        string number = Console.ReadLine() ?? "0";       // Считываем число
        return number;                                   // Возвращаем значение
    }
    int CalcDateFor(string numbers)                       // Метод подсчета суммы чисел (вычленяем каждый элемент строки и суммируем)              
    {
        int length = numbers.Length;                     // Выявляем длинну
        int sum = 0;
        for (int index = 0; index < length; index++)     // Цикл: 
        {
            string digit = numbers.Substring(index, 1);  // Берем поочереди каждый символ
            int number = int.Parse(digit);               // Приводим к целому числу
            sum = sum + number;                          // суммируем с предыдущим результатом
        }
        return sum;
    }

}

// ----- МЕТОД СПЛИТ(ПОЛУЧАЕМ СТРОКУ ЧЕРЕЗ ЗАПЯТУЮ И КЛАДЕМ ЕЕ В МАССИВ-----------
string SplitMet(string names)           // метод заполнения массива случайными значениями от 0 до 100
{
    string[] array = names.Split(",");
    int numRand = new Random().Next(0, array.Length);
    string nameRand = array[numRand];
    return nameRand;
}

// ----- FACTORIAL-----------
long Factorial(int inputedNumber)       // метод подсчета
{
    long factorial = 1;
    for (int index = 1; index <= inputedNumber; index++)
    {
        factorial = factorial * index;
    }
    return factorial;
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
// Перебираем массив с помощью foreach, ищем значения в отрезке [10, 99]
int FindCountNums(int[] array)


// ----СОЗДАЕМ КОЛЛЕКЦИЮ ЦВЕТОВ-----
void Color()
{
    ConsoleColor[] colorColl = new ConsoleColor[]{ ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue,
                                        ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Green,
                                        ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta,
                                        ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.White, ConsoleColor.Gray};

    // Печатаем двумерный массив
    void Print2DArrayColored(string prefix, int[,] array2D)
    {
        Console.WriteLine(prefix);
        for (byte i = 0; i < array2D.GetLength(0); i++)
        {
            for (byte j = 0; j < array2D.GetLength(1); j++)
            {
                Console.ForegroundColor = colorColl[new System.Random().Next(0, 16)];
                Console.Write($"{array2D[i, j]} ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
