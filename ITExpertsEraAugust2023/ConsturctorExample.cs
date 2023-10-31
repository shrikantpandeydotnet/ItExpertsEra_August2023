using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    public class ConsturctorExample
    {

        public int var1;

        public string var2;

        public static int var3;

        public ConsturctorExample()
        {
            var1 = 100;
        }
        public ConsturctorExample(int a) // Parameterized Constructor.
        {
            var1 = a;
            var3 = a;
        }

        public ConsturctorExample(int a, string b) // Parameterized Constructor.
        {
            var1 = a;
            var2 = b;
        }

        static ConsturctorExample()
        {
            var3 = 500;
        }


        public static int sum(int a, int b)
        {
            return a + b;

        }
    }
}
