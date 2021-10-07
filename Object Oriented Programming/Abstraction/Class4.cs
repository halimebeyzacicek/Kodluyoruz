using System;
using System.Collections.Generic;
using System.Text;

namespace kodluyoruz_encapsulation
{
    class ogretmen : okul
    {
        public override void Yasi(int dg, int bg)
        {
            int yas = bg - dg;
            if (yas < 50)
            {
                Console.WriteLine("Şuan emekli olamazsınız!");
            }
            else
            {
                Console.WriteLine("Emekli olabilirsiniz!");
            }
        }
    }
}
