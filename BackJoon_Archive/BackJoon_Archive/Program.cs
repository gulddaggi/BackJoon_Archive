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
            int count = int.Parse(Console.ReadLine());
            string prob = Console.ReadLine();
            int ans = 0;
            for (int i = 0; i < count; i++)
			{
                ans += int.Parse(prob[i].ToString());
			}

            Console.WriteLine(ans);
        }
    }
}
