using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string f;
            int n;

        f = ReadLine();

            if (f == string.Empty)
                n = 0;
            else
                n = int.Parse(f);
            WriteLine(n);
        }
    }
}
