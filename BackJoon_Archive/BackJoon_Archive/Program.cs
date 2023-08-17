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
            string line;
            int num;
            line = Console.ReadLine();
            num = line.Split(' ').Length;

            if (line[0] == ' ')
	        {
                --num;
	        }

            if (line[line.Length - 1] == ' ')
	        {
                --num;
        	}

            Console.WriteLine(num);
        }
    }
}
