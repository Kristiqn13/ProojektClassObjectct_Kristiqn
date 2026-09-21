using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProojektClassObjectct_Kristiqn
{
    internal class Carinfo
    {
        private string brand;
        private int year;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (value != "")
                    brand = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900 && value <= 2026)
                    year = value;
            }
        }

        public Carinfo(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public Carinfo(string brand)
        {
            Brand = brand;
            Year = 2026;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Year: " + Year);
        }

        public void ChangeYear(int newYear)
        {
            Year = newYear;
        }
    }
}
