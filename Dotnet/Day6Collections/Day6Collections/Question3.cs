using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Collections
{
    internal class Question3
    {
        public static void Operations()
        {
            Console.WriteLine("-----------------------Question3--------------------------");
            //Create a List<int> to store marks of 5 students.
            //Add marks (e.g., 78, 92, 67, 88, 95).
            List<int> marks = new List<int>();
            marks.Add(78);
            marks.Add(92);
            marks.Add(67);
            marks.Add(88);
            marks.Add(95);

            //Calculate and print the average mark.
            double sum = 0;
            foreach (var item in marks)
            {
                sum += item;
            }
            Console.WriteLine($"Average : {sum / marks.Count}");

            //Remove the lowest mark.
            marks.Remove(marks.Min());

            //Sort the list in ascending order and print the updated list.
            marks.Sort();
            Console.WriteLine("--------------Ascending order--------------------------");
            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}
