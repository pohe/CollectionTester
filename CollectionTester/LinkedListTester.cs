using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{

    class LinkedListTester
    {
        private LinkedList<int> numbers = new LinkedList<int>();

        public LinkedListTester()
        {
            // Fill the List<int> by using the AddFirst method 
            foreach (int number in new int[] { 10, 8, 6, 4, 2 })
            {
                numbers.AddFirst(number);
            }
            
            // Iterate using a for statement Console.WriteLine("Iterating using a for statement:"); 
            for (LinkedListNode<int> node = numbers.First; node != null; node = node.Next)
            {
                int number = node.Value;
                Console.WriteLine(number);
            }
            // Iterate using a foreach statement 
            Console.WriteLine("\nIterating using a foreach statement:");
            foreach (int number in numbers) 
            { 
                Console.WriteLine(number); 
            }
            // Iterate backwards 
            Console.WriteLine("\nIterating list in reverse order:");
            for (LinkedListNode<int> node = numbers.Last; node != null; node = node.Previous)
            {
                int number = node.Value;
                Console.WriteLine(number);
            }
            


        }
    }
}

