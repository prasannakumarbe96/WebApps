using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BookServices
{
    public interface IBookInterface
    {

       
        bool UpdateBook(Book book, int bookid);
        Book DeleteBook(int bookid);
        IList<Book> GetAllBooks();
        Book Add(Book book);
        Book GetBookById(int bookID);

    }

   
}
