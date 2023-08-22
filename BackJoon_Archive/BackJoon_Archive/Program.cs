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
            int a, b;
            string prob;
            prob = Console.ReadLine();
            a = int.Parse(prob.Split(' ')[0]);
            b = int.Parse(prob.Split(' ')[1]);
            if (a < b)
            {
                Console.WriteLine('<');
            }
            else if (a > b)
            {
                Console.WriteLine('>');
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
