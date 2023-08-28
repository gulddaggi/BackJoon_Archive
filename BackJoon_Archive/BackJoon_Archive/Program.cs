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
            uint count = uint.Parse(Console.ReadLine());
            string[] prob = Console.ReadLine().Split();
            int min = int.Parse(prob[0]);
            int max = int.Parse(prob[0]);

            for (int i = 0; i < count; i++)
            {
                int tmp = int.Parse(prob[i]);

                if (tmp > max)
                {
                    max = tmp;
                }

                if (tmp < min)
                {
                    min = tmp;
                }
            }
            
            Console.Write(min + " " + max);
        }
    }
}
