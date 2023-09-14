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
            int prob = int.Parse(Console.ReadLine());
            int count = 0;
            int ans = 666;

            while (true)
        	{
                if (ans.ToString().Contains("666"))
                {
                    ++count;
                }

                if (count == prob)
                {
                    Console.WriteLine(ans);
                    break;
                }

                ++ans;
        	}
        }
    }
}
