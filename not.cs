using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace not
{
    class not
    {
        public double not1, not2, not3, ort;
        string son;
        public double ortalama()
        {
            ort = (not1 + not2 + not3) / 3;
            return (ort);
        }
        public string sonuc()
        {
            if (ort < 50)
                son = "kaldı";
            else
                son = "gecti";
            return (son);
        }
    }
}
