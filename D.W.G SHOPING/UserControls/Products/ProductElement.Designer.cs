
namespace D.W.G_SHOPING.UserControls
{
    partial class ProductElement
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
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonSave = new Guna.UI2.WinForms.Guna2Button();
            this.ProductCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductToken = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonExpand = new Guna.UI2.WinForms.Guna2Button();
            this.AddImgButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProductPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.NotInStock = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MainPanel.BorderRadius = 30;
            this.MainPanel.BorderThickness = 2;
            this.MainPanel.Controls.Add(this.buttonUpdate);
            this.MainPanel.Controls.Add(this.buttonDelete);
            this.MainPanel.Controls.Add(this.buttonSave);
            this.MainPanel.Controls.Add(this.ProductCount);
            this.MainPanel.Controls.Add(this.ProductToken);
            this.MainPanel.Controls.Add(this.buttonExpand);
            this.MainPanel.Controls.Add(this.AddImgButton);
            this.MainPanel.Controls.Add(this.ProductPicture);
            this.MainPanel.Controls.Add(this.ProductPrice);
            this.MainPanel.Controls.Add(this.ProductTitle);
            this.MainPanel.Controls.Add(this.NotInStock);
            this.MainPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ShadowDecoration.Parent = this.MainPanel;
            this.MainPanel.Size = new System.Drawing.Size(189, 229);
            this.MainPanel.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.CheckedState.Parent = this.buttonUpdate;
            this.buttonUpdate.CustomImages.Parent = this.buttonUpdate;
            this.buttonUpdate.FillColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.HoverState.Parent = this.buttonUpdate;
            this.buttonUpdate.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_upload_40;
            this.buttonUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonUpdate.Location = new System.Drawing.Point(129, 18);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.ShadowDecoration.Parent = this.buttonUpdate;
            this.buttonUpdate.Size = new System.Drawing.Size(31, 20);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.UseTransparentBackground = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonUpdate_MouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.CheckedState.Parent = this.buttonDelete;
            this.buttonDelete.CustomImages.Parent = this.buttonDelete;
            this.buttonDelete.FillColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.HoverState.Parent = this.buttonDelete;
            this.buttonDelete.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_close_window_30;
            this.buttonDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonDelete.Location = new System.Drawing.Point(32, 114);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.ShadowDecoration.Parent = this.buttonDelete;
            this.buttonDelete.Size = new System.Drawing.Size(31, 20);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.UseTransparentBackground = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonDelete_MouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonDelete_MouseLeave);
            // 
            // buttonSave
            // 
            this.buttonSave.CheckedState.Parent = this.buttonSave;
            this.buttonSave.CustomImages.Parent = this.buttonSave;
            this.buttonSave.FillColor = System.Drawing.Color.Transparent;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.HoverState.Parent = this.buttonSave;
            this.buttonSave.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_save_30;
            this.buttonSave.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonSave.Location = new System.Drawing.Point(129, 18);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.ShadowDecoration.Parent = this.buttonSave;
            this.buttonSave.Size = new System.Drawing.Size(31, 20);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.UseTransparentBackground = true;
            this.buttonSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSave_MouseClick);
            // 
            // ProductCount
            // 
            this.ProductCount.AutoRoundedCorners = true;
            this.ProductCount.BackColor = System.Drawing.Color.Transparent;
            this.ProductCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductCount.BorderRadius = 11;
            this.ProductCount.BorderThickness = 2;
            this.ProductCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductCount.DefaultText = "Кол-во";
            this.ProductCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductCount.DisabledState.Parent = this.ProductCount;
            this.ProductCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.ProductCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductCount.FocusedState.Parent = this.ProductCount;
            this.ProductCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductCount.HoverState.Parent = this.ProductCount;
            this.ProductCount.Location = new System.Drawing.Point(16, 194);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.PasswordChar = '\0';
            this.ProductCount.PlaceholderText = "";
            this.ProductCount.SelectedText = "";
            this.ProductCount.SelectionStart = 6;
            this.ProductCount.ShadowDecoration.Parent = this.ProductCount;
            this.ProductCount.Size = new System.Drawing.Size(80, 24);
            this.ProductCount.TabIndex = 13;
            this.ProductCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductCount.TextChanged += new System.EventHandler(this.ProductCount_TextChanged);
            this.ProductCount.Leave += new System.EventHandler(this.ProductCount_Leave);
            this.ProductCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductCount_MouseClick);
            // 
            // ProductToken
            // 
            this.ProductToken.AutoRoundedCorners = true;
            this.ProductToken.BackColor = System.Drawing.Color.Transparent;
            this.ProductToken.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductToken.BorderRadius = 11;
            this.ProductToken.BorderThickness = 2;
            this.ProductToken.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductToken.DefaultText = "Токен";
            this.ProductToken.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductToken.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductToken.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductToken.DisabledState.Parent = this.ProductToken;
            this.ProductToken.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductToken.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.ProductToken.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductToken.FocusedState.Parent = this.ProductToken;
            this.ProductToken.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductToken.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductToken.HoverState.Parent = this.ProductToken;
            this.ProductToken.Location = new System.Drawing.Point(96, 194);
            this.ProductToken.Name = "ProductToken";
            this.ProductToken.PasswordChar = '\0';
            this.ProductToken.PlaceholderText = "";
            this.ProductToken.SelectedText = "";
            this.ProductToken.SelectionStart = 5;
            this.ProductToken.ShadowDecoration.Parent = this.ProductToken;
            this.ProductToken.Size = new System.Drawing.Size(80, 24);
            this.ProductToken.TabIndex = 12;
            this.ProductToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductToken.TextChanged += new System.EventHandler(this.ProductToken_TextChanged);
            this.ProductToken.Leave += new System.EventHandler(this.ProductToken_Leave);
            this.ProductToken.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductToken_MouseClick);
            // 
            // buttonExpand
            // 
            this.buttonExpand.CheckedState.Parent = this.buttonExpand;
            this.buttonExpand.CustomImages.Parent = this.buttonExpand;
            this.buttonExpand.FillColor = System.Drawing.Color.Transparent;
            this.buttonExpand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonExpand.ForeColor = System.Drawing.Color.White;
            this.buttonExpand.HoverState.Parent = this.buttonExpand;
            this.buttonExpand.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_zoom_to_extents_20;
            this.buttonExpand.Location = new System.Drawing.Point(32, 18);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.ShadowDecoration.Parent = this.buttonExpand;
            this.buttonExpand.Size = new System.Drawing.Size(31, 20);
            this.buttonExpand.TabIndex = 8;
            this.buttonExpand.UseTransparentBackground = true;
            this.buttonExpand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonExpand_MouseClick);
            this.buttonExpand.MouseEnter += new System.EventHandler(this.buttonExpand_MouseEnter);
            this.buttonExpand.MouseLeave += new System.EventHandler(this.buttonExpand_MouseLeave);
            // 
            // AddImgButton
            // 
            this.AddImgButton.BorderColor = System.Drawing.Color.Transparent;
            this.AddImgButton.BorderRadius = 10;
            this.AddImgButton.BorderThickness = 1;
            this.AddImgButton.CheckedState.Parent = this.AddImgButton;
            this.AddImgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddImgButton.CustomImages.Parent = this.AddImgButton;
            this.AddImgButton.FillColor = System.Drawing.Color.Transparent;
            this.AddImgButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddImgButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddImgButton.HoverState.Parent = this.AddImgButton;
            this.AddImgButton.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_add_35;
            this.AddImgButton.ImageSize = new System.Drawing.Size(35, 35);
            this.AddImgButton.Location = new System.Drawing.Point(125, 106);
            this.AddImgButton.Name = "AddImgButton";
            this.AddImgButton.PressedColor = System.Drawing.Color.Transparent;
            this.AddImgButton.ShadowDecoration.Parent = this.AddImgButton;
            this.AddImgButton.Size = new System.Drawing.Size(35, 35);
            this.AddImgButton.TabIndex = 6;
            this.AddImgButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddImgButton_MouseClick);
            // 
            // ProductPicture
            // 
            this.ProductPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductPicture.Location = new System.Drawing.Point(32, 13);
            this.ProductPicture.Name = "ProductPicture";
            this.ProductPicture.ShadowDecoration.Parent = this.ProductPicture;
            this.ProductPicture.Size = new System.Drawing.Size(128, 128);
            this.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPicture.TabIndex = 5;
            this.ProductPicture.TabStop = false;
            this.ProductPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductPicture_MouseClick);
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoRoundedCorners = true;
            this.ProductPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductPrice.BorderRadius = 11;
            this.ProductPrice.BorderThickness = 2;
            this.ProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPrice.DefaultText = "Цена";
            this.ProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPrice.DisabledState.Parent = this.ProductPrice;
            this.ProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.ProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPrice.FocusedState.Parent = this.ProductPrice;
            this.ProductPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPrice.HoverState.Parent = this.ProductPrice;
            this.ProductPrice.Location = new System.Drawing.Point(15, 170);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.PasswordChar = '\0';
            this.ProductPrice.PlaceholderText = "";
            this.ProductPrice.SelectedText = "";
            this.ProductPrice.SelectionStart = 4;
            this.ProductPrice.ShadowDecoration.Parent = this.ProductPrice;
            this.ProductPrice.Size = new System.Drawing.Size(162, 24);
            this.ProductPrice.TabIndex = 1;
            this.ProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductPrice.TextChanged += new System.EventHandler(this.ProductPrice_TextChanged);
            this.ProductPrice.Leave += new System.EventHandler(this.ProductPrice_Leave);
            this.ProductPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductPrice_MouseClick);
            // 
            // ProductTitle
            // 
            this.ProductTitle.AutoRoundedCorners = true;
            this.ProductTitle.BackColor = System.Drawing.Color.Transparent;
            this.ProductTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductTitle.BorderRadius = 11;
            this.ProductTitle.BorderThickness = 2;
            this.ProductTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductTitle.DefaultText = "Название";
            this.ProductTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductTitle.DisabledState.Parent = this.ProductTitle;
            this.ProductTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.ProductTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductTitle.FocusedState.Parent = this.ProductTitle;
            this.ProductTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductTitle.HoverState.Parent = this.ProductTitle;
            this.ProductTitle.Location = new System.Drawing.Point(15, 147);
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.PasswordChar = '\0';
            this.ProductTitle.PlaceholderText = "";
            this.ProductTitle.SelectedText = "";
            this.ProductTitle.SelectionStart = 8;
            this.ProductTitle.ShadowDecoration.Parent = this.ProductTitle;
            this.ProductTitle.Size = new System.Drawing.Size(162, 24);
            this.ProductTitle.TabIndex = 0;
            this.ProductTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductTitle.TextChanged += new System.EventHandler(this.ProductTitle_TextChanged);
            this.ProductTitle.Leave += new System.EventHandler(this.ProductTitle_Leave);
            this.ProductTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductTitle_MouseClick);
            // 
            // NotInStock
            // 
            this.NotInStock.AutoSize = true;
            this.NotInStock.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.NotInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NotInStock.Location = new System.Drawing.Point(21, 199);
            this.NotInStock.Name = "NotInStock";
            this.NotInStock.Size = new System.Drawing.Size(69, 13);
            this.NotInStock.TabIndex = 16;
            this.NotInStock.Text = "Not in stock";
            this.NotInStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotInStock_MouseClick);
            // 
            // ProductId
            // 
            this.ProductId.AutoSize = true;
            this.ProductId.Location = new System.Drawing.Point(188, 219);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(0, 13);
            this.ProductId.TabIndex = 17;
            this.ProductId.Visible = false;
            // 
            // ProductElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ProductId);
            this.Controls.Add(this.MainPanel);
            this.Name = "ProductElement";
            this.Size = new System.Drawing.Size(195, 235);
            this.Load += new System.EventHandler(this.ProductElement_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2TextBox ProductPrice;
        private Guna.UI2.WinForms.Guna2TextBox ProductTitle;
        private Guna.UI2.WinForms.Guna2Button AddImgButton;
        private Guna.UI2.WinForms.Guna2PictureBox ProductPicture;
        private Guna.UI2.WinForms.Guna2Button buttonExpand;
        private Guna.UI2.WinForms.Guna2TextBox ProductCount;
        private Guna.UI2.WinForms.Guna2TextBox ProductToken;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private System.Windows.Forms.Label ProductId;
        private System.Windows.Forms.Label NotInStock;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
    }
}
