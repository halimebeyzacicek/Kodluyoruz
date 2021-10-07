using System;
using System.Collections.Generic;
using System.Text;

namespace kodluyoruz_encapsulation
{
    abstract class okul
    {
        public string adi;
        public int dogum_yili;
        public int bugun;

        abstract public void Yasi(int dg, int bg);
    }
}
