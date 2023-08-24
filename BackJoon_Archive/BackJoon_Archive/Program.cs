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
            int index = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
			{
                string ans = index + " * " + i + " = " + (i * index);
                Console.WriteLine(ans);
			}
        }
    }
}
