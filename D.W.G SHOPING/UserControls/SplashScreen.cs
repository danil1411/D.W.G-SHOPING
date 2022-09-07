using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.W.G_SHOPING
{
    public partial class SplashScreen : UserControl
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void RemoveButton_MouseClick(object sender, MouseEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            panel1.Controls.Remove(RemoveButton);
            login.MovingCircle.Start();
        }
    }
}
