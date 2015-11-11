using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXERCISE4
{
    class Program
    {  //quicksort
        static void Main(string[] args)
        {
            Console.WriteLine("NOW input a list of integer,seperaged by \",\" DO NOT ADD \' , \' after the last number");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int[] tosort= new int[inputs.Length];
            int count = 0;
            foreach (string i in inputs) {
                tosort[count] = int.Parse(i);
                count++;
            }

            int[] result = quickSort(tosort);

            foreach (int j in result) {
                Console.Write(j.ToString()+"  ");
            }

           
            Console.ReadLine();



            return;
        }



        static int[] quickSort(int[] input)
        {
            sortLR(input,0, input.Length - 1);
            return input;
        }

        static int[] sortLR(int[] input,int left, int right) {
            int pivot;
            
            //save
            int l = left;
            int r = right;
            pivot = input[left];
            while (left < right) {
                while ((input[right] >= pivot) && (left < right)) right = right - 1;
                if (left != right) {
                    input[left] = input[right];
                    left = left + 1;
                }

                while ((input[left] <= pivot) && (left < right)) left = left + 1;
                if (left != right)
                {
                    input[right] = input[left];
                    right = right - 1;

                }
            
            
            
            }
            input[left] = pivot;
            pivot = left;
            left = l;
            right = r;

            if (left < pivot) sortLR(input,left, pivot - 1);
            if (pivot < right) sortLR(input, pivot + 1, right);

            return input;
        }
    }
}
