using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms.Inheritance
{
     class Car  // Parent Class
    {
        public string model;   // Creating Veriable 
        public string color;   // Creating Veriable 
        public Double price;   // Creating Veriable 

        public void PrintCarInformation()    // Parent class Method
        {
            Console.WriteLine("Model is : " +model);
            Console.WriteLine("Color is : " +color);
            Console.WriteLine("Price is : " +price);
        }
    }
}
