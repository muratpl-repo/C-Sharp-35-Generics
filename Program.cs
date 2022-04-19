using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83DersGenerics //Bi metota gonderilen degerlerin turlerini genellestirmeye yarar..
{
    class Program
    {
        static void YazdirGeneric<T>(T deger) //Burada dönus tiplerini T olarak genelestirdik ve kod fazlaligindan kurtulduk...
        {
            Console.WriteLine(deger);
        }

        static void Main(string[] args)
        {
            YazdirGeneric<int>(5);
            YazdirGeneric<double>(5.4);
            YazdirGeneric<string>("Kaan Academy");
            YazdirGeneric<bool>(false);
        }
    }
}
