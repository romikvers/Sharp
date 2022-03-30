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
using System.Collections.Generic;
using System.Text;

namespace lab_4_sharp
{
    class Pryamokutnyk
    {
        private double hight;
        private double width;
        public Pryamokutnyk()
        {
            this.hight = 0;
            this.width = 0;
        }
        public void SetLength(double hight)
        {
            if (hight < 0) {
                this.hight = 0;
            }
            else {
                this.hight = hight;
            }
        }
        public void SetWidth( double width)
        {
            if (width < 0)
            {
                this.width = 0;
            }
            else
            {
                this.width = width;
            }
        }
        public void Init(double hight, double width)
        {
            SetLength(hight);
            SetWidth(width);
        }
        public double GetLength()
        {
            return this.hight;
        }
        public double GetWidth()
        {
            return this.width;
        }
        public void Read()
        {
            do {
                Console.Write("hight : ");
                this.hight = Double.Parse(Console.ReadLine());
                Console.Write("width : ");
                this.width = Double.Parse(Console.ReadLine());
            } while (this.hight < 0 || this.width < 0);
        }
        public void Display()
        {
            Console.WriteLine($"hight = {this.hight}, width = {this.width} ");
        }
        public void Square()
        {
            Console.WriteLine($"Square : {this.hight * this.width}");
        }
        public void Perimeter()
        {
            Console.WriteLine($"Square : {2 * (this.hight + this.width)}");
        }
    }
}
