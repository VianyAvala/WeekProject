using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekProject.Models;

namespace WeekProject.Controllers
{
    public class BooksController : Controller
    {

        private readonly ApplicationDbContext _context = null;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Books
        public ActionResult Index()
        {

            var Books = _context.Books.ToList();
            return View(Books);
            
        }

        public ActionResult Details(int id)
        {
            
            var Book = _context.Books.FirstOrDefault(B => B.Id == id);
            if (Book != null)
            {
                return View(Book);
            }
            return HttpNotFound();
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var Books = _context.Books.FirstOrDefault(B => B.Id == id);
            if (Books != null)

            {
                var categories = _context.Categories.ToList();
                ViewBag.Categories = categories;
                return View(Books);
            }
            return HttpNotFound("Books  doesn't exists");
        }

        [HttpPost]
        public ActionResult Edit(Book Books)
        {
            if (Books != null)
            {
                var BookInDb = _context.Books.Find(Books.Id);
                if (BookInDb != null)
                {
                    BookInDb.Price = Books.Price;
                    BookInDb.BookName = Books.BookName;
                    BookInDb.BookType = Books.BookType;
                    BookInDb.Description = Books.Description;
                  
                    _context.SaveChanges();

                }
                return RedirectToAction("Index");


            }
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(Books);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var BookInDb = _context.Books.FirstOrDefault(B => B.Id == id);
            if (BookInDb != null)
            {
                _context.Books.Remove(BookInDb);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var Books = _context.Books.FirstOrDefault(B => B.Id == id);
            if (Books != null)

            {
                var categories = _context.Categories.ToList();
                ViewBag.Categories = categories;
                return View(Books);
            }
            return HttpNotFound("Books  doesn't exists");
        }

        [HttpPost]

        public ActionResult Update(Book Books)
        {
            if (Books != null)
            {
                var BookInDb = _context.Books.Find(Books.Id);
                if (BookInDb != null)
                {
                    BookInDb.Price = Books.Price;
                    BookInDb.BookName = Books.BookName;
                    BookInDb.BookType = Books.BookType;
                    BookInDb.Description = Books.Description;

                    _context.SaveChanges();

                }
                return RedirectToAction("Index");


            }
            var categories = _context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(Books);
        }

    }
}