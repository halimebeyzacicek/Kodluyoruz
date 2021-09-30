using System;

namespace kodluyoruz_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap book = new Kitap("Beyaz Geceler", -202, "Dostoyevski");
            //book.yazdir(book.sayfaSayisi); //kitap class ı içerisinde değişkenleri private olduğu için onlara bu şekilde ulaşamayız.
           
            int sayfaSayisi =book.getSayfaSayisi();
            book.yazdir(sayfaSayisi);

            book.setSayfaSayisi(-10);//set ile sayfa sayisini değiştirdik. 
            int sayfaSayisi1 = book.getSayfaSayisi();
            book.yazdir(sayfaSayisi1);

            Console.ReadLine();
        }
    }
}
