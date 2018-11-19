using System;

namespace _9.Border
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        static void WriteTextWithBorder(string line)
        {
            Console.Write("+");
            for (int i = 0; i < line.Length + 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            Console.WriteLine("| " + line + " |");
            Console.Write("+");
            for (int i = 0; i < line.Length + 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
