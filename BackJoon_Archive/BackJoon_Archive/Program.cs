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
            string[] prob = new string[count];

            for (int i = 0; i < count; i++)
			{
                prob[i] = Console.ReadLine();
			}

            Array.Sort(prob);
            List<string> tmp = prob.ToList();
            List<string> ans = new List<string>();
            List<string> minList = new List<string>();

            while(tmp.Count > 0)
            {
                minList.Add(tmp[0]);
                for (int i = 0; i < tmp.Count; i++)
			    {
                    if (tmp[i].Length < minList[0].Length)
                    {
                        minList.Clear();
                        minList.Add(tmp[i]);
                    }
                    else if(tmp[i].Length == minList[0].Length)
                    {
                        minList.Add(tmp[i]);
                    }
    			}

                for (int i = 0; i < minList.Count; i++)
		    	{
                    ans.Add(minList[i]);
                    tmp.Remove(minList[i]);
	    		}

                minList.Clear();
            }
            ans = ans.Distinct().ToList();
            for (int i = 0; i < ans.Count; i++)
			{
                Console.WriteLine(ans[i]);
			}
        }
    }
}
