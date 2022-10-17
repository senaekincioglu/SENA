using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSLAR2
{
    internal class URUNBİLGİSİ
    {
        //class ÖZELLİKLERİ CLASS DA TANIMLANIR. programda çağrıldı

       //string _adi;//adda değişiklik yapılmak istenirse.
        public int ıd { get; set; }
       
        //public string Adi { get { return "aa" + _adi; } set { _adi = value; } }   
        public int Adet { get; set; }  

        public string Adi
        {
            get { return "aaa" + Adi; }
            set { Adi = value; }
        }
        }
    }

