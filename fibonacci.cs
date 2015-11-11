using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXERCISE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now you can generate fibonacci!");
            
            int f1 = 0, f2 = 1;
            int f3;
            while (true){

                Console.WriteLine("How long sequence do you want to generate? Press Interger + ENTER to continue OR press Q + ENTER+ENTER to quit.");
                
                //if (Console.ReadLine() == ("q") || Console.ReadLine() == ("Q")) Console.ReadLine(); not correct instead:
                string input = Console.ReadLine();
                //if (input == ("q") || input == ("Q")) Console.ReadLine();
                if (input == ("q") || input == ("Q")) break;
                int len;
                if (Int32.TryParse(input, out len))
                {   
                    if (len>=1)
                        Console.WriteLine(f1);
                    if (len >= 2) Console.WriteLine(f2);
                    if (len>2) {
                        for (int i = 2; i < len; i++) {
                            f3 = f1 + f2;
                            Console.WriteLine(f3);
                            f1 = f2;
                            f2 = f3;
                        
                        }
                    
                    
                    }
                        
                }
                else {
                    Console.WriteLine("invalid input!");
                    continue;
                }

                }
            Console.ReadLine();
        }
    }
}
