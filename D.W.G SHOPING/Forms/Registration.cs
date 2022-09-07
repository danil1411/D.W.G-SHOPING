using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Vml;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Globalization;

namespace D.W.G_SHOPING
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
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

        private void Max_Min_MouseEnter(object sender, EventArgs e)
        {
            Max_Min.BackColor = Color.FromArgb(232, 113, 111);
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.FromArgb(232, 113, 111);
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Transparent;
        }

        public bool max;
        private void Max_Min_MouseClick(object sender, MouseEventArgs e)
        {
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
        }

        private void Max_Min_MouseLeave(object sender, EventArgs e)
        {
            Max_Min.BackColor = Color.Transparent;
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

        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private int checkPassrdChar = 1; // checking that password box text is hiding or showing, 0 = no : 1 = yes
        private void PictureLock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && checkPassrdChar == 1)
            {
                checkPassrdChar = 0;
                PasswordText.UseSystemPasswordChar = false;
            }
            else if (e.Button == MouseButtons.Left && checkPassrdChar == 0)
            {
                checkPassrdChar = 1;
                PasswordText.UseSystemPasswordChar = true;
            }
        }

        private bool ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// check that all field is correct and add field information to the DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SingInButton_MouseClick(object sender, MouseEventArgs e)
        {
            string buffer = EmailText.Text;
            bool checkIsEmailValid = ValidateEmail(buffer);
                if (checkIsEmailValid == true && Password_Okay_Picture.Visible == true && finalcheck_Okay.Visible == true)
                {
                MovingCircle.Stop();
                string name = Name_TextBox.Text, email = EmailText.Text, password = PasswordText.Text;
                this.Close();
                using (var context = new User())
                {
                    Guid giud = Guid.NewGuid();
                    var add = context.User_Add(giud, name, email, password);
                }
                Login login = new Login();
                login.Show();
                }
                if (checkIsEmailValid == false)
                {
                    Panel_Effect.Start();
                    Email_Line.Visible = false;
                    Email_TransparentPanel.Visible = true;
                }
                if (Password_Okay_Picture.Visible != true)
                {
                Password_Line.Visible = false;
                    Password_TransparentPanel.Visible = true;
                     Panel_Effect.Start();
                }
                if( Name_TextBox.Text.StartsWith(" ") == true || Name_TextBox.Text.Length < 1)
                {
                    Name_Panel.Visible = true;
                    Name_line.Visible = false;
                    Panel_Effect.Start();
                }
        }

        /// <summary>
        /// next couple filds always, while changing information in them, chacking the right way of information in them and help the users with the visual hints make a right decision about correctness infromation in the fields 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length >= 1 && PasswordText.Text.Length >= 1 && EmailText.Text.Length >= 1) { finalcheck_Ex.Visible = false; finalcheck_Okay.Visible = true; }
            else if (Name_TextBox.Text.Length <= 0 || PasswordText.Text.Length <= 0 || EmailText.Text.Length <= 0) { finalcheck_Okay.Visible = false; finalcheck_Ex.Visible = true; }
            Email_Line.Visible = true;
            Email_TransparentPanel.Visible = false;
        } // check that all field is fill

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length >= 1 && PasswordText.Text.Length >= 1 && EmailText.Text.Length >= 1) { finalcheck_Ex.Visible = false; finalcheck_Okay.Visible = true; }
            else if (Name_TextBox.Text.Length <= 0 || PasswordText.Text.Length <= 0 || EmailText.Text.Length <= 0) { finalcheck_Okay.Visible = false; finalcheck_Ex.Visible = true; }
            Password_TransparentPanel.Visible = false;
            Password_Line.Visible = true;
        } // check that all field is fill

        private void Name_TextBox_Enter(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length >= 1 && PasswordText.Text.Length >= 1 && EmailText.Text.Length >= 1) { finalcheck_Ex.Visible = false; finalcheck_Okay.Visible = true; }
            else if (Name_TextBox.Text.Length <= 0 || PasswordText.Text.Length <= 0 || EmailText.Text.Length <= 0) { finalcheck_Okay.Visible = false; finalcheck_Ex.Visible = true; }
            Name_Panel.Visible = false;
            Name_line.Visible = true;
        } // check that all field is fill

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length >= 1 && PasswordText.Text.Length >= 1 && EmailText.Text.Length >= 1) { finalcheck_Ex.Visible = false; finalcheck_Okay.Visible = true; }
            else if (Name_TextBox.Text.Length <= 0 || PasswordText.Text.Length <= 0 || EmailText.Text.Length <= 0) { finalcheck_Okay.Visible = false; finalcheck_Ex.Visible = true; }
        } // check that all field is fill

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length >= 1 && PasswordText.Text.Length >= 1 && EmailText.Text.Length >= 1) { finalcheck_Ex.Visible = false; finalcheck_Okay.Visible = true; }
            else if (Name_TextBox.Text.Length <= 0 || PasswordText.Text.Length <= 0 || EmailText.Text.Length <= 0) { finalcheck_Okay.Visible = false; finalcheck_Ex.Visible = true; }

            if (PasswordText.Text.Length >= 7)
            {
                Password_Ex_Picture.Visible = false;
                Password_Okay_Picture.Visible = true;
            }else if (PasswordText.Text.Length < 7)
            {
                Password_Ex_Picture.Visible = true;
                Password_Okay_Picture.Visible = false;
            }
        } // check that all field is fill? and check length of password textBox

        /// <summary>
        /// Make Moving_Circle method is correct that's mean that variable which need for method contains there is.
        /// </summary>
        public int c_LB = 413;
        public int c_LT = 56;
        public int c_RB = 413;
        public int c_RT = 92;
        public bool Mm = false, Nn = false, Bb = false, Vv = false;
        public int transparentLine = 40;

        private void Panel_Effect_Tick(object sender, EventArgs e)
        {
            Email_TransparentPanel.BackColor = Color.FromArgb(transparentLine, Color.DarkRed);
            Password_TransparentPanel.BackColor = Color.FromArgb(transparentLine, Color.DarkRed);
            Name_Panel.BackColor = Color.FromArgb(transparentLine, Color.DarkRed);
            transparentLine += 5;
            if (transparentLine >= 200)
            {
                transparentLine = 40;
                Panel_Effect.Stop();
            }
        }

        /// <summary>
        /// Method make circle, which contains in logan screen, moving. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovingCircle_Tick(object sender, EventArgs e)
        {
            var circle_lB = Circle_Left_Bottom.Location.X;
            Circle_Left_Bottom.Location = new Point(circle_lB, c_LB);
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
