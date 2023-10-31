using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class MethodOverridingConcept
    {
    }

    public class A
    {
        public virtual void Method1()
        {
            Console.WriteLine("I am virtual parent class method");
        }

        public void Method2()
        {
            Console.WriteLine("I am method 2 of parent classs");
        }
    }

    public class B : A
    {
        public override void Method1()
        {
            Console.WriteLine("I am child class override method");
        }

        public new void Method2() // Method Hiding
        {
            Console.WriteLine("I am method 2 of parent classs");
        }
    }

    public sealed class C : B
    {
        public sealed override void Method1()
        {
            Console.WriteLine("I am child class override method");
        }
    }

    //public class D : C
    //{
    //    public override void Method1()
    //    {
    //        Console.WriteLine("I am child class override method");
    //    }
    //}
}
