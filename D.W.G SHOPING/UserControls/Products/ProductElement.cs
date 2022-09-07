using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BL_Products;

namespace D.W.G_SHOPING.UserControls
{
    public partial class ProductElement : UserControl
    {
        string tempTitle, tempPrice, tempCount, tempToken;
        Guid id;
        bool ispressed = false, isdone = false;
        bool isfirst = true;
        bool enabled = true;
        ProductView view;
        Image imagee, imagee1, tempImage;
        string file = null;
        public ProductElement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for products, whick gets from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public ProductElement(string Title, int Price, int Count, string Token, string Image, Guid Id)
        {
            isdone = false;
            InitializeComponent();
            id = Id;
            ispressed = true;
            ProductId.Text = Convert.ToString(Id);
            ProductTitle.Text = Title;
            if (Count == 0)
            {
                ProductCount.Text = Convert.ToString(Count);
                NotInStock.BringToFront();
            }
            else
            {
                ProductCount.Text = Convert.ToString(Count);
            }
            ProductPrice.Text = Convert.ToString(Price);
            ProductToken.Text = Token;
            ProductPicture.Image = ConvertBase64ArrayToImage(Image);
            buttonSave.Visible = false;
            AddImgButton.Visible = false;
            tempCount = ProductCount.Text;
            tempToken = ProductToken.Text;
            tempTitle = ProductTitle.Text;
            tempPrice = ProductPrice.Text;
            tempImage = ProductPicture.Image;
            isdone = true;
        }

        /// <summary>
        /// Method which one increase delete text from TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProductTitle.Text == "Название")
            {
                ProductTitle.Text = "";
            }
        }

