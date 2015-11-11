using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXERCISE7
{
    class Program
    {//calculate 24   ADD any operators 
        static void Main(string[] args)
        {
            int a, b, c, d;
            while (true)
            {
                Console.WriteLine("calculate 24 using + - * / ^ and any () ");
                Random rnd = new Random();
                    a = rnd.Next(1, 14);
                    b = rnd.Next(1, 14);
                    c = rnd.Next(1, 14);
                    d = rnd.Next(1, 14);
                    if (justify(a, b, c, d)) break;
            }

            Console.WriteLine(a.ToString()+" "+b.ToString()+" "+c.ToString()+" "+d.ToString());
            Console.ReadLine();
        }
        static int[] op(int a, int b) {
            if (a % b == 0)
                return new int[] { a + b, a - b, a * b, a ^ b, a / b };
            else
                return new int[] { a + b, a - b, a * b, a ^ b };
           
        }

        static int[] op(int[] a, int b) { 
            int div= 0;
            foreach (int i in a){
                if (i%b==0) div++;
            }
            int[] ret = new int[4 * a.Length + div];
            int j = 0;
            foreach (int i in a)
            {
                ret[j]=i+b;
                ret[j+1]=i-b;
                ret[j+2]=i*b;
                ret[j+3]=i^b;
                j=j+4;

                if (i % b == 0) {
                    ret[j] = i / b;
                    j++;
                }
            }


            return ret;

        }

        static int[] op(int a, int[] b)
        {
            int div = 0;
            foreach (int i in b)
            {
                if (i!=0 && a % i == 0) div++;
            }
            int[] ret = new int[4 * b.Length + div];
            int j = 0;
            foreach (int i in b)
            {
                ret[j] = i + a;
                ret[j + 1] = a-i;
                ret[j + 2] = a*i;
                ret[j + 3] = a ^ i;
                j = j + 4;

                if (i!=0 && a % i == 0)
                {
                    ret[j] = a/i;
                    j++;
                }
            }


            return ret;

        }

        static int[] op(int[] a, int[] b) {
            int count=0;
            foreach (int i in a) {
                count += op(i, b).Length;
            }
            int[] ret = new int[count];
            int addition = 0;
            
            foreach (int i in a)
            {
                int len = op(i, b).Length;
                for (int j=0; j < len; j++)
                {
                    ret[j + addition] = op(i, b)[j];

                }
                addition += len;
            }

            return ret;
        }
        static bool comp24(int[] result) {
            foreach (int i in result) {
                if (i == 24)
                    return true;
            
            }
            return false;
        }

        static bool justify(int a, int b, int c, int d)
        { 
            int [] tojust={a,b,c,d};
            Console.WriteLine("haha1");
            if (comp24(op(op(a, b), op(c, b)))) return true;
            Console.WriteLine("haha2");
            if (comp24(   op(op(op(a, b),c),d) )  ) return true;
            Console.WriteLine("haha3");
            if (comp24(   op(op(  a, op(b, c)),d)  )) return true;
            Console.WriteLine("haha4");
            if (comp24(   op(a,   op(op(b, c), d)   ))) return true;
            Console.WriteLine("haha5");
            
            if (comp24(  op(a,op(b,op(c,d))     )          )) return true;



            return false;



        }


    }
}
