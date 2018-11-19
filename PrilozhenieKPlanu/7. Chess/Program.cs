using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMove("a1", "d4");
            TestMove("f7", "e7");
            TestMove("f4", "f7");
            TestMove("g2", "h1");

            Console.ReadKey();
        }

        //переделать в соответствии с ТЗ
        private static bool TestMove(string start, string finish)
        {
            //без проверки корректности нотации

            if (start[0] == finish[0] || start[1] == finish[1] ||
                start[0] - finish[0] == start[1] - finish[1] || start[0] + finish[0] == start[1] + finish[1])
                return true;

            return false;

            //if (start[0] == finish[0]) Console.WriteLine("Ход по горизонтали");
            //else if (start[1] == finish[1]) Console.WriteLine("Ход по вертикали");
            //else if (start[0] - finish[0] == start[1] - finish[1] || start[0] + finish[0] == start[1] + finish[1]) Console.WriteLine("Ход по диагонали");
            //else Console.WriteLine("Ход неверный");
        }
    }
}
