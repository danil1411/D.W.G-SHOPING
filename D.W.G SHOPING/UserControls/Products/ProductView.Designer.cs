
namespace D.W.G_SHOPING.UserControls
{
    partial class ProductView
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
            this.AddImgButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductToken = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductCount = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductTitle = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductPrice = new System.Windows.Forms.Label();
            this.ProductPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.MainPanel.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MainPanel.BorderRadius = 30;
            this.MainPanel.BorderThickness = 2;
            this.MainPanel.Controls.Add(this.guna2Panel4);
            this.MainPanel.Controls.Add(this.guna2Panel1);
            this.MainPanel.Controls.Add(this.guna2Panel3);
            this.MainPanel.Controls.Add(this.guna2Panel2);
            this.MainPanel.Controls.Add(this.ProductPicture);
            this.MainPanel.Controls.Add(this.AddImgButton);
            this.MainPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(198)))), ((int)(((byte)(153)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ShadowDecoration.Parent = this.MainPanel;
            this.MainPanel.Size = new System.Drawing.Size(400, 480);
            this.MainPanel.TabIndex = 1;
            // 
            // AddImgButton
            // 
            this.AddImgButton.BackColor = System.Drawing.Color.Transparent;
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
            this.AddImgButton.Image = global::D.W.G_SHOPING.Properties.Resources.icons8_add_50;
            this.AddImgButton.ImageSize = new System.Drawing.Size(50, 50);
            this.AddImgButton.Location = new System.Drawing.Point(296, 278);
            this.AddImgButton.Name = "AddImgButton";
            this.AddImgButton.PressedColor = System.Drawing.Color.Transparent;
            this.AddImgButton.ShadowDecoration.Parent = this.AddImgButton;
            this.AddImgButton.Size = new System.Drawing.Size(50, 50);
            this.AddImgButton.TabIndex = 6;
            this.AddImgButton.UseTransparentBackground = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Panel4.BorderRadius = 16;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.ProductToken);
            this.guna2Panel4.Location = new System.Drawing.Point(202, 421);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(175, 35);
            this.guna2Panel4.TabIndex = 15;
            // 
            // ProductToken
            // 
            this.ProductToken.AutoSize = true;
            this.ProductToken.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProductToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductToken.Location = new System.Drawing.Point(88, 2);
            this.ProductToken.Name = "ProductToken";
            this.ProductToken.Size = new System.Drawing.Size(0, 28);
            this.ProductToken.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.ProductCount);
            this.guna2Panel1.Location = new System.Drawing.Point(26, 421);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(175, 35);
            this.guna2Panel1.TabIndex = 14;
            // 
            // ProductCount
            // 
            this.ProductCount.AutoSize = true;
            this.ProductCount.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProductCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductCount.Location = new System.Drawing.Point(91, 2);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(0, 28);
            this.ProductCount.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Panel3.BorderRadius = 16;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.ProductTitle);
            this.guna2Panel3.Location = new System.Drawing.Point(15, 349);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(371, 35);
            this.guna2Panel3.TabIndex = 13;
            // 
            // ProductTitle
            // 
            this.ProductTitle.AutoSize = true;
            this.ProductTitle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProductTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductTitle.Location = new System.Drawing.Point(186, 3);
            this.ProductTitle.MaximumSize = new System.Drawing.Size(371, 35);
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.Size = new System.Drawing.Size(0, 28);
            this.ProductTitle.TabIndex = 12;
            this.ProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Panel2.BorderRadius = 16;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.ProductPrice);
            this.guna2Panel2.Location = new System.Drawing.Point(15, 385);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(371, 35);
            this.guna2Panel2.TabIndex = 13;
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSize = true;
            this.ProductPrice.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProductPrice.Location = new System.Drawing.Point(186, 4);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(0, 28);
            this.ProductPrice.TabIndex = 12;
            this.ProductPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ProductPicture
            // 
            this.ProductPicture.BorderRadius = 30;
            this.ProductPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProductPicture.Location = new System.Drawing.Point(36, 20);
            this.ProductPicture.Name = "ProductPicture";
            this.ProductPicture.ShadowDecoration.Parent = this.ProductPicture;
            this.ProductPicture.Size = new System.Drawing.Size(325, 325);
            this.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPicture.TabIndex = 5;
            this.ProductPicture.TabStop = false;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainPanel);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(400, 480);
            this.MainPanel.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Button AddImgButton;
        private Guna.UI2.WinForms.Guna2PictureBox ProductPicture;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label ProductTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label ProductPrice;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label ProductToken;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label ProductCount;
    }
}
