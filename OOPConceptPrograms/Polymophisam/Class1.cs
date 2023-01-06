using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms.Polymophisam
{
    internal class Class1  // same  class
    {
       public void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
       public void sum(double a,int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
