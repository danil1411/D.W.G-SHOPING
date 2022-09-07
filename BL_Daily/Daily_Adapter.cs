using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO_Daily;
using DAL_Daily;
namespace BL_Daily
{
    public class Daily_Adapter
    {
        public static DailyTask GetById(string iD)
        {
            DailyTask task;
            task = (new DailyDAL()).GetById(new Guid(iD));
            return task;
        }
        public static DailyTask GetById(Guid iD)
        {
            DailyTask task;
            task = (new DailyDAL()).GetById(iD);
            return task;
        }
        public static List<DailyTask> GetAllByType(int type)
        {
            return (new DailyDAL()).GetAllByType(type);
        }

        public static List<DailyTask> GetAll()
        {
            return (new DailyDAL()).GetAll();
        }
        public static int Add(string Task, int Type, int IsDone, string Date)
        {
            DailyTask task = new DailyTask();
            task.Id = Guid.NewGuid();
            task.Task = Task;
            task.Type = Type;
            task.Date = Date;
            task.IsDone = IsDone;
            int row = (new DailyDAL()).Add(task);
            return row;
        }
        public static List<DailyTask> GetByTask(string text)
        {
            List<DailyTask> tasks = GetAll().FindAll(c => (c.Task.ToLower().CompareTo(text.Trim().ToLower())) == 0);
            return tasks;
        }
        public static List<DailyTask> GetByType(int text)
        {
            List<DailyTask> tasks = GetAll().FindAll(c => (c.Type.CompareTo(text)) == 0);
            return tasks;
        }
        public static int DeleteByTask(string token)
        {
            int prap;
            prap = (new DailyDAL()).DeletByTask(token);
            return prap;
        }
        public static int Update(DailyTask task, string Task, int Type, int IsDone, string Date)
        {
            task.Task = Task;
            task.Type = Type;
            task.IsDone = IsDone;
            task.Date = Date;
            int prap = (new DailyDAL()).Update(task);
            return prap;
        }
    }
}
