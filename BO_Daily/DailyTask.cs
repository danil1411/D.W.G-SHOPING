using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_Daily
{
    public class DailyTask
    {
        public Guid Id { get; set; }
        public string Task { get; set; }
        public int Type { get; set; }
        public string Date { get; set; }
        public int IsDone { get; set; }
    }
}
