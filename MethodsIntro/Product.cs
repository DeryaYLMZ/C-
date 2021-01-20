using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIntro
{
    class Product //İerisinde Ürün ile ilgili istediğim özellkikleri barındıran yapıdır.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Explanation { get; set; }
        public int Piece { get; set; }
    }
}
