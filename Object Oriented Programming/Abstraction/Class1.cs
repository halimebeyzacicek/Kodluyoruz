using System;
using System.Collections.Generic;
using System.Text;

namespace kodluyoruz_encapsulation
{
    public class Roman : Kitap//kalıtım
    {
        public Roman(string kitapAdi, int sayfaSayisi, string yazar) : base(kitapAdi, sayfaSayisi, yazar)
        {
            //parent in kurucu çalışacak.
        }
        public string getYazar()
        {
            return this.yazar;
        }
        public void setYazar(string yazar)
        {
            this.yazar = yazar;
        }
        public void yazdirString(string yazar)
        {
            Console.WriteLine("Yazar Adı:{0}", yazar);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        public string getKitapAdi()
        {
            return this.kitapAdi = kitapAdi;
        }

        public override void polyKitap(string kitapAdi)
        {
            Console.WriteLine("Roman Poly(kitabın adi:{0})", kitapAdi);
        }
    }
}
