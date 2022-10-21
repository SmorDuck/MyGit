using System;
namespace TestProject1
{
    abstract class Airplane
    {
        private int speed;
        private int hight;
        private string company;

        public int Speed
        {
            get
            {
                return speed;
            }
            private set { }
        }

        public int Hight
        {
            get
            {
                return hight;
            }
            private set { }
        }

        public string Company
        {
            get
            {
                return company;
            }
            private set { }
        }

        public Airplane(int speed, int hight, string company)
        {
            setValues(speed, hight, company);
            print();
        }

        public void setValues(int speed, int hight, string company)
        {
            this.speed = speed;
            this.hight = hight;
            this.company = company;
        }

        public void place()
        {
            string[] cities = {"Москвy", "Турцию", "Берлин", "Киев", "Вашингтон"};

            string city;
            city = cities[Random(0, 5)];
            Console.WriteLine("Самолет отправляется в " + city);        }

        private int Random(int ot, int k)
        {
            Random ran = new Random();
            int i = ran.Next(ot, k);
            return i;
        }

        public void print()
        {
            Console.WriteLine("Максимальная скорость самолета: " + speed + ". Самолет может взлеть на высоту " + hight + " км. Самолет от компании - " + company);
            place();
        }
    }
}

  