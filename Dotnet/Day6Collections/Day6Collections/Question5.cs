using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Collections
{
    internal class Question5
    {
        public static void Operations()
        {
            Console.WriteLine("-----------------------Question5--------------------------");
            //Create a List<string> of 6 names.
            List<string> names = new List<string>();
            names.Add("Anu");
            names.Add("Minu");
            names.Add("Tinu");
            names.Add("Sophy");
            names.Add("Serah");
            names.Add("anugraha");

            //Find all names that start with 'A'.
            var namesWithA = names.Where(x => x.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Names starting with 'A'");
            foreach (var name in namesWithA)
            {
                Console.WriteLine(name);
            }

            //Find names with length greater than 4.
            Console.WriteLine("Names whose length is greater than 4");
            var lengthGreaterThanFour = names.Where(x => x.Length > 4);
            foreach (var name in lengthGreaterThanFour)
            {
                Console.WriteLine(name);
            }
        }
    }
}
