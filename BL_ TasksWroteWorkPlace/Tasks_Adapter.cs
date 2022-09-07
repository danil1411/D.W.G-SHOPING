using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL_TasksWroteWorkPlace;

namespace BL__TasksWroteWorkPlace
{
    public class Tasks_Adapter
    {
        public static int Add(string text, int Hour_Minutes, int Hour_Hours, int Date_Days, int Date_Month, int Repeat)
        {
            BO_Variables variables = new BO_Variables();
            variables.id = Guid.NewGuid();

            variables.Text = text;
            variables.Hours_Minutes = Hour_Minutes;
            variables.Hours_Hours = Hour_Hours;
            variables.Date_Days = Date_Days;
            variables.Date_Month = Date_Month;
            variables.Repeat = Repeat;
            int row = (new TasksDAL()).Add(variables);
            return row;
        }
    }
}
