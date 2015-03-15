using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatchingPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new int[] { 15,3, 15, 3 };
            var result = getPosition(input1);

            System.Console.WriteLine(result);
            Console.ReadKey();
        }

        public static string getPosition(int[] input1)
        {
            //Write code here

            var sb = new StringBuilder();

            int N = input1.Length;

            int[] sum = new int[N];
            
            
            
            for(int i =0 ;i<N;i++)
            {
                if (input1[i] > 20 || input1[i] < 0)
                {
                    return "invalid";
                }
                for(int j =0 ;j<i;j++)
                {
                    if(input1[i]== input1[j])
                    {
                        sum[i] += 1;
                    }
                }

                if (i - 1 > 0)
                    sum[i] = sum[i] + sum[i - 1];
            }

            for (int k = 0; k < N;k++ )
            {
                if (k != N - 1)
                    sb.AppendFormat("{0},", sum[k]);
                else
                    sb.AppendFormat("{0}", sum[k]);
            }


            return sb.ToString();

        }
    }
}
