using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_Daily;
using BO_Daily;

namespace D.W.G_SHOPING.UserControls.Daily
{
    public partial class DailyWriteAdd : UserControl
    {
        bool ispressed = false, ispres = false;
        int typeoftask = 0;
        int IsDone;
        Guid id;
        public DailyWriteAdd()
        {
            InitializeComponent();
        }
        public DailyWriteAdd(string Task, string date, int type, int isdone, Guid Id)
        {
            InitializeComponent();
            showNameOfTask.Text = Task;
            showDate.Text = date;
            typeoftask = type;
            IsDone = isdone;
            if(isdone == 1)
            {
                isWorkEnded.Checked = true;
            }
            id = Id;
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if(Menu.Location.Y >= 3)
            {
                Menu.Location = new Point(Menu.Location.X, Menu.Location.Y - 3);
            }
        }

        private void buttonShowMore_MouseClick(object sender, MouseEventArgs e)
        {
            if(!ispressed)
            {
                Menu.Visible = true;
                timerMenu.Start();
                timerMenuOut.Stop();
                ispressed = true;
            }
            else
            {
                timerMenu.Stop();
                timerMenuOut.Start();
                ispressed = false;
            }
        }

        private void timerMenuOut_Tick(object sender, EventArgs e)
        {
            if (Menu.Location.Y <= 41)
            {
                Menu.Location = new Point(Menu.Location.X, Menu.Location.Y + 3);
            }
        }

        private void isWorkEnded_CheckedChanged(object sender, EventArgs e)
        {
            buttonRestore.Visible = true;
            showNameOfTask.Font = new Font(showNameOfTask.Font, FontStyle.Strikeout);
            buttonShowMore.Enabled = false;
            timerMenu.Stop();
            timerMenuOut.Start();
            panelBack.FillColor = Color.LightSalmon;
            panelBack.FillColor2 = Color.LightSalmon;
            showNameOfTask.FillColor = Color.LightSalmon;
            showNameOfTask.BorderColor = Color.LightSalmon;
        }

        private void buttonRestore_MouseClick(object sender, MouseEventArgs e)
        {
            isWorkEnded.Checked = false;
            buttonShowMore.Enabled = true;
            buttonRestore.Visible = false;
            panelBack.FillColor = Color.FromArgb(229, 94, 91);
            panelBack.FillColor2 = Color.FromArgb(229, 94, 91);
            showNameOfTask.FillColor = Color.FromArgb(229, 94, 91);
            showNameOfTask.BorderColor = Color.FromArgb(229, 94, 91);
            showNameOfTask.Font = new Font(showNameOfTask.Font, FontStyle.Regular);
            Daily_Adapter.Update(Daily_Adapter.GetById(id), showNameOfTask.Text, typeoftask, 0, showDate.Text);
        }

        private void buttonWorkEnded_MouseClick(object sender, MouseEventArgs e)
        {
            Daily_Adapter.DeleteByTask(showNameOfTask.Text);
            Parent.Controls.Remove(this);
        }

        private void isWorkEnded_MouseClick(object sender, MouseEventArgs e)
        {
            Daily_Adapter.Update(Daily_Adapter.GetById(id), showNameOfTask.Text, typeoftask, 1, showDate.Text);
        }

        private void buttonRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            Daily_Adapter.Update(Daily_Adapter.GetById(id), showNameOfTask.Text, typeoftask, 0, showDate.Text);
        }

        private void buttonShowList_MouseClick(object sender, MouseEventArgs e)
        {
            if(!ispres)
            {
                showNameOfTask.ReadOnly = false;
                showNameOfTask.Focus();
                ispres = true;
            }
            else
            {
                showNameOfTask.ReadOnly = true;
                ispres = false;
            }
        }
    }
}
