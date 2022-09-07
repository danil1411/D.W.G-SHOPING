using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_Products;
using BO_Products;

namespace D.W.G_SHOPING.UserControls
{

    public partial class Products : UserControl
    {
        List<Product_Variables> prod = new List<Product_Variables>();
        List<Product_Variables> sortedBySearchFilter = new List<Product_Variables>();
        bool enabled = false;
        public Products()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method which add ProductElement control to the flow layount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ProductElement product = new ProductElement();
            LayoutProducts.Controls.Add(product);
        }

        /// <summary>
        /// Method which add ProductSearchControl control to the Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Products_Load(object sender, EventArgs e)
        {
            try
            {
                prod.AddRange(Products_Adapter.GetAll());
            }
            catch
            {
                          
            }
            searchfilter.Visible = true;
            foreach (var obj in prod)
            {
                ProductElement addedproduct = new ProductElement(obj.Title, obj.Price, obj.Count, obj.Token, obj.Image, obj.Id);
                LayoutProducts.Controls.Add(addedproduct);
            }
        }

        /// <summary>
        /// Method which start/stop timers of search textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFilters_MouseClick(object sender, MouseEventArgs e)
        {

            if (!enabled)
            {
                timerGoOut.Stop();
                timerSearch.Start();
                enabled = true;
                TextBoxSearch.ReadOnly = false;
            }
            else
            {
                timerSearch.Stop();
                timerGoOut.Start();
                enabled = false;
                TextBoxSearch.ReadOnly = false;
            }
        }

        private void timerSearch_Tick(object sender, EventArgs e)
        {
            if (searchfilter.Height < 210)
            {
                searchfilter.Height += 5;
            }
        }

        private void timerGoOut_Tick(object sender, EventArgs e)
        {
            if (searchfilter.Height >= 0)
            {
                searchfilter.Height -= 5;
            }
        }

        /// <summary>
        /// Method which makes reload products from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxSearch.Text = "";
            searchfilter.ResetRadio();
            prod.Clear();
            LayoutProducts.Controls.Clear();
            prod.AddRange(Products_Adapter.GetAll());
            foreach (var obj in prod)
            {
                ProductElement addedproduct = new ProductElement(obj.Title, obj.Price, obj.Count, obj.Token, obj.Image, obj.Id);
                LayoutProducts.Controls.Add(addedproduct);
            }
        }

        /// <summary>
        /// Method which check filteres to search and return result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductSearch_MouseClick(object sender, MouseEventArgs e)
        {
            int searchFilter = searchfilter.CheckByFilter();
            switch (searchFilter)
            {
                case 0:
                    sortedBySearchFilter.Clear();
                    LayoutProducts.Controls.Clear();
                    sortedBySearchFilter.AddRange(Products_Adapter.GetByTitle(TextBoxSearch.Text));
                    foreach (var obj in sortedBySearchFilter)
                    {
                        ProductElement addedproduct = new ProductElement(obj.Title, obj.Price, obj.Count, obj.Token, obj.Image, obj.Id);
                        LayoutProducts.Controls.Add(addedproduct);
                    }
                    if (!sortedBySearchFilter.Any())
                    {
                        MessageBox.Show(
                        "Nothing found!",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        buttonRefresh_MouseClick(sender, e);
                    }
                    break;
                case 1:
                    sortedBySearchFilter.Clear();
                    LayoutProducts.Controls.Clear();
                    sortedBySearchFilter.AddRange(Products_Adapter.GetByTitle(TextBoxSearch.Text));
                    foreach (var obj in sortedBySearchFilter)
                    {
                        ProductElement addedproduct = new ProductElement(obj.Title, obj.Price, obj.Count, obj.Token, obj.Image, obj.Id);
                        LayoutProducts.Controls.Add(addedproduct);
                    }
                    if (!sortedBySearchFilter.Any())
                    {
                        MessageBox.Show(
                        "Nothing found!",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        buttonRefresh_MouseClick(sender, e);
                    }
                    break;
                case 2:
                    sortedBySearchFilter.Clear();
                    LayoutProducts.Controls.Clear();
                    sortedBySearchFilter.AddRange(Products_Adapter.GetByToken(TextBoxSearch.Text));
                    foreach (var obj in sortedBySearchFilter)
                    {
                        ProductElement addedproduct = new ProductElement(obj.Title, obj.Price, obj.Count, obj.Token, obj.Image, obj.Id);
                        LayoutProducts.Controls.Add(addedproduct);
                    }
                    if (!sortedBySearchFilter.Any())
                    {
                        MessageBox.Show(
                        "Nothing found!",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        buttonRefresh_MouseClick(sender, e);
                    }
                    break;
                case 3:
                    sortedBySearchFilter.Clear();
                    LayoutProducts.Controls.Clear();
                    sortedBySearchFilter.AddRange(Products_Adapter.GetByPrice(Convert.ToInt32(TextBoxSearch.Text)));
                    foreach (var obj in sortedBySearchFilter)
                    {
                        ProductElement addedproduct = new ProductElement(obj.Title, obj.Price, obj.Count, obj.Token, obj.Image, obj.Id);
                        LayoutProducts.Controls.Add(addedproduct);
                    }
                    if (!sortedBySearchFilter.Any())
                    {
                        MessageBox.Show(
                        "Nothing found!",
                        "Search",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        buttonRefresh_MouseClick(sender, e);
                    }
                    break;
            }
        }
    }
}
