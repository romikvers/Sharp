    /*Створити клас Прямокутник. У закритій частині визначити поля:
    • висоту і
    • ширину.
    Методи:
    • обчислення площі,
    • обчислення периметру,
    • встановлення висоти,
    • встановлення ширини,
    • отримання висоти,
    • отримання ширини;
    • виведення значень елементів класу на екран.
    Методи встановлення полів класу мають перевіряти коректність параметрів, що
    задаються.
    */
using System;

namespace lab_4_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pryamokutnyk  a = new Pryamokutnyk();
            Console.WriteLine(" a :");
            a.Read();
            a.Square();
            a.Display();
            Console.WriteLine("///////////////////////////////");
            Pryamokutnyk b = new Pryamokutnyk();
            Console.WriteLine(" b :");
            b.SetLength(12);
            b.SetLength(2);
            b.Display();
            b.Perimeter();
        }
    }
}
