using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms.Incapsulation
{
    class Account 
    {
        int accountBalence =1000;
        
        public void SetBalence(int amount)
        {
            accountBalence = amount;
           
        }
        public void GetBalence()
        {
            Console.WriteLine("Account Balence is :"+accountBalence);
        }
    }

    

}
