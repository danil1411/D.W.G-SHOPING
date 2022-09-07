using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.W.G_SHOPING
{
    class Product
    {
        public static List<Product> MyList { get; set; }
        public List<Product> products = new List<Product>();
        protected string producttitle;
        protected int productprice;
        protected string productimage;
        protected string productcount;
        protected string producttoken;
        public Product(string producttitle, int productprice, string productimage, string productcount, string producttoken)
        {
            this.producttitle = producttitle;
            this.productimage = productimage;
            this.productprice = productprice;
            this.productcount = productcount;
            this.producttoken = producttoken;
        }
        public Product()
        {
        }
        public string ProductTitle
        {
            get { return producttitle; }
            set { producttitle = value; }
        }
        public string ProductImage
        {
            get { return productimage; }
            set { productimage = value; }
        }
        public int ProductPrice
        {
            get { return productprice; }
            set { productprice = value; }
        }
        public string ProductCount
        {
            get { return productcount; }
            set { productcount = value; }
        }
        public string ProductToken
        {
            get { return producttoken; }
            set { producttoken = value; }
        }
    }
}
