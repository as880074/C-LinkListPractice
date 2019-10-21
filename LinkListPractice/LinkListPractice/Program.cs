using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            int a = 1, b = 2, c = 3;
            SinglyList<int> NumList = new SinglyList<int>();
            NumList.Add(a);
            NumList.Add(b);
            NumList.Add(c);
            foreach (var data in NumList.ToList()) 
            {
                Console.WriteLine(data + "  " );
            }

            Console.ReadLine();
        }
    }
}
