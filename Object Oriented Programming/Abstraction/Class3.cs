using System;
using System.Collections.Generic;
using System.Text;

namespace kodluyoruz_encapsulation
{
    class ogrenci : okul
    {
        public override void Yasi(int dg, int bg)
        {
            int yas = bg - dg;
            if (yas < 18)
            {
                Console.WriteLine("Siz oy kullanamazsınız ama markete girebilirsiniz!");
            }
            else
            {
                Console.WriteLine("Siz oy kullanabilirsiniz ve markete girebilirsiniz!");
            }
        }
    }
}
