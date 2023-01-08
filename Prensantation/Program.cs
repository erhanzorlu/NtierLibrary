using Bll.Repository.Concrete;
using BusinessLayer.Repository.Concrete;

Console.WriteLine("Hoşgeldiniz...");
//BookRepository bb = new BookRepository();
//BookCategoryRepository bc = new BookCategoryRepository();
//UserRepository u = new UserRepository();
Metotlar b= new Metotlar(); 

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
while (true)
{
    Console.WriteLine("---------Menu---------\n1-Fiyata göre listele\n2-Toplam fiyatı getir\n3-Kitap adı ara\n4-Yazar adı ara\n5-Kategori adı ara\n6-Kitapların dolar cinsinden fiyatları\n7-Açıklamaya göre");
    int sayi = int.Parse(Console.ReadLine());
    if (sayi == 1)
    {

        Console.WriteLine("Fiyat Gir");
        decimal fiyat = decimal.Parse(Console.ReadLine());
        b.metot2(fiyat);
        Console.ReadLine();
    }
    else if (sayi == 2)
    {
        b.metot1();
    }
    else if (sayi == 3)
    {
        global::System.Console.WriteLine("Kitap adı giriniz...");
        string ara = Console.ReadLine();
        b.metot3(ara);
    }
    else if (sayi == 4)
    {
        global::System.Console.WriteLine("Yazar adı giriniz...");
        string ara = Console.ReadLine();
        b.metot4(ara);
    }
    else if (sayi == 5)
    {
        global::System.Console.WriteLine("Kategori adı giriniz...");
        string ara = Console.ReadLine();
        b.metot5(ara);
    }
    else if (sayi == 6)
    {
     
        b.metot6();
    }
    else if (sayi==7)
    {
        global::System.Console.WriteLine("Açıklama giriniz...");
        string ara = Console.ReadLine();
        b.metot7(ara);
    }
}






