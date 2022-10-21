using System;
namespace TestProject1
{
    class Mazda : Car
    {
        private string auto_pusk;

        public Mazda(string marka, string collour, int probeg, string pusk) : base(marka, collour, probeg)
        {
            this.auto_pusk = pusk;
            Print();
            Razdel();
        }

        public override void Print()
        {
            Console.WriteLine("Марка автомобиля - " + Marka + ". Цвет авто - " + Collour + ". Пробег: " + Probeg + auto_pusk);
        }
    }
}

