using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal9
    {
        public Logic1Soal9()
        {
        }

        public static void CetakData(int n)
        {
            int a = 0;
            int b = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    Console.Write(i + "\t");
                    a = i * 3;
                }
                else if (i == 2)
                {
                    Console.Write(a + "\t");

                }
                else
                {
                    b = a * 3;
                    Console.Write(b + "\t");
                    a = b;
                }

            }
            Console.WriteLine(" ");
        }
    }
}
