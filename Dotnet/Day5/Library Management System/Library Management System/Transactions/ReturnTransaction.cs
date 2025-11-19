using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Books;
using LibrarySystem.Members;

namespace LibrarySystem.Transactions
{
        public class ReturnTransaction
        {
            public int ReturnId { get; set; }
            public Member MemberId { get; set; }
            public Book BookId { get; set; }
            public DateTime ReturnDate { get; set; }

            public ReturnTransaction(int returnId, Member memberId, Book bookId)
            {
                ReturnId = returnId;
                MemberId = memberId;
                BookId = bookId;
                ReturnDate = DateTime.Now;
            }

        public override string ToString()
        {
            return $"Return Id is {ReturnId}, {MemberId},{BookId} and ReturnDate is {ReturnDate}";
        }
    }
}
