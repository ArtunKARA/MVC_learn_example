using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LrnEFCore.DataBaseFirst.DAL
{
    public class Product//Products Tablo içerisindeki stunlar ile ilgili işlemler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
