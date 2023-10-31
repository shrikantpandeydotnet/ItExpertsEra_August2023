using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraAugust2023
{
    public class AccessModifier
    {
        // Access Modifier. 

        public int var_public = 10;
        private int var_private = 10;
        internal int var_internal = 20;
        protected int var_protected = 20;

        protected internal int var_protectedinternal = 100;

        int classVariable1 = 100;

        public void Method1()
        {
            var_public = 20;

            var_private = 20;

            var_internal = 20;

            var_protected = 20;

            var_protectedinternal = 150;

            int test1 = 5000;
        }

        public void Method2()
        {
            classVariable1 = 100;
        }
    }

    public class childAccessModifier : AccessModifier
    {
        public void MehthodChild()
        {
            var_protected = 20;
        }
    }
}
