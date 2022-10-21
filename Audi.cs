using System;
namespace TestProject1
{
    class Audi : Car
    {
        private string equipment; //Комплектация

        public Audi(string marka, string col, int prob, string equipment) : base(marka, col, prob)
        {
            this.equipment = equipment;
            Print();
            Razdel();
        }

        public override void Print()
        {
            Console.WriteLine("Марка нового автомобиля - " + Marka + ". Цвет авто - " + Collour + ". Пробег: " + Probeg + equipment);
        }
    }
}

