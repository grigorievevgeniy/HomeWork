using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Good_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintGreeting("Student", 10.01));
            Console.WriteLine(PrintGreeting("Bill Gates", 10000000.5));
            Console.WriteLine(PrintGreeting("Steve Jobs", 1));
        }

        private static string PrintGreeting(string name, double salary)
        {
            salary = Math.Ceiling(salary);
            string result = $"Hello, {name}, your salary is {salary} ";
            return result;
        }
    }
}
