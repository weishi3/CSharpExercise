using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPEXXERCISE6
{  
    class Program
    {//find all config files in a directory (for example . jenkins)
        static void Main(string[] args)
        {
            Console.WriteLine("input a directory");
            string path = Console.ReadLine();
            string[] filenames=Directory.GetFiles(path, "*.xml", SearchOption.AllDirectories);
            foreach (string f in filenames) {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}
