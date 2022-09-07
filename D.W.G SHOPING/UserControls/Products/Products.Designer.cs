
namespace D.W.G_SHOPING.UserControls
{
    partial class Products
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
            this.LayoutProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.timerSearch = new System.Windows.Forms.Timer(this.components);
            this.timerGoOut = new System.Windows.Forms.Timer(this.components);
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SearchFilters = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProductSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProductAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.searchfilter = new D.W.G_SHOPING.ProductsSearchFilters();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutProducts
            // 
            this.LayoutProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LayoutProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.LayoutProducts.Location = new System.Drawing.Point(9, 246);
            this.LayoutProducts.Name = "LayoutProducts";
            this.LayoutProducts.Size = new System.Drawing.Size(1448, 741);
            this.LayoutProducts.TabIndex = 0;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.AutoRoundedCorners = true;
            this.TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.TextBoxSearch.BorderRadius = 15;
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
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSearch.HoverState.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Location = new System.Drawing.Point(84, 9);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.PasswordChar = '\0';
            this.TextBoxSearch.PlaceholderText = "";
            this.TextBoxSearch.SelectedText = "";
            this.TextBoxSearch.ShadowDecoration.Parent = this.TextBoxSearch;
            this.TextBoxSearch.Size = new System.Drawing.Size(476, 33);
            this.TextBoxSearch.TabIndex = 2;
            // 
            // timerSearch
            // 
            this.timerSearch.Interval = 10;
            this.timerSearch.Tick += new System.EventHandler(this.timerSearch_Tick);
            // 
            // timerGoOut
            // 
            this.timerGoOut.Interval = 10;
            this.timerGoOut.Tick += new System.EventHandler(this.timerGoOut_Tick);
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.LayoutProducts;
            this.guna2VScrollBar1.BorderRadius = 6;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            this.guna2VScrollBar1.HoverState.Parent = null;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1423, 246);
            this.guna2VScrollBar1.MouseWheelBarPartitions = 10;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.PressedState.Parent = this.guna2VScrollBar1;
            this.guna2VScrollBar1.ScrollbarSize = 14;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(14, 738);
            this.guna2VScrollBar1.TabIndex = 0;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(72)))), ((int)(((byte)(190)))), ((int)(((byte)(216)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.buttonRefresh);
            this.guna2Panel1.Controls.Add(this.SearchFilters);
            this.guna2Panel1.Controls.Add(this.ProductSearch);
            this.guna2Panel1.Controls.Add(this.TextBoxSearch);
            this.guna2Panel1.Controls.Add(this.ProductAdd);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.guna2Panel1.Location = new System.Drawing.Point(683, 145);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(724, 49);
            this.guna2Panel1.TabIndex = 5;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_cloud_refresh_40;
            this.buttonRefresh.Location = new System.Drawing.Point(659, 5);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.ShadowDecoration.Parent = this.buttonRefresh;
            this.buttonRefresh.Size = new System.Drawing.Size(40, 40);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.TabStop = false;
            this.buttonRefresh.UseTransparentBackground = true;
            this.buttonRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRefresh_MouseClick);
            // 
            // SearchFilters
            // 
            this.SearchFilters.BackColor = System.Drawing.Color.Transparent;
            this.SearchFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchFilters.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_settings_40;
            this.SearchFilters.Location = new System.Drawing.Point(613, 5);
            this.SearchFilters.Name = "SearchFilters";
            this.SearchFilters.ShadowDecoration.Parent = this.SearchFilters;
            this.SearchFilters.Size = new System.Drawing.Size(40, 40);
            this.SearchFilters.TabIndex = 9;
            this.SearchFilters.TabStop = false;
            this.SearchFilters.UseTransparentBackground = true;
            this.SearchFilters.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchFilters_MouseClick);
            // 
            // ProductSearch
            // 
            this.ProductSearch.BackColor = System.Drawing.Color.Transparent;
            this.ProductSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductSearch.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_search_40;
            this.ProductSearch.Location = new System.Drawing.Point(567, 5);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.ShadowDecoration.Parent = this.ProductSearch;
            this.ProductSearch.Size = new System.Drawing.Size(40, 40);
            this.ProductSearch.TabIndex = 7;
            this.ProductSearch.TabStop = false;
            this.ProductSearch.UseTransparentBackground = true;
            this.ProductSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductSearch_MouseClick);
            // 
            // ProductAdd
            // 
            this.ProductAdd.BackColor = System.Drawing.Color.Transparent;
            this.ProductAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductAdd.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_add_40;
            this.ProductAdd.Location = new System.Drawing.Point(15, 5);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.ShadowDecoration.Parent = this.ProductAdd;
            this.ProductAdd.Size = new System.Drawing.Size(40, 40);
            this.ProductAdd.TabIndex = 6;
            this.ProductAdd.TabStop = false;
            this.ProductAdd.UseTransparentBackground = true;
            this.ProductAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductAdd_MouseClick);
            // 
            // searchfilter
            // 
            this.searchfilter.BackColor = System.Drawing.Color.Transparent;
            this.searchfilter.ForeColor = System.Drawing.Color.Transparent;
            this.searchfilter.Location = new System.Drawing.Point(825, 184);
            this.searchfilter.Name = "searchfilter";
            this.searchfilter.Size = new System.Drawing.Size(400, 0);
            this.searchfilter.TabIndex = 6;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.Controls.Add(this.searchfilter);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.LayoutProducts);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(1440, 987);
            this.Load += new System.EventHandler(this.Products_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
        private System.Windows.Forms.Timer timerSearch;
        private System.Windows.Forms.Timer timerGoOut;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ProductAdd;
        private Guna.UI2.WinForms.Guna2PictureBox ProductSearch;
        private Guna.UI2.WinForms.Guna2PictureBox SearchFilters;
        public System.Windows.Forms.FlowLayoutPanel LayoutProducts;
        private Guna.UI2.WinForms.Guna2PictureBox buttonRefresh;
        private ProductsSearchFilters searchfilter;
    }
}
