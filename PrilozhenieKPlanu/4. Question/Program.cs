using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Question
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(GetSquare(42));
        }

        private static void Print(int x)
        {
            Console.WriteLine(x);
        }

        private static int GetSquare(int ch)
        {
            return ch * ch;
        }
    }
}
