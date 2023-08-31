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
            string[] prob = Console.ReadLine().Split(' ');
            int M = int.Parse(prob[0]);
            int N = int.Parse(prob[1]);
            char[,] chess = new char[M, N];
            int count = 0;
            int ans = 50 * 50;

            for (int i = 0; i < M; i++)
			{
                string line = Console.ReadLine();

                for (int j = 0; j < N; j++)
			    {
                    chess[i, j] = line[j];
    			}
			}

            for (int i = 0; i < M; i++)
			{
                count = 0;
                if (i + 8 > M)
                {
                    continue;
                }

                for (int j = 0; j < N; j++)
    			{
                    count = 0;
                    if (j + 8 > N)
                    {
                        count = 0;
                        continue;
                    }

                    char a, b; 
                    if (chess[i, j] == 'W')
                    {
                        a = 'W';
                        b = 'B';
                    }
                    else
                    {
                        a = 'B';
                        b = 'W';
                    }

                    for (int x = 0; x < 2; x++)
			        {
                        if(x == 1)
                        {
                            char tmp = a;
                            a = b;
                            b = tmp;
                        }

                        for (int k = i; k < i+8; k++)
			            {
                            for (int l = j; l < j+8; l++)
        	                {
                                if (k % 2 == i % 2)
                                {
                                    if (l % 2 == j % 2)
                                    {
                                        if(chess[k, l] != a) count += 1;
                                    }
                                    else
                                    {
                                        if(chess[k, l] != b) count += 1;
                                    }
                                }
                                else
                                {
                                    if (l % 2 == j % 2)
                                    {
                                        if(chess[k, l] != b) count += 1;
                                    }
                                    else
                                    {
                                        if(chess[k, l] != a) count += 1;
                                    }
                                }       
            	            }
    			        }
                        ans = Math.Min(ans, count);   
                        count = 0;
			        }                
    			}
			}
            Console.WriteLine(ans);
        }
    }
}
