using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar3
{
    internal class Emlak
    {
        private string semt;
        private string renk;
        private int odasayisi;
        private int katno;
        private double alan;

        public string SEMTİ
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string RENGİ
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }
        public int ODASAYİSİ
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }
        public int KATNUMARASI
        {
            get { return katno; }
            set { katno = Math.Abs(value); }    
        }
        public double ALANI
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
