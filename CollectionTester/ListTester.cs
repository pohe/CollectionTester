using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace CollectionTester
{
    class ListTester
    {
        private List<int> numberList; // A list of integers

        public ListTester()
        {
            //When we create a List object, we do not need to specify any size:
            numberList = new List<int>();
            for (int number = 0; number < 10; number++)
            {
                numberList.Add(number * number);
            }
            
            printList();
            Console.WriteLine("Removes the element 0");
            numberList.Remove(0);// removes the element with value 0

            printList();
            Console.WriteLine("Removes the element at position 4");
            numberList.RemoveAt(4); // removes the element at position 4
            int i1 = numberList[6];
            printList();
            // iterating using a for loop
            Console.WriteLine("Print out the elements using a for loop");
            for (int i = 0; i < numberList.Count; i++)
            {
                int number = numberList[i];
                Console.WriteLine(number);
            }

            Console.WriteLine("Sorting");
            //numberList.Sort();
            //numberList.Reverse(); 
            numberList.Sort((int x, int y) =>
            {
                if (y > x)
                    return 1;
                else if (x > y)
                    return -1;
                else
                {
                    return 0;
                }
            });
            //numberList.Sort(new SorterOmvendt());
            printList();
            int searchFor = 16;
            int index = -1;
            index = numberList.BinarySearch(searchFor);
            if (index >= 0)
                Console.WriteLine($"The number {searchFor}  found {index} ");
            int ib= numberList.FindIndex((x)=>x>5&&x<20);
            Console.WriteLine($"Number betweeen 5 and 20 {numberList[ib]}");

            Console.WriteLine("Equal numbers");
            List<int> eqList = numberList.FindAll((x) => x % 2 == 0);
            foreach (int eq in eqList)
            {
                Console.WriteLine(eq);
            }

            Console.WriteLine($"Using foreach printing equal numbers");
            numberList.ForEach(delegate (int number)
            {
                if (number%2==0)
                    Console.WriteLine($"Equal number {number}");
            });

            Console.WriteLine($"Using foreach printing all numbers");
            numberList.ForEach(( number)=>
            {
                Console.Write($"{number}  ");
            });

        }

        public void printList()
        {
            foreach (int value in numberList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
