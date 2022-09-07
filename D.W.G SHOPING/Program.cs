using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.W.G_SHOPING
{
    /// <summary>
    /// static public class for hand over information about if GlobalPictureTrash was pressed or not
    /// </summary>
    static class DeleteButton {
        public static bool DeleteButtonPressed = false; 
    }

    /// <summary>
    /// static public class with list in order to contain spawned WroteWorkPlace adress in order to delete it from LayoutPanel from the Tasks 
    /// </summary>
    public static class BufferDelete{
        static public List<Control> ll = new List<Control>();
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
