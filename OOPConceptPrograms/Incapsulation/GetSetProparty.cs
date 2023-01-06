using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptPrograms.Incapsulation
{
    internal class GetSetProparty
    {
        int AccBalance = 2000; // private data by default
        public int Balence
        {
            set 
            {
                AccBalance = value; // Value as parameter
            
            }
            get
            {
                return AccBalance;
            }
        }
    }
}
