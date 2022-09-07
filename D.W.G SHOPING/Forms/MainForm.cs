using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Management.Automation.Language;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.W.G_SHOPING
{
    public partial class MainForm : Form
    {
        private bool MaxWindow = false;
        public MainForm()
        {
            InitializeComponent();
            BookFeeping.BringToFront();
            CalculatorButton.BringToFront();
            Daily.BringToFront();
            ChatButton.BringToFront();
            Products.BringToFront();
            Tasks.BringToFront();
        }

        private void ExitPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Make default position for Navigation Bar when form was launched
            Daily.Location = new Point(-158, 382);
            BookFeeping.Location = new Point(-156, 461);
            Products.Location = new Point(-112, 543);
            Tasks.Location = new Point(-111, 624);
        }



        /// <summary>
        /// Daily Algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>    
        private bool pullOverDaily = false;
        int dailyX = -158;
        private int backDaily = 0;
        private void Daily_MouseEnter(object sender, EventArgs e)
        {
            if (pullOverDaily == false && (daily1.Visible == false && bookkeeping1.Visible == false && products1.Visible == false && tasks1.Visible == false)) {
                dailyTimer.Start();
            }
        }

        private void Daily_MouseLeave(object sender, EventArgs e)
        {
            if (pullOverDaily == true) {
                backDaily = Daily.Location.X;
                DailyBackTimer.Start();
            }
        }

        private void dailyTimer_Tick(object sender, EventArgs e)
        {
            Daily.Location = new Point(dailyX, 382);
            if (dailyX <= -93)
            {
                dailyX += 4;
            } else if (dailyX >= -93)
            {
                dailyX = -158;
                dailyTimer.Stop();
                pullOverDaily = true;
            }
        }

        private void DailyBackTimer_Tick(object sender, EventArgs e)
        {

            Daily.Location = new Point(backDaily, 382);
            if (backDaily >= -158)
            {
                backDaily -= 4;
            }else if (backDaily <= -158)
            {
                DailyBackTimer.Stop();
                Daily.Location = new Point(-158, 382);
                pullOverDaily = false;
            }
        }

        /// <summary>
        /// Book Keeping Algorithm 
        /// </summary>
        private int bookX = -156;
        private bool pullOverBookkeeping = false;
        private int backBook = 0;
        private void BookFeeping_MouseEnter(object sender, EventArgs e)
        {
            if (pullOverBookkeeping == false && (daily1.Visible == false && bookkeeping1.Visible == false && products1.Visible == false && tasks1.Visible == false))
            {
                bookkeepingTimer.Start();
            }
        }

        private void BookFeeping_MouseLeave(object sender, EventArgs e)
        {
            if (pullOverBookkeeping == true)
            {
                backBook = BookFeeping.Location.X;
                BookkeepingBackTimer.Start();
            }
        }

        private void bookkeepingTimer_Tick(object sender, EventArgs e)
        {
            BookFeeping.Location = new Point(bookX, 461);
            if (bookX <= -23)
            {
                bookX += 5;
            }
            else if (bookX >= -23)
            {
                    bookX = -156;
                    bookkeepingTimer.Stop();
                    pullOverBookkeeping = true;
            }
        }

        private void BookkeepingBackTimer_Tick(object sender, EventArgs e)
        {
            BookFeeping.Location = new Point(backBook, 461);
            if (backBook >= -156)
            {
                backBook -= 5;
            }
            else if (backBook <= -156)
            {
                BookkeepingBackTimer.Stop();
                BookFeeping.Location = new Point(-156, 461);
                pullOverBookkeeping = false;
            }
        }

        /// <summary>
        /// Product Algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private int productX = -112;
        private bool pullOverProduct = false;
        private int backProduct = 0;
        private void Products_MouseEnter(object sender, EventArgs e)
        {
            if (pullOverProduct == false && (daily1.Visible == false && bookkeeping1.Visible == false && products1.Visible == false && tasks1.Visible == false))
            {
                productsTimer.Start();
            }
        }

        private void Products_MouseLeave(object sender, EventArgs e)
        {
            if (pullOverProduct == true)
            {
                backProduct = Products.Location.X;
                ProductsBackTimer.Start();
            }
        }

        private void productsTimer_Tick(object sender, EventArgs e)
        {
            Products.Location = new Point(productX, 543);
            if (productX <= -15)
            {
                productX += 4;
            }
            else if (productX >= -15)
            {
                productX = -112;
                productsTimer.Stop();
                pullOverProduct = true;
            }
        }

        private void ProductsBackTimer_Tick(object sender, EventArgs e)
        {
            Products.Location = new Point(backProduct, 543);
            if (backProduct >= -112)
            {
                backProduct -= 4;
            }
            else if (backProduct <= -112)
            {
                ProductsBackTimer.Stop();
                Products.Location = new Point(-112, 543);
                pullOverProduct = false;
            }
        }

        /// <summary>
        /// Tasks Algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private int taskX = -140;
        private bool pullOverTask = false;
        private int backTask = 0;
        private void Tasks_MouseEnter(object sender, EventArgs e)
        {
            if (pullOverTask == false && (daily1.Visible == false && bookkeeping1.Visible == false && products1.Visible == false && tasks1.Visible == false))
            {
                tasksTimer.Start();
            }
        }

        private void Tasks_MouseLeave(object sender, EventArgs e)
        {
            if (pullOverTask == true)
            {
                backTask = Tasks.Location.X;
                TasksBackTimer.Start();
            }
        }

        private void tasksTimer_Tick(object sender, EventArgs e)
        {
            Tasks.Location = new Point(taskX, 624);
            if (taskX <= -40)
            {
                taskX += 4;
            }
            else if (taskX >= -40)
            {
                taskX = -111;
                tasksTimer.Stop();
                pullOverTask = true;
            }
        }

        private void TasksBackTimer_Tick(object sender, EventArgs e)
        {
            Tasks.Location = new Point(backTask, 624);
            if (backTask >= -111)
            {
                backTask -= 4;
            }
            else if (backTask <= -111)
            {
                TasksBackTimer.Stop();
                Tasks.Location = new Point(-111, 624);
                pullOverTask = false;
            }
        }



        /// <summary>
        /// make current window hiding but still can see at the taskbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"> Control all acts from user </param>
        /// 
        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        /// <summary>
        /// Next Code make a Form movement from the panel of top 
        /// </summary>
        private bool dragging;
        private Point pointClicked;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));

                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);

                this.Location = pointMoveTo;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        /// <summary>
        /// a Clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            Watch.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Max_Min_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MaxWindow == false)
            {
                MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
                WindowState = FormWindowState.Maximized;
                MaxWindow = true;
            }
            else if (e.Button == MouseButtons.Left && MaxWindow == true)
            {
                WindowState = FormWindowState.Normal;
                MaxWindow = false;
            }
        }

        private void HomeButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bookkeeping1.Visible = false;
                daily1.Visible = false;
                products1.Visible = false;
                tasks1.Visible = false;
            }
        }

        private void Daily_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                daily1.BringToFront();
                daily1.Visible = true;
                bookkeeping1.Visible = false;
                products1.Visible = false;
                tasks1.Visible = false;
            }
        }

        private void BookFeeping_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bookkeeping1.BringToFront();
                daily1.Visible = false;
                bookkeeping1.Visible = true;
                products1.Visible = false;
                tasks1.Visible = false;
            }
        }

        private void Products_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                products1.BringToFront();
                daily1.Visible = false;
                bookkeeping1.Visible = false;
                products1.Visible = true;
                tasks1.Visible = false;
            }
        }

        private void Tasks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tasks1.BringToFront();
                daily1.Visible = false;
                bookkeeping1.Visible = false;
                products1.Visible = false;
                tasks1.Visible = true;
            }
        }
    }
}
