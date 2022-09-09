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
Math.Round(Math.Sqrt(num1), 2) == num2) //ПОИСК КВАДРАТА И ОКРУГЛЕНИЕ ДО ДВУХ ЦИФР ПОСЛЕ ЗАПЯТОЙ