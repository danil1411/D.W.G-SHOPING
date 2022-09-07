using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BO_Variables
    {
        public Guid id { get; set; }
        public string Text { get; set; }
        public int Hours_Minutes { get; set; }
        public int Hours_Hours { get; set; }
        public int Date_Days { get; set; }
        public int Date_Month { get; set; }
        public int Repeat { get; set; }
    }
}
