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
            string[] prob;
            int a, b;

            while (true)
        	{
                prob = Console.ReadLine().Split(' ');
                a = int.Parse(prob[0]);
                b = int.Parse(prob[1]);
                if (a == 0 && b == 0)
                {
                    break;
                }

                Console.WriteLine(a + b);
        	}
        }
    }
}
