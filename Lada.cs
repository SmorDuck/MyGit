using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace TestProject1
{
    class Lada : Car
    {
        public Lada(string marka, string collour, int probeg) : base(marka, collour, probeg)
        {
            print();
            Razdel();
        }

        public override void Print()
        {
            Console.WriteLine("Марка автомобиля - " + Marka + ". Цвет авто - " + Collour + ". Пробег: " + Probeg);
        }
    }
}

