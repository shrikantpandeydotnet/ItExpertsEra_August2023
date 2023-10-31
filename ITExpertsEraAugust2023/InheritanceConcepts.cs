using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    public class Parent
    {
        public Parent() // 1
        {
            Console.WriteLine("I am Parent Class Constructor");
        }

        static Parent() // 2
        {
            Console.WriteLine("I am Static Parent Class Constructor");
        }

        public void ParentMethod()
        {
            Console.WriteLine(" I am a Parent Method");
        }
    }

    public class Child : Parent // Inheritance.
    {
        public Child() // 3
        {
            Console.WriteLine("I am Parent Class Constructor");
        }

        static Child() // 4
        {
            Console.WriteLine("I am Static Parent Class Constructor");
        }
        public void ChildMethod()
        {
            Console.WriteLine(" I am a Child Method");
        }
    }

    public class Child2 : Parent // Inheritance.
    {
        public void ChildMethod2()
        {
            Console.WriteLine(" I am a Child 2 Method");
        }
    }

    public class GrandChild : Child // Inheritance.
    {
        public void GrandChildMethod()
        {
            Console.WriteLine(" I am a Grand Child Method");
        }
    }


    public class GrandChild2 : Child // Inheritance.
    {
        public void GrandChildMethod2()
        {
            Console.WriteLine(" I am a Grand Child 2 Method");
        }
    }
}
