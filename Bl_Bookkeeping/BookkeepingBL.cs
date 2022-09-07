using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Bookkeeping;
using BO_Bookkeeping;

namespace BL_Bookeeping
{
    public class BookkeepingBL
    {
        public static int Add_Book(string userfilename, int favourite,
 string token, string RootDirectory, string FileName2, string FileAttribute,
            DateTime FileCreateDate, byte[] FileStreamCol)
        {
            BookkeepingBO bookkeepingBO = new BookkeepingBO();
            bookkeepingBO.id = Guid.NewGuid();
            id_Bookkeeping.guid = bookkeepingBO.id;
            bookkeepingBO.userfilename = userfilename;
            bookkeepingBO.favourite = favourite;
            bookkeepingBO.token = token;
            bookkeepingBO.RootDirectory = RootDirectory;
            bookkeepingBO.FileName2 = FileName2;
            bookkeepingBO.FileAttribute = FileAttribute;
            bookkeepingBO.FileCreateDate = FileCreateDate;
            bookkeepingBO.FileStreamCol = FileStreamCol;
            int row = (new BookkeepingDAL()).Add(bookkeepingBO);
            return row;
        }
       
        public static int Delete_Book(string token, string RootDirectory, string FileName)
        {
            int prap;
            prap = (new BookkeepingDAL()).deleteToken(token, RootDirectory, FileName);
            return prap;
        }
        public static int Update_Book(string userfilename, int favourite, string token)
        {
            BookkeepingBO bookkeepingBO = new BookkeepingBO();
            bookkeepingBO.userfilename = userfilename;
            bookkeepingBO.favourite = favourite;
            bookkeepingBO.token = token;
            int prep;
            prep = (new BookkeepingDAL()).UpdateBook(bookkeepingBO);
            return prep;
        }
        public static List<BookkeepingBO> GetAll()
        {
            return (new BookkeepingDAL()).GetAll();
        }
        public static List<BookkeepingBO> GetAllFile()
        {
            return (new BookkeepingDAL()).GetAllFile();
        }
    }
}

