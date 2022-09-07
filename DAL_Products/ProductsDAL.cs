using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BO_Products;
using DAL_Products;

namespace DAL_Products
{
    public class ProductsDAL : BaseDAO
    {
        public Product_Variables GetById(Guid id)
        {
            Product_Variables product = null;

            command.CommandText = "Product_GetById";

            SqlParameter objParam = command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            objParam.Value = id;

            SqlDataReader objReader = command.ExecuteReader();

            if (objReader.Read())
            {
                product = getItem(objReader);
            }
            conn.Close();

            return product;
        }

        private Product_Variables getItem(SqlDataReader objReader)
        {
            var product = new Product_Variables();

            object ob = null;

            product.Id = objReader.GetGuid(0);

            if ((ob = objReader.GetValue(1)) != DBNull.Value)
                product.Title = Convert.ToString(ob);

            if ((ob = objReader.GetValue(2)) != DBNull.Value)
                product.Price = Convert.ToInt32(ob);
            
            if ((ob = objReader.GetValue(3)) != DBNull.Value)
                product.Image = Convert.ToString(ob);

            if ((ob = objReader.GetValue(4)) != DBNull.Value)
                product.FileName = Convert.ToString(ob);

            if ((ob = objReader.GetValue(5)) != DBNull.Value)
                product.Count = Convert.ToInt32(ob);

            if ((ob = objReader.GetValue(6)) != DBNull.Value)
                product.Token = Convert.ToString(ob);

            return product;
        }
        public List<Product_Variables> GetAll()
        {
            List<Product_Variables> products = new List<Product_Variables>();
            command.CommandText = "Product_GetAll";

            SqlDataReader objReader = command.ExecuteReader();

            while (objReader.Read())
            {
                products.Add(getItem(objReader));
            }
            conn.Close();
            return products;
        }

        public int Update(Product_Variables ob)
        {
            command.CommandText = "Product_Update";
            setParameters(ob);
            var insertedRows = command.ExecuteNonQuery();
            conn.Close();
            return insertedRows;
        }

        public int Add(Product_Variables ob)
        {
            command.CommandText = "Product_Add";

            setParameters(ob);

            var insertedRows = command.ExecuteNonQuery();
            var o = command.Parameters["RETURN VALUE"].Value;

            if (o != null)
                insertedRows = Convert.ToInt32(o);

            conn.Close();
            return insertedRows;
        }

        public int DeletByToken(string token)
        {
            command.CommandText = "Product_Delete";
            SqlParameter objParam = command.Parameters.Add("@Token", SqlDbType.NVarChar);
            objParam.Value = token;

            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public void setParameters(Product_Variables ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            objParam1.Value = ob.Id;
            SqlParameter objParam2 = command.Parameters.Add("@Title", SqlDbType.NVarChar);
            objParam2.Value = ob.Title;
            SqlParameter objParam3 = command.Parameters.Add("@Price", SqlDbType.Int);
            objParam3.Value = ob.Price;
            SqlParameter objParam4 = command.Parameters.Add("@Image", SqlDbType.NVarChar);
            objParam4.Value = ob.Image;
            SqlParameter objParam5 = command.Parameters.Add("@FileName", SqlDbType.NVarChar);
            objParam5.Value = ob.FileName;
            SqlParameter objParam6 = command.Parameters.Add("@Count", SqlDbType.Int);
            objParam6.Value = ob.Count;
            SqlParameter objParam7 = command.Parameters.Add("@Token", SqlDbType.NVarChar);
            objParam7.Value = ob.Token;
            SqlParameter objParam8 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam8.Direction = ParameterDirection.ReturnValue;
        }
    }
}
