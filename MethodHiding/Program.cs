using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class Program
    {
        /* Method Hiding : Hiding the base class method within the derived class is called method hiding.
            - To implementbase class method hiding we don‟t required a keyword virtual but in derived class method required a keyword “new”.
            - it is same as method overriding in that we will use virtual and override keyword's to methods but in method hiding we use only new keyword to derived class method. */

        static void Main(string[] args)
        {
            ClassB obj = new ClassB();
            obj.Meth();
        }
    }
}
