using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2.sınıflar
{
    public class Porsche : Hareketsekli
    {
        public void Hizligit()
        {
            Console.WriteLine("PORSCHE COK HIZLI GIDEMEZ");
        }
        public void Denizgit()
        {
            Console.WriteLine("PORSCHE DENIZDE GIDEMEZ");
        }
        public void Havadagit()
        {
            Console.WriteLine("PORSCHE HAVADA GIDEBILIR");
        }
       
    }
}
