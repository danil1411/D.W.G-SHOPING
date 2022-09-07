
namespace D.W.G_SHOPING.UserControls.Daily
{
    partial class DailyWriteAdd
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.showDate = new System.Windows.Forms.Label();
            this.panelBack = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.showNameOfTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.isWorkEnded = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.buttonWorkEnded = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonShowMore = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonRestore = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Menu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.buttonShowList = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.timerMenuOut = new System.Windows.Forms.Timer(this.components);
            this.panelBack.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // showDate
            // 
            this.showDate.AutoSize = true;
            this.showDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.showDate.Location = new System.Drawing.Point(974, 19);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(38, 13);
            this.showDate.TabIndex = 3;
            this.showDate.Text = "label1";
            // 
            // panelBack
            // 
            this.panelBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.panelBack.BorderRadius = 5;
            this.panelBack.BorderThickness = 4;
            this.panelBack.Controls.Add(this.showNameOfTask);
            this.panelBack.Controls.Add(this.showDate);
            this.panelBack.Controls.Add(this.isWorkEnded);
            this.panelBack.Controls.Add(this.buttonWorkEnded);
            this.panelBack.Controls.Add(this.buttonShowMore);
            this.panelBack.Controls.Add(this.buttonRestore);
            this.panelBack.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.panelBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.panelBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.panelBack.Location = new System.Drawing.Point(3, 38);
            this.panelBack.Name = "panelBack";
            this.panelBack.ShadowDecoration.Parent = this.panelBack;
            this.panelBack.Size = new System.Drawing.Size(1159, 40);
            this.panelBack.TabIndex = 0;
            // 
            // showNameOfTask
            // 
            this.showNameOfTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.showNameOfTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.showNameOfTask.DefaultText = "";
            this.showNameOfTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.showNameOfTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.showNameOfTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.showNameOfTask.DisabledState.Parent = this.showNameOfTask;
            this.showNameOfTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.showNameOfTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.showNameOfTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showNameOfTask.FocusedState.Parent = this.showNameOfTask;
            this.showNameOfTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showNameOfTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.showNameOfTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showNameOfTask.HoverState.Parent = this.showNameOfTask;
            this.showNameOfTask.Location = new System.Drawing.Point(58, 7);
            this.showNameOfTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showNameOfTask.Name = "showNameOfTask";
            this.showNameOfTask.PasswordChar = '\0';
            this.showNameOfTask.PlaceholderText = "";
            this.showNameOfTask.ReadOnly = true;
            this.showNameOfTask.SelectedText = "";
            this.showNameOfTask.ShadowDecoration.Parent = this.showNameOfTask;
            this.showNameOfTask.Size = new System.Drawing.Size(909, 26);
            this.showNameOfTask.TabIndex = 5;
            // 
            // isWorkEnded
            // 
            this.isWorkEnded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.isWorkEnded.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.isWorkEnded.CheckedState.BorderThickness = 0;
            this.isWorkEnded.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.isWorkEnded.CheckedState.InnerColor = System.Drawing.Color.White;
            this.isWorkEnded.CheckedState.Parent = this.isWorkEnded;
            this.isWorkEnded.Location = new System.Drawing.Point(13, 7);
            this.isWorkEnded.Name = "isWorkEnded";
            this.isWorkEnded.ShadowDecoration.Parent = this.isWorkEnded;
            this.isWorkEnded.Size = new System.Drawing.Size(26, 26);
            this.isWorkEnded.TabIndex = 2;
            this.isWorkEnded.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.isWorkEnded.UncheckedState.BorderThickness = 2;
            this.isWorkEnded.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.isWorkEnded.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.isWorkEnded.UncheckedState.Parent = this.isWorkEnded;
            this.isWorkEnded.CheckedChanged += new System.EventHandler(this.isWorkEnded_CheckedChanged);
            this.isWorkEnded.MouseClick += new System.Windows.Forms.MouseEventHandler(this.isWorkEnded_MouseClick);
            // 
            // buttonWorkEnded
            // 
            this.buttonWorkEnded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonWorkEnded.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonWorkEnded.CheckedState.Parent = this.buttonWorkEnded;
            this.buttonWorkEnded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWorkEnded.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonWorkEnded.HoverState.Parent = this.buttonWorkEnded;
            this.buttonWorkEnded.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_delete_30;
            this.buttonWorkEnded.ImageRotate = 0F;
            this.buttonWorkEnded.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonWorkEnded.Location = new System.Drawing.Point(1078, 3);
            this.buttonWorkEnded.Name = "buttonWorkEnded";
            this.buttonWorkEnded.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonWorkEnded.PressedState.Parent = this.buttonWorkEnded;
            this.buttonWorkEnded.Size = new System.Drawing.Size(39, 33);
            this.buttonWorkEnded.TabIndex = 1;
            this.buttonWorkEnded.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonWorkEnded_MouseClick);
            // 
            // buttonShowMore
            // 
            this.buttonShowMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowMore.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonShowMore.CheckedState.Parent = this.buttonShowMore;
            this.buttonShowMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowMore.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonShowMore.HoverState.Parent = this.buttonShowMore;
            this.buttonShowMore.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_menu_vertical_30;
            this.buttonShowMore.ImageRotate = 0F;
            this.buttonShowMore.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonShowMore.Location = new System.Drawing.Point(1120, 5);
            this.buttonShowMore.Name = "buttonShowMore";
            this.buttonShowMore.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonShowMore.PressedState.Parent = this.buttonShowMore;
            this.buttonShowMore.Size = new System.Drawing.Size(33, 31);
            this.buttonShowMore.TabIndex = 0;
            this.buttonShowMore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonShowMore_MouseClick);
            // 
            // buttonRestore
            // 
            this.buttonRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRestore.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonRestore.CheckedState.Parent = this.buttonRestore;
            this.buttonRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestore.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRestore.HoverState.Parent = this.buttonRestore;
            this.buttonRestore.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_reset_30;
            this.buttonRestore.ImageRotate = 0F;
            this.buttonRestore.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRestore.Location = new System.Drawing.Point(1036, 3);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRestore.PressedState.Parent = this.buttonRestore;
            this.buttonRestore.Size = new System.Drawing.Size(39, 33);
            this.buttonRestore.TabIndex = 6;
            this.buttonRestore.Visible = false;
            this.buttonRestore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRestore_MouseClick);
            // 
            // Menu
            // 
            this.Menu.BorderRadius = 10;
            this.Menu.Controls.Add(this.buttonShowList);
            this.Menu.Controls.Add(this.buttonRefresh);
            this.Menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Menu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Menu.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Menu.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Menu.Location = new System.Drawing.Point(1062, 41);
            this.Menu.Name = "Menu";
            this.Menu.ShadowDecoration.Parent = this.Menu;
            this.Menu.Size = new System.Drawing.Size(100, 33);
            this.Menu.TabIndex = 1;
            this.Menu.Visible = false;
            // 
            // buttonShowList
            // 
            this.buttonShowList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonShowList.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonShowList.CheckedState.Parent = this.buttonShowList;
            this.buttonShowList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowList.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonShowList.HoverState.Parent = this.buttonShowList;
            this.buttonShowList.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_edit_30;
            this.buttonShowList.ImageRotate = 0F;
            this.buttonShowList.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonShowList.Location = new System.Drawing.Point(52, 3);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonShowList.PressedState.Parent = this.buttonShowList;
            this.buttonShowList.Size = new System.Drawing.Size(29, 27);
            this.buttonShowList.TabIndex = 2;
            this.buttonShowList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonShowList_MouseClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRefresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonRefresh.CheckedState.Parent = this.buttonRefresh;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRefresh.HoverState.Parent = this.buttonRefresh;
            this.buttonRefresh.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_cloud_refresh_30;
            this.buttonRefresh.ImageRotate = 0F;
            this.buttonRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRefresh.Location = new System.Drawing.Point(14, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRefresh.PressedState.Parent = this.buttonRefresh;
            this.buttonRefresh.Size = new System.Drawing.Size(29, 27);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRefresh_MouseClick);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // timerMenuOut
            // 
            this.timerMenuOut.Interval = 10;
            this.timerMenuOut.Tick += new System.EventHandler(this.timerMenuOut_Tick);
            // 
            // DailyWriteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.Menu);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "DailyWriteAdd";
            this.Size = new System.Drawing.Size(1165, 81);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelBack;
        private Guna.UI2.WinForms.Guna2ImageButton buttonShowMore;
        private Guna.UI2.WinForms.Guna2ImageButton buttonWorkEnded;
        private Guna.UI2.WinForms.Guna2CustomRadioButton isWorkEnded;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Menu;
        private Guna.UI2.WinForms.Guna2ImageButton buttonShowList;
        private Guna.UI2.WinForms.Guna2ImageButton buttonRefresh;
        private System.Windows.Forms.Label showDate;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Timer timerMenuOut;
        private Guna.UI2.WinForms.Guna2TextBox showNameOfTask;
        private Guna.UI2.WinForms.Guna2ImageButton buttonRestore;
    }
}
