using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SkippingSum
{
    class Program
    {
        static void Main(string[] args)
        {

            //TextReader reader = new StreamReader("input.txt");

            MyTextReader reader = new MyTextReader(new MyTextFileReader("input.txt"));
           

            var line = reader.ReadLine().Trim();
            char separator = ' ';
            var dt =  line.Split(separator);
            //Read input from stdin and provide input before running
            
            //var line1 = System.Console.ReadLine().Trim();
            var N = Int32.Parse(dt[0]);
            var Q = int.Parse(dt[1]);

            line =  reader.ReadLine();
            dt = line.Split(separator);

            int[] A = new int[N];

            for (var i = 0; i < N; i++)
            {
                A[i] = int.Parse(dt[i]);
            }

            
                for (int i = 0; i < Q; i++)
                {
                    line = reader.ReadLine();
                    dt = line.Split(separator);
                    var L = int.Parse(dt[0]);
                    var R = int.Parse(dt[1]);
                    var K = int.Parse(dt[2]);
                    var sum =  SkippingSum(L, R, K, A);

                    System.Console.WriteLine(sum);
                   
                }

                System.Console.ReadKey();
           
        }

        static int SkippingSum(int L, int R, int K, int[] A)
        {
            int sum = 0;
            while (L <= R)
            {
                sum = sum + A[L-1];
                L = L + K;
            }
            return sum;
        }



    }


    public interface ITextReader
    {
        string ReadLine();
    }

    public interface IReader
    {
        string ReadLine();
    }

    public class ConsoleReader : IReader
    {

        public string ReadLine()
        {
           return  Console.ReadLine().Trim();
        }
    }

    public class MyTextFileReader:IReader
    {
        TextReader rdr;
        public MyTextFileReader(string fileName)
        {
            rdr = new StreamReader(fileName);
        }
        public string ReadLine()
        {

            return rdr.ReadLine().Trim();
        }
    }

    public class MyTextReader : ITextReader
    {
        private IReader reader; 
        public MyTextReader(IReader reader)
        {
            this.reader = reader;
        }

        public string ReadLine()
        {
           return this.reader.ReadLine();
        }
    }
}
