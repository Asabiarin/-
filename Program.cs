using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ilk vize notunuzu giriniz.");
            string vize1s = Console.ReadLine();
            Console.WriteLine("ikinci vize notunuzu giriniz");
            string vize2s = Console.ReadLine();
            Console.WriteLine("final notunuzu giriniz");
            string finals = Console.ReadLine();

            int vize1 = Int32.Parse(vize1s);
            int vize2 = Int32.Parse(vize2s);
            int final = Int32.Parse(finals);
            int ortalama = (vize1 / 4 + vize2 / 4 + final / 2);

            if (ortalama < 20)
            {
                Console.WriteLine("F aldınız");
            }
            if ( 20<= ortalama & ortalama < 40 )
            {
                Console.WriteLine("D aldınız");
            }
            if (40 <=  ortalama & ortalama < 60)
            {
                Console.WriteLine("C aldınız");
            }
            if (60 <= ortalama & ortalama < 80)
            {
                Console.WriteLine("B aldınız");
            }
            if (100<= ortalama & ortalama <=80)
            {
                Console.WriteLine("A aldınız");
            }
            Console.ReadLine();
        }
    }
}
