using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BO_Daily;

namespace DAL_Daily
{
    public class DailyDAL : BaseDAO
    {
        public DailyTask GetById(Guid id)
        {
            DailyTask task = null;

            command.CommandText = "Daily_GetById";

            SqlParameter objParam = command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            objParam.Value = id;

            SqlDataReader objReader = command.ExecuteReader();

            if (objReader.Read())
            {
                task = getItem(objReader);
            }
            conn.Close();

            return task;
        }

        private DailyTask getItem(SqlDataReader objReader)
        {
            var task = new DailyTask();

            object ob = null;

            task.Id = objReader.GetGuid(0);

            if ((ob = objReader.GetValue(1)) != DBNull.Value)
                task.Task = Convert.ToString(ob);

            if ((ob = objReader.GetValue(2)) != DBNull.Value)
                task.Type = Convert.ToInt32(ob);

            if ((ob = objReader.GetValue(3)) != DBNull.Value)
                task.Date = Convert.ToString(ob);

            if ((ob = objReader.GetValue(4)) != DBNull.Value)
                task.IsDone = Convert.ToInt32(ob);

            return task;
        }
        public List<DailyTask> GetAll()
        {
            List<DailyTask> tasks = new List<DailyTask>();
            command.CommandText = "Daily_GetAll";

            SqlDataReader objReader = command.ExecuteReader();

            while (objReader.Read())
            {
                tasks.Add(getItem(objReader));
            }
            conn.Close();
            return tasks;
        }
        public List<DailyTask> GetAllByType(int type)
        {
            List<DailyTask> tasks = new List<DailyTask>();
            command.CommandText = "Daily_GetAllByType";
            SqlParameter objParam = command.Parameters.Add("@Type", SqlDbType.Int);
            objParam.Value = type;
            SqlDataReader objReader = command.ExecuteReader();

            

            while (objReader.Read())
            {
                tasks.Add(getItem(objReader));
            }
            conn.Close();
            return tasks;
        }

        public int Update(DailyTask ob)
        {
            command.CommandText = "Daily_Update";
            setParameters(ob);
            var insertedRows = command.ExecuteNonQuery();
            conn.Close();
            return insertedRows;
        }

        public int Add(DailyTask ob)
        {
            command.CommandText = "Daily_Add";

            setParameters(ob);

            var insertedRows = command.ExecuteNonQuery();
            var o = command.Parameters["RETURN VALUE"].Value;

            if (o != null)
                insertedRows = Convert.ToInt32(o);

            conn.Close();
            return insertedRows;
        }

        public int DeletByTask(string token)
        {
            command.CommandText = "Daily_Delete";
            SqlParameter objParam = command.Parameters.Add("@Task", SqlDbType.NVarChar);
            objParam.Value = token;

            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public void setParameters(DailyTask ob)
        {
            SqlParameter objParam1 = command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            objParam1.Value = ob.Id;
            SqlParameter objParam2 = command.Parameters.Add("@Task", SqlDbType.NVarChar);
            objParam2.Value = ob.Task;
            SqlParameter objParam3 = command.Parameters.Add("@Type", SqlDbType.Int);
            objParam3.Value = ob.Type;
            SqlParameter objParam4 = command.Parameters.Add("@Date", SqlDbType.NVarChar);
            objParam4.Value = ob.Date;
            SqlParameter objParam5 = command.Parameters.Add("@IsDone", SqlDbType.Int);
            objParam5.Value = ob.IsDone;
            SqlParameter objParam6 = command.Parameters.Add("RETURN VALUE", SqlDbType.Int);
            objParam6.Direction = ParameterDirection.ReturnValue;
        }
    }
}
