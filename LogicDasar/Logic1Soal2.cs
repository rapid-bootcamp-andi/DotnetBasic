using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal2
    {
        public Logic1Soal2()
        {
        }

        public static void CetakData(int n)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    if (i == 0)
                    {
                        a = 1;
                        Console.Write(a + "\t");
                    }
                    else
                    {
                        Console.Write(a + "\t");
                    }
                }
                else
                {
                    b = a * 3;
                    Console.Write(b + "\t");
                    a = b - i;
                }

            }
            Console.WriteLine(" ");
        }
    }
}
