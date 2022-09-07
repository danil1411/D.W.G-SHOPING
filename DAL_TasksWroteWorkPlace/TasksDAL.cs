using DAL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL_TasksWroteWorkPlace
{
    public class TasksDAL : BaseDAL
    {
        public int Add(BO_Variables ob)
        {
            command.CommandText = "WroteWorkPlace_Add";

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

        private void setParameters(BO_Variables ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@id", SqlDbType.UniqueIdentifier);
            objParam1.Value = ob.id;
            SqlParameter objParam2 = command.Parameters.Add("@Text", SqlDbType.NVarChar);
            objParam2.Value = ob.Text;
            SqlParameter objParam3 = command.Parameters.Add("@Hours_Minutes", SqlDbType.Int);
            objParam3.Value = ob.Hours_Minutes;
            SqlParameter objParam4 = command.Parameters.Add("@Hours_Hours", SqlDbType.Int);
            objParam4.Value = ob.Hours_Hours;
            SqlParameter objParam5 = command.Parameters.Add("@Date_Days", SqlDbType.Int);
            objParam5.Value = ob.Date_Days;
            SqlParameter objParam6 = command.Parameters.Add("@Date_Month", SqlDbType.Int);
            objParam6.Value = ob.Date_Month;
            SqlParameter objParam7 = command.Parameters.Add("@Repeat", SqlDbType.Int);
            objParam7.Value = ob.Repeat;
            SqlParameter objParam8 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam8.Direction = ParameterDirection.ReturnValue;
        }
    }
}
