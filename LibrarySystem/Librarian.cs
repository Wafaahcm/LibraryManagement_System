﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarian : User
    {
        public int EmployeeNumber { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }
        public void AddBook(Book newBook, Library library)
        {
            library.Add(newBook); //???
        }
        public void RemoveBook(Book newBook, Library library)  // j'ai pas compris comment passer classe library comme para ici 
        {
            library.Remove(newBook);
        }
    }
}
