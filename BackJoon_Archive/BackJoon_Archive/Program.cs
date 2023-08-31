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
            string prob = Console.ReadLine();
            for (int i = 97; i < 123; i++)
			{
                for (int j = 0; j < prob.Length; j++)
			    {
                    if (prob[j] == (char)i)
                    {
                        Console.Write(j);
                        Console.Write(" ");
                        break;
                    }

                    if(j == prob.Length - 1)
                    {
                        Console.Write(-1);
                        Console.Write(" ");
                    }
    			}
			}
        }
    }
}
