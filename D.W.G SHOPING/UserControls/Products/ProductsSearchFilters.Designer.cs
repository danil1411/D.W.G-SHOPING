
namespace D.W.G_SHOPING
{
    partial class ProductsSearchFilters
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioTitle = new System.Windows.Forms.RadioButton();
            this.radioPrice = new System.Windows.Forms.RadioButton();
            this.radioToken = new System.Windows.Forms.RadioButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.guna2Panel1.BorderRadius = 11;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.radioToken);
            this.guna2Panel1.Controls.Add(this.radioPrice);
            this.guna2Panel1.Controls.Add(this.radioTitle);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomizableEdges.TopLeft = false;
            this.guna2Panel1.CustomizableEdges.TopRight = false;
            this.guna2Panel1.FillColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(400, 210);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(154, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by:";
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.radioTitle.Location = new System.Drawing.Point(43, 60);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(60, 27);
            this.radioTitle.TabIndex = 1;
            this.radioTitle.TabStop = true;
            this.radioTitle.Text = "Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            // 
            // radioPrice
            // 
            this.radioPrice.AutoSize = true;
            this.radioPrice.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.radioPrice.Location = new System.Drawing.Point(43, 107);
            this.radioPrice.Name = "radioPrice";
            this.radioPrice.Size = new System.Drawing.Size(65, 27);
            this.radioPrice.TabIndex = 2;
            this.radioPrice.TabStop = true;
            this.radioPrice.Text = "Price";
            this.radioPrice.UseVisualStyleBackColor = true;
            // 
            // radioToken
            // 
            this.radioToken.AutoSize = true;
            this.radioToken.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(94)))), ((int)(((byte)(91)))));
            this.radioToken.Location = new System.Drawing.Point(43, 157);
            this.radioToken.Name = "radioToken";
            this.radioToken.Size = new System.Drawing.Size(72, 27);
            this.radioToken.TabIndex = 3;
            this.radioToken.TabStop = true;
            this.radioToken.Text = "Token";
            this.radioToken.UseVisualStyleBackColor = true;
            // 
            // ProductsSearchFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ProductsSearchFilters";
            this.Size = new System.Drawing.Size(400, 211);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioToken;
        private System.Windows.Forms.RadioButton radioPrice;
        private System.Windows.Forms.RadioButton radioTitle;
    }
}
