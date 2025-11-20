using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Collections
{
    internal class Question2
    {
        public static void Operations()
        {
            Console.WriteLine("-----------------------Question2--------------------------");
            //Create an ArrayList and add the following elements:
            //A string ("John")
            //An integer (25)
            //A double (75.5)
            //A boolean (true)
            ArrayList myList = new ArrayList();
            myList.Add("John");
            myList.Add(25);
            myList.Add(75.5);
            myList.Add(true);
            //Iterate through the list and print each element along with its data type using GetType().
            foreach (var item in myList)
            {
                Console.WriteLine($"{item} : {item.GetType()}");
            }
        }
    }
}
