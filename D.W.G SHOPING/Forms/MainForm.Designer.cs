namespace D.W.G_SHOPING
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.Max_Min = new System.Windows.Forms.PictureBox();
            this.dailyTimer = new System.Windows.Forms.Timer(this.components);
            this.DailyBackTimer = new System.Windows.Forms.Timer(this.components);
            this.bookkeepingTimer = new System.Windows.Forms.Timer(this.components);
            this.BookkeepingBackTimer = new System.Windows.Forms.Timer(this.components);
            this.productsTimer = new System.Windows.Forms.Timer(this.components);
            this.ProductsBackTimer = new System.Windows.Forms.Timer(this.components);
            this.tasksTimer = new System.Windows.Forms.Timer(this.components);
            this.TasksBackTimer = new System.Windows.Forms.Timer(this.components);
            this.Watch = new Guna.UI2.WinForms.Guna2Button();
            this.CalculatorButton = new Guna.UI2.WinForms.Guna2Button();
            this.ChatButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.userWindow = new Guna.UI2.WinForms.Guna2Button();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.Products = new Guna.UI2.WinForms.Guna2Button();
            this.Tasks = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookFeeping = new Guna.UI2.WinForms.Guna2Button();
            this.Daily = new Guna.UI2.WinForms.Guna2Button();
            this.Circle_Right_Top = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rectangles_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bookkeeping1 = new D.W.G_SHOPING.UserControls.Bookkeeping();
            this.daily1 = new D.W.G_SHOPING.UserControls.Daily.Daily();
            this.products1 = new D.W.G_SHOPING.UserControls.Products();
            this.tasks1 = new D.W.G_SHOPING.UserControls.Tasks();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle_Right_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangles_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.ExitPicture);
            this.panel1.Controls.Add(this.Max_Min);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 34);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(1361, 8);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(20, 20);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 13;
            this.Minimize.TabStop = false;
            this.Minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseClick);
            // 
            // ExitPicture
            // 
            this.ExitPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitPicture.BackColor = System.Drawing.Color.Transparent;
            this.ExitPicture.Image = ((System.Drawing.Image)(resources.GetObject("ExitPicture.Image")));
            this.ExitPicture.Location = new System.Drawing.Point(1418, 3);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(29, 31);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPicture.TabIndex = 12;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitPicture_MouseClick);
            // 
            // Max_Min
            // 
            this.Max_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Max_Min.Image = ((System.Drawing.Image)(resources.GetObject("Max_Min.Image")));
            this.Max_Min.Location = new System.Drawing.Point(1385, 2);
            this.Max_Min.Name = "Max_Min";
            this.Max_Min.Size = new System.Drawing.Size(33, 32);
            this.Max_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Max_Min.TabIndex = 19;
            this.Max_Min.TabStop = false;
            this.Max_Min.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Max_Min_MouseClick);
            // 
            // dailyTimer
            // 
            this.dailyTimer.Interval = 10;
            this.dailyTimer.Tick += new System.EventHandler(this.dailyTimer_Tick);
            // 
            // DailyBackTimer
            // 
            this.DailyBackTimer.Interval = 10;
            this.DailyBackTimer.Tick += new System.EventHandler(this.DailyBackTimer_Tick);
            // 
            // bookkeepingTimer
            // 
            this.bookkeepingTimer.Interval = 4;
            this.bookkeepingTimer.Tick += new System.EventHandler(this.bookkeepingTimer_Tick);
            // 
            // BookkeepingBackTimer
            // 
            this.BookkeepingBackTimer.Interval = 4;
            this.BookkeepingBackTimer.Tick += new System.EventHandler(this.BookkeepingBackTimer_Tick);
            // 
            // productsTimer
            // 
            this.productsTimer.Interval = 7;
            this.productsTimer.Tick += new System.EventHandler(this.productsTimer_Tick);
            // 
            // ProductsBackTimer
            // 
            this.ProductsBackTimer.Interval = 7;
            this.ProductsBackTimer.Tick += new System.EventHandler(this.ProductsBackTimer_Tick);
            // 
            // tasksTimer
            // 
            this.tasksTimer.Interval = 10;
            this.tasksTimer.Tick += new System.EventHandler(this.tasksTimer_Tick);
            // 
            // TasksBackTimer
            // 
            this.TasksBackTimer.Interval = 10;
            this.TasksBackTimer.Tick += new System.EventHandler(this.TasksBackTimer_Tick);
            // 
            // Watch
            // 
            this.Watch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Watch.Animated = true;
            this.Watch.AutoRoundedCorners = true;
            this.Watch.BackColor = System.Drawing.Color.Transparent;
            this.Watch.BorderColor = System.Drawing.Color.Transparent;
            this.Watch.BorderRadius = 22;
            this.Watch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Watch.CheckedState.Parent = this.Watch;
            this.Watch.CustomImages.Parent = this.Watch;
            this.Watch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Watch.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Watch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Watch.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Watch.HoverState.Parent = this.Watch;
            this.Watch.Location = new System.Drawing.Point(551, -15);
            this.Watch.Name = "Watch";
            this.Watch.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Watch.PressedDepth = 40;
            this.Watch.ShadowDecoration.BorderRadius = 28;
            this.Watch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Watch.ShadowDecoration.Depth = 65;
            this.Watch.ShadowDecoration.Enabled = true;
            this.Watch.ShadowDecoration.Parent = this.Watch;
            this.Watch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Watch.Size = new System.Drawing.Size(420, 46);
            this.Watch.TabIndex = 52;
            this.Watch.TextOffset = new System.Drawing.Point(0, 7);
            this.Watch.UseTransparentBackground = true;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CalculatorButton.Animated = true;
            this.CalculatorButton.BackColor = System.Drawing.Color.Transparent;
            this.CalculatorButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.CalculatorButton.BorderRadius = 22;
            this.CalculatorButton.BorderThickness = 2;
            this.CalculatorButton.CheckedState.Parent = this.CalculatorButton;
            this.CalculatorButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.CalculatorButton.CustomImages.Parent = this.CalculatorButton;
            this.CalculatorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.CalculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.CalculatorButton.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.CalculatorButton.HoverState.Parent = this.CalculatorButton;
            this.CalculatorButton.Location = new System.Drawing.Point(1412, 319);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.CalculatorButton.PressedDepth = 40;
            this.CalculatorButton.ShadowDecoration.BorderRadius = 0;
            this.CalculatorButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.CalculatorButton.ShadowDecoration.Depth = 65;
            this.CalculatorButton.ShadowDecoration.Parent = this.CalculatorButton;
            this.CalculatorButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.CalculatorButton.Size = new System.Drawing.Size(47, 209);
            this.CalculatorButton.TabIndex = 55;
            this.CalculatorButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CalculatorButton.UseTransparentBackground = true;
            // 
            // ChatButton
            // 
            this.ChatButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChatButton.Animated = true;
            this.ChatButton.BackColor = System.Drawing.Color.Transparent;
            this.ChatButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.ChatButton.BorderRadius = 22;
            this.ChatButton.BorderThickness = 2;
            this.ChatButton.CheckedState.Parent = this.ChatButton;
            this.ChatButton.CustomImages.Parent = this.ChatButton;
            this.ChatButton.FillColor = System.Drawing.Color.Transparent;
            this.ChatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.ChatButton.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ChatButton.HoverState.Parent = this.ChatButton;
            this.ChatButton.Location = new System.Drawing.Point(1412, 637);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.ChatButton.PressedDepth = 40;
            this.ChatButton.ShadowDecoration.BorderRadius = 0;
            this.ChatButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.ChatButton.ShadowDecoration.Depth = 65;
            this.ChatButton.ShadowDecoration.Parent = this.ChatButton;
            this.ChatButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ChatButton.Size = new System.Drawing.Size(47, 209);
            this.ChatButton.TabIndex = 56;
            this.ChatButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChatButton.UseTransparentBackground = true;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // userWindow
            // 
            this.userWindow.Animated = true;
            this.userWindow.BackColor = System.Drawing.Color.Transparent;
            this.userWindow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.userWindow.BorderRadius = 8;
            this.userWindow.BorderThickness = 2;
            this.userWindow.CheckedState.Parent = this.userWindow;
            this.userWindow.CustomImages.Parent = this.userWindow;
            this.userWindow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.userWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.userWindow.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.userWindow.HoverState.Parent = this.userWindow;
            this.userWindow.Location = new System.Drawing.Point(33, -5);
            this.userWindow.Name = "userWindow";
            this.userWindow.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.userWindow.PressedDepth = 40;
            this.userWindow.ShadowDecoration.BorderRadius = 0;
            this.userWindow.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.userWindow.ShadowDecoration.Depth = 65;
            this.userWindow.ShadowDecoration.Parent = this.userWindow;
            this.userWindow.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.userWindow.Size = new System.Drawing.Size(139, 36);
            this.userWindow.TabIndex = 59;
            this.userWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.userWindow.UseTransparentBackground = true;
            // 
            // HomeButton
            // 
            this.HomeButton.Animated = true;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.HomeButton.BorderRadius = 8;
            this.HomeButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.HomeButton.BorderThickness = 2;
            this.HomeButton.CheckedState.Parent = this.HomeButton;
            this.HomeButton.CustomBorderColor = System.Drawing.Color.Transparent;
            this.HomeButton.CustomImages.Parent = this.HomeButton;
            this.HomeButton.CustomizableEdges.BottomLeft = false;
            this.HomeButton.CustomizableEdges.TopLeft = false;
            this.HomeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.HomeButton.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.HomeButton.HoverState.Parent = this.HomeButton;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HomeButton.ImageOffset = new System.Drawing.Point(-4, 1);
            this.HomeButton.ImageSize = new System.Drawing.Size(28, 28);
            this.HomeButton.Location = new System.Drawing.Point(-7, -7);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.HomeButton.PressedDepth = 40;
            this.HomeButton.ShadowDecoration.BorderRadius = 15;
            this.HomeButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.HomeButton.ShadowDecoration.Depth = 65;
            this.HomeButton.ShadowDecoration.Parent = this.HomeButton;
            this.HomeButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.HomeButton.Size = new System.Drawing.Size(41, 38);
            this.HomeButton.TabIndex = 60;
            this.HomeButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HomeButton.UseTransparentBackground = true;
            this.HomeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeButton_MouseClick);
            // 
            // Products
            // 
            this.Products.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Products.Animated = true;
            this.Products.AutoRoundedCorners = true;
            this.Products.BackColor = System.Drawing.Color.Transparent;
            this.Products.BorderColor = System.Drawing.Color.Transparent;
            this.Products.BorderRadius = 21;
            this.Products.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Products.CheckedState.Parent = this.Products;
            this.Products.CustomImages.Parent = this.Products;
            this.Products.CustomizableEdges.BottomLeft = false;
            this.Products.CustomizableEdges.TopLeft = false;
            this.Products.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Products.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Products.HoverState.Parent = this.Products;
            this.Products.Image = ((System.Drawing.Image)(resources.GetObject("Products.Image")));
            this.Products.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Products.ImageOffset = new System.Drawing.Point(1, 0);
            this.Products.ImageSize = new System.Drawing.Size(25, 25);
            this.Products.Location = new System.Drawing.Point(-15, 608);
            this.Products.Name = "Products";
            this.Products.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Products.PressedDepth = 40;
            this.Products.ShadowDecoration.BorderRadius = 28;
            this.Products.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Products.ShadowDecoration.Depth = 65;
            this.Products.ShadowDecoration.Parent = this.Products;
            this.Products.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Products.Size = new System.Drawing.Size(155, 45);
            this.Products.TabIndex = 41;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Products.UseTransparentBackground = true;
            this.Products.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Products_MouseClick);
            this.Products.MouseEnter += new System.EventHandler(this.Products_MouseEnter);
            this.Products.MouseLeave += new System.EventHandler(this.Products_MouseLeave);
            // 
            // Tasks
            // 
            this.Tasks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tasks.Animated = true;
            this.Tasks.AutoRoundedCorners = true;
            this.Tasks.BackColor = System.Drawing.Color.Transparent;
            this.Tasks.BorderColor = System.Drawing.Color.Transparent;
            this.Tasks.BorderRadius = 21;
            this.Tasks.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Tasks.CheckedState.Parent = this.Tasks;
            this.Tasks.CustomImages.Parent = this.Tasks;
            this.Tasks.CustomizableEdges.BottomLeft = false;
            this.Tasks.CustomizableEdges.TopLeft = false;
            this.Tasks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Tasks.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Tasks.HoverState.Parent = this.Tasks;
            this.Tasks.Image = ((System.Drawing.Image)(resources.GetObject("Tasks.Image")));
            this.Tasks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tasks.ImageSize = new System.Drawing.Size(25, 25);
            this.Tasks.Location = new System.Drawing.Point(-40, 689);
            this.Tasks.Name = "Tasks";
            this.Tasks.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Tasks.PressedDepth = 40;
            this.Tasks.ShadowDecoration.BorderRadius = 28;
            this.Tasks.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Tasks.ShadowDecoration.Depth = 65;
            this.Tasks.ShadowDecoration.Parent = this.Tasks;
            this.Tasks.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Tasks.Size = new System.Drawing.Size(155, 45);
            this.Tasks.TabIndex = 42;
            this.Tasks.Text = "Tasks";
            this.Tasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tasks.UseTransparentBackground = true;
            this.Tasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tasks_MouseClick);
            this.Tasks.MouseEnter += new System.EventHandler(this.Tasks_MouseEnter);
            this.Tasks.MouseLeave += new System.EventHandler(this.Tasks_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-8, 810);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1061, 214);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1108, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // BookFeeping
            // 
            this.BookFeeping.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BookFeeping.Animated = true;
            this.BookFeeping.AutoRoundedCorners = true;
            this.BookFeeping.BackColor = System.Drawing.Color.Transparent;
            this.BookFeeping.BorderColor = System.Drawing.Color.Transparent;
            this.BookFeeping.BorderRadius = 21;
            this.BookFeeping.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.BookFeeping.CheckedState.Parent = this.BookFeeping;
            this.BookFeeping.CustomImages.Parent = this.BookFeeping;
            this.BookFeeping.CustomizableEdges.BottomLeft = false;
            this.BookFeeping.CustomizableEdges.TopLeft = false;
            this.BookFeeping.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.BookFeeping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookFeeping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.BookFeeping.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.BookFeeping.HoverState.Parent = this.BookFeeping;
            this.BookFeeping.Image = ((System.Drawing.Image)(resources.GetObject("BookFeeping.Image")));
            this.BookFeeping.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BookFeeping.ImageSize = new System.Drawing.Size(25, 25);
            this.BookFeeping.Location = new System.Drawing.Point(-23, 526);
            this.BookFeeping.Name = "BookFeeping";
            this.BookFeeping.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.BookFeeping.PressedDepth = 40;
            this.BookFeeping.ShadowDecoration.BorderRadius = 28;
            this.BookFeeping.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.BookFeeping.ShadowDecoration.Depth = 65;
            this.BookFeeping.ShadowDecoration.Parent = this.BookFeeping;
            this.BookFeeping.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BookFeeping.Size = new System.Drawing.Size(198, 45);
            this.BookFeeping.TabIndex = 40;
            this.BookFeeping.Text = "Bookkeeping";
            this.BookFeeping.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BookFeeping.UseTransparentBackground = true;
            this.BookFeeping.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookFeeping_MouseClick);
            this.BookFeeping.MouseEnter += new System.EventHandler(this.BookFeeping_MouseEnter);
            this.BookFeeping.MouseLeave += new System.EventHandler(this.BookFeeping_MouseLeave);
            // 
            // Daily
            // 
            this.Daily.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Daily.Animated = true;
            this.Daily.AutoRoundedCorners = true;
            this.Daily.BackColor = System.Drawing.Color.Transparent;
            this.Daily.BorderColor = System.Drawing.Color.Transparent;
            this.Daily.BorderRadius = 21;
            this.Daily.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Daily.CheckedState.Parent = this.Daily;
            this.Daily.CustomImages.Parent = this.Daily;
            this.Daily.CustomizableEdges.BottomLeft = false;
            this.Daily.CustomizableEdges.TopLeft = false;
            this.Daily.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Daily.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Daily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Daily.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Daily.HoverState.Parent = this.Daily;
            this.Daily.Image = ((System.Drawing.Image)(resources.GetObject("Daily.Image")));
            this.Daily.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Daily.ImageSize = new System.Drawing.Size(25, 25);
            this.Daily.Location = new System.Drawing.Point(-93, 447);
            this.Daily.Name = "Daily";
            this.Daily.PressedColor = System.Drawing.Color.Transparent;
            this.Daily.PressedDepth = 40;
            this.Daily.ShadowDecoration.BorderRadius = 28;
            this.Daily.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.Daily.ShadowDecoration.Depth = 65;
            this.Daily.ShadowDecoration.Parent = this.Daily;
            this.Daily.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Daily.Size = new System.Drawing.Size(198, 45);
            this.Daily.TabIndex = 39;
            this.Daily.Text = "Daily ";
            this.Daily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Daily.UseTransparentBackground = true;
            this.Daily.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Daily_MouseClick);
            this.Daily.MouseEnter += new System.EventHandler(this.Daily_MouseEnter);
            this.Daily.MouseLeave += new System.EventHandler(this.Daily_MouseLeave);
            // 
            // Circle_Right_Top
            // 
            this.Circle_Right_Top.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Circle_Right_Top.Image = ((System.Drawing.Image)(resources.GetObject("Circle_Right_Top.Image")));
            this.Circle_Right_Top.Location = new System.Drawing.Point(191, 141);
            this.Circle_Right_Top.Name = "Circle_Right_Top";
            this.Circle_Right_Top.Size = new System.Drawing.Size(253, 245);
            this.Circle_Right_Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Circle_Right_Top.TabIndex = 46;
            this.Circle_Right_Top.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-124, 498);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // Rectangles_2
            // 
            this.Rectangles_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Rectangles_2.Image = ((System.Drawing.Image)(resources.GetObject("Rectangles_2.Image")));
            this.Rectangles_2.Location = new System.Drawing.Point(587, 815);
            this.Rectangles_2.Name = "Rectangles_2";
            this.Rectangles_2.Size = new System.Drawing.Size(1056, 224);
            this.Rectangles_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rectangles_2.TabIndex = 51;
            this.Rectangles_2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1251, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(253, 245);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // bookkeeping1
            // 
            this.bookkeeping1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.bookkeeping1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookkeeping1.Location = new System.Drawing.Point(0, 36);
            this.bookkeeping1.Name = "bookkeeping1";
            this.bookkeeping1.Size = new System.Drawing.Size(1440, 987);
            this.bookkeeping1.TabIndex = 61;
            this.bookkeeping1.Visible = false;
            // 
            // daily1
            // 
            this.daily1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.daily1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.daily1.Location = new System.Drawing.Point(0, 34);
            this.daily1.Name = "daily1";
            this.daily1.Size = new System.Drawing.Size(1440, 987);
            this.daily1.TabIndex = 62;
            this.daily1.Visible = false;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.Transparent;
            this.products1.Location = new System.Drawing.Point(0, 34);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(1440, 987);
            this.products1.TabIndex = 63;
            this.products1.Visible = false;
            // 
            // tasks1
            // 
            this.tasks1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.tasks1.Location = new System.Drawing.Point(0, 34);
            this.tasks1.Name = "tasks1";
            this.tasks1.Size = new System.Drawing.Size(1440, 987);
            this.tasks1.TabIndex = 65;
            this.tasks1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1440, 1024);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.BookFeeping);
            this.Controls.Add(this.tasks1);
            this.Controls.Add(this.products1);
            this.Controls.Add(this.bookkeeping1);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.userWindow);
            this.Controls.Add(this.ChatButton);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Circle_Right_Top);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Rectangles_2);
            this.Controls.Add(this.Watch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalculatorButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.daily1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D.W.G Shop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle_Right_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangles_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox ExitPicture;
        private System.Windows.Forms.PictureBox Max_Min;
        private Guna.UI2.WinForms.Guna2Button Daily;
        private Guna.UI2.WinForms.Guna2Button BookFeeping;
        private Guna.UI2.WinForms.Guna2Button Products;
        private Guna.UI2.WinForms.Guna2Button Tasks;
        private System.Windows.Forms.PictureBox Circle_Right_Top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox Rectangles_2;
        private System.Windows.Forms.Timer dailyTimer;
        private System.Windows.Forms.Timer DailyBackTimer;
        private System.Windows.Forms.Timer bookkeepingTimer;
        private System.Windows.Forms.Timer BookkeepingBackTimer;
        private System.Windows.Forms.Timer productsTimer;
        private System.Windows.Forms.Timer ProductsBackTimer;
        private System.Windows.Forms.Timer tasksTimer;
        private System.Windows.Forms.Timer TasksBackTimer;
        private Guna.UI2.WinForms.Guna2Button Watch;
        private Guna.UI2.WinForms.Guna2Button CalculatorButton;
        private Guna.UI2.WinForms.Guna2Button ChatButton;
        private System.Windows.Forms.Timer ClockTimer;
        private Guna.UI2.WinForms.Guna2Button userWindow;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private UserControls.Bookkeeping bookkeeping1;
        private UserControls.Tasks tasks1;
        private UserControls.Products products1;
        private UserControls.Daily.Daily daily1;
    }
}