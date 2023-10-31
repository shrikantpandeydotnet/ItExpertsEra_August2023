using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    public abstract class AbstractClass
    {
        public void TestMethod()
        {
            Console.WriteLine("I am method with body");
        }

        public abstract void TestMethod2();
    }

    public class ChildAbstract : AbstractClass
    {
        public override void TestMethod2()
        {
            Console.WriteLine("This is the body of abstract class abstract method");
        }
    }

}
