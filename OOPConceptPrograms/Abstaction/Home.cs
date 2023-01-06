using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms.Abstaction
{
    internal abstract class Home
    {
        public abstract void locker(); // Abstarct class not have body in class
        public void Hall()             // regular method
        {
            Console.WriteLine("Hall has TV");
        }
    }
     class Flate:Home                 // child class
    {
        public override void locker() // body of abstract class 
        {
            Console.WriteLine("Loker has 50cr");
        }
    }
}
