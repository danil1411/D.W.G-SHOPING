using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace D.W.G_SHOPING
{
    public partial class Calculator : UserControl
    {
        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        double result;
        string[] arrayOfNumbers = new string[3900];
        string[] arrayOfSign = new string[3900];
        int counter = 0, cnt = 1, i = 0; string s = "";
        bool isopen = false;
        string alarm = "Неправильная форма записи! Попробуйте ещё раз!";
        string alarmbrackets = "Ошибка! Проверьте, закрыты ли все скобки!";
        string alarmoperators = "Не найдено операторов в примере! Проверьте правильность написания!";
        private int cleanUpY = 394;
        private bool down = false;
        private bool downCorners = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void CleanUp_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox_0.Text = "";
            TextBoxResult.Text = "";
            Array.Clear(arrayOfNumbers, 0, arrayOfNumbers.Length - 1);
            Array.Clear(arrayOfSign, 0, arrayOfSign.Length - 1);
            counter = 0; cnt = 1; i = 0; s = string.Empty;
            isopen = false;
            CEtimer.Start();
        }

        private void CEtimer_Tick(object sender, EventArgs e)
        {
            CleanUp.Location = new Point(260, cleanUpY); // 461
            if (down == false)
            {
                cleanUpY += 5;
                if (cleanUpY >= 400 && downCorners == false)
                {
                    downCorners = true;
                    CleanUp.CustomizableEdges.BottomLeft = true;
                    CleanUp.CustomizableEdges.BottomRight = true;
                }
                    if (cleanUpY >= 461)
                    {
                        down = true;
                    CleanUp.CustomizableEdges.BottomLeft = false;
                    CleanUp.CustomizableEdges.BottomRight = false;
                }
            } else if (down == true)
            {
                cleanUpY -= 5;
                if (cleanUpY <= 389)
                {
                    downCorners = false;
                    CEtimer.Stop();
                    down = false;
                }
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 100, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
            CSharpScript.EvaluateAsync("12+3");
        }

        private void Plus_MouseClick(object sender, MouseEventArgs e)
        {
            if (i == 0)
            {
                if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "+"; }
                arrayOfSign[counter] = "+";
                i++;
                cnt = 0;
            }
            else
            {
                if (TextBox_0.Text[TextBox_0.Text.Length - 1] == '+' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '-' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '*' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '/' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '^')
                {
                    TextBox_0.Text = TextBox_0.Text.Remove(TextBox_0.Text.Length - 1);
                    TextBox_0.Text += "+";
                    cnt = 0;
                    arrayOfSign[counter] = "+";
                }
                else
                {
                    TextBox_0.Text += "+";
                    cnt = 0;
                    arrayOfSign[counter] = "+";
                }
            }
        }

        private void Minus_MouseClick(object sender, MouseEventArgs e)
        {
            if (i == 0)
            {
                if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "-"; }
                arrayOfSign[counter] = "-";
                i++;
                cnt = 0;
            }
            else
            {
                if (TextBox_0.Text[TextBox_0.Text.Length - 1] == '+' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '-' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '*' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '/' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '^')
                {
                    TextBox_0.Text = TextBox_0.Text.Remove(TextBox_0.Text.Length - 1);
                    TextBox_0.Text += "-";
                    cnt = 0;
                    arrayOfSign[counter] = "-";
                }
                else
                {
                    TextBox_0.Text += "-";
                    cnt = 0;
                    arrayOfSign[counter] = "-";
                }
            }
        }

        private void Multiply_MouseClick(object sender, MouseEventArgs e)
        {
            if (i == 0)
            {
                if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "*"; }
                arrayOfSign[counter] = "*";
                i++;
                cnt = 0;
            }
            else
            {
                if (TextBox_0.Text[TextBox_0.Text.Length - 1] == '+' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '-' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '*' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '/' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '^')
                {
                    TextBox_0.Text = TextBox_0.Text.Remove(TextBox_0.Text.Length - 1);
                    TextBox_0.Text += "*";
                    cnt = 0;
                    arrayOfSign[counter] = "*";
                }
                else
                {
                    TextBox_0.Text += "*";
                    cnt = 0;
                    arrayOfSign[counter] = "*";
                }
            }
        }

        private void Share_MouseClick(object sender, MouseEventArgs e)
        {
            if (i == 0)
            {
                if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "/"; }
                arrayOfSign[counter] = "/";
                i++;
                cnt = 0;
            }
            else
            {
                if (TextBox_0.Text[TextBox_0.Text.Length - 1] == '+' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '-' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '*' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '/' || TextBox_0.Text[TextBox_0.Text.Length - 1] == '^')
                {
                    TextBox_0.Text = TextBox_0.Text.Remove(TextBox_0.Text.Length - 1);
                    TextBox_0.Text += "/";
                    cnt = 0;
                    arrayOfSign[counter] = "/";
                }
                else
                {
                    TextBox_0.Text += "/";
                    cnt = 0;
                    arrayOfSign[counter] = "/";
                }
            }
        }

        private void Dot_MouseClick(object sender, MouseEventArgs e)
        {

            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += ","; }
            arrayOfNumbers[counter] += ",";
        }

        private void One_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "1"; }
            arrayOfNumbers[counter] += "1";

        }

        private void Two_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "2"; }
            arrayOfNumbers[counter] += "2";
        }

        private void Three_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "3"; }
            arrayOfNumbers[counter] += "3";
        }

        private void For_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "4"; }
            arrayOfNumbers[counter] += "4";
        }

        private void Root_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextBox_0.Text.Length != 0)
            {
                s = TextBox_0.Text;
                s = s.Remove(s.Length - 1);
                TextBox_0.Text = s;
            }
        }

        private void Five_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "5"; }
            arrayOfNumbers[counter] += "5";
        }

        private void Six_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "6"; }
            arrayOfNumbers[counter] += "6";
        }

        private void Seven_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "7"; }
            arrayOfNumbers[counter] += "7";
        }

        private void Eight_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "8"; }
            arrayOfNumbers[counter] += "8";
        }

        private void BracketLEFT_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "("; isopen = true; }
            arrayOfNumbers[counter] += "(";
        }

        private void Nine_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "9"; }
            arrayOfNumbers[counter] += "9";
        }

        private void Zero_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += "0"; }
            arrayOfNumbers[counter] += "0";
        }

        private void BarcketRIGHT_MouseClick(object sender, MouseEventArgs e)
        {
            if (cnt == 0)
            {
                counter++;
            }
            cnt++;
            if (TextBox_0.Text.Length >= 1000) {; } else { TextBox_0.Text += ")"; isopen = false; }
            arrayOfNumbers[counter] += "(";
        }

        private void Quantity_MouseClick(object sender, MouseEventArgs e)
        {
            s = TextBox_0.Text;
            if (isopen)
            {
                MessageBox.Show(alarmbrackets);
            }
            else if (s[s.Length - 1] == ',' || s[s.Length - 1] == '+' || s[s.Length - 1] == '-' || s[s.Length - 1] == '*' || s[s.Length - 1] == '/' || s[0] == '+' || s[0] == '-' || s[0] == ',' || s[0] == '*' || s[0] == '/')
            {
                MessageBox.Show(alarm);
            }
            else if (counter < 1) 
            {
                MessageBox.Show(alarmoperators);
            }
            else
            {
                TextBoxResult.Text = TextBox_0.Text;
                result = Parse(TextBox_0.Text);
                TextBox_0.Text = Convert.ToString(result);
            }
        }

        static double Parse(string expression)
        {
            return CSharpScript.EvaluateAsync<double>(expression).Result;
        }
    }
}
