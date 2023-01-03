using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal5
    {
        public Logic1Soal5()
        {
        }

        public static void CetakData(int n)
        {
            int[] deret = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i < 3)
                {
                    deret[i] = 1;
                }
                else
                {
                    deret[i] = deret[i - 1] + deret[i - 2] + deret[i - 3];
                }
                Console.Write(deret[i] + "\t");
            }
            Console.WriteLine(" ");
        }
    }
}
