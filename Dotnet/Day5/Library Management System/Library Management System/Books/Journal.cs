using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Books
{
    internal class Journal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Journal(int id, string name)
        {
            Id = id; 
            Name = name;
        }

        public override string ToString()
        {
            return $"Journal id : {Id} , Journal title : {Name}";
        }
    }
}
