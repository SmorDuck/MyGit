using System;
namespace TestProject1
{
    class Bus : Car
    {
        public Bus(string marka) : base(marka)
        {
            Print();
            Razdel();
        }

         public override void Print()
        {
            Console.WriteLine("Когда машина в ремонте, я катаюсь на " + Marka);
        }
    }
}

