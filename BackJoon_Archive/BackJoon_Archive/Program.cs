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
            double a;
            double b;
            string num;
            num = Console.ReadLine();
            a = uint.Parse(num.Split(' ')[0]);
            b = int.Parse(num.Split(' ')[1]);
            Console.WriteLine(a / b);
        }
    }
}
