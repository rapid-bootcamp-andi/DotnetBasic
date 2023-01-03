using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic1Soal3
    {
        public Logic1Soal3()
        {
        }

        public static void CetakData(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i <= 0)
                {
                    Console.Write(i + "\t");
                }
                else
                {
                    int hasil = i * 2;
                    Console.Write(hasil + "\t");
                }
            }
            Console.WriteLine(" ");
        }
    }
}
