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
            string[] prob = Console.ReadLine().Split();
            int num = int.Parse(prob[0]);
            int maximum = int.Parse(prob[1]);
            int[,] stu_list = new int[6, 2];
            int ans = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    stu_list[i, j] = 0;
                }
            }

            for (int i = 0; i < num; i++)
            {
                string[] tmp = Console.ReadLine().Split();
                ++stu_list[int.Parse(tmp[1])-1, int.Parse(tmp[0])];
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ans += stu_list[i, j] / maximum;
                    if (stu_list[i, j] % maximum != 0)
                    {
                        ++ans;
                    }
                }
            }


            Console.WriteLine(ans);

        }
    }
}
