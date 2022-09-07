using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_Products
{
    public class Product_Variables
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string FileName { get; set; }
        public int Count { get; set; }
        public string Token { get; set; }
        
    }
}
