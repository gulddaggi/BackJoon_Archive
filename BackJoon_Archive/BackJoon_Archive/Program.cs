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
            int[] nums = new int[10];
            List<int> sameList = new List<int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
			{
                nums[i] = int.Parse(Console.ReadLine()) % 42;
			}

            for (int i = 0; i < nums.Length; i++)
			{
                int tmp = count;

                if (sameList.Contains(nums[i]))
                {
                    continue;
                }
                for (int j = 1; j < nums.Length; j++)
	    		{
                    if (nums[i] != nums[j])
                    {
                        ++count;
                        sameList.Add(nums[i]);
                        break;
                    }
    			}

                if(tmp != count)
                {
                    continue;
                }
			}

            if(count == 0)
            {
                ++count;
            }
            Console.WriteLine(count);
        }
    }
}
