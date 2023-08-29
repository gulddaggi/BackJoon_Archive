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
            int a = 1;
            int b = 1;

            while (true)
	        {
                string tmp = Console.ReadLine();
                string[] prob;
                if (tmp == null)
            	{
                    break;
            	}
                else
	            {
                    prob = tmp.Split(' ');
            	}
                a = int.Parse(prob[0]);
                b = int.Parse(prob[1]);
                if ((a <= 0 || b >= 10))
                {
                    break;
                }
                Console.WriteLine(a + b);
        	}
        }
    }
}
