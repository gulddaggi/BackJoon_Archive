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
            if(int.Parse(prob[0]) == 1)
            {
                int thr = 1;
                for (int i = 1; i < prob.Length; i++)
			    {
                    if (int.Parse(prob[i]) != ++thr)
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
			    }
                Console.WriteLine("ascending");
            }
            else if(int.Parse(prob[0]) == 8)
            {
                int thr = 8;
                for (int i = 1; i < prob.Length; i++)
			    {
                    if (int.Parse(prob[i]) != --thr)
                    {
                        Console.WriteLine("mixed");
                        return;
                    }
			    }
                Console.WriteLine("descending");
            }
            else
            {
                Console.WriteLine("mixed");
            }
        }
    }
}
