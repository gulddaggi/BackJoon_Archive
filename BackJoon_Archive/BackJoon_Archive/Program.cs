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
            string[] prob;
            for (int i = 0; i < count; i++)
			{
                prob = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(prob[0]) + int.Parse(prob[1]));
			}

        }
    }
}
