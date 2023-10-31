using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    public interface InterfaceExample
    {
        public void IMethod1();
        public int Sum(int a, int b);
    }

    public interface IMathsOperation
    {
        public void multiply(double a, double b);
        public int Sum(int a, int b);

    }

    public class ClassA
    {
        public void methodClassA()
        {
            Console.WriteLine("I am Class method");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

    public abstract class Classb
    {
        public void methodClassb()
        {
            Console.WriteLine("I am Class method");
        }
    }

    public class TestClass : ClassA, InterfaceExample, IMathsOperation
    {
        public void IMethod1()
        {
            Console.WriteLine("I am Method1");
        }

        public void multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        int InterfaceExample.Sum(int a, int b) // Explicit Implementation
        {
            return a + b;
        }

        int IMathsOperation.Sum(int a, int b) // Explicit Implementation
        {
            return a + b +100000;
        }

        public void childclassmethod()
        {
            Console.WriteLine("I am child class method not exist anywhere in the parent");
        }
    }
}
