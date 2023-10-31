using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    internal class ExceptionHandlingExample
    {

        public void TestMethod()
        {
            try 
            {
                int i = 100;

                int j = 0;



                try
                {
                    int k = 0;
                    if (k == 0)
                    {
                        throw new ArgumentException("there is an invalid argument in the class");
                    }

                    Console.WriteLine("test line");
                }
                catch (Exception)
                {
                    throw;
                }

                int result = i / j;

                Console.WriteLine(result);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(" Please correct your argument before proceeding to next step.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(" There is a divide by zero exception. Please contact your system administrator");

            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error in the system. " + ex.Message.ToString());
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("This is a finally block code and will call always");
            }
        }
    }
}
