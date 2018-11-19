using System;

namespace _10.ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }

        static void WriteBoard(int st)
        {
            int even = 1;
            for (int i = 0; i < st; i++)
            {
                for (int j = 0; j < st; j++)
                {
                    if (even % 2 == 1) Console.Write("$");
                    else Console.Write(".");
                    even++;
                }
                if (st % 2 == 0) even++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
