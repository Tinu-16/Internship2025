using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Members;
using LibrarySystem.Books;


namespace LibrarySystem.Transactions
{
    public class BorrowTransaction
    {
        public int BorrowId { get; set; }
        public Member MemberId { get; set; }
        public Book BookId { get; set; }
        public DateTime BorrowDate { get; set; }

        public BorrowTransaction(int borrowId, Member memberId, Book bookId)
        {
            BorrowId = borrowId;
            MemberId = memberId;
            BookId = bookId;
            BorrowDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Borrow Id is {BorrowId}, {MemberId},{BookId} and BorrowDate is {BorrowDate}";
        }
    }
}
