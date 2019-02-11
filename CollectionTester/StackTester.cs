using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    class StackTester
    {
        public StackTester()
        {
            Stack<int> numbers = new Stack<int>();
            // fill the stack 
            Console.WriteLine("Pushing items onto the stack:");
            foreach (int number in new int[4] { 9, 3, 7, 2 })
            {
                numbers.Push(number);
                Console.WriteLine("{0} has been pushed on the stack", number);
            }
            // iterate through the stack 
            Console.WriteLine("\nThe stack now contains:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            // empty the stack 
            Console.WriteLine("\nPopping items from the stack:");
            while (numbers.Count > 0)
            {
                int number = numbers.Pop();
                Console.WriteLine("{0} has been popped off the stack", number);
            }
        }

    }
}
