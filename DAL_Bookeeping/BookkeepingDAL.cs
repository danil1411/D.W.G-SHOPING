using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BO_Bookkeeping;
using DAL_Bookkeeping;
namespace DAL_Bookkeeping
{
    public class BookkeepingDAL : BaseDAL
    {
        public int Add(BookkeepingBO ob)
        {
            //SqlCommand command = new SqlCommand();
            //string query = "insert into BookkeepingBO (id, filename, userfilename, favourite)";
            //query += " values (@id, @filename, @userfilename, @favourite)";
            command.CommandText = "Bookkeeping_Add2";

            setParameters(ob);
            var insertedRows = command.ExecuteNonQuery();
            var o = command.Parameters["RETURN VALUE"].Value;

            if (o != null)
            {
                insertedRows = Convert.ToInt32(o);
            }

            connection.Close();
            return insertedRows;
        }
        public List<BookkeepingBO> GetAll()
        {
            List<BookkeepingBO> contacts = new List<BookkeepingBO>();
            command.CommandText = "Bookkeeping_GetAll";

            SqlDataReader objReader = command.ExecuteReader();

            while (objReader.Read())
            {
                contacts.Add(getItem(objReader));
            }
            connection.Close();
            return contacts;
        }
        public List<BookkeepingBO> GetAllFile()
        {
            List<BookkeepingBO> contacts = new List<BookkeepingBO>();
            command.CommandText = "Bookkeeping_File";

            SqlDataReader objReader = command.ExecuteReader();

            while (objReader.Read())
            {
                contacts.Add(getFile(objReader));
            }
            connection.Close();
            return contacts;
        }
        private BookkeepingBO getFile(SqlDataReader objReader)
        {
            var contact = new BookkeepingBO();

            object ob = null;

            if ((ob = objReader.GetValue(0)) != DBNull.Value)
                contact.token = Convert.ToString(ob);

            if ((ob = objReader.GetValue(1)) != DBNull.Value)
                contact.FileStreamCol = (byte[]) ob;
            return contact;
        }
        private BookkeepingBO getItem(SqlDataReader objReader)
        {
            var contact = new BookkeepingBO();

            object ob = null;

            contact.id = objReader.GetGuid(0);

            if ((ob = objReader.GetValue(1)) != DBNull.Value)
                contact.userfilename = Convert.ToString(ob);

            if ((ob = objReader.GetValue(2)) != DBNull.Value)
                contact.favourite = Convert.ToInt32(ob);

            if ((ob = objReader.GetValue(3)) != DBNull.Value)
                contact.token = Convert.ToString(ob);

            if ((ob = objReader.GetValue(4)) != DBNull.Value)
                contact.RootDirectory = Convert.ToString(ob);

            if ((ob = objReader.GetValue(5)) != DBNull.Value)
                contact.FileName2 = Convert.ToString(ob);

            if ((ob = objReader.GetValue(6)) != DBNull.Value)
                contact.FileAttribute = Convert.ToString(ob);

            if ((ob = objReader.GetValue(7)) != DBNull.Value)
                contact.FileCreateDate = Convert.ToDateTime(ob);

            if ((ob = objReader.GetValue(8)) != DBNull.Value)
                contact.FileSize = Convert.ToDecimal(ob);

            if ((ob = objReader.GetValue(9)) != DBNull.Value)
                contact.FileStreamCol = (byte[]) ob;

            return contact;
        }
        //public int Add_id(BookkeepingBO boa)
        //{
        //    //SqlCommand command = new SqlCommand();
        //    //string query = "insert into BookkeepingBO (id, filename, userfilename, favourite)";
        //    //query += " values (@id, @filename, @userfilename, @favourite)";
        //   command.CommandText = "id_Bookkeeping_Add";

        //   setParameters3(boa);
        //    var insertedRows = command.ExecuteNonQuery();
        //    var o = command.Parameters["RETURN VALUE"].Value;

        //    if (o != null)
        //    {
        //        insertedRows = Convert.ToInt32(o);
        //    }

