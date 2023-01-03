using LogicDasar;

public class MainLogic
{
    public static void Main()
    {
        Console.WriteLine("Masukan Angka :");
        string? input = Console.ReadLine();
        int n = input == null ? 0 : int.Parse(input);

        Console.Write("\nLogic 1 Soal 1 = ");
        Logic1Soal1.CetakData(n);
        Console.Write("\nLogic 1 Soal 2 = ");
        Logic1Soal2.CetakData(n);
        Console.Write("\nLogic 1 Soal 3 = ");
        Logic1Soal3.CetakData(n);
        Console.Write("\nLogic 1 Soal 4 = ");
        Logic1Soal4.CetakData(n);
        Console.Write("\nLogic 1 Soal 5 = ");
        Logic1Soal5.CetakData(n);
        Console.Write("\nLogic 1 Soal 6 = ");
        Logic1Soal6.CetakData(n);
        Console.Write("\nLogic 1 Soal 7 = ");
        Logic1Soal7.CetakData(n);
        Console.Write("\nLogic 1 Soal 8 = ");
        Logic1Soal8.CetakData(n);
        Console.Write("\nLogic 1 Soal 9 = ");
        Logic1Soal9.CetakData(n);
        Console.Write("\nLogic 1 Soal 10 = ");
        Logic1Soal10.CetakData(n);

        Console.Write("\nLogic 2 Soal 1\n");
        Logic2Soal1.CetakData(n);
        Console.Write("\nLogic 2 Soal 2\n");
        Logic2Soal2.CetakData(n);
        Console.Write("\nLogic 2 Soal 3\n");
        Logic2Soal3.CetakData(n);
        Console.Write("\nLogic 2 Soal 4\n");
        Logic2Soal4.CetakData(n);
        Console.Write("\nLogic 2 Soal 5\n");
        Logic2Soal5.CetakData(n);
        Console.Write("\nLogic 2 Soal 6\n");
        Logic2Soal6.CetakData(n);


    }
}
