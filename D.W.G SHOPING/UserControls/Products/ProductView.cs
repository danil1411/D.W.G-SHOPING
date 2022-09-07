using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.W.G_SHOPING.UserControls
{
    public partial class ProductView : UserControl
    {
        
        public ProductView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A constructor, whick make scaled up control for product element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public ProductView(string Title, System.Drawing.Image Image, string Price, string Count, string Token)
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            ProductTitle.Text = Title;
            ProductTitle.Location = new Point(186 - ((Convert.ToInt32(ProductTitle.Text.Length) * 11) /2) - 5, 3);
            ProductPicture.Image = Image;
            ProductPrice.Text = Price;
            ProductPrice.Location = new Point(186 - ((Convert.ToInt32(ProductPrice.Text.Length) * 11) / 2) - 5, 4);
            ProductToken.Text = Token;
            ProductToken.Location = new Point(88 - ((Convert.ToInt32(ProductToken.Text.Length) * 11) / 2) - 6, 2);
            ProductCount.Text = Count;
            if (ProductCount.Text == "0" || ProductCount.Text == "Кол-во")
            {
                ProductCount.Text = "not in stock";
                ProductCount.Location = new Point(88 - ((Convert.ToInt32(ProductCount.Text.Length) * 10) / 2), 2);
            }
            else
            {
                ProductCount.Location = new Point(88 - ((Convert.ToInt32(ProductCount.Text.Length) * 11) / 2) - 5, 2);
            }
        }
    }
}
