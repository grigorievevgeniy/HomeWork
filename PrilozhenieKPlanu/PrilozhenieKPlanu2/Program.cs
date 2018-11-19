using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrilozhenieKPlanu2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("< name >:< email >");
            list.Add("< ndfsdame >:< email >");
            list.Add("< name >:< email >");
            list.Add("< nxcdfame >:< email >");
            list.Add("< xcvname >:< email >");
            list.Add("< cvxcname >:< email >");
            list.Add("< nzxcame >:< email >");
            list.Add("< name >:< email >");

            Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
            dict2 = OptimizeContacts(list);

            Console.ReadKey();
        }

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string key;
            foreach (string item in contacts)
            {
                key = Convert.ToString(item[2]) + Convert.ToString(item[3]);
                if (dict.ContainsKey(key)) dict[key].Add(item);
                else
                {
                    dict.Add(key, new List<string>() { item });

                    //dict.Add(key, new List<string>());
                    //dict[key].Add(item);
                }
            }
            return dict;
        }
    }
}
