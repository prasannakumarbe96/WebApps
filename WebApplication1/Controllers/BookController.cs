using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
      public   int count;
        public IBookInterface book;
        public BookController(IBookInterface books)
        {
            
            book = books;
        }
       
    
        public IActionResult UpdateBook(Book bk )
        {
            var xyz=false;


            if (bk != null ) {
            
                 xyz = (bool)this.book.UpdateBook(bk, bk.BookID);
            ViewData["Res"] = xyz;
            }
            else
            {
                ViewData["Res"] = false;
            }


            return View();
        }
       
        public  IActionResult GetBookById(int BookID)
        {
            Book books = (Book)this.book.GetBookById(BookID);
            ViewData["GetBook"] = books;
            if (books != null)
                return RedirectToAction("UpdateBook", "Book",books);
            return View();
        }
     
        public IActionResult Add(Book bk)
        {
            if (bk.BookID != 0)
            {


                Book adBook = this.book.Add(bk);
                ViewData["Res"] = adBook;

            }
            ViewData["Res"] = null;
            return View();

        }
    


    public IActionResult DeleteBook(Book dbk)
    {
        Book dbook = (Book)this.book.DeleteBook(dbk.BookID);
        ViewData["Res"] = dbook;
        return View();



    }
    public IActionResult GetBooks()
    {
        var listbook = this.book.GetAllBooks();
        ViewData["listbooks"] = listbook;
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ListOfBooks()
    {
        return View();
    }
}
}