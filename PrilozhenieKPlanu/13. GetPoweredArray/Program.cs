using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GetPoweredArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArray(GetPoweredArray(arrayToPower, 1));
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " * ");
            }
            Console.WriteLine();
        }

        static int[] GetPoweredArray(int[] arr, int power)
        {
            double powerD = Convert.ToDouble(power);

            for (int i = 0; i < arr.Length; i++)
                arr[i] = Convert.ToInt32(Math.Pow(Convert.ToDouble(arr[i]), powerD));

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 1; j < power; j++)
            //    {
            //        arr[i] = arr[i] * arr[i];
            //    }
            //}

            return arr;
        }
    }
}
