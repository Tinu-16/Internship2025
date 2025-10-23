using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Collections
{
    internal class Question4
    {
        public static void Operations()
        {
            Console.WriteLine("-----------------------Question4--------------------------");
            Book book1 = new Book("The Alchemist", "Paulo Coelho", 102.5);
            Book book2 = new Book("Atomic Habits", "James Clear", 200);
            Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", 300);

            //Create a List<Book> and add at least 3 books.
            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            //Display all book details.
            foreach (var item in books)
            {
                Console.WriteLine($"Title : {item.Title}, Author : {item.Author}, Price : {item.Price}");
            }

            //Find and display the book with the highest price.
            Book book = books.MaxBy(b => b.Price);
            Console.WriteLine($"Book with highest price is {book.Title} and it's author is {book.Author} and its price is {book.Price}");

            //Remove a book by title
            List<Book> bookRemove = books.Where(x => x.Title.Equals("The Alchemist", StringComparison.OrdinalIgnoreCase)).ToList();
            if (bookRemove.Count > 0)
            {
                foreach (var item in bookRemove)
                {
                    books.Remove(item);
                }
            }
            
            Console.WriteLine("-----------------------After removal--------------------------");
            foreach (var item in books)
            {
                Console.WriteLine($"Title : {item.Title}, Author : {item.Author}, Price : {item.Price}");
            }
        }
    }
}
