using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class OutVsRef
    {

        public int SumMethod(ref int i, ref int j)
        {
            i = i + 200;
            j = j + 200;

            return i + j;
        }

        public void MathsOperation (int i, int j, out int sum, out int subtract, out int multiply, out int divide)
        {
            sum = i + j; 
            subtract = i - j; 
            multiply = i * j; 
            divide = i / j;
        }

        public int RefTest(ref int i)
        {
            return i; 
        }

        public int OutTest(out int i)
        {
            i = 10;
            return i;
        }

    }
}
