using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D.W.G_SHOPING
{
    public partial class ProductsSearchFilters : UserControl
    {
        public ProductsSearchFilters()
        {
            InitializeComponent();
        }
        public void ResetRadio()
        {
            radioPrice.Checked = false;
            radioTitle.Checked = false;
            radioToken.Checked = false;
        }
        public int CheckByFilter()
        {
            if (radioTitle.Checked)
            {
                return 1;
            }
            else if (radioToken.Checked)
            {
                return 2;
            } 
            else if (radioPrice.Checked)
            {
                return 3;
            }  
            else
            {
                return 0;
            }
        }
    }
}
