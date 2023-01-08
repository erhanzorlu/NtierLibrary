using Bll.Repository.Concrete;
using BusinessLayer.Repository.Concrete;
using DataAccess.Entity;
using System;

Console.WriteLine("Hoşgeldiniz...");
BookRepository b = new BookRepository();
BookCategoryRepository bc=new BookCategoryRepository();
UserRepository u= new UserRepository();

//Book book = new Book()
//{
//    BookName = "Dublörün Dilemması",
//    Description = "Biz yetimler intikam iştiyakıyla doluyuzdur. Dehşeti dengelemeye yatkınızdır. Başkalarının öçlerini de almaya hevesleniriz. Yetimlik bize kanlı doğaçlamalar yapma cüreti verir. Suçlamakla ya da suç işlemekle kaybolmayan bir masumiyet imtiyazına sahibizdir.",
//    Page = 160,
//    AuthorId = 3,
//    Price = 60
//};
//Console.WriteLine(b.Create(book));

//foreach (var item in b.GetAll())
//{
//    global::System.Console.WriteLine(item.BookName + " Vergisiz fiyat: " +item.Price+" TL Vergili Fiyatı: "+ item.PriceTotal + " TL");
//}
//Console.WriteLine("------------------------");
b.metot1();
Console.WriteLine("Fiyat Gir");
decimal fiyat = decimal.Parse(Console.ReadLine());

b.metot2(fiyat);
Console.ReadLine();


