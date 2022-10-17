using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtekrar
{
    internal class Customer //propert tutan class
    {
        //Property
        public int Id { get; set; }//bir müşterinin özelliklerini tutmak için kullandığımız nesne. //Müşterinin ıd si olur

        public string FirsName { get; set; } //Müşterini ismi olur
        public string LastName { get; set; } //Müşterinin soyismi
        public string City { get; set; } //Müşterinin şehri

        //Kural getiriliyorsa örnek verirsek FirstName set edilirse yani ona bir değer verirse firstname başına başka bir karakter getirelim mesela Doç

        //Burda bunu yaparken get bloğu açık yazılır yani get ve set içindeki noktali virgül kaldırılarak süslü parantez açılır. Firstname bilerek yorum satırına aldım get set değer alıcaksa diye örnek yapıyorum. Örnek: 
        public string firstname; // get set içinde işlem yapılacaksa field tanımlanır.
        //public string FirstName 
        //{ 
        //    get 
        //    {
        //        return "Mr."+ firstname;   //Müşteriyi çektiğin zaman artık önünde Mr. olacak şekilde ver demek. ama genelde böyle yapılmaz üstteki gibi yapılır.
        //    }

        //    set
        //    { 
        //        firstname = value;  
        //    }
        //}

        //set veri yazıldığı zaman
        //get veri okunduğu zaman
        //ilk yazılır sonra okunur. ilk set sonra get çalışır gibi

    }
}
