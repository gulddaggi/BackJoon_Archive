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
            string[] nums = Console.ReadLine().Split();
            int[] prob = new int[count];
            int target = int.Parse(Console.ReadLine());
            int ans = 0;
            int tmp = prob.Length;

            if (tmp > target)
            {
                tmp = target;
            }

            for (int i = 0; i < tmp; i++)
			{
                prob[i] = int.Parse(nums[i]);
			}

            Array.Sort(prob);

            for (int i = 0; i < tmp; i++)
			{
                for (int j = i+1; j < tmp; j++)
			    {
                    if (prob[i] + prob[j] == target)
                    {
                        ++ans;
                    }
                    else if(prob[i] + prob[j] > target)
                    {
                        break;
                    }
			    }
			}

            Console.WriteLine(ans);
        }
    }
}
