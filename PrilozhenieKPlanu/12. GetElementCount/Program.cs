using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GetElementCount
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int GetElementCount(int[] items, int itemToFind)
        {
            int count = 0;

            foreach (int item in items)
                if (item == itemToFind) count++;

            return count;
        }

    }
}
