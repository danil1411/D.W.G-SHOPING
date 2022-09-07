using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_Bookkeeping
{
    public class BookkeepingBO
    {
        // For UserFile stats
        public Guid id { get; set; }
        //public string filename { get; set; }
        public string userfilename { get; set; }
        public int favourite { get; set; }
        //public byte[] vs { get; set; }
        public string token { get; set; }
        // For file
        public string RootDirectory { get; set; }
        public string FileName2 { get; set; }
        public string FileAttribute { get; set; }
        public DateTime FileCreateDate { get; set; }
        public decimal FileSize { get; set; }
        public byte[] FileStreamCol { get; set; }
        //public byte[] Document { get; set; }

    }
    public static class id_Bookkeeping
    {
        public static Guid guid { get; set; }
    }
    public static class id_Update
    {
        public static string id { get; set; }
    }

    public static class userfilename_Bookkeeping
    {
        public static string userFileName { get; set; }
    }
}
