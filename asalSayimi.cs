using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaDers
{
    class Program
    {
        static void Main(string[] args)
        { 
            int sayi;
            int sonuc;
            int sayac = 0;
            bool asalMi = true;

            Console.WriteLine("Sayıyı gir;");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < sayi; i++)
            {
                Console.WriteLine(i);
                if (sayi % i == 0)
                {
                    asalMi = false;
                    sayac++;
                }
                else
                {
                    asalMi = true;
                }
               
            }
            if (sayac==0) Console.Write("Evet Asaldır");
            else Console.Write("hayır değil");
}
