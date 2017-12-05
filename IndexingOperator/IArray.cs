using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexingOperator
{
    class IArray
    {
        public double[] Array;
        public double this[int index]
        {
            get
            {
                return Array[index];
            }

            set
            {
                Array[index] = Math.Pow(value, 2);
            }
        }
        public IArray(int rangeOfFinish)
        {
            Array = new double[rangeOfFinish];
        }
    }
}
