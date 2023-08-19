using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_Archive
{
    class Program
    {
        static void Main(string[] args)
        {
            string prob;
            prob = Console.ReadLine().ToUpper();
            int max_count = -1;
            char ans = prob[0];
            Dictionary<char, int> table = new Dictionary<char, int>();

            for (int i = 0; i < 26; i++)
			{
                char tmp = (char)((int)'A' + i);
                table.Add(tmp, 0);
			}

            for (int i = 0; i < prob.Length; i++)
			{
                ++table[prob[i]];
			}

            for (int i = 0; i < table.Count; i++)
			{
                char tmp = (char)((int)'A' + i);
                if(table[tmp] > max_count)
                {
                    max_count = table[tmp];
                    ans = tmp;
                }
                else if (table[tmp] == max_count)
                {
                    ans = '?';
                }
			}
            Console.WriteLine(ans);
        }
    }
}
