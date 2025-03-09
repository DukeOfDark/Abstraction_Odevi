using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev2.sınıflar
{
    public class Mercedes : Hareketsekli
    {
        public void Hizligit()
        {
            Console.WriteLine("Mercedes COK HIZLI GIDEMEZ");
        }
        public void Denizgit()
        {
            Console.WriteLine("Mercedes DENİZDE YUZER");
        }
        public void Havadagit()
        {
            Console.WriteLine("Mercedes HAVADA UCAR");
        }

    }
}