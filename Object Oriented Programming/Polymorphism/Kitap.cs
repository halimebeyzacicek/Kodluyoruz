using System;
using System.Collections.Generic;
using System.Text;

namespace kodluyoruz_encapsulation
{
    public class Kitap
    {
        private int sayfaSayisi;//dışarıdan erişilip negatif bir değer girlmesini istemiyorum.anlamsızlık olur.
        public string kitapAdi, yazar;

        //Kitap sınıfından oluşturacağımız bir nesne bu niteliklerin hepsini taşısın.
        //Bu yüzden oluşturacağımız Constructor(kurucu) metodunu bu şekilde oluşturalım.

        public Kitap(string kitapAdi,int sayfaSayisi, string yazar) //kurucu metot
        {
            this.kitapAdi = kitapAdi;
            this.sayfaSayisi = sayfaSayisi;
            this.yazar = yazar;
            if (sayfaSayisi <= 0)//sayfa sayısının negatif girilmesini önlemek için.
            {
                this.sayfaSayisi = sayfaSayisi*-1;
            }
            else
            {
                this.sayfaSayisi = sayfaSayisi;
            }
        }
        public int getSayfaSayisi()//get
        {
            return this.sayfaSayisi;
        }
        public void setSayfaSayisi(int sayfaSayisi)//set
        {
            this.sayfaSayisi = sayfaSayisi;
            if (sayfaSayisi <= 0)//sayfa sayısının negatif girilmesini önlemek için.
            {
                this.sayfaSayisi = sayfaSayisi * -1;
            }
            else
            {
                this.sayfaSayisi = sayfaSayisi;
            }
            Console.WriteLine("Sayfa sayisi değiştirildi!");
        }

        public void yazdirInt(int sayfaSayisi)
        {
            Console.WriteLine("kitabın sayfa sayisi:{0}",sayfaSayisi);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public string getKitapAdi()
        {
            return this.kitapAdi = kitapAdi;
        }

        public virtual void polyKitap(string kitapAdi)
        {
            Console.WriteLine("Kitap Poly(kitabın adi:{0})", kitapAdi);
        }
       
    }
}
