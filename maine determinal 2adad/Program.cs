using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maine_determinal_2adad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] array = new double[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("element {0},{1} = ", i + 1, j + 1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Calc(array);
        }
        private static void Calc(double[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i + 1, j + 1] = (array[i, j] + array[i, j + 1] +
                    array[i, j + 2] + array[i + 1, j] + array[i + 2, j] +
                    array[i + 2, j + 1] + array[i + 2, j + 2] + array[i + 1, j + 2]) / 8;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("new element {0},{1} = {2} ", i + 1, j + 1, array[i, j]);
                }
            }
        }
    }
}
