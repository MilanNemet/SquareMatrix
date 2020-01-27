using System;
using static Matrix; 

namespace ConsoleApp1
{
    public static class Program
    {

        static void Main()
        {
            //Thread.Sleep(5000);
            //Console.WriteLine("start");
            //var list = new List<byte>();
            //for (byte i = 0; i < 255; i++)
            //{
            //    for (int j = 0; j < 100000; j++)
            //    {
            //        list.Add(i);
            //    }
            //    Thread.Sleep(100);
            //}
            //Console.WriteLine();
            //Console.Write("Press any key to continue...");
            //Console.ReadKey(true);

            int[][] _matrix2x2 = new int [][] { new int[]{ 1, 2 }, new int[] { 3, 4 } };
            int[][] _matrix3x3 = new int[][] { new int[] { 1, 0, 11 }, new int[] { 3, 6, 5 }, new int[] { 5, 6, 7 } };
            int[][] _matrix4x4 = new int[][] { new int[] { 1, 2, 11, 5 }, new int[] { 3, 6, 5, 6 }, new int[] { 5, 6, 7, 8 }, new int[] { 1, 2, 11, 0 } };

            Console.WriteLine(Determinant(_matrix2x2));
            Console.WriteLine(Determinant(_matrix3x3));
            Console.WriteLine(Determinant(_matrix4x4));
        }
    }
}