using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    class QueueTester
    {
        public QueueTester()
        {
            Queue<int> numbers = new Queue<int>();
            // fill the queue 
            Console.WriteLine("Populating the queue:"); 
            foreach (int number in new int[4]{9, 3, 7, 2}) 
            {     
                numbers.Enqueue(number);     
                Console.WriteLine("{0} has joined the queue", number); 
            }  
            // iterate through the queue 
            Console.WriteLine("\nThe queue contains the following items:"); 
            foreach (int number in numbers) 
            {     
                Console.WriteLine(number); 
            }  
            // empty the queue 
            Console.WriteLine("\nDraining the queue:"); 
            while (numbers.Count > 0) 
            {     
                int number = numbers.Dequeue();      
                Console.WriteLine("{0} has left the queue", number); 
            }
            //int i = numbers.Peek();
        }
    }
}
