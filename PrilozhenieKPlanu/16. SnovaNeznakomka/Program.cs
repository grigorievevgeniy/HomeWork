using System;
using System.Text;
using System.IO;

namespace _16.SnovaNeznakomka
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string result = string.Empty;

            char[] d = { '\r', '\n' };

            text = File.ReadAllText("234.txt", Encoding.Default);

            string[] lines = text.Split(d, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("push"))
                {
                    result += lines[i].Remove(0, 5);
                }
                if (lines[i].StartsWith("pop"))
                {
                    int x = Convert.ToInt32(lines[i].Remove(0, 4));
                    result = result.Remove(result.Length - x);
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
