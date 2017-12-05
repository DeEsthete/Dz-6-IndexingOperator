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
            ar.Array[0] = 2;
            ar.Array[1] = 4;
            ar.Array[2] = 8;
            Console.WriteLine(ar.Array[0]);
            Console.WriteLine(ar.Array[1]);
            Console.WriteLine(ar.Array[2]);
            Console.ReadLine();
        }
    }
}
