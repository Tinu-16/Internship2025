using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class SportsCharacter
    {
        public static void SportsCharacters(char character) 
        {
            switch (character)
            {
                case 'c':
                    Console.WriteLine("Cricket");
                    break;
                case 'f':
                    Console.WriteLine("Football");
                    break;
                case 'h':
                    Console.WriteLine("Hockey");
                    break;
                case 't':
                    Console.WriteLine("Tennis");
                    break;
                case 'b':
                    Console.WriteLine("Badminton");
                    break;
                default:
                    Console.WriteLine("Enter any of the above characters");
                    break;
            }
        }
    }
}
