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
            int[] nums = new int[26];

            for (int i = 97; i < 123; i++)
			{
                for (int j = 0; j < prob.Length; j++)
			    {
                    if (prob[j] == (char)(i))
                    {
                        nums[i-97] += 1;
                    }
			    }   
			}

            for (int i = 0; i < nums.Length; i++)
			{
                Console.Write(nums[i]);
                Console.Write(" ");
			}
        }
    }
}
