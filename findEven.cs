using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXERCISE3
{   
    class Program
    {//find all even numbers
        static void Main(string[] args)
        {
            Console.WriteLine("enter Integers, seperate by \",\"  Any inproper input would cause exit");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int[] inputnum=new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++) { 
                int temp;
                
                if (Int32.TryParse(inputs[i], out temp))
                {
                    inputnum[i] = temp;

                }
                else {
                    return;
                }
            
            }

            var evenNums =
                from num in inputnum
                where num % 2 == 0
                select num;
            Console.WriteLine("Even numbers are displayed here:");
            foreach (var v in evenNums) {
                Console.Write(v + " , ");
            }

            Console.Read();
            return;


        }
    }
}
