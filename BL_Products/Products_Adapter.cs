using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO_Products;
using DAL_Products;
namespace BL_Products
{
    public class Products_Adapter
    {

        public static Product_Variables GetById(string iD)
        {
            Product_Variables product;
            product = (new ProductsDAL()).GetById(new Guid(iD));
            return product;
        }
        public static Product_Variables GetById(Guid iD)
        {
            Product_Variables product;
            product = (new ProductsDAL()).GetById(iD);
            return product;
        }

        public static List<Product_Variables> GetAll()
        {
            return (new ProductsDAL()).GetAll();
        }
        public static int Add(string Title, int Price, int Count, string Token, string Image, string FileName)
        {
            Product_Variables product = new Product_Variables();
            product.Id = Guid.NewGuid();
            product.Title = Title;
            product.Price = Price;
            product.Count = Count;
            product.Token = Token;
            product.Image = Image;
            product.FileName = FileName;
            int row = (new ProductsDAL()).Add(product);
            return row;
        }
        public static List<Product_Variables> GetByTitle(string text)
        {
            List<Product_Variables> products = GetAll().FindAll(c => (c.Title.ToLower().CompareTo(text.Trim().ToLower())) == 0);
            return products;
        }
        public static List<Product_Variables> GetByToken(string text)
        {
            List<Product_Variables> products = GetAll().FindAll(c => (c.Token.ToLower().CompareTo(text.Trim().ToLower())) == 0);
            return products;
        }
        public static List<Product_Variables> GetByPrice(int text)
        {
            List<Product_Variables> products = GetAll().FindAll(c => (c.Price.CompareTo(text)) == 0);
            return products;
        }
        public static int DeleteByToken(string token)
        {
            int prap;
            prap = (new ProductsDAL()).DeletByToken(token);
            return prap;
        }
        public static int Update(Product_Variables product, string Title, int Price, int Count, string Token, string Image)
        {
            product.Title = Title;
            product.Price = Price;
            product.Count = Count;
            product.Token = Token;
            product.Image = Image;
            int prap = (new ProductsDAL()).Update(product);
            return prap;
        }
    }
}
