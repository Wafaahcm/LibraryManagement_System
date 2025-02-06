using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryUser : User
    {
        public LibraryUser(string name)
        {
            Name = name;
        }
        public LibraryCard Card { get; set; } // Library user has library card <<Aggregation>>

        public void BorrowBook(Book book, Library library)
        {
            library.BorrowBook(book);
        }
    }
}
