//===========================================================================================
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
string? inputNumber = Console.ReadLine();
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
foreach(var day in dayOfWeek) 
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
foreach(var day in dayOfWeek) 
{
   Console.WriteLine($"key: {day.Key} value: {day.Value}"); 
}

Console.WriteLine("Выводим элемент и кладем его в переменную"); 
string fri  = dayOfWeek[4];       //  выводим элемент и кладем его в новую переменную
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









