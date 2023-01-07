
using BusinessLayer.Repository.Abstract;
using Dal.Entity;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repository.Concrete
{
    public class UserRepository : ICrudRepository<User>
    {
        BookContextDb db = new BookContextDb();
        public string Create(User Entity)
        {
            try
            {
                db.Users.Add(Entity);
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
                db.Users.Remove(FindId(id));
                db.SaveChanges();

                return "Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public User FindId(int id)
        {
            return db.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public string Update(User Entity)
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
        public bool Giris(string kullanici, int password)
        {
            foreach (var item in db.Users)
            {
                if (item.UserName == kullanici && item.Password == password)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
