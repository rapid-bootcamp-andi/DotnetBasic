using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic2Soal6
    {
        public Logic2Soal6()
        {
        }

        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int a = 1;
                int b = 1;
                int c = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i + j <= n - 1 && i - j >= 0 || i - j <= 0 && i + j >= n - 1)
                    {
                        Console.Write(a + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
