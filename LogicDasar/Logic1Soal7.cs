using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal7
    {
        public Logic1Soal7()
        {
        }

        public static void CetakData(int n)
        {
            char huruf = 'A';
            // isi array
            for (int i = 0; i < n; i++)
            {
                // genap dulu
                Console.Write(huruf + "\t");
                huruf++;
                
            }

            // print array
            
            Console.WriteLine(" ");
        }
    }
}
