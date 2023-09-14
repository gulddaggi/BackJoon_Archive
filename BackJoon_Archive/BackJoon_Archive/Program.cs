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
            while (true)
        	{
                string prob = Console.ReadLine();
                if(prob.Length == 1)
                {
                    if (prob[0] == '0')
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("yes");
                        continue;
                    }
                }

                int center = (prob.Length / 2) + 1;
                for (int i = 0; i < center; i++)
			    {
                    if (prob[i] != prob[prob.Length-i-1])
                    {
                        Console.WriteLine("no");
                        break;
                    }
                    else
                    {
                        if(i == center-1) 
                        {    
                            Console.WriteLine("yes");
                            break;
                        }
                    }
                }
	        }
        }
    }
}
