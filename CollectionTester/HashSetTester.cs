using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    class HashSetTester
    {
        public HashSetTester()
        {
            HashSet<string> employees = new HashSet<string>(new string[] { "Fred", "Bert", "Harry", "John" }); 
            HashSet<string> customers = new HashSet<string>(new string[] { "John", "Sid", "Harry", "Diana" });
            
            employees.Add("James"); 
            customers.Add("Francesca");
            Console.WriteLine("Employees:"); 
            foreach (string name in employees) 
            { 
                Console.WriteLine(name); 
            }
            Console.WriteLine("\nCustomers:"); 
            foreach (string name in customers) 
            { 
                Console.WriteLine(name); 
            }
            //Console.WriteLine("\nCustomers who are also employees:"); 
            //customers.IntersectWith(employees);
            //foreach (string name in customers)
            //{
            //    Console.WriteLine(name);
            //}
            Console.WriteLine("\nCustomers union employees:");
            IEnumerable<string> cu = customers.Union(employees);

            foreach (string name in cu) { 
                Console.WriteLine(name); 
            }

            //customers.IsSubsetOf(employees);

        }
    }
}
