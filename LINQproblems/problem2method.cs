using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class problem2method
    {

        //member variables
        public List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        //constructor

        //member methods
        public IEnumerable<string> removeDuplicates(List<string> list)
        {
            return list.Distinct();
            
        }
    }
}
