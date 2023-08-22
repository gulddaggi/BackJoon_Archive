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
            prob = Console.ReadLine();
            int ans = 0;
            for (int i = 0; i < 5; i++)
			{
                int tmp = int.Parse(prob.Split(' ')[i]);
                ans += tmp * tmp;
			}
            Console.WriteLine(ans % 10);
        }
    }
}
