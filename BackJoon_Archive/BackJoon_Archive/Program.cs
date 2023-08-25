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
            StringBuilder sb = new StringBuilder();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                sb.AppendLine((i + 1).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
