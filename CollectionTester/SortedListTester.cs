using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    class SortedListTester
    {
        public SortedListTester()
        {
            SortedList<string, int> ages = new SortedList<string, int>();

            // fill the SortedList 
            ages.Add("John", 47);    
            // using the Add method 
            ages.Add("Diana", 46); 
            ages["James"] = 20;      
            // using array notation 
            ages["Francesca"] = 18;  
            // iterate using a foreach statement 
            // the iterator generates a KeyValuePair item 
            Console.WriteLine("The SortedList contains:"); 
            foreach (KeyValuePair<string, int> element in ages) {     
                string name = element.Key;     
                int age = element.Value;     
                Console.WriteLine("Name: {0}, Age: {1}", name, age); 
            }

        }
    }
}
