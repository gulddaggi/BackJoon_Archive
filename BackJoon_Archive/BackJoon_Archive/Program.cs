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
            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
			{
                string prob = Console.ReadLine();
                int numCount = int.Parse(prob.Split(' ')[0]);
                prob = prob.Split(' ')[1];
                string ans = "";

                for (int j = 0; j < prob.Length; j++)
			    {
                    for (int k = 0; k < numCount; k++)
			        {
                        ans += prob[j];
			        }
			    }
                Console.WriteLine(ans);
			}
        }
    }
}
