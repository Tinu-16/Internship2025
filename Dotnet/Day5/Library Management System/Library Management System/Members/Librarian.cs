using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Members
{
    internal class Librarian
    {
        public int Id { get; set; }
        public string LibrarianName { get; set; }

        public Librarian(int id, string librarianName)
        {
            Id = id;
            LibrarianName = librarianName;
        }
        public override string ToString()
        {
            return $"Librarian id is {Id} and Librarian name is {LibrarianName}";
        }

    }
}
