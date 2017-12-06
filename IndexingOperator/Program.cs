using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            IArray ar = new IArray(3);
            ar[0] = 2;
            ar[1] = 4;
            ar[2] = 8;
            Console.WriteLine(ar[0]);
            Console.WriteLine(ar[1]);
            Console.WriteLine(ar[2]);
            Console.ReadLine();
        }
    }
}
