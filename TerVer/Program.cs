using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerVer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Бросаются две игральные кости." +
                " Определить вероятность того, что: а) сумма числа очков не превосходит N");

            int NumberOfPointCube = 6; //  коллво очков  на  кубике

            int countСube = 2; // кол-во  кубиков

            int N = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите N");
                    N = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    continue;
                }
            }

            double P = 0;

            int[,] massivA = new int[NumberOfPointCube, NumberOfPointCube];

            // заполним массив 
            int n = 0;  //  число всех   элементарных равновозможных исходов
            int m = 0;  // m – число исходов, благоприятствующих осуществлению события A

            for (int i = 1; i <= massivA.GetLength(1); i++)
            {
                for (int j = 1; j <= massivA.GetLength(0); j++)
                {
                    massivA[i-1, j-1] = i + j;
                    n++;

                    if (massivA[i-1, j-1] <= N)
                    {
                        m++;
                    }
                }
            }

            P = (double) m / n;

            Console.WriteLine("\n Матрица возможных вариантов" );

            // выведем  - для наглядности 

            for (int i = 0; i < massivA.GetLength(1); i++)
            {
                for (int j = 0; j < massivA.GetLength(0); j++)
                {
                   Console.Write (  massivA[i, j] + " " );
                }
                Console.WriteLine();
            }

            Console.WriteLine("n= " + n);

            Console.WriteLine("m= " + m+ "\n");

            Console.WriteLine("вероятность выпадения  суммы числа очков " +
                "которые  не превосходит " +N + " = " + Math.Round(P, 4) * 100 + "%");

            Console.Read();

        }
    }
}
