using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace csharp_console1
{
    class Program
    {
        [DllImport("C:\\Raveendra\\Practice\\csharp\\cpp-ConsoleApplication1\\Debug\\cpp-proj2-dll.dll", CharSet = CharSet.Auto)]
       // [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SumTwo(int var_x, int var_y);

        [DllImport("C:\\Raveendra\\Practice\\csharp\\cpp-ConsoleApplication1\\Debug\\cpp-proj2-dll.dll", CharSet = CharSet.Auto)]
        public static extern int test1();

        [DllImport("C:\\Raveendra\\Practice\\csharp\\cpp-ConsoleApplication1\\Debug\\cpp-proj2-dll.dll", CharSet = CharSet.Auto)]
        public static extern char test2();

        static void Main(string[] args)
        {
            int var_x = 5;
            int var_y = 10;
            int r;
            char c;
            r = test1();
            c = test2();
            int res;
            res = SumTwo(var_x, var_y);
          //  var res = sumTwo(var_x, var_y);
            Console.WriteLine("Sum of {0} {1} : {2}", var_x, var_y, res);
            Console.WriteLine("char result {0}", c);
            var x = Console.Read();
        }
    }
}
