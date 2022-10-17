using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass
{
    internal class Insan
    {
        public string Ad { get; set; } //Aldığı değeri değiştirmeden geri döndüreceksek get;set; şeklinde
        public string Soyad { get; set; }
        public string GozRengi { get; set; }
        public string SacRengi { get; set; }
        public DateTime DogumTarihi { get; set; }

        public int Yas
        {
            get
            {
                int yasHesap = DateTime.Now.Year - DogumTarihi.Year; //Readonl. değer veremezsin. Sadece değeri okursun.
                return yasHesap;
            }
        }

        private string tcNo;// Field. sette düzenlenen değere getten ulaşabilmek için bu taşıyıcı görevi görür. 

        public string TcNo
        {
            get { return tcNo; }
            set
            {
                if (value.Length == 11)// Değer üzerinde düzenleme yapar.
                {
                    tcNo = value;
                }
                else
                {
                    tcNo = "Hatalı";
                }
            }
        }

        public string Konus()
        {
            return Ad+ " konuşuyor.";
        }
    }
}