        /// <summary>
        /// Method which one increase delete text from TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductPrice_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProductPrice.Text == "Цена")
            {
                ProductPrice.Text = "";
            }
        }

        /// <summary>
        /// Method which add image for PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddImgButton_MouseClick(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Title = "Open Image";
                of.Filter = "Img files (*.png)|*.png|(*.jpeg)|*.jpeg";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    ProductPicture.Image = Image.FromFile(of.FileName);
                    file = of.FileName;
                }
                AddImgButton.Hide();
                ispressed = true;
                ProductPicture.Cursor = Cursors.Hand;
            }
        }

        /// <summary>
        /// Method which makes PictureBox works like Button if button was pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (ispressed)
            {
                using (OpenFileDialog of = new OpenFileDialog())
                {
                    of.Title = "Open Image";
                    of.Filter = "Img files (*.png)|*.png|(*.jpeg)|*.jpeg";
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        ProductPicture.Image = Image.FromFile(of.FileName);
                        file = of.FileName;
                        buttonUpdate.Visible = true;
                    }
                }
            }
        }

        /// <summary>
        /// Button which makes ProductElement scale up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExpand_MouseClick(object sender, MouseEventArgs e)
        {
            if (!enabled)
            {
                view.Visible = false;
                Parent.Location = new Point(0, Parent.Location.Y);
                Parent.Size = new Size(Parent.Width + 410, Parent.Height);
                enabled = true;
                this.BorderStyle = BorderStyle.None;
            }
            else
            if (enabled && Parent.Location.X + 410 == 820) {; }
            else
            {
                if (isfirst)
                {
                    view = new ProductView(ProductTitle.Text, ProductPicture.Image, ProductPrice.Text, ProductCount.Text, ProductToken.Text);
                    Parent.Location = new Point(Parent.Location.X + 410, Parent.Location.Y);
                    Parent.Size = new Size(Parent.Width - 410, Parent.Height);
                    view.Location = new Point(5, Parent.Location.Y + 5);
                    Parent.Parent.Controls.Add(view);
                    view.BringToFront();
                    isfirst = false;
                    enabled = false;
                }
                else
                {
                    view = new ProductView(ProductTitle.Text, ProductPicture.Image, ProductPrice.Text, ProductCount.Text, ProductToken.Text);
                    view.Location = new Point(5, Parent.Location.Y + 5);
                    Parent.Location = new Point(410, Parent.Location.Y);

                    Parent.Parent.Controls.Add(view);
                    view.BringToFront();
                    enabled = false;
                }
                this.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        /// <summary>
        /// Method which set image for expand button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExpand_MouseEnter(object sender, EventArgs e)
        {
            buttonExpand.Image = imagee;
        }

        /// <summary>
        /// Method which hides image of expand button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductElement_Load(object sender, EventArgs e)
        {
            
            imagee1 = buttonDelete.Image;
            imagee = buttonExpand.Image;
            buttonExpand.Image = null;
            buttonDelete.Image = null;
        }

        /// <summary>
        /// Method which hides image of expand button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExpand_MouseLeave(object sender, EventArgs e)
        {
            buttonExpand.Image = null;
        }

        private void ProductCount_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProductCount.Text == "Кол-во")
            {
                ProductCount.Text = "";
            }
        }

        private void ProductToken_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (ProductToken.Text == "Токен")
            {
                ProductToken.Text = "";
            }
        }

        /// <summary>
        /// Method which dont let to write letters in count field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductCount_TextChanged(object sender, EventArgs e)
        {
            if (ProductCount.Text != tempCount && isdone)
            {
                buttonUpdate.Visible = true;
            }
            else
            {
                buttonUpdate.Visible = false;
            }
            if (ProductCount.Text != "Кол-во")
            {
                bool checkISNumber = int.TryParse(ProductCount.Text, out int buffer);
                if (checkISNumber != true)
                {
                    if (ProductCount.Text.Length != 0)
                    {
                        ProductCount.Text = ProductCount.Text.Remove((ProductCount.Text.Length - 1));
                        ProductCount.SelectionStart = ProductCount.Text.Length;
                        ProductCount.SelectionLength = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Method which dont let to write letters in price field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductPrice_TextChanged(object sender, EventArgs e)
        {
            if (ProductPrice.Text != tempPrice && isdone)
            {
                buttonUpdate.Visible = true;
            }
            else
            {
                buttonUpdate.Visible = false;
            }
            if (ProductPrice.Text != "Цена")
            {
                bool checkISNumber = int.TryParse(ProductPrice.Text, out int buffer);
                if (checkISNumber != true)
                {
                    if (ProductPrice.Text.Length != 0)
                    {
                        ProductPrice.Text = ProductPrice.Text.Remove((ProductPrice.Text.Length - 1));
                        ProductPrice.SelectionStart = ProductPrice.Text.Length;
                        ProductPrice.SelectionLength = 0;
                    }
                }
            }
        }

        private void ProductTitle_Leave(object sender, EventArgs e)
        {
            if (ProductTitle.Text == "")
            {
                ProductTitle.Text = "Название";
            }
        }

        private void ProductPrice_Leave(object sender, EventArgs e)
        {
            if (ProductPrice.Text == "")
            {
                ProductPrice.Text = "Цена";
            }
        }

        private void ProductCount_Leave(object sender, EventArgs e)
        {
            if (ProductCount.Text == "0" || ProductCount.Text == "")
            {
                ProductCount.Text = "";
                NotInStock.Text = "Not in stock";
            }
        }

        private void ProductToken_Leave(object sender, EventArgs e)
        {
            if (ProductToken.Text == "")
            {
                ProductToken.Text = "Токен";
            }
        }

        /// <summary>
        /// Button, which add product to DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProductTitle.Text != "" && ProductPrice.Text != "" && ProductCount.Text != "" && ProductToken.Text != "")
            {
                Products_Adapter.Add(ProductTitle.Text, Convert.ToInt32(ProductPrice.Text), Convert.ToInt32(ProductCount.Text), ProductToken.Text, ConvertImageToBytes(ProductPicture.Image), file);
                buttonSave.Visible = false;
                tempCount = ProductCount.Text;
                tempToken = ProductToken.Text;
                tempTitle = ProductTitle.Text;
                tempPrice = ProductPrice.Text;
                tempImage = ProductPicture.Image;
                isdone = true;
            }
        }

        /// <summary>
        /// Method, which convert base64 to Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public Image ConvertBase64ArrayToImage(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Method, which convert Image to Base64String
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public string ConvertImageToBytes(Image img)
        {
            using (MemoryStream m = new MemoryStream())
            {
                img.Save(m, img.RawFormat);
                byte[] imageBytes = m.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void ProductToken_TextChanged(object sender, EventArgs e)
        {
            if (ProductToken.Text != tempToken && isdone)
            {
                buttonUpdate.Visible = true;
            }
            else
            {
                buttonUpdate.Visible = false;
            }
        }

        private void buttonDelete_MouseEnter(object sender, EventArgs e)
        {
            buttonDelete.Image = imagee1;
        }

        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            buttonDelete.Image = null;
        }

        private void NotInStock_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProductCount.Text == "0" || ProductCount.Text == "")
            {
                NotInStock.Text = "";
                ProductCount.Focus();
            }
        }

        /// <summary>
        /// Method, which update product in DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            if(ProductCount.Text == "")
            {
                Products_Adapter.Update(Products_Adapter.GetById(id), ProductTitle.Text, Convert.ToInt32(ProductPrice.Text), 0, ProductToken.Text, ConvertImageToBytes(ProductPicture.Image));
            }
            else
            {
                Products_Adapter.Update(Products_Adapter.GetById(id), ProductTitle.Text, Convert.ToInt32(ProductPrice.Text), Convert.ToInt32(ProductCount.Text), ProductToken.Text, ConvertImageToBytes(ProductPicture.Image));
            }
            buttonUpdate.Hide();
        }

        private void ProductTitle_TextChanged(object sender, EventArgs e)
        {
            if(ProductTitle.Text != tempTitle && isdone)
            {
                buttonUpdate.Visible = true;
            }
            else
            {
                buttonUpdate.Visible = false;
            }
        }

        /// <summary>
        /// Method which delete product from layout and DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Products_Adapter.DeleteByToken(ProductToken.Text);
            Parent.Controls.Remove(this);
        }
    }
}
