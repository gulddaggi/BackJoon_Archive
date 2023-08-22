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
            int[] num = new int[10];
            int tmp = 1;

            for (int i = 0; i < num.Length; i++)
			{
                num[i] = 0;
			}

            for (int i = 0; i < 3; i++)
			{
                tmp *= int.Parse(Console.ReadLine());
			}

            string ans = tmp.ToString();

            for (int i = 0; i < ans.Length; i++)
			{
                int index = int.Parse(ans[i].ToString());
                num[index] += 1;
			}

            for (int i = 0; i < num.Length; i++)
			{
                Console.WriteLine(num[i]);
			}
        }
    }
}
