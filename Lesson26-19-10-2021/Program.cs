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
            var reversmas = n.ToString().ToArray().Reverse();
            Console.Write("Reverse number: ");
            foreach (var i in reversmas)
                Console.Write($" {i} ");
            Console.Write($"\n\nArray: ");
            int[] mas = new[] { 1, 2, 3, 4, 5, 1, 2, -2, -3, -23, 4 };
            if (mas.Length == 0)
                Console.WriteLine(mas);
            foreach (var i in mas)
                Console.Write($" {i} ");
            var count = mas.Where(p => p > 0).Count();
            var sum = mas.Where(mas => mas < 0).Sum();
            double[] result = new double[] { count, sum };
            Console.Write($"\nCount positive and Sum nagative : ");
            foreach (var i in result)
                Console.Write($" {i} ");
            string[] array1 = new string[] { "Glasses", "Eyes", "Monocles", "Ere", "Rf" };
            Console.Write($"\n\nArray string: ");
            foreach (var i in array1)
                Console.Write($" {i} ");
            Console.Write($"\nSort for length of Array string: ");
            var resultArray1 = array1.OrderBy(x => x.Length);
            double[] array2 = new[] { -2, -2, 4.23, -2, -2, -2 };
            double a = array2[0];
            Console.Write($"\n\nArray double: ");
            foreach (var i in array2)
                Console.Write($" {i} ");
            var resultArray2 = array2.SkipWhile(w => w == a).Take(1);
            foreach (var i in resultArray2)
                Console.Write($"\nResult: {i}");
        }
    }
}
