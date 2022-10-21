using System;

namespace TestProject1
{
    class Program
    {
        static void Main()
        {
            Aeroflot airplane = new Aeroflot(550, 515, "Aeroflot");

            Lada priora = new Lada("Lada Priora", "Серый", 108316);


            Aeroflot aeroflot = new Aeroflot(550, 515, "Aeroflot");

            Mazda mazda3 = new Mazda("Mazda 3 BK", "Синий", 178951, ". Машина оснащена автозапуском");

            Audi RS6 = new Audi("Audi RS6", "Черный", 809, ". Машина в самой жирной комплектации");
        }

    }
}