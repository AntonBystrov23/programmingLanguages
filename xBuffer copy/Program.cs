using System;



namespace project
{
    class Program 
    {
        public Program(){} // Конструктор
        static void Main()
        {
            Robot steal = new Robot("Robocop", 800, new byte[]{0, 1, 8});
            steal.PrintValues();
            Robot wood = new Robot();
            wood.setValues("Vasya", 150, new byte[]{12, 1, 8});
            wood.PrintValues();
        }
    }
}