        //    connection.Close();
        //    return insertedRows;
        //}
        public int Update(BookkeepingBO bo)
        {
            command.CommandText = "Bookkeeping_update";
            setParameters2(bo);

            var insertedRows = command.ExecuteNonQuery();
            var o = command.Parameters["RETURN VALUE"].Value;
            if (o != null)
            {
                insertedRows = Convert.ToInt32(o);
            }

            connection.Close();
            return insertedRows;
        }
        public int UpdateBook(BookkeepingBO bo)
        {
            command.CommandText = "Bookkeeping_Update";
            SqlParameter objParam3 = command.Parameters.Add("@userfilename", SqlDbType.NVarChar);
            objParam3.Value = bo.userfilename;
            SqlParameter objParam4 = command.Parameters.Add("@favourite", SqlDbType.Bit);
            objParam4.Value = bo.favourite;
            SqlParameter objParam = command.Parameters.Add("@token", SqlDbType.NVarChar);
            objParam.Value = bo.token;

            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public int deleteToken (string token, string RootDirectory, string FileName2)
        {
            command.CommandText = "Bookkeeping_Delete";
            SqlParameter objParam = command.Parameters.Add("@token", SqlDbType.NVarChar);
            objParam.Value = token;
            SqlParameter objParam2 = command.Parameters.Add("@RootDirectory", SqlDbType.NVarChar);
            objParam2.Value = RootDirectory;
            SqlParameter objParam3 = command.Parameters.Add("@FileName", SqlDbType.NVarChar);
            objParam3.Value = FileName2;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        private void setParameters(BookkeepingBO ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@ID", SqlDbType.UniqueIdentifier);
            objParam1.Value = ob.id;
            SqlParameter objParam3 = command.Parameters.Add("@userfilename", SqlDbType.NVarChar);
            objParam3.Value = ob.userfilename;
            SqlParameter objParam4 = command.Parameters.Add("@favourite", SqlDbType.Bit);
            objParam4.Value = ob.favourite;
            SqlParameter objParam6 = command.Parameters.Add("@token", SqlDbType.NVarChar);
            objParam6.Value = ob.token;
            SqlParameter objParam9 = command.Parameters.Add("@RootDirectory", SqlDbType.VarChar);
            objParam9.Value = ob.RootDirectory;
            SqlParameter objParam10 = command.Parameters.Add("@FileName", SqlDbType.VarChar);
            objParam10.Value = ob.FileName2;
            SqlParameter objParam11 = command.Parameters.Add("@FileAttribute", SqlDbType.VarChar);
            objParam11.Value = ob.FileAttribute;
            SqlParameter objParam12 = command.Parameters.Add("@FileCreateDate", SqlDbType.DateTime);
            objParam12.Value = ob.FileCreateDate;
            //SqlParameter objParam13 = command.Parameters.Add("@FileSize", SqlDbType.Decimal);
            //objParam13.Value = ob.FileSize;
            SqlParameter objParam14 = command.Parameters.Add("@FileStreamCol", SqlDbType.VarBinary);
            objParam14.Value = ob.FileStreamCol;
            SqlParameter objParam7 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam7.Direction = ParameterDirection.ReturnValue;
        }
        private void setParameters2(BookkeepingBO ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            objParam1.Value = ob.id;
            SqlParameter objParam2 = command.Parameters.Add("@filename", SqlDbType.NVarChar);
            objParam2.Value = ob.FileName2;
            SqlParameter objParam3 = command.Parameters.Add("@userfilename", SqlDbType.NVarChar);
            objParam3.Value = ob.userfilename;
            SqlParameter objParam4 = command.Parameters.Add("@favourite", SqlDbType.Bit);
            objParam4.Value = ob.favourite;
            SqlParameter objParam6 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam6.Direction = ParameterDirection.ReturnValue;
        }
        private void setParameters3(BookkeepingBO ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            objParam1.Value = ob.id;
            SqlParameter objParam2 = command.Parameters.Add("@filename", SqlDbType.NVarChar);
            objParam2.Value = ob.FileName2;
            SqlParameter objParam3 = command.Parameters.Add("@userfilename", SqlDbType.NVarChar);
            objParam3.Value = ob.userfilename;
            SqlParameter objParam4 = command.Parameters.Add("@favourite", SqlDbType.Bit);
            objParam4.Value = ob.favourite;
            SqlParameter objParam5 = command.Parameters.Add("@file", SqlDbType.VarBinary);
            objParam5.Value = ob.FileStreamCol;
            SqlParameter objParam6 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam6.Direction = ParameterDirection.ReturnValue;
        }
    }
}
