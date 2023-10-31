using ITExpertsEraAugust2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ChildAccessModifierExample : AccessModifier
    {

        public void MethodExampleChild()
        {
            var_protected = 100;
            var_protectedinternal = 500;
        }
    }
}
