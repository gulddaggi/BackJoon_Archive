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
            string[] prob = new string[count];
            string[] ans = new string[count];
            for (int i = 0; i < count; i++)
			{
                prob[i] = Console.ReadLine();
			}
            List<string> minList = new List<string>();
            for (int i = 0; i < prob.Length; i++)
			{
                minList.Add(minList[i]);

                for (int j = i+1; j < length; j++)
			    {
                    if (minList[0].Length > prob[j].Length)
                    {
                        minList.Clear();
                        minList.Add(prob[j]);
                    }
                    else if(minList[0].Length == prob[j].Length)
                    {
                        if (minList[0])
                        {

                        }
                        for (int k = 0; k < minList[0].Length; k++)
			            {
                            // 중복 삭제

                            // 추가
                            if(minList[0][k] < prob[j][k])
                            {
                                minList.Add(prob[j]);
                            }
                            // 위치 변경
                            else if (minList[0][k] > prob[j][k])
                            {
                                minList.Sort
                            }
			            }
                    }
                    
    			}

                for (int x = 0; x < minList.Count; x++)
			    {
                    ans[i + x] = minList[x];
			    }
                minList.Clear();

			}
        }
    }
}
