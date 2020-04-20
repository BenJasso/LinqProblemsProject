using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class problem1method
    {
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        string test = "th";

        public IEnumerable<string> wordsWithTH(List<string> list)
        {
            var listofTHWords = list.Where(m => m.Contains(test));
            return listofTHWords;
        }

        
    }
}
