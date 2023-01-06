using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms.Inheritance
{
    class BMW:Maruti// Multi Level Inheritace (Child Class OF Maruti)
    {
        public int speed;
        public void PrintSpeed()
        {
            Console.WriteLine("BMWs Speed Is : "+speed);
        }
    }
}
