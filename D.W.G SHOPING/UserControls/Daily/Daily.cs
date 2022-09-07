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
    public partial class Daily : UserControl
    {
        List<DailyTask> tasks = new List<DailyTask>();
        bool ispressed = false;
        public Daily()
        {
            InitializeComponent();
        }

        private void TaskAddButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ispressed)
            {
                TaskAdd.Visible = true;
                ispressed = true;
            }
            else
            {
                TaskAdd.Visible = false;
                ispressed = false;
            }
        }

        private void addToFlow_MouseClick(object sender, MouseEventArgs e)
        {
            int type = 0;
            string temp = Convert.ToString(comboBoxType.SelectedItem);
            switch (temp)
            {
                case "Основные":
                    type = 1;
                    Daily_Adapter.Add(inputNewTask.Text, type, 0, inputDateForNewTask.Text);
                    break;
                case "Работа":
                    type = 2;
                    Daily_Adapter.Add(inputNewTask.Text, type, 0, inputDateForNewTask.Text);
                    break;
                case "Ежедневные":
                    type = 3;
                    Daily_Adapter.Add(inputNewTask.Text, type, 0, inputDateForNewTask.Text);
                    break;
                case null:
                    break;
            }
            DailyWriteAdd daily = new DailyWriteAdd(inputNewTask.Text, inputDateForNewTask.Text, type, 0, Guid.NewGuid());
            mainFlowForTasks.Controls.Add(daily);
        }

        private void Daily_Load(object sender, EventArgs e)
        {
            try
            {
                tasks.AddRange(Daily_Adapter.GetAll());
            }
            catch
            { }
            foreach (var obj in tasks)
            {
                DailyWriteAdd daily = new DailyWriteAdd(obj.Task, obj.Date, obj.Type, obj.IsDone, obj.Id);
                mainFlowForTasks.Controls.Add(daily);
            }
        }

        private void showAllTasks_MouseClick(object sender, MouseEventArgs e)
        {
            tasks.Clear();
            mainFlowForTasks.Controls.Clear();
            labelType.Text = "Основные задачи";
            tasks.AddRange(Daily_Adapter.GetAllByType(1));
            foreach(var obj in tasks)
            {
                DailyWriteAdd daily = new DailyWriteAdd(obj.Task, obj.Date, obj.Type, obj.IsDone, obj.Id);
                mainFlowForTasks.Controls.Add(daily);
            }
        }

        private void showMain_MouseClick(object sender, MouseEventArgs e)
        {
            tasks.Clear();
            mainFlowForTasks.Controls.Clear();
            labelType.Text = "Рабочие задачи";
            tasks.AddRange(Daily_Adapter.GetAllByType(2));
            foreach (var obj in tasks)
            {
                DailyWriteAdd daily = new DailyWriteAdd(obj.Task, obj.Date, obj.Type, obj.IsDone, obj.Id);
                mainFlowForTasks.Controls.Add(daily);
            }
        }

        private void showWork_MouseClick(object sender, MouseEventArgs e)
        {
            tasks.Clear();
            mainFlowForTasks.Controls.Clear();
            labelType.Text = "Ежедневные задачи";
            tasks.AddRange(Daily_Adapter.GetAllByType(3));
            foreach (var obj in tasks)
            {
                DailyWriteAdd daily = new DailyWriteAdd(obj.Task, obj.Date, obj.Type, obj.IsDone, obj.Id);
                mainFlowForTasks.Controls.Add(daily);
            }
        }

        private void mainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            tasks.Clear();
            mainFlowForTasks.Controls.Clear();
            labelType.Text = "Все задачи";
            tasks.AddRange(Daily_Adapter.GetAll());
            foreach (var obj in tasks)
            {
                DailyWriteAdd daily = new DailyWriteAdd(obj.Task, obj.Date, obj.Type, obj.IsDone, obj.Id);
                mainFlowForTasks.Controls.Add(daily);
            }
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            tasks.Clear();
            mainFlowForTasks.Controls.Clear();
            tasks.AddRange(Daily_Adapter.GetByTask(TextBoxSearch.Text));
            foreach (var obj in tasks)
            {
                DailyWriteAdd daily = new DailyWriteAdd(obj.Task, obj.Date, obj.Type, obj.IsDone, obj.Id);
                mainFlowForTasks.Controls.Add(daily);
            }
            if (!tasks.Any())
            {
                MessageBox.Show(
                "Nothing found!",
                "Search",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                mainScreen_MouseClick(sender, e);
            }
        }
    }
}
