using Dal.Entity;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Concrete
{
    public class BookCategoryRepository
    {
        BookContextDb db = new BookContextDb();
        public List<BookCategory> GetAll()
        {
            return db.BookCategories.ToList();
        }
        public void Dondur()
        {
            var result = from o in db.BookCategories
                        
                         select new
                         {
                             o.Book.BookName,
                             o.Category.CategoryName

                         }
                         ;
            foreach (var item in result)
            {
                global::System.Console.WriteLine(item.BookName + " " + item.CategoryName);
            }
        }
      
        
    }
}
