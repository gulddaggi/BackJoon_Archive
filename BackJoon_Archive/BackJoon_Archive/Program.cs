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
            string prob = Console.ReadLine();
            int[] count = new int[10];
            for (int i = 0; i < count.Length; i++)
			{
                count[i] = 0;
			}

            for (int i = 0; i < prob.Length; i++)
			{
                int tmp = int.Parse(prob[i].ToString());
                if (tmp == 6 || tmp == 9)
                {
                    if (count[6] > count[9])
                    {
                        count[9] += 1;
                    }
                    else if (count[6] < count[9])
                    {
                        count[6] += 1;
                    }
                    else
                    {
                        count[tmp] += 1;
                    }
                }
                else
                {
                    count[tmp] += 1;
                }
			}

            int ans = 0;
            for (int i = 0; i < count.Length; i++)
			{
                if(count[i] > ans)
                {
                    ans = count[i];
                }
			}

            Console.WriteLine(ans);
        }
    }
}
