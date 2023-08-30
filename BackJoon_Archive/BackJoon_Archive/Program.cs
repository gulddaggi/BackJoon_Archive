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
            string[] time = Console.ReadLine().Split(' ');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);
            minute -= 45;
            if (minute < 0)
            {
                if(--hour == -1) hour = 23;
                minute += 60;
            }
            Console.WriteLine(hour.ToString() + " " + minute.ToString());
        }
    }
}
