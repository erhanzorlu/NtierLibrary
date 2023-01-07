using BusinessLayer.Repository.Abstract;
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
    public class BookRepository : ICrudRepository<Book>
    {
        BookContextDb db = new BookContextDb();
        public string Create(Book Entity)
        {
            try
            {
                db.Books.Add(Entity);
                db.SaveChanges();
                return "Kayıt başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Delete(int id)
        {
            try
            {
                db.Books.Remove(FindId(id));
                db.SaveChanges();

                return "Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Book FindId(int id)
        {
            return db.Books.Find(id);
        }

        public List<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public string Update(Book Entity)
        {
            try
            {
                db.Entry(Entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

                return $"Güncelleme başarılı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
       
    }
}
