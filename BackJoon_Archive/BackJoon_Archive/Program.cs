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
            string[] prob = Console.ReadLine().Split(' ');
            string[] prob_num = Console.ReadLine().Split(' ');
            int[] nums = new int[int.Parse(prob[0])];
            int thr = int.Parse(prob[1]);
            for (int i = 0; i < nums.Length; i++)
			{
                nums[i] = int.Parse(prob_num[i]);
                if (nums[i] < thr)
                {
                    Console.Write(nums[i]);
                    Console.Write(" ");
                }
			}
        }
    }
}
