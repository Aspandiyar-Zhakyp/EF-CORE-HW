using EF_CORE_ADO.NET.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDebtors();
            ShowAuthors();
            ShowAvaliableBooks();
            ShowTakedBooks();
            NoMoreSorrow();
        }

        static void ShowDebtors()
        {
            using (LibraryEntity db = new LibraryEntity())
            {
                Console.WriteLine("--------------- Debtors ---------------");
                var debtors = db.Сlient.Where(c => c.IsDebtor == true);
                foreach (var item in debtors)
                    Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }

        static void ShowAuthors()
        {
            using (LibraryEntity db = new LibraryEntity())
            {
                Console.WriteLine("--------------- Authors ---------------");
                var authors = from a in db.BooksTheLibrary
                              join b in db.Authors on
                              a.Id_author equals b.Id

                              where a.Id_book == 3
                              select new { FN = b.FirstName, LN = b.LastName };

                foreach (var item in authors)
                {
                    Console.WriteLine($"{item.FN} {item.LN}");
                }
            }
        }

        static void ShowAvaliableBooks()
        {

            using (LibraryEntity db = new LibraryEntity())
            {
                Console.WriteLine("--------------- Avaliable Books ---------------");
                var a_books = db.BooksTheLibrary
                    .Join(db.Books, b => b.Id_book, e => e.Id, (b, e) => new { Title = e.Title, idc = b.Id_customer })
                    .Where(a => a.idc == null);

                foreach (var item in a_books)
                {
                    Console.WriteLine(item.Title);
                }
            }
        }

        static void ShowTakedBooks()
        {

            using (LibraryEntity db = new LibraryEntity())
            {
                Console.WriteLine("--------------- Taked Books ---------------");

                var book = db.BooksTheLibrary
                    .Join(db.Books, b => b.Id_book, e => e.Id, (b, e) => new { Title = e.Title, idc = b.Id_customer })
                    .Join(db.Сlient, x => x.idc, y => y.Id, (b, x) => new { idc = x.Id, Title = b.Title })
                    .Where(p => p.idc == 2);

                foreach (var item in book)
                {
                    Console.WriteLine(item.Title);
                }
            }
        }

        static void NoMoreSorrow()
        {
            using (LibraryEntity db = new LibraryEntity())
            {
                foreach (var item in db.Сlient)
                    item.IsDebtor = false;
                db.SaveChanges();
            }
        }
    }
}
