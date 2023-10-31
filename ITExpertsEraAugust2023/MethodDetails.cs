using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class MethodDetails
    {
        public int Size { get; set; }
        // Method Syntax 

        public void Add(int num1, int num2)
        {
            int result = num1 + num2;

            Console.WriteLine(result);
        }


        // Method with return type other than void. 

        public int AddWithReturnType(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
        }

        // method that return any type. 

        public object MethodWithAnyType()
        {
            return 10;
        }

        public bool isSizeGreateThan100()
        {
            if (Size > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // method that return more than one value.

        public string[] GetAllFruits()
        {
            string[] result = new string[2];
            result[0] = "Apple";
            result[0] = "Banana";

            return result;
        }

        // Write a method which returns sum, subtraction, multiplication and division. 

        public int[] Maths(int num1, int num2)
        {
            int[] result = new int[4];

            result[0] = num1 + num2;
            result[1] = num1 - num2;
            result[2] = num1 * num2;
            result[3] = num1 / num2;

            return result;
        }

        // method with array 

        public int  testArrayMethod(string[] value)
        {
            foreach (string i in value)
            {
                Console.WriteLine(i);
            }

            return value.Length;
        }


    }
}
