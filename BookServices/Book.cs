using System;
using System.Collections;
using System.Collections.Generic;
namespace BookServices
{
    public class Book : IBookInterface
    {
        public static List<Book> listOfBooks= new List<Book>();
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookPublisherName { get; set; }
        public int BookPrice { get; set; }

        public Book Add(Book book)
        {
            if (Book.listOfBooks.Count !=0 || Book.listOfBooks.Count==0)
            {
                Book.listOfBooks.Add(book);
             
            }
            return book;
        }

        

        public Book DeleteBook(int BookID)
        {
            Book temp=null;
            var count = Book.listOfBooks.Count;
            if (Book.listOfBooks.Count != 0)
            {
                foreach (Book book in Book.listOfBooks)
                {
                    if (book.BookID == BookID)
                    {
                        temp = book;
                        break;
                    }
                    else
                    {
                        --count;
                    }
                }
            }
            
          
            if (temp != null)
            {
                Book.listOfBooks.RemoveAt(Book.listOfBooks.IndexOf(temp));
                return temp;
            }
            else
            {
                return temp ;
            }
         
        }

        public IList<Book> GetAllBooks()
        {
         
            return Book.listOfBooks;
        }

        public Book GetBookById(int bookID)
        {
            Book temp = null;
            var count = Book.listOfBooks.Count;
            if (Book.listOfBooks.Count != 0)
            {
                foreach (Book book in Book.listOfBooks)
                {
                    if (book.BookID == bookID)
                    {
                        temp = book;
                        break;
                    }
                    else
                    {
                        --count;
                    }
                }
            }


            if (temp != null)
            {
           
                return temp;
            }
            else
            {
                return temp;
            }
        }

        public bool UpdateBook(Book newBook, int bookid)
        {

            Book temp = null;
            foreach (Book book in Book.listOfBooks)
            {
                if (book.BookID == bookid)
                {
                    temp = book;
                }
            }
            if (temp != null )
            {
                //Book.listOfBooks.Insert(Book.listOfBooks.IndexOf(temp), newBook);
                int index=Book.listOfBooks.IndexOf(temp);
                Book.listOfBooks[index] = newBook;
                return true;
            }
            else
            {
                return false ;
            }

         
        }
    }
}
