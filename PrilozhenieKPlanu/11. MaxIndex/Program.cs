using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.MaxIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxIndex(new double[] { 1, 2, 3 }));
            Console.WriteLine(MaxIndex(new double[] { }));
            Console.WriteLine(MaxIndex(new double[] { 1 }));
            Console.WriteLine(MaxIndex(new double[] { 0, 100, 1, 2, 100 }));
            Console.WriteLine(MaxIndex(new double[] { 1, 2, 3, 100, 4, 5, 6 }));
            Console.WriteLine(MaxIndex(new double[] { 100, 100, 100, 100 }));
            //Console.WriteLine(MaxIndex(CreateSecretBigArray1()));
            //Console.WriteLine(MaxIndex(CreateSecretBigArray2()));
        }

        static int MaxIndex(double[] array)
        {
            if (array.Length == 0) return -1;

            double max = array[0];

            for (int i = 1; i < array.Length; i++)
                if (max < array[i]) max = array[i];

            for (int i = 0; i < array.Length; i++)
                if (max == array[i]) return i;

            return 0; //до этой строчки код не дойдет.
        }

    }
}
