using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{

    class DictionaryTester
    {
        public DictionaryTester()
        {
            // Key is String (CPR)
            // Value is Student object
            Dictionary<String, Student> students;

            students = new Dictionary<String, Student>();

            Student s1 = new Student("123456789", "Peter", "Bakkesvinget 67", "12345678");
            // Adding using the Add method
            students.Add("123456789", s1);
            Student s2 = new Student("124", "Patrick", "Bakkesvinget 69", "87654321");
            // Adding using the Add method
            students.Add("124", s2);
            Student s3 = new Student("125", "Clara", "Bakkesvinget 71", "12121212");
            //Adding sing array notation
            students["125"] = s3;
            //students.Add("125", s3);
            Console.WriteLine("The Dictionary contains: ");
            foreach (KeyValuePair<string, Student> element in students)
            {
                String key = element.Key;
                Student s = element.Value;
                Console.WriteLine("Key " + key + " Student " + s.ToString());
            }

            students.Remove("124");
            Console.WriteLine("The Dictionary contains after removing elements with key 124: ");
            foreach (KeyValuePair<string, Student> element in students)
            {
                String key = element.Key;
                Student s = element.Value;
                Console.WriteLine("Key " + key + " Student " + s.ToString());
            }

            if (students.ContainsKey("124"))
                Console.WriteLine("The element with key 124 was found");
            else
                Console.WriteLine("The element with key 124 was not found");
            if (students.ContainsKey("123"))
                Console.WriteLine("The element with key 123 was found");
            else
                Console.WriteLine("The element with key 123 was not found");
            
        }
    }
}
