using System;
namespace TestProject1
{
    abstract class Car
    {
        private string marka;
        private string collour;
        private int probeg;

        public string Marka
        {
            get { return marka; }
            private set { }
        }
        public string Collour
        {
            get { return collour; }
            private set { }
        }
        public int Probeg
        {
            get { return probeg; }
            private set { }
        }


        public void par(string marka, string collour, int probeg)
        {
            this.probeg = probeg;
            this.marka = marka;
            this.collour = collour;
        }

        public void p(string m)
        {
            marka = m;
        }

        public Car(string marka)
        {
            p(marka);
        }

        public Car(string marka, string collour, int probeg)
        {
            par(marka, collour, probeg);

        }
        public abstract void Print();

        public virtual void print()
        {
            Console.WriteLine("Марка моей машины " + Marka + ". Цвет моей тачки - " + Collour + ". У нее " + Probeg + " пробег");
        }

        public void Razdel() //разделялка
        {
            Console.WriteLine("--------------");
        }
 
    }
}

