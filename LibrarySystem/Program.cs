

using LibrarySystem;
using System;

Console.WriteLine("Welcome to the library system");

Library library = new Library();

Console.WriteLine("Are you librarian or regular user (L / R)");

var userType = Console.ReadLine().ToUpper()[0];


if (userType == 'L')
{
    Console.WriteLine("Welcome librarian, Enter your name");
    string librarianName = Console.ReadLine();

    //Librarian Logic:
    Librarian l1 = new Librarian(librarianName);

    Console.WriteLine($"Welcome {l1.Name}");

    while (true)
    {
        Console.WriteLine("please choose to Add book (A) / Remove book (R) / Display book (D)");

        char choice = Console.ReadLine().ToUpper()[0];

        switch (choice)
        {
            case 'A':
                Console.WriteLine("Enter Book details");
                string bookName = Console.ReadLine();
                string bookAuthor = Console.ReadLine();
                int bookYear = Convert.ToInt32(Console.ReadLine());
                Book book = new Book()
                {
                    Title = bookName,
                    Author = bookAuthor,
                    Year = bookYear
                };
                l1.AddBook(book, library); // ???
                break;

            case 'R':
                Console.WriteLine("Enter Book details to remove");
                bookName = Console.ReadLine();
                bookAuthor = Console.ReadLine();
                bookYear = Convert.ToInt32(Console.ReadLine());
                book = new Book()
                {
                    Title = bookName,
                    Author = bookAuthor,
                    Year = bookYear
                };
                l1.RemoveBook(book, library);
                break;
            case 'D':
                Console.WriteLine("The book list");
                l1.DisplayBooks(library);
                break;
            default: Environment.Exit(0);
                break;
        }
    }
}


else if (userType == 'R')
{
    Console.WriteLine("Welcome User, Enter your name");
    string name = Console.ReadLine();

    //Librarian Logic:
    LibraryUser u1 = new LibraryUser(name);

    Console.WriteLine($"Welcome {u1.Name}");

    while (true)
    {
        Console.WriteLine("please choose to Display book (D) or Borrow Book (B)");

        char choice = Console.ReadLine().ToUpper()[0];

        switch (choice)
        {

            case 'D':
                Console.WriteLine("The book list");
                u1.DisplayBooks(library);
                break;

            case 'B':
                Console.WriteLine("Enter Book details to borrow");
                string bookName = Console.ReadLine();
                string bookAuthor = Console.ReadLine();
                int bookYear = Convert.ToInt32(Console.ReadLine());
                Book book = new Book()
                {
                    Title = bookName,
                    Author = bookAuthor,
                    Year = bookYear
                };
                u1.BorrowBook(book, library); // ???
                break;
           
            default:
                Environment.Exit(0);
                break;
        }
    }
}
else
{
    Console.WriteLine("Please enter correct value (L or R)");
}





