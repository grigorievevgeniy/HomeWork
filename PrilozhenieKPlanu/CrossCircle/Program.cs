using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCircle
{
    class Program
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Check("XXX OO. ...");
            Check("OXO XO. .XO");
            Check("OXO XOX OX.");
            Check("XOX OXO OXO");
            Check("... ... ...");
            Check("XXX OOO ...");

            Console.ReadKey();
        }

        private static void Check(string description)
        {
            Console.WriteLine(description.Replace(" ", "\r\n"));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static GameResult GetGameResult(Mark[,] field)
        {


            if (WinComb(field, Mark.Cross))
                if(WinComb(field, Mark.Circle))
                    return GameResult.Draw;

            if (WinComb(field, Mark.Cross))
                return GameResult.CrossWin;

            if (WinComb(field, Mark.Circle))
                return GameResult.CircleWin;

            return GameResult.Draw;
        }


        
        private static bool WinComb(Mark[,] field, Mark mark)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (field[i, 0] == mark && field[i, 1] == mark && field[i, 2] == mark ||
                    field[0, i] == mark && field[1, i] == mark && field[2, i] == mark)
                    return true;
            }
            if (field[0, 0] == mark && field[1, 1] == mark && field[2, 2] == mark ||
                field[0, 2] == mark && field[1, 1] == mark && field[2, 0] == mark)
                return true;
            return false;
        }

        // Метод для поля любого размера (квадратного)
        private static bool WinComb2(Mark[,] field, Mark mark, int size)
        {
            int count;

            for (int i = 0; i < size; i++)
            {
                count = 0;
                for (int j = 0; j < size; j++)
                {
                    if (field[i, j] == mark) count++;
                }
                if (count == size) return true;
            }

            for (int i = 0; i < size; i++)
            {
                count = 0;
                for (int j = 0; j < size; j++)
                {
                    if (field[j, i] == mark) count++;
                }
                if (count == size) return true;
            }

            count = 0;
            for (int i = 0; i < size; i++)
            {
                if (field[i, i] == mark) count++;
            }
            if (count == size) return true;

            count = 0;
            for (int i = 0; i < size; i++)
            {
                if (field[i, size - 1 - i] == mark) count++;
            }
            if (count == size) return true;

            return false;
        }

        private static Mark[,] CreateFromString(string description)
        {
            //private static Mark[,] CreateFromString(string str)
            //{
            //    var field = str.Split(' ');
            //    var ans = new Mark[3, 3];
            //    for (int x = 0; x < field.Length; x++)
            //    for (var y = 0; y < field.Length; y++)
            //        ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            //    return ans;
            //}

            Mark[,] mark = new Mark[3, 3];
            int x = 0, y = 0;
            description = description.Replace(" ", "");

            for (int i = 0; i < description.Length; i++)
            {
                if (description[i] == 'X') mark[y, x] = Mark.Cross;
                else if (description[i] == 'O') mark[y, x] = Mark.Circle;
                else mark[y, x] = Mark.Empty;

                x++;
                if (x == 3)
                {
                    x = 0;
                    y++;
                }
            }

            return mark;
        }
    }
}
