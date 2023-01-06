using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms.Inheritance
{

    class Maruti:Car  // Child Class is Maruti (Single level Inheritance)
    {
        public Double milage;
       public void PrintMilage()  // Child Class Method
        {
            Console.WriteLine("Milage is : " + milage);
        }

    }
}
