using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;

            line = Console.ReadLine();
            int T = Convert.ToInt32(line);

            for (int t_i = 0; t_i < T; t_i++)
            {
                line = Console.ReadLine();
                int N = Convert.ToInt32(line);

                String out_ = Solve(N);
                Console.Out.WriteLine(out_);

            }
            Console.ReadLine();
        }

        static String Solve(int N)
        {
            List<int> list = new List<int> ();

            for (int k = 44; k<1000000;k++)
            {
                string kstring = k.ToString();
                if ((kstring.Contains("4") || kstring.Contains("5")) && kstring.Contains("1") && kstring.Contains("2") && kstring.Contains("3") && kstring.Contains("6") && kstring.Contains("7") && kstring.Contains("8") && kstring.Contains("9") && kstring.Contains("0"))

                { 
                    if(k.ToString().Length %2 ==0)
                    {

                        int m  = k;
                        int temp = m;
                        int r;
                        int sum = 0;
                        while (m > 0)
                        {
                            r = m % 10;
                            sum = (sum * 10) + r;
                            m = m / 10;
                        }

                        if(temp == sum)
                        {
                            list.Add(k);
                        }

                    }

                }
           
                }
            return list.ElementAt(N-1).ToString();
            }
        }
}
