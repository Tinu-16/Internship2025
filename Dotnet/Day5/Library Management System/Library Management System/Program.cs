using LibrarySystem.Books;
using LibrarySystem.Members;
using LibrarySystem.Transactions;

Book book=new Book(101,"Alchemist","Paulo Coelho");
Console.WriteLine(book);

Journal journal = new Journal(201, "International Journal of Biological Sciences");
Console.WriteLine(journal);

Magazine magazine = new Magazine(301, "India Today");
Console.WriteLine(magazine);

Librarian librarian = new Librarian(2001, "Rakhi");
Console.WriteLine(librarian);

Member member = new Member(1001, "Tinu");
Console.WriteLine(member);

BorrowTransaction borrowTransaction = new BorrowTransaction(1, member, book);
Console.WriteLine(borrowTransaction);

ReturnTransaction returnTransaction = new ReturnTransaction(2, member, book);
Console.WriteLine(returnTransaction);

