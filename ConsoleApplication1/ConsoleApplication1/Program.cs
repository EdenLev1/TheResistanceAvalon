using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            a[0] = 100;
            a[1] = 90;
            a[2] = 80;
            a[3] = 70;
            a[4] = 80;
            a[5] = 40;
            
            int[] b = new int[3];
            b[0] = 3;
            b[1] = 2;
            b[2] = 1;
            int[] c = cc(a, b);
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.Read();
        }
        public static int[] cc(int[] a, int[] b)
        {
            int sum = 0;
            int[] c = new int[b.Length];
            int i = 0;
            for (int j=0;j<b.Length;j++)
            { 
                for(int k=0;k<b[j];i++,k++)
                {
                    sum += a[i];
                }
                c[j] = sum/b[j];
                sum = 0;
            }
            return c;
        }
    }
}
