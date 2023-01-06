using OOPConceptPrograms.Incapsulation;
using OOPConceptPrograms.Inheritance;
using OOPConceptPrograms.Polymophisam;
using OOPConceptPrograms.Abstaction;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number\n1.Enheritance\n2.Polymorphism\n3.Incapsulatin\n4.Abstraction");
            int iNo = Convert.ToInt32(Console.ReadLine());
            switch (iNo)
            {

                case 1:
                    Console.WriteLine("Single Level Inheritace");
                    Maruti obj1 = new Maruti();  // Creating Object of Child Class (Maruti), parent is (Car)
                                                 // Sigle level Inheritace
                    obj1.model = "Alto";         // Accessing Parent Calss Veriable 
                    obj1.color = "White";
                    obj1.price = 500000;
                    obj1.milage = 25.2d;
                    obj1.PrintCarInformation();  // Method Calling Parent Class though Child Calss
                    obj1.PrintMilage();          // Child Class (Maruti) Method Calling 

                    Console.WriteLine("\nMultilevel Inheritace");
                    BMW obj2 = new BMW();        //Creating objct of 3rd child(BMW) and calling parent of perent method (Car)
                    obj2.model = "Alto";         // Accessing Parent Calss Veriable 
                    obj2.color = "White";
                    obj2.price = 500000;
                    obj2.milage = 25.2d;
                    obj2.speed = 150;
                    obj2.PrintCarInformation();  // Method Calling Parent Class though Child Calss
                    obj2.PrintMilage();          // Child Class (Maruti) Method Calling 
                    obj2.PrintSpeed();

                    Console.WriteLine("\nHierachcal Inheritac");
                    Tata obj3 = new Tata();      // Second Child of Car is Tata
                    obj3.model = "Nexon";        
                    obj3.color = "Blue";         // Accesesing parent Veriable
                    obj3.price = 1700000;
                    obj3.electric = "Electric"; 
                    obj3.PrintCarInformation();  //calling parent class
                    obj3.HierachcalInheritance();//Second child class
       
                    break;
                case 2:
                    Console.WriteLine("\nPolymorphism");
                    Class1 add = new Class1(); // overloding Achive by providing diff type of parameter                           
                    add.sum(2,6);              //diff no of parameter
                    add.sum(2.40000, 4);       // diff sequence of parameter

                    Dog tommy = new Dog();     // Method Override
                    tommy.Eat();               // Name,paramerts should be all same
                    break;
                case 3:
                    Console.WriteLine("\nIncapsulatin");
                    Account my = new Account();
                    my.SetBalence(2040); // getset Method We can Accsses private data 
                    my.GetBalence();

                    GetSetProparty Acc = new GetSetProparty();
                    Acc.Balence = 10000;
                    Console.WriteLine("Account Balance is : "+ Acc.Balence);
                    break;
                case 4:
                    Console.WriteLine("\nAbstraction");
                    Flate ne = new Flate(); // creating objrct of deriv class
                    ne.Hall();              // calling base class method
                    ne.locker();            // calling abstract method through override method
                   
                    break;
            }


            Console.ReadLine();

        }
    }
}
