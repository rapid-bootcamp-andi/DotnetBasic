using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal1
    {
        public Logic1Soal1()
        {
        }

        public static void CetakData(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(" ");
        }
    }
}
