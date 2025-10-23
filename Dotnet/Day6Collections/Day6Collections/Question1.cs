using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Collections
{
    internal class Question1
    {
        public static void Operations()
        {
            Console.WriteLine("-----------------------Question1--------------------------");
            //Create an ArrayList to store student names.
            ArrayList arrayList = new ArrayList();

            //Add 5 student names to the list.
            arrayList.Add("Anju");
            arrayList.Add("Anu");
            arrayList.Add("Sujith");
            arrayList.Add("Serah");
            arrayList.Add("Mariam");

            //Display all names.
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }

            //Remove one name from the list.
            arrayList.Remove("Sujith");
            Console.WriteLine("----------After removing sujith----------");
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }

            //Insert a new name at index 2.
            arrayList.Insert(2, "Tinu");

            //Print the final list using both a for loop and a foreach loop.
            Console.WriteLine("----------Using for loop----------");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("----------Using foreach loop----------");
            foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
