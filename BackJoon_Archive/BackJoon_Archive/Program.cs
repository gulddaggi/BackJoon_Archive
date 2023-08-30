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
            for (int i = 0; i < count; i++)
            {
                string prob = Console.ReadLine();
                int tmp = 0;
                int ans = 0;
                for (int j = 0; j < prob.Length; j++)
                {
                    if (prob[j] == 'O')
                    {
                        ++tmp;
                        ans += tmp;
                    }
                    else
                    {
                        tmp = 0;
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
