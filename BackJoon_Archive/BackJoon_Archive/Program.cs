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
            int[] array = new int[9];
            int ans = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
			{
                array[i] = int.Parse(Console.ReadLine());
			}

            for (int i = 0; i < array.Length; i++)
			{
                if (array[i] > ans)
                {
                    ans = array[i];
                    index = i;
                }
			}

            Console.WriteLine(ans);
            Console.WriteLine(index + 1);
        }
    }
}
