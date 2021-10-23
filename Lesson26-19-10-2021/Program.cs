using System;
using System.Linq;
using System.Collections.Generic;
namespace Lesson26_19_10_2021
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random(10);
            int n = random.Next();
            Console.WriteLine($"Number: {n}");
            var reversmas = n.ToString().ToArray().Reverse().ToArray();
            Console.Write("Reverse number: ");
            WriteArray(reversmas);
            Console.Write($"\n\nArray: ");
            int[] mas = new[] { 1, 2, 3, 4, 5, 1, 2, -2, -3, -23, 4 };
            if (mas.Length == 0)
                Console.WriteLine(mas);
            WriteArray(mas);
            var count = mas.Where(p => p > 0).Count();
            var sum = mas.Where(mas => mas < 0).Sum();
            double[] result = new double[] { count, sum };
            Console.Write($"\nCount positive and Sum nagative : ");
            WriteArray(result);
            string[] array1 = new string[] { "Glasses", "Eyes", "Monocles", "Ere", "Rf" };
            Console.Write($"\n\nArray string: ");
            WriteArray(array1);
            Console.Write($"\nSort for length of Array string: ");
            var resultArray1 = array1.OrderBy(x => x.Length).ToArray();
            WriteArray(resultArray1);
            double[] array2 = new[] { -2,-2, -2, -234.8, -2, -2, -2 };
            double a = array2[2];
            Console.Write($"\n\nArray double: ");
            WriteArray(array2);
            var resultArray2 = array2.SkipWhile(w => w == a ).Take(1);
            foreach (var i in resultArray2)
                Console.Write($"\nResult: {i}");
        }
         static void WriteArray<T>(T[] array )
        {
            foreach (var item in array)
                Console.Write($" {item} ");
        }
    }
}
