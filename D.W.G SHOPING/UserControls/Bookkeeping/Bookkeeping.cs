using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO_Bookkeeping;
using BL_Bookeeping;
using DAL_Bookkeeping;
using System.Configuration;
using System.Security.Cryptography;

namespace D.W.G_SHOPING.UserControls
{
    public partial class Bookkeeping : UserControl
    {
        int countTarget = 0;
        //Ініціалізація змінних
        string filename;
        string result;
        string extension;
        string path;
        List<Guna.UI2.WinForms.Guna2Panel> nigger = new List<Guna.UI2.WinForms.Guna2Panel>();
        bool ok = false;
        public List<Guid> guids = new List<Guid>();
        string filesave;
        byte[] clone;
        List<BookkeepingBO> ts = new List<BookkeepingBO>();
        private string connectionString;
        public Bookkeeping()
        {
            InitializeComponent();

        }



        private void bookkeeping_Load(object sender, EventArgs e)
        {
            SearchBox.FillColor = Color.FromArgb(250, 198, 153);
            this.BackColor = Color.FromArgb(229, 94, 91);
            BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.BackColor = Color.FromArgb(250, 198, 153);
            try
            {
                ts.AddRange(BookkeepingBL.GetAll());
            }
            catch
            {

            }
            foreach (var item in ts)
            {
               
                Panel2 fuckit2 = new Panel2();
                fuckit2.pictureBox8.Click += new EventHandler(id_uniq);
                fuckit2.pictureBox7.Click += new EventHandler(was_wollen_wir_trinken);
                // беремо назву та формат файлу
                filename = item.FileName2;
                result = Path.GetFileName(filename);
                path = item.RootDirectory;
                extension = item.FileName2;
                fuckit2.Path.Text = item.RootDirectory;
                fuckit2.token_delete.Text = item.token;
                fuckit2.FileName.Text = item.FileName2;
                fuckit2.UserFileName.Text = item.userfilename;
                fuckit2.id_unique.Text = item.id.ToString();
                //fuckit2.pictureBox7.Click += new System.EventHandler(was_wollen_wir_trinken());
                // через switch перевіряємо, який формат файлу, та в залежності від результату видаємо йому картинку 
                if (extension.Contains(".docx"))
                {
                    fuckit2.logo.Image = Word.Image;
                }
                else if (extension.Contains(".xlsx"))
                {
                    fuckit2.logo.Image = Excel.Image;
                }
                else if (extension.Contains(".ai"))
                {
                    fuckit2.logo.Image = Ai.Image;
                }
                else if (extension.Contains(".psd"))
                {
                    fuckit2.logo.Image = photoshop.Image;
                }
                else
                {
                    fuckit2.logo.Image = noLogo.Image;
                }               
                guids.Add(item.id);
                flowLayoutPanel1.Controls.Add(fuckit2);
                nigger.Add(fuckit2.guna2Panel1);
                countTarget += 1;
                
            }

        }
        public void id_uniq(object sender, EventArgs e)
        {
            connectionString = ConfigurationManager.
                ConnectionStrings["ConnectionString1"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "Bookkeeping_Update";
                if (ok == false)
                {
                    ok = true;
                }
                else
                {
                    foreach (Guid guid in guids)
                    {
                        foreach (Guna.UI2.WinForms.Guna2Panel guna in nigger)
                        {
                            string find_id = guna.Controls.OfType<Label>().Single(l => l.Name == "id_unique").Text;

                            if (find_id == guid.ToString())
                            {
                                
                                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                                {

                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue("@id", SqlDbType.UniqueIdentifier).Value = guid;
                                    command.Parameters.AddWithValue("@userfilename", SqlDbType.NVarChar).Value = guna.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>().Single(l => l.Name == "UserFileName").Text;
                                    command.Parameters.AddWithValue("@favourite", SqlDbType.Bit).Value = guna.Controls.OfType<Guna.UI2.WinForms.Guna2PictureBox>().Single(l => l.Name == "Favourite").Visible;
                                    //    //BookkeepingBL.Update_Book(guid, guna.Controls.OfType<Label>().Single(l => l.Name == "FileName").Text,
                                    //    //    guna.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>().Single(l => l.Name == "UserFileName").Text,
                                    //    //    guna.Controls.OfType<Guna.UI2.WinForms.Guna2PictureBox>().Single(l => l.Name == "Favourite").Visible);
                                    sqlConnection.Open();
                                    command.ExecuteNonQuery();
                                    sqlConnection.Close();
                                }

                            }
                        }
                    }
                    ok = false;
                }
            }
        }
        public void was_wollen_wir_trinken(object sender, EventArgs e)
        {
            foreach (Guna.UI2.WinForms.Guna2Panel a in nigger)
            {
                bool ne = a.Controls.OfType<Guna.UI2.WinForms.Guna2PictureBox>().Single(l => l.Name == "Favourite").Visible;

                if (ne == true)
                {
                    flowLayoutPanel1.SuspendLayout();
                    flowLayoutPanel1.Controls.SetChildIndex(a.Parent, 0);
                    flowLayoutPanel1.ResumeLayout();
                }
            }
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            string RandomString(int length)
            {
                const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                StringBuilder res = new StringBuilder();
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    byte[] uintBuffer = new byte[sizeof(uint)];

                    while (length-- > 0)
                    {
                        rng.GetBytes(uintBuffer);
                        uint num = BitConverter.ToUInt32(uintBuffer, 0);
                        res.Append(valid[(int)(num % (uint)valid.Length)]);
                    }
                }

                return res.ToString();
            }

