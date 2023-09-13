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
            int num = int.Parse(Console.ReadLine());
            string[] prob = Console.ReadLine().Split();
            int target = int.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 0; i < prob.Length; i++)
            {
                if (int.Parse(prob[i]) == target)
                {
                    ++ans;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
