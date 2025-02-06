using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentBook = 0;

        private Book[] BorrowedBooks = new Book[50];
        private int currentBorrowedBookCount = 0;
        public void Display()
        {
            for (int i = 0; i < currentBook; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }
        public void Add(Book book) //???
        {
            if(currentBook < books.Length)
            {
                books[currentBook] = book;
                currentBook++;
                Console.WriteLine("Book added sucessfuly");
            }
            else
            {
                Console.WriteLine("Library is full , can't add new book");
            }
        }
        public void Remove(Book book)
        {
           int index = Array.IndexOf(books, book);
            books[index] = null;
            currentBook--;
            Console.WriteLine("Book removed");
        }
        public void BorrowBook(Book book)
        {
            if (currentBorrowedBookCount < books.Length)
            {
                BorrowedBooks[currentBorrowedBookCount] = book;
                currentBorrowedBookCount++;
                Console.WriteLine("Book borrowed sucessfuly");
            }
            else
            {
                Console.WriteLine("Sorry can't borrow more books");
            }
        }
    }
}