            // вибор файлу
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Додавання нової панелі при кліку на кнопку
                Panel2 fuckit = new Panel2();
                fuckit.pictureBox8.Click += new EventHandler(id_uniq);
                fuckit.pictureBox7.Click += new EventHandler(was_wollen_wir_trinken);
                // беремо назву та формат файлу
                filename = openFileDialog1.FileName;
                result = Path.GetFileName(filename);
                extension = Path.GetExtension(filename);
                path = Path.GetDirectoryName(filename);
                fuckit.Path.Text = path;
                decimal length = new System.IO.FileInfo(path + '/' + result).Length; 
                fuckit.token_delete.Text = RandomString(10);           
                fuckit.FileName.Text = result;
                byte[] file = File.ReadAllBytes(path + '/' + result);
                clone = file;
                filesave = "/" +result;
                byte[] FileToByteArray(string result)
                  
                {
                    byte[] fileData = null;

                    using (FileStream fs = File.OpenRead(path + '/' + result))
                    {
                        var binaryReader = new BinaryReader(fs);
                        fileData = binaryReader.ReadBytes((int)fs.Length);
                    }
                    return fileData;
                }
                //fuckit.pictureBox6.Click += new EventHandler(download2);
                //fuckit.pictureBox7.Click += new System.EventHandler(was_wollen_wir_trinken());
                // через switch перевіряємо, який формат файлу, та в залежності від результату видаємо йому картинку 
                switch (extension)
                {
                    case ".docx":
                        fuckit.logo.Image = Word.Image;
                        break;
                    case ".xlsx":
                        fuckit.logo.Image = Excel.Image;
                        break;
                    case ".ai":
                        fuckit.logo.Image = Ai.Image;
                        break;
                    case ".psd":
                        fuckit.logo.Image = photoshop.Image;
                        break;

                    default:
                        fuckit.logo.Image = noLogo.Image;
                        break;
                }
                flowLayoutPanel1.Controls.Add(fuckit);
                nigger.Add(fuckit.guna2Panel1);
                countTarget += 1;
                DateTime dateTime = DateTime.Now;
                
                BookkeepingBL.Add_Book(fuckit.UserFileName.Text,
                    Convert.ToInt32(fuckit.Favourite.Visible), fuckit.token_delete.Text,
                    path, result, "Raw", dateTime, FileToByteArray(result));
                fuckit.id_unique.Text = id_Bookkeeping.guid.ToString();
                guids.Add(id_Bookkeeping.guid);
                //BookkeepingBL.Add_Book_ID(guids[3]);

            }
        }
        private void Search_Click(object sender, EventArgs e)
        {

            //реалізація пошуку через назву файла циклом foreach
            foreach (Guna.UI2.WinForms.Guna2Panel i in nigger)
            {

                string n = i.Controls.OfType<Label>().Single(l => l.Name == "FileName").Text;
                if (SearchBox.TextLength >= 1)
                {
                    Regex regex = new Regex(@"" + SearchBox.Text + @"(\S*)");
                    Match match = regex.Match(n);
                    if (match.Success)
                    {
                        i.FillColor = Color.FromArgb(46, 153, 140);
                        i.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>().Single(t => t.Name == "UserFileName").FillColor = Color.FromArgb(46, 153, 140);

                        try
                        {
                            flowLayoutPanel1.SuspendLayout();
                            flowLayoutPanel1.Controls.SetChildIndex(i.Parent, 0);
                            flowLayoutPanel1.ResumeLayout();
                        }
                        catch (System.ArgumentException)
                        {

                        }
                    }
                    // якщо текст у полі співпадає із назвою файлу, то файл переноситься на початок списк                    
                }
                //якщо поле пошуку пусте, знімається виділення синім з файлу
                else
                {

                    i.FillColor = Color.FromArgb(229, 94, 91);
                    i.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>().Single(t => t.Name == "UserFileName").FillColor = Color.FromArgb(229, 94, 91);
                }
            }
        }
    }
}
