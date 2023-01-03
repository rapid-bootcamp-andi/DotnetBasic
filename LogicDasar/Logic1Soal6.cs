using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal6
    {
        public Logic1Soal6()
        {
        }

        public static void CetakData(int n)
        {
            int[] deret = new int[n];
            int a = 0;

            for (int i = 0; i <= 99; i++)
            {
                int bil = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        bil = bil + 1;
                    }
                }
                if (bil == 2)
                {
                    a += 1;
                    if (a <= n)
                    {
                        Console.Write(i + "\t");
                    }
                    else
                    {
                        i = 99;
                    }

                }
            }
            Console.WriteLine(" ");
        }
    }
}
