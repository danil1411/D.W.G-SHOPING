using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using D.W.G_SHOPING.UserControls;
using BO_Bookkeeping;
using BL_Bookeeping;
using DAL_Bookkeeping;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;

namespace D.W.G_SHOPING.UserControls
{
    public partial class Panel2 : UserControl
    {

        bool blockButton = false;
        public bool zvezdOchka = false;
        List<BookkeepingBO> files = new List<BookkeepingBO>();
        public Panel2()
        {
            //задання значень при завантаженні userControl на bookkeeping
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;

            FileName.ForeColor = Color.FromArgb(250, 198, 153);
            UserFileName.ForeColor = Color.FromArgb(250, 198, 153);
            UserFileName.FillColor = Color.FromArgb(229, 94, 91);
            UserFileName.Text = "Ваше название файла";

        }
        public Panel2(string Desc)
        {
            InitializeComponent();


        }




        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
        //методи для подій MouseEnter MouseLeave
        private void size_location_change(PictureBox pictureBox)
        {
            pictureBox.Size = new Size(pictureBox.Width - 6, pictureBox.Height - 6);
            pictureBox.Location = new Point(pictureBox.Location.X + 3, pictureBox.Location.Y + 3);
        }
        private void size_location_back(PictureBox pictureBox)
        {
            pictureBox.Size = new Size(pictureBox.Width + 6, pictureBox.Height + 6);
            pictureBox.Location = new Point(pictureBox.Location.X - 3, pictureBox.Location.Y - 3);
        }
        //реалізація методів для подій MouseEnter MouseLeave
        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            size_location_change(pictureBox7);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            size_location_back(pictureBox7);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {

            size_location_change(pictureBox8);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {

            size_location_back(pictureBox8);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            size_location_change(pictureBox3);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            size_location_back(pictureBox3);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            size_location_change(pictureBox5);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            size_location_back(pictureBox5);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            size_location_change(pictureBox6);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            size_location_back(pictureBox6);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            size_location_change(pictureBox4);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            size_location_back(pictureBox4);
        }

        //Видалення UserControl зі списку
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var s = ((PictureBox)(sender)).Parent;
            var g = s.Parent;
            g.Parent.Controls.Remove(g);
            BookkeepingBL.Delete_Book(token_delete.Text, Path.Text, FileName.Text);
            pictureBox4.Parent.Controls.Remove(pictureBox4.Parent);
        }
        //Дозволяє видалити файл
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Enabled = true;

        }
        //Забороняє видалення файлу
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.Enabled = false;

        }
        //Фокус на полі для ввода назви файла
        private void pictureBox8_Click(object sender, EventArgs e)
        {


            if (blockButton == false)
            {
                pictureBox8.MouseEnter -= new System.EventHandler(pictureBox8_MouseEnter);
                pictureBox8.MouseLeave -= new System.EventHandler(pictureBox8_MouseLeave);
                blockButton = true;

                UserFileName.ReadOnly = false;
                if (UserFileName.Text == "Ваше название файла")
                {
                    UserFileName.Text = "";
                    UserFileName.Focus();
                }
                else
                {
                    UserFileName.Focus();
                }
            }
            else
            {
                pictureBox8.MouseEnter += new System.EventHandler(pictureBox8_MouseEnter);
                pictureBox8.MouseLeave += new System.EventHandler(pictureBox8_MouseLeave);
                blockButton = false;
                UserFileName.ReadOnly = true;
                if (UserFileName.Text.Length == 0)
                {
                    UserFileName.Text = "Ваше название файла";
                }


            }


        }

        public void pictureBox7_Click(object sender, EventArgs e)
        {
            if (zvezdOchka == true)
            {
                zvezdOchka = false;
                Favourite.Visible = false;
            }
            else
            {

                zvezdOchka = true;
                Favourite.Visible = true;
            }


        }
        private void guna2Panel1_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FileDownload.FileName = FileName.Text;
            if (FileDownload.ShowDialog() == DialogResult.OK)
            {
                files.AddRange(BookkeepingBL.GetAllFile());
                FileDownload.Filter = "(*.*)|*.*";
                foreach (var item in files)
                {
                    if (item.token == token_delete.Text)
                    {
                        byte[] saveFile = item.FileStreamCol;

                        System.IO.File.WriteAllBytes(FileDownload.FileName, saveFile);
                    }
                }
            }
        }
    }
}
