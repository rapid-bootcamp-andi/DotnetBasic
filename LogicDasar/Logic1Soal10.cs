using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal10
    {
        public Logic1Soal10()
        {
        }

        public static void CetakData(int n)
        {
            int[] deret = new int[n];
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    Console.Write(i + "\t");
                }
                else
                {
                    a = i * i * i;
                    Console.Write(a + "\t");
                }

            }
            Console.WriteLine("\n");
        }
    }
}
