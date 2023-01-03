using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic2Soal5
    {
        public Logic2Soal5()
        {
        }

        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int a = 1;
                int b = 1;
                int c = 1;
                int d = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n - 1 && i - j <= 0 || i - j >= 0 && i + j <= n - 1)
                    {
                        Console.Write(a + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                    d = a + b + c;
                    a = b;
                    b = c;
                    c = d;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
