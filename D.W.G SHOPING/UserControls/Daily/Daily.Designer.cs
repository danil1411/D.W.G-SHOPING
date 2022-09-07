
namespace D.W.G_SHOPING.UserControls.Daily
{
    partial class Daily
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.TaskAddButton = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.mainScreen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.showWork = new Guna.UI2.WinForms.Guna2Button();
            this.showMain = new Guna.UI2.WinForms.Guna2Button();
            this.showAllTasks = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.createNewTask = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.mainFlowForTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            this.greetingsLabel = new System.Windows.Forms.TextBox();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.TaskAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.addToFlow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.inputDateForNewTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.inputNewTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskAddButton)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen)).BeginInit();
            this.createNewTask.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.TaskAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.CausesValidation = false;
            this.guna2Panel2.Controls.Add(this.TaskAddButton);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.guna2Panel2.Location = new System.Drawing.Point(40, 38);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(112, 65);
            this.guna2Panel2.TabIndex = 10;
            // 
            // TaskAddButton
            // 
            this.TaskAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskAddButton.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_add_new_50;
            this.TaskAddButton.Location = new System.Drawing.Point(31, 7);
            this.TaskAddButton.Name = "TaskAddButton";
            this.TaskAddButton.ShadowDecoration.Parent = this.TaskAddButton;
            this.TaskAddButton.Size = new System.Drawing.Size(50, 50);
            this.TaskAddButton.TabIndex = 0;
            this.TaskAddButton.TabStop = false;
            this.TaskAddButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskAddButton_MouseClick);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(146)))), ((int)(((byte)(122)))));
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.guna2CustomGradientPanel1.Controls.Add(this.mainScreen);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Panel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.showWork);
            this.guna2CustomGradientPanel1.Controls.Add(this.showMain);
            this.guna2CustomGradientPanel1.Controls.Add(this.showAllTasks);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(146)))), ((int)(((byte)(122)))));
            this.guna2CustomGradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 10;
            this.guna2CustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(146)))), ((int)(((byte)(122)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(199, 987);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // mainScreen
            // 
            this.mainScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainScreen.Image = ((System.Drawing.Image)(resources.GetObject("mainScreen.Image")));
            this.mainScreen.Location = new System.Drawing.Point(14, 148);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.ShadowDecoration.Parent = this.mainScreen;
            this.mainScreen.Size = new System.Drawing.Size(165, 165);
            this.mainScreen.TabIndex = 11;
            this.mainScreen.TabStop = false;
            this.mainScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainScreen_MouseClick);
            // 
            // showWork
            // 
            this.showWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showWork.BorderRadius = 10;
            this.showWork.CheckedState.Parent = this.showWork;
            this.showWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showWork.CustomImages.Parent = this.showWork;
            this.showWork.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.showWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.showWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.showWork.HoverState.Parent = this.showWork;
            this.showWork.Location = new System.Drawing.Point(40, 542);
            this.showWork.Name = "showWork";
            this.showWork.ShadowDecoration.Parent = this.showWork;
            this.showWork.Size = new System.Drawing.Size(112, 65);
            this.showWork.TabIndex = 7;
            this.showWork.Text = "Ежедневные";
            this.showWork.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showWork_MouseClick);
            // 
            // showMain
            // 
            this.showMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showMain.BorderRadius = 10;
            this.showMain.CheckedState.Parent = this.showMain;
            this.showMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showMain.CustomImages.Parent = this.showMain;
            this.showMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.showMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.showMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.showMain.HoverState.Parent = this.showMain;
            this.showMain.Location = new System.Drawing.Point(40, 459);
            this.showMain.Name = "showMain";
            this.showMain.ShadowDecoration.Parent = this.showMain;
            this.showMain.Size = new System.Drawing.Size(112, 65);
            this.showMain.TabIndex = 6;
            this.showMain.Text = "Работа";
            this.showMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showMain_MouseClick);
            // 
            // showAllTasks
            // 
            this.showAllTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showAllTasks.BorderRadius = 10;
            this.showAllTasks.CheckedState.Parent = this.showAllTasks;
            this.showAllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllTasks.CustomImages.Parent = this.showAllTasks;
            this.showAllTasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.showAllTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.showAllTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.showAllTasks.HoverState.Parent = this.showAllTasks;
            this.showAllTasks.Location = new System.Drawing.Point(40, 377);
            this.showAllTasks.Name = "showAllTasks";
            this.showAllTasks.ShadowDecoration.Parent = this.showAllTasks;
            this.showAllTasks.Size = new System.Drawing.Size(112, 65);
            this.showAllTasks.TabIndex = 5;
            this.showAllTasks.Text = "Основные";
            this.showAllTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showAllTasks_MouseClick);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // createNewTask
            // 
            this.createNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createNewTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createNewTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.createNewTask.BorderRadius = 10;
            this.createNewTask.BorderThickness = 5;
            this.createNewTask.Controls.Add(this.guna2VScrollBar1);
            this.createNewTask.Controls.Add(this.mainFlowForTasks);
            this.createNewTask.Controls.Add(this.labelType);
            this.createNewTask.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(146)))), ((int)(((byte)(122)))));
            this.createNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createNewTask.Location = new System.Drawing.Point(205, 144);
            this.createNewTask.Name = "createNewTask";
            this.createNewTask.ShadowDecoration.Parent = this.createNewTask;
            this.createNewTask.Size = new System.Drawing.Size(1235, 671);
            this.createNewTask.TabIndex = 4;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.mainFlowForTasks;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.guna2VScrollBar1.HoverState.Parent = null;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1206, 53);
            this.guna2VScrollBar1.MouseWheelBarPartitions = 10;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.PressedState.Parent = this.guna2VScrollBar1;
            this.guna2VScrollBar1.ScrollbarSize = 19;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(19, 598);
            this.guna2VScrollBar1.TabIndex = 12;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            // 
            // mainFlowForTasks
            // 
            this.mainFlowForTasks.Location = new System.Drawing.Point(28, 53);
            this.mainFlowForTasks.Name = "mainFlowForTasks";
            this.mainFlowForTasks.Size = new System.Drawing.Size(1185, 598);
            this.mainFlowForTasks.TabIndex = 11;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.labelType.Location = new System.Drawing.Point(31, 19);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(106, 22);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Все задачи";
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.greetingsLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.greetingsLabel.Location = new System.Drawing.Point(219, 21);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(276, 13);
            this.greetingsLabel.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.buttonSearch);
            this.guna2Panel1.Controls.Add(this.TextBoxSearch);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.guna2Panel1.Location = new System.Drawing.Point(219, 915);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1206, 69);
            this.guna2Panel1.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_google_web_search_50;
            this.buttonSearch.Location = new System.Drawing.Point(14, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.ShadowDecoration.Parent = this.buttonSearch;
            this.buttonSearch.Size = new System.Drawing.Size(50, 50);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.UseTransparentBackground = true;
            this.buttonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseClick);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AutoRoundedCorners = true;
            this.TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.TextBoxSearch.BorderRadius = 18;
            this.TextBoxSearch.BorderThickness = 2;
            this.TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSearch.DefaultText = "";
            this.TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.DisabledState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.FocusedState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.HoverState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Location = new System.Drawing.Point(72, 16);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.ShadowDecoration.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Size = new System.Drawing.Size(1110, 39);
            this.TextBoxSearch.TabIndex = 2;
            // 
            // TaskAdd
            // 
            this.TaskAdd.BackColor = System.Drawing.Color.Transparent;
            this.TaskAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(146)))), ((int)(((byte)(122)))));
            this.TaskAdd.BorderRadius = 10;
            this.TaskAdd.CausesValidation = false;
            this.TaskAdd.Controls.Add(this.comboBoxType);
            this.TaskAdd.Controls.Add(this.addToFlow);
            this.TaskAdd.Controls.Add(this.inputDateForNewTask);
            this.TaskAdd.Controls.Add(this.inputNewTask);
            this.TaskAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.TaskAdd.Location = new System.Drawing.Point(219, 21);
            this.TaskAdd.Name = "TaskAdd";
            this.TaskAdd.ShadowDecoration.Parent = this.TaskAdd;
            this.TaskAdd.Size = new System.Drawing.Size(447, 99);
            this.TaskAdd.TabIndex = 11;
            this.TaskAdd.Visible = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.ForeColor = System.Drawing.Color.White;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Основные",
            "Работа",
            "Ежедневные"});
            this.comboBoxType.Location = new System.Drawing.Point(22, 70);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(317, 21);
            this.comboBoxType.TabIndex = 5;
            this.comboBoxType.Text = "Выберите папку:";
            // 
            // addToFlow
            // 
            this.addToFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToFlow.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_checkmark_55;
            this.addToFlow.Location = new System.Drawing.Point(367, 24);
            this.addToFlow.Name = "addToFlow";
            this.addToFlow.ShadowDecoration.Parent = this.addToFlow;
            this.addToFlow.Size = new System.Drawing.Size(55, 55);
            this.addToFlow.TabIndex = 4;
            this.addToFlow.TabStop = false;
            this.addToFlow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addToFlow_MouseClick);
            // 
            // inputDateForNewTask
            // 
            this.inputDateForNewTask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputDateForNewTask.BackColor = System.Drawing.Color.Transparent;
            this.inputDateForNewTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inputDateForNewTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(146)))), ((int)(((byte)(122)))));
            this.inputDateForNewTask.BorderRadius = 10;
            this.inputDateForNewTask.BorderThickness = 0;
            this.inputDateForNewTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputDateForNewTask.DefaultText = "00/00/0000";
            this.inputDateForNewTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputDateForNewTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputDateForNewTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDateForNewTask.DisabledState.Parent = this.inputDateForNewTask;
            this.inputDateForNewTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputDateForNewTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.inputDateForNewTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDateForNewTask.FocusedState.Parent = this.inputDateForNewTask;
            this.inputDateForNewTask.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.inputDateForNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.inputDateForNewTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputDateForNewTask.HoverState.Parent = this.inputDateForNewTask;
            this.inputDateForNewTask.IconLeftCursor = System.Windows.Forms.Cursors.SizeNS;
            this.inputDateForNewTask.Location = new System.Drawing.Point(22, 38);
            this.inputDateForNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.inputDateForNewTask.Name = "inputDateForNewTask";
            this.inputDateForNewTask.PasswordChar = '\0';
            this.inputDateForNewTask.PlaceholderText = "";
            this.inputDateForNewTask.SelectedText = "";
            this.inputDateForNewTask.SelectionStart = 10;
            this.inputDateForNewTask.ShadowDecoration.Parent = this.inputDateForNewTask;
            this.inputDateForNewTask.Size = new System.Drawing.Size(317, 25);
            this.inputDateForNewTask.TabIndex = 3;
            this.inputDateForNewTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputNewTask
            // 
            this.inputNewTask.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputNewTask.BackColor = System.Drawing.Color.Transparent;
            this.inputNewTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inputNewTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(146)))), ((int)(((byte)(122)))));
            this.inputNewTask.BorderRadius = 10;
            this.inputNewTask.BorderThickness = 0;
            this.inputNewTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNewTask.DefaultText = "Напишите то, что хотите сделать";
            this.inputNewTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputNewTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputNewTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputNewTask.DisabledState.Parent = this.inputNewTask;
            this.inputNewTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputNewTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.inputNewTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputNewTask.FocusedState.Parent = this.inputNewTask;
            this.inputNewTask.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.inputNewTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputNewTask.HoverState.Parent = this.inputNewTask;
            this.inputNewTask.IconLeftCursor = System.Windows.Forms.Cursors.SizeNS;
            this.inputNewTask.Location = new System.Drawing.Point(22, 7);
            this.inputNewTask.Margin = new System.Windows.Forms.Padding(6);
            this.inputNewTask.Name = "inputNewTask";
            this.inputNewTask.PasswordChar = '\0';
            this.inputNewTask.PlaceholderText = "";
            this.inputNewTask.SelectedText = "";
            this.inputNewTask.SelectionStart = 31;
            this.inputNewTask.ShadowDecoration.Parent = this.inputNewTask;
            this.inputNewTask.Size = new System.Drawing.Size(317, 25);
            this.inputNewTask.TabIndex = 0;
            this.inputNewTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Daily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Controls.Add(this.TaskAdd);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.createNewTask);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Name = "Daily";
            this.Size = new System.Drawing.Size(1440, 987);
            this.Load += new System.EventHandler(this.Daily_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskAddButton)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen)).EndInit();
            this.createNewTask.ResumeLayout(false);
            this.createNewTask.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.TaskAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addToFlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button showWork;
        private Guna.UI2.WinForms.Guna2Button showMain;
        private Guna.UI2.WinForms.Guna2Button showAllTasks;
        private System.Windows.Forms.TextBox greetingsLabel;
        private Guna.UI2.WinForms.Guna2Panel createNewTask;
        private System.Windows.Forms.Label labelType;
        internal System.Windows.Forms.FlowLayoutPanel mainFlowForTasks;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox mainScreen;
        private Guna.UI2.WinForms.Guna2PictureBox TaskAddButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox buttonSearch;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private Guna.UI2.WinForms.Guna2Panel TaskAdd;
        private Guna.UI2.WinForms.Guna2PictureBox addToFlow;
        private Guna.UI2.WinForms.Guna2TextBox inputDateForNewTask;
        private Guna.UI2.WinForms.Guna2TextBox inputNewTask;
        private System.Windows.Forms.ComboBox comboBoxType;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
    }
}
