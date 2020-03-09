using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._03._20_ahmet_calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev evim = new Ev();
            Console.WriteLine("Kaç katlıev?");
            evim.SetKat(int.Parse(Console.ReadLine()));
            Console.WriteLine("Kaç Odalı?");
            evim.SetOda(int.Parse(Console.ReadLine()));
            Console.WriteLine("Kaç metrekare ev?");
            evim.SetMet(int.Parse(Console.ReadLine()));


            Console.ReadKey();

        }
    }

    class Ev
    {
        int kat;
        int oda;
        int met;

        public int GetKat()
        {
            return kat;
        }

        public void SetKat(int value)
        {
            kat = Math.Abs(value);
        }

        //int odaya ctrl+. yaptıktan sonra public int'li olan değerede ctrl+. yapıyoruz.
        public int GetOda()
        {
            return oda;
        }

        public void SetOda(int value)
        {
            oda = Math.Abs(value);
        }

        public int GetMet()
        {
            return met;
        }

        public void SetMet(int value)
        {
            if (value < 0)
            {
                FileStream fs = new FileStream(@"d:\hata.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write($"Oda Sayısına Negatif değer girildi, girilen tarih: {DateTime.Now} Girilen yanlış değer: {value}");
                fs.Flush();
                sw.Close();
                fs.Close();
                Console.WriteLine("YANLIŞ DEĞER!!!");
            }
            met = value;
        }
    }
}
