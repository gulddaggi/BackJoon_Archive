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
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
			{
                string ans = "";
                for (int j = 0; j < i+1; j++)
			    {
                    ans += '*';
			    }
                Console.WriteLine(ans.PadLeft(a));
			}
        }
    }
}
