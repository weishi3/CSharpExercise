using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXERCISE5
{
    class Program
    {//mergesort
        static void Main(string[] args)
        {
            Console.WriteLine("start MergeSort");
            Console.WriteLine("NOW input a list of integer,seperaged by \",\" DO NOT ADD \' , \' after the last number");
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');
            int[] tosort = new int[inputs.Length];
            int count = 0;
            foreach (string i in inputs)
            {
                tosort[count] = int.Parse(i);
                count++;
            }


            Stopwatch s = Stopwatch.StartNew();
            sort(tosort,0,tosort.Length-1);
            s.Stop();


            foreach (int j in tosort)
            {
                Console.Write(j.ToString() + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("To MergeSort "+tosort.Length.ToString()+" numbers:");
            Console.WriteLine("It takes:"+ s.ElapsedMilliseconds+ "Milliseconds ");
            Console.ReadLine();



            return;
        }



         
         static void merge(int [] tomerge, int l ,int r, int mid){
            int []temp = new int [100];
            int countTotal, tempIndex;
            int leftStop= (mid-1);
            tempIndex=l;
            countTotal=r-l+1;

            //a critical situation
            while ((l<=leftStop) && (mid<=r)){
                if (tomerge[l]<=tomerge[mid]) temp[tempIndex++]=tomerge[l++];
                else temp[tempIndex++]=tomerge[mid++];
            }
            while (l<=leftStop) temp[tempIndex++]=tomerge[l++];
            while(mid<=r)  temp[tempIndex++]=tomerge[mid++];

            for (int i =0; i<countTotal;i++){
            
                tomerge[r]=temp[r];
                r--;
            
            }
        
           
        }

         static void sort(int[] tosort, int l, int r) {
             int mid = (l + r) / 2;
             if (r>l)//case need sort
             {
                 sort(tosort, l, mid);
                 sort(tosort, mid + 1, r);
                 merge(tosort, l, mid + 1, r);//mid

             }
         
         }



    }
}
