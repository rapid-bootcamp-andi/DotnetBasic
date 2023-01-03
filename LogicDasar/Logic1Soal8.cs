using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal8
    {
        public Logic1Soal8()
        {
        }

        public static void CetakData(int n)
        {
            char huruf = 'A';
            int angka = 2;
            // isi array
            for (int i = 0; i < n; i++)
            {
                // genap dulu
                if (i % 2 == 0)
                {
                    Console.Write(huruf + "\t");
                }
                else
                {
                    Console.Write(angka + "\t");
                    angka += 2;
                }
                huruf++;
            }

            // print array
            Console.WriteLine(" ");
        }
    }
}
