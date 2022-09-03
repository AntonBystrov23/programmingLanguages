// Задача №11: Напишите программу, которая принимает 2 числа и выводить, является ли второе число кратным первому. 
// Если оно не является кратным первому, то программа выдает остаток от деления
int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

void printData()  // вводим данные
{
Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();  
Console.Write("Введите второе число: ");
string? inputLineB = Console.ReadLine();
inputNumberA = int.Parse(inputLineA);
inputNumberB = int.Parse(inputLineB);
}
void calculateData()
{
result = (inputNumberB % inputNumberA == 0);
}
void showResult()
{
if (result)      // true
    {
        Console.Write("Число " + inputNumberB + " является кратным числу " + inputNumberA);
    }
    else           // false
    {
        Console.Write("Остаток от деления равен " + (inputNumberB % inputNumberA)); // ищем остаток от деления и выводим на экран
    }
}

printData();
calculateData();
showResult();

// if (inputLineA != null && inputLineB != null)  // проверяем 
// {
//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);   //  приводим к цвещественному
//     bool res = (inputNumberB % inputNumberA == 0);
//     if (res)      // true
//     {
//         Console.Write("Число " + inputNumberB + " является кратным числу " + inputNumberA);
//     }
//     else           // false
//     {
//         int result = (inputNumberB % inputNumberA);            // ищем остаток от деления и выводим на экран
//         Console.Write("Остаток от деления равен " + result);
//     }
// }


// if (inputLineA != null && inputLineB != null)  // проверяем 
// {
//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);   //  приводим к цвещественному
//     Console.Write((inputNumberB % inputNumberA ==0) ? "Число является кратным " : ("Остаток от деления равен " + (inputNumberB % inputNumberA)));

// }


