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
            int a = int.Parse(prob[0]);
            int b = int.Parse(prob[1]);
            Console.WriteLine(a * b);
        }
    }
}
