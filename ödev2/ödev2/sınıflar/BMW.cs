using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2.sınıflar
{
    public class BMW : Hareketsekli
    {
        public void Hizligit()
        {
            Console.WriteLine("BMW COK HIZLI GIDER");
        }
        public void Denizgit()
        {
            Console.WriteLine("BMW DENİZDE YUZER"); 
        }
        public void Havadagit()
        {
            Console.WriteLine("BMW HAVADA UCAR");
        }

    }
}
