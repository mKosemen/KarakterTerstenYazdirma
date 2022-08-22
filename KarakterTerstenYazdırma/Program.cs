using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterTerstenYazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin;
            string[] veri;
            Console.WriteLine("Bir metin giriniz.");
            metin = Console.ReadLine();
            veri = metin.Trim().Split(' ');

            for (int i = 0; i < veri.Length; i++)
            {
                veri[i] = veri[i].Remove(0, 1) + (veri[i])[0];
            }
            Console.WriteLine(String.Join(" ",veri));

            Console.ReadLine();
        }
    }
}
