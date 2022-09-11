// Задача №11: Напишите программу, которая принимает число, и проверяет, является ли число  одновременно кратным 7 и 23

int inputNumberA = 0;
bool result = false;

void printData()  // вводим данные
{
Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine()?? "0";  
inputNumberA = int.Parse(inputLineA);
}
void calculateData()
{
result = (inputNumberA % 7 == 0 && inputNumberA % 23 == 0); // логический оператор &&
}
void showResult()
{
if (result)      // true
    {
        Console.Write("Число " + inputNumberA + " является кратным обоим числам.");
    }
    else           // false
    {
        Console.Write("Число " + inputNumberA + " не является кратным двум заданным числам."); 
    }
}

printData();
calculateData();
showResult();