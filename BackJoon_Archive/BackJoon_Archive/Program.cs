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
            string prob;
            prob = Console.ReadLine();
            int max_count = -1;
            char ans = prob[0];
            for (int i = 0; i < prob.Length; i++)
			{                    
                int count = 0;
                int a = prob[i];

                if(a > 91)
                {
                    a = a - 32;
                }

                for (int j = i+1; j < prob.Length; j++)
			    {
                    int b = prob[j];

                    if(b > 91)
                    {
                        b = b - 32;
                    }

                    if(a == b)
                    {
                        ++count;
                    }

			    }

                if (count > max_count)
	            {
                    max_count = count;
                    ans = prob[i];
	            }

                else if (count == max_count)
                {
                    ans = '?';
                }
			}
            Console.WriteLine(ans.ToString().ToUpper());
        }
    }
}
