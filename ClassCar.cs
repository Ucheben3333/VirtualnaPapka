using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nov3._6._2026
{
    internal class ClassCar
    {
        private string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int godina;
        public int Godina
        {
            get { return godina; }
            set { if (value < 1980) 
            {
                value = 2000;
            }
            godina = value; 
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Godina: {Godina}");
        }
        public ClassCar(string marka, string model, int godina)
        {
            Marka = marka;
            Model = model;
            Godina = godina;
            count++;
        }
        public void sustoqnie()
        {
            if (this.godina > 2020)
            {
                Console.WriteLine("Kolata e nova");
            }
            else
            {
                Console.WriteLine("Kolata e stara");
            }

        }
        static private int count;
        static public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public ClassCar()
        {
            Marka = "";
            Model = "";
            Godina = 0;
        }
    }
}
