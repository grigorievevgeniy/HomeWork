using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Bitcoin
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1.11;
            int peopleCount = 60;
            int totalMoney = (int)(amount * peopleCount + 0.5);
            Console.WriteLine(totalMoney);
        }
    }
}
