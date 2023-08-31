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
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] prob = Console.ReadLine().Split(' ');
                int floor = int.Parse(prob[0]);
                int rooms = int.Parse(prob[1]);
                int guest = int.Parse(prob[2]);
                rooms = (guest % floor == 0) ? (guest / floor) : (guest / floor) + 1;
                floor = (guest % floor == 0) ? (floor) : (guest % floor);
                Console.WriteLine(floor * 100 + rooms);
            }
        }
    }
}
