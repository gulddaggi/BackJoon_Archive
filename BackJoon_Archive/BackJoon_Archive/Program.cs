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
            uint a;
            int b;
            string prob;
            prob = Console.ReadLine();
            a = uint.Parse(prob.Split(' ')[0]);
            b = int.Parse(prob.Split(' ')[1]);

            Console.WriteLine(a + b);
            
        }
    }
}
