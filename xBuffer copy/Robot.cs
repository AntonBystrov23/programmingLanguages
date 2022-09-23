using System;



namespace project
{
    class Robot 
    {
        //private, protected, public - три типа модификаторов
        private string name;
        private int weight;
        private byte[] coordinates;
        
        public Robot(string _name, int _weight, byte[] _coordinates) // Конструктор с парраметрами
        {
            Console.WriteLine("Object has been created."); // при создании нового объекта каждый раз будет выскакивать это сообщение
            setValues(_name, _weight, _coordinates);  // прикрепляем метод для внесения данных(можно было тело метода прописать в конструкции)
        }                
        public Robot()
        {
            Console.WriteLine("Object without parameters.");
        }                   // Конструктор без парраметров

        public void setValues(string _name, int _weight, byte[] _coordinates) // Отдельный метод для внесения данных(т.к. созданные переменные в формате приват)
        {
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }
        public void PrintValues()
        {
            System.Console.Write("Вес " + name + " = " + weight + ". Координаты: ");
            foreach(byte el in coordinates)
            System.Console.Write(el + " ");
            System.Console.WriteLine();

        }
    }
}