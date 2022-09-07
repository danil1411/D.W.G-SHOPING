using OpenXmlPowerTools;
using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.W.G_SHOPING
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(229, 94, 91), ButtonBorderStyle.Solid);
        }

        private int checkPassrdChar = 1; // checking that password box text is hiding or showing, 0 = no : 1 = yes
        private void PictureLock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && checkPassrdChar == 1)
            {
                checkPassrdChar = 0;
                PasswordText.UseSystemPasswordChar = false;
            } else if (e.Button == MouseButtons.Left && checkPassrdChar == 0)
            {
                checkPassrdChar = 1;
                PasswordText.UseSystemPasswordChar = true;
            }
        }

        bool drag = false;
        Point start_point = new Point(0, 0);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ExitPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }

        private void ExitPicture_MouseEnter(object sender, EventArgs e)
        {
            ExitPicture.BackColor = Color.FromArgb(232, 113, 111);
        }

        private void ExitPicture_MouseLeave(object sender, EventArgs e)
        {
            ExitPicture.BackColor = Color.Transparent;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(232, 113, 111);
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Transparent;
        }

        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Max_Min_MouseEnter(object sender, EventArgs e)
        {
            Max_Min.BackColor = Color.FromArgb(232, 113, 111);
        }

        private void Max_Min_MouseLeave(object sender, EventArgs e)
        {
            Max_Min.BackColor = Color.Transparent;
        }

        public bool max;
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                if (max == false)
                {
                    MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
                    WindowState = FormWindowState.Maximized;
                    max = true;
                }
                else if (max == true)
                {
                    WindowState = FormWindowState.Normal;
                    max = false;
                }
            }else
            {
                ;
            }
        }

        /// <summary>
        /// Make Moving_Circle method is correct that's mean that variable which need for method contains there is.
        /// </summary>
            public int c_LB = 413;
            public int c_LT = 56;
            public int c_RB = 413;
            public int c_RT = 92;
            public bool Mm = false, Nn = false, Bb = false, Vv = false;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void SingInButton_MouseClick(object sender, MouseEventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }

        private void CreateAccount_Button_MouseClick(object sender, MouseEventArgs e)
        {
            Registration registration = new Registration();
                MovingCircle.Stop();
                registration.MovingCircle.Start();
                this.Hide();
                registration.Show();
        }


        /// <summary>
        /// Method make circle, which contains in logan screen, moving. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovingCircle_Tick(object sender, EventArgs e)
        {
            var circle_lB = Circle_Left_Bottom.Location.X;
            Circle_Left_Bottom.Location = new Point( circle_lB, c_LB);
            if (Mm == false) { c_LB++; }
            if (c_LB == 423) { Mm = true; }
            if (Mm == true) { c_LB--; }
            if (c_LB == 403) { Mm = false; }

            var circle_lT = Circle_Left_Top.Location.X;
            Circle_Left_Top.Location = new Point(circle_lT, c_LT);
            if (c_LT == 66/*66*/) { Nn = true; }
            if (c_LT == 43/*46*/) { Nn = false; }
            if (Nn == true) { c_LT--; }
            if (Nn == false) { c_LT++; }

            var circle_rB = Circle_Right_Bottom.Location.X;
            Circle_Right_Bottom.Location = new Point(circle_rB, c_RB);
            if (c_RB == 423) { Bb = true; }
            if (c_RB == 403) { Bb = false; }
            if (Bb == true) { c_RB--; }
            if (Bb == false) { c_RB++; }

            var circle_rT = Circle_Right_Top.Location.X;
            Circle_Right_Top.Location = new Point(circle_rT, c_RT);
            if (c_RT == 110/*102*/) { Vv = true; }
            if (c_RT == 82/*82*/) { Vv = false; }
            if (Vv == true) { c_RT--; }
            if (Vv == false) { c_RT++; }

        }

    }
}
