﻿using System;

namespace kodluyoruz_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap book = new Kitap("Beyaz Geceler", -202, "Dostoyevski");
            //book.yazdir(book.sayfaSayisi); //kitap class ı içerisinde değişkenleri private olduğu için onlara bu şekilde ulaşamayız.
           
            int sayfaSayisi =book.getSayfaSayisi();
            book.yazdirInt(sayfaSayisi);

            book.setSayfaSayisi(-10);//set ile sayfa sayisini değiştirdik. 
            sayfaSayisi = book.getSayfaSayisi();
            book.yazdirInt(sayfaSayisi);

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n#Kalıtım ile Kitap#");

            Roman book1 = new Roman("Şato", 100, "Kafka");//roman ın parent i kitap olduğu için kitap ta tanımlı her şey roman da da tanımlı.

            sayfaSayisi= book1.getSayfaSayisi();
            book1.yazdirInt(sayfaSayisi);

            book1.setSayfaSayisi(-30);
            sayfaSayisi = book1.getSayfaSayisi();
            book1.yazdirInt(sayfaSayisi);

            /////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n#Kalıtım ile Roman#");

            string yazar=book1.getYazar();
            book1.yazdirString(yazar);

            book1.setYazar("Franz Kafka");
            yazar=book1.getYazar();
            book1.yazdirString(yazar);
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n#Polymorphism#");
            Kitap book3 = new Roman("Hayvan Çiftliği", 100, "GeorgeOrwell");
            Kitap book4 = new Kitap("İçimizdeki Şeytan", 150, "SabahattinAli");

            string kitap_adi = book3.getKitapAdi();
            string kitap_adi1 = book4.getKitapAdi();

            book3.polyKitap(kitap_adi);
            book4.polyKitap(kitap_adi1);


            Console.ReadLine();
        }
    }
}
