using System;

namespace matric1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linii-");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] matr = new int[N, N];

            bool matrIdentitate = true;

            for (int row = 0; row < matr.GetLength(0); row++)

                for (int col = 0; col < matr.GetLength(1); col++)
                {
                    Console.Write($"[{row},{col}]:");
                    matr[row, col] = Convert.ToInt32(Console.ReadLine());

                    if (row != col)
                    {
                        if (matr[row, col] != 0)
                        {
                            matrIdentitate = false;
                        }
                    }
                    else if (matr[row, col] != 1)
                    {
                        matrIdentitate = false;
                    }
                }
            if (matrIdentitate == true)
                Console.WriteLine("Adevarat");
            else
                Console.WriteLine("Fals");


        }
    }
}