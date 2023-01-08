using DataAccess.Context;

namespace BusinessLayer.Repository.Concrete
{
    public class Metotlar
    {
        BookContextDb db = new BookContextDb();
        public void metot1()
        {
            var result = (from o in db.Books
                          select o.Price).Sum();
            Console.WriteLine("Toplam kitapların fiyatı: " + result + " TL");
        }
        public void metot2(decimal deger)
        {
            var result = (from b in db.Books

                          join a in db.Authors on b.Id equals a.Id
                          where b.Price > deger
                          select new
                          {
                              Kdvli_Fiyat = b.PriceTotal,
                              b.BookName,

                              Yazar = a.FirstName + a.LastName,


                          });
            foreach (var item in result)
            {
                global::System.Console.WriteLine(item);
            }

        }
        public void metot3(string deger)
        {
            var result = (from b in db.Books

                          join a in db.Authors on b.Id equals a.Id
                          where b.BookName.Contains(deger)
                          select new
                          {
                              b.BookName,
                              Kdvli_Fiyat = b.PriceTotal,
                              Yazar = a.FirstName + a.LastName,


                          });
            foreach (var item in result)
            {
                global::System.Console.WriteLine(item);
            }

        }
        public void metot4(string deger)
        {
            var result = (from b in db.Books

                          join a in db.Authors on b.Id equals a.Id
                          where a.FirstName.Contains(deger)
                          select new
                          {
                              Kitap_İsmi = b.BookName,
                              Kdvli_Fiyat = b.PriceTotal,
                              Yazar = a.FirstName + " " + a.LastName,


                          });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public void metot5(string deger)
        {
            var result = (from b in db.Books
                          join bc in db.BookCategories on b.Id equals bc.BookId
                          join a in db.Authors on b.Id equals a.Id
                          where bc.Category.CategoryName.Contains(deger)
                          select new
                          {
                              Kitap_İsmi = b.BookName,
                              Kdvli_Fiyat = b.PriceTotal,
                              Yazar = a.FirstName + " " + a.LastName,
                              Kategori = bc.Category.CategoryName,


                          });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public void metot6()
        {
            var result = from b in db.Books

                         select new
                         {
                             b.BookName,
                             dolar = b.Price / 18,
                             kdvliDolar = b.PriceTotal / 18,

                         };
            foreach (var item in result)
            {
                global::System.Console.WriteLine(item);
            }
        }
        public void metot7(string deger)
        {
            var result = (from b in db.Books

                          join a in db.Authors on b.Id equals a.Id
                          where b.Description.Contains(deger)
                          select new
                          {
                              Kitap_İsmi = b.BookName,
                              Kdvli_Fiyat = b.PriceTotal,
                              Açıklama = b.Description,
                              Yazar = a.FirstName + " " + a.LastName,


                          });


            foreach (var item in result)
            {
                global::System.Console.WriteLine(item);
              
            }
            Console.WriteLine("boş");
        }

    }
}
