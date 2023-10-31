using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class PropertiesExample
    {
        private int var1 = 10;        
        private int var2 = 10;


        /// <summary>
        /// General propery syntax.
        /// </summary>
        public int MyProperty 
        { 
            get
            {
                return var1;
            }
            set
            {
                var1 = value;
            }
        }

        // Read only property. 

        public int MyProperty2
        {
            get
            {
                return var2;
            }
        }



        public void TestMethod()
        {
            Console.WriteLine(MyProperty);

            MyProperty = 100; // set the value of property

            int result = MyProperty; // get the value of the property.

            Console.WriteLine(result);

            Console.WriteLine(var1);

        }
    }
}
