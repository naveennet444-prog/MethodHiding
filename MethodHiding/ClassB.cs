using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class ClassB : ClassA
    {
        public new void Meth()  //using new keyword we are hiding ClassA Method.
        {
            Console.WriteLine("i am ClassB method");
        }
    }
}
