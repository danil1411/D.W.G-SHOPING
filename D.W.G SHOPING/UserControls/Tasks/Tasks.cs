using System;
using System.Drawing;
using System.Windows.Forms;
using BL__TasksWroteWorkPlace;

namespace D.W.G_SHOPING.UserControls
{
    public partial class Tasks : UserControl
    {
        private static string BufferForFirstStartOFTextfield;
        public Tasks()
        {
            InitializeComponent();
            MovingPersonPanel.Location = new Point(1071, 262);
            MovingPersonPanel.Visible = false;
            MovingPersonPanel.SendToBack();
            DateANDHourPicker.Location = new Point(1253, 308);
            DateANDHourPicker.Visible = false;
            DateANDHourPicker.SendToBack();
            BufferForFirstStartOFTextfield = TextField.Text;
        }

        /// <summary>
        /// when tasks was loaded then MovingPanelOFPicture change the transaparent value and thickness
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tasks_Load(object sender, EventArgs e)
        {
            MovingPanelOFPicture.FillColor = Color.FromArgb(70, 250, 198, 153);
            MovingPanelOFPicture.BorderColor = Color.FromArgb(100, 250, 198, 153);
            MovingPanelOFPicture.BorderThickness = 1;
            TextField.Text = "Description";
        }

        /// <summary>
        /// When mouse enter to TextField
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool FirstClickDescription = false;
        private void TextField_Enter(object sender, EventArgs e)
        {
            if (TextField.Text.Length == 0 || FirstClickDescription == false)
            {
                TextField.Text = "";
                TextField.Font = new Font("Segoe UI Symbol", 15.75f, FontStyle.Regular);
                FirstClickDescription = true;
            }
        }

        /// <summary>
        /// When mouse leave from TextField
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextField_Leave(object sender, EventArgs e)
        {
            if (TextField.Text.Length == 0 && FirstClickDescription == true)
            {
                TextField.Font = new Font("Segoe UI Symbol", 15.75f, FontStyle.Italic);
                TextField.Text = "Description";
                FirstClickDescription = false;
            }
        }

        /// <summary>
        /// Method which one decrease the picture of List 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalListPicture_MouseEnter(object sender, EventArgs e)
        {
            GlobalListPicture.Size = new Size(28, 28); GlobalListPicture.Location = new Point(31, 13);
        }

        /// <summary>
        /// Method which one increase the picture of List 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalListPicture_MouseLeave(object sender, EventArgs e)
        {
            GlobalListPicture.Size = new Size(33, 33); GlobalListPicture.Location = new Point(29, 10); 
        }

        /// <summary>
        /// Method which one decrease the picture of Person task 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalPersonPicture_MouseEnter(object sender, EventArgs e)
        {
            GlobalPersonPicture.Size = new Size(37, 30); GlobalPersonPicture.Location = new Point(77, 10);
        }

        /// <summary>
        /// Method which one increase the picture of Person task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalPersonPicture_MouseLeave(object sender, EventArgs e) 
        {
            GlobalPersonPicture.Size = new Size(42, 35); GlobalPersonPicture.Location = new Point(75, 7); 
        }

        /// <summary>
        /// Method which one decrease the picture of Replay 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalRePlayPicture_MouseEnter(object sender, EventArgs e)
        {
            GlobalRePlayPicture.Size = new Size(35, 30); GlobalRePlayPicture.Location = new Point(133, 10);
        }

        /// <summary>
        /// Method which one increase the picture of Replay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalRePlayPicture_MouseLeave(object sender, EventArgs e)
        {
            GlobalRePlayPicture.Size = new Size(40, 35); GlobalRePlayPicture.Location = new Point(130, 8);
        }

        /// <summary>
        /// Method which one decrease the picture of Trash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalTrashPicture_MouseEnter(object sender, EventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == false)
            {
                GlobalTrashPicture.Size = new Size(30, 30);
                GlobalTrashPicture.Location = new Point(182, 9);
            }
        }

        /// <summary>
        /// Method which one increase the picture of Trash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalTrashPicture_MouseLeave(object sender, EventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == false)
            {
                GlobalTrashPicture.Size = new Size(35, 35);
                GlobalTrashPicture.Location = new Point(180, 8);
            }
        }

        /// <summary>
        /// Method which one decrease the picture of Local Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPersonPicture_MouseEnter(object sender, EventArgs e) 
        {
            LocalPersonPicture.Size = new Size(37, 30); LocalPersonPicture.Location = new Point(18, 4);
        }

        /// <summary>
        /// Method which one increase the picture of Local Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPersonPicture_MouseLeave(object sender, EventArgs e)
        {
            LocalPersonPicture.Size = new Size(42, 35); LocalPersonPicture.Location = new Point(15, 2);
        }

        /// <summary>
        /// Method which one decrease the picture of Local Calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalendarPicture_MouseEnter(object sender, EventArgs e)
        {
            CalendarPicture.Size = new Size(35, 35); CalendarPicture.Location = new Point(64, 2);
        }

        /// <summary>
        /// Method which one increase the picture of Local Calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalendarPicture_MouseLeave(object sender, EventArgs e)
        {
            CalendarPicture.Size = new Size(40, 40); CalendarPicture.Location = new Point(61, -1);
        }

        /// <summary>
        /// Make CheckMark_PictureBox decrease
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckMark_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            CheckMark_PictureBox.Size = new Size(38, 32); CheckMark_PictureBox.Location = new Point(108, 3);
        }

        /// <summary>
        /// Make CheckMark_PictureBox increase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckMark_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            CheckMark_PictureBox.Size = new Size(43, 37); CheckMark_PictureBox.Location = new Point(106, 0);
        }

        /// <summary>
        /// start an opening animation if <c>MovingPersonPanel.Visible = false</c>
        /// </summary>
        ///  <example>
        ///   <code>
        ///    if(MovingPersonPanel.Visible == false){
        ///      MovingPersonPanelOpen.Start();
        ///    }else{
        ///      ...
        ///    }
        ///   </code>
        ///  </example>
        /// <summary>
        ///  if <c>MovingPersonPanel.Visible = true</c> then a closing animation
        /// </summary>
        ///  <example>
        ///   <code>
        ///    if(MovingPersonPanel.Visible == false){
        ///     ...
        ///    }else{
        ///     MovingPersonPanelClose.Start();
        ///    }
        ///   </code>
        ///  </example>
        private void LocalPersonPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (MovingPersonPanel.Visible == false)
            {
                MovingPersonPanelOpenTimer.Start();
            }
            else
            {
                MovingPersonPanelClose.Start();
            }
        }

        // Dynamically changing Y position in property MovingPersonPanel.Location.Y
        private int MovingPersonPanelY = 262;
        /// <summary>
        /// MovingPersonPanel an opening animation 
        /// <remarks>
        /// this <c>void</c> has been renamed to MovingPersonPanelOpenTimer
        /// </remarks>
        /// <example>
        /// <code>
        /// private void MovingPersonPanelOpenTimer_Tick(object sender, EventArgs e){...}
        /// </code>
        /// </example>
        ///</summary>
        private void MovingPersonPanelTimer_Tick(object sender, EventArgs e)
        {
            MovingPersonPanel.Visible = true;
            MovingPersonPanel.Location = new Point(MovingPersonPanel.Location.X, MovingPersonPanelY);
            if (MovingPersonPanelY <= 301)
            {
                MovingPersonPanelY += 4;
            }
            else if (MovingPersonPanelY >= 301)
            {
                MovingPersonPanelY = 301;
                MovingPersonPanel.Location = new Point(MovingPersonPanel.Location.X, MovingPersonPanelY);
                MovingPersonPanelOpenTimer.Stop();
            }
        }

        /// <summary>
        /// a closing animation of MovingPersonPanel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovingPersonPanelClose_Tick(object sender, EventArgs e)
        {
            MovingPersonPanel.Location = new Point(MovingPersonPanel.Location.X, MovingPersonPanelY);
            if (MovingPersonPanelY >= 262)
            {
                MovingPersonPanelY -= 4;
            }
            else if (MovingPersonPanelY <= 262)
            {
                MovingPersonPanel.Visible = false;
                MovingPersonPanelY = 262;
                MovingPersonPanel.Location = new Point(MovingPersonPanel.Location.X, MovingPersonPanelY);
                MovingPersonPanelClose.Stop();
            }
        }

        /// <summary>
        /// add dynamically panel on Tasks
        /// </summary>
        /// <param name="desc"></param>
        /// <seealso cref="Tasks">
        private void AddPanel(string desc, string DayMonth, string HourMinutes)
        {
            if (TextField.Text == "Description")
            {
                desc = "";
                WroteWorkPlace place = new WroteWorkPlace(desc, DayMonth, HourMinutes);
                LayoutPanel.Controls.Add(place);
            }
            else
            {
                WroteWorkPlace place = new WroteWorkPlace(desc, DayMonth, HourMinutes);
                LayoutPanel.Controls.Add(place);
            }
        }

        /// <summary>
        /// the same with Text_Field_KeyPress but if MouseButtons.Left was pressed also if 
        /// <c>if(e.Button == MouseButtons.Left && (DateDay.Text != "00" && DateMonth.Text != "00") && (DateMonth.Focused == false && DateDay.Focused == false))</c>
        /// then <c>AddPanel(...)</c> calls
        /// if another result then work another condition <c>DateANDHourPickertimerOpen.Start()</c>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <seealso cref="TextField_KeyPress(object, KeyPressEventArgs)">
        private void CheckMark_PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (DateDay.Text != "00" && DateMonth.Text != "00") && (DateMonth.Focused == false && DateDay.Focused == false))
            {
                
                string bufferForPlusDateAndMonth = DateDay.Text + "." + DateMonth.Text;
                string bufferForPlusHourAndMinutes = HourPicker.Text + ":" + MinutesPicker.Text;
                Tasks_Adapter.Add(TextField.Text, int.Parse(MinutesPicker.Text), int.Parse(HourPicker.Text), int.Parse(DateDay.Text), int.Parse(DateMonth.Text), 1);
                AddPanel(TextField.Text, bufferForPlusDateAndMonth, bufferForPlusHourAndMinutes);
                DateDay.Text = "00";
                DateMonth.Text = "00";
                MinutesPicker.Text = "00";
                HourPicker.Text = "00";
                TextField.Font = new Font("Segoe UI Symbol", 15.75f, FontStyle.Italic);
                TextField.Text = "Description";
                FirstClickDescription = false;
            }
            else
            {
                DateANDHourPickertimerOpen.Start();
            }
        }

        // ISNULLHourPicker it is variable that checks if the string is empty or NULL
        static bool ISNUllHourPicker;

        /// <summary>
        /// If HourPicker.Text is Two Zeros then string become empty for don't distract user writing any text ( two zeros desappeared ) 
        /// </summary>
        /// <example>
        /// <c>HourPicker.Text = "00"</c> that's means if <c>HourPicker.Focus == true</c> then <c>HourPicker.Text = ""</c>
        /// </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HourPicker_Enter(object sender, EventArgs e)
        {
            if (HourPicker.Text == "00")
            {
                HourPicker.Text = "";
            }
        }

        ///<summary>
        /// void in order to when <c>Focus()</c> leave , <c>HourPicker.Text</c> become TWO ZEROS(00) if <c>HourPicker.Text</c> is empty or NULL
        ///</summary>
        ///<summary>
        /// also if <c>Focus()</c> is alread leave but <c>hourPicker.Text</c> contain one symbol ( always only number ) 
        /// then with <c>if(...){...}</c>  before that number located ZERO(0) 0 always adding with the string bufferOFOneSymbolOFTExt variable
        ///</summary>
        ///  <example>
        ///  <code>
        ///   if(HourPicker.Text.Length == 1){
        ///    HourPicker.Text = bufferOFOneSymbolOFText + HourPicker.Text;
        ///   }
        ///  </code>
        ///  </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <paramref name="bufferOFOneSymbolOFText" > this is the string variable contains ZERO(0) in order to place ZERO(0) before some number in <c>HourPicke.Text</c></paramref>
        private void HourPicker_Leave(object sender, EventArgs e)
        {
            // in order to puts ZERO(0) before number in HourPicker.Text if HourPicker.Text equal one symbol
            string bufferOFOneSymbolOFText = "0";
            ISNUllHourPicker = String.IsNullOrEmpty(HourPicker.Text);
            if (ISNUllHourPicker == true)
            {
                HourPicker.Text = "00";
            }
            if (HourPicker.Text.Length == 1)
            {
                HourPicker.Text = bufferOFOneSymbolOFText + HourPicker.Text;
            }
        }

        /// <summary>
        /// if amount of <c>HourPicker.Text</c> will be more that a certain numbers of time that can't be written
        /// </summary>
        /// <summary>
        /// if length of <c>HourPicker.Text</c> more than or equal TWO(2), <c>Focus()</c> move to next object <c>MinutesPicker.Text</c>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HourPicker_TextChanged(object sender, EventArgs e)
        {
            // buffer - buffer for transformed number from string to int, this contain certain number from String in order to check if String Text is a number
            bool checkISNumber = int.TryParse(HourPicker.Text, out int buffer);
            if (checkISNumber == true && buffer <= 23)
            {
                ;
            }
            else
            {
                HourPicker.Text = "";
            }
            if (HourPicker.Text.Length >= 2)
            {
                MinutesPicker.Focus();
            }
        }

        /// <summary>
        /// If MinutesPicker.Text is Two Zeros then string become empty for don't distract user writing any text ( two zeros desappeared ) 
        /// </summary>
        /// <example>
        /// <c>MinutesPicker.Text = "00"</c> that's means if <c>MinutesPicker.Focus == true</c> then <c>MinutesPicker.Text = ""</c>
        /// </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinutesPicker_Enter(object sender, EventArgs e)
        {
            if (MinutesPicker.Text == "00")
            {
                MinutesPicker.Text = "";
            }
        }

        ///<summary>
        /// void in order to when <c>Focus()</c> leave , <c>MinutesPicker.Text</c> become TWO ZEROS(00) if <c>MinutesPicker.Text</c> is empty or NULL
        ///</summary>
        ///<summary>
        /// also if <c>Focus()</c> is alread leave but <c>MinutesPicker.Text</c> contain one symbol ( always only number ) 
        /// then with <c>if(...){...}</c>  before that number located ZERO(0) 0 always adding with the string bufferOFOneSymbolOFTExt variable
        ///</summary>
        ///  <example>
        ///  <code>
        ///   if(MinutesPicker.Text.Length == 1){
        ///    MinutesPicker.Text = bufferOFOneSymbolOFText + MinutesPicker.Text;
        ///   }
        ///  </code>
        ///  </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <paramref name="bufferOFOneSymbolOFText" > this is the string variable contains ZERO(0) in order to place ZERO(0) before some number in <c>MinutesPicker.Text</c></paramref>
        private void MinutesPicker_Leave(object sender, EventArgs e)
        {
            // in order to puts ZERO(0) before number in MinutesPicker.Text if MinutesPicker.Text equal one symbol
            string bufferOFOneSymbolOFText = "0";
            ISNUllHourPicker = String.IsNullOrEmpty(MinutesPicker.Text);
            if (ISNUllHourPicker == true)
            {
                MinutesPicker.Text = "00";
            }
            if (MinutesPicker.Text.Length == 1)
            {
                MinutesPicker.Text = bufferOFOneSymbolOFText + MinutesPicker.Text;
            }
        }

        /// <summary>
        /// if amount of <c>MinutesPicker.Text</c> will be more that a certain numbers of time that can't be written 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinutesPicker_TextChanged(object sender, EventArgs e)
        {
            // buffer - buffer for transformed number from string to int, this contain certain number from String in order to check if String Text is a number
            bool checkISNumber = int.TryParse(MinutesPicker.Text, out int buffer);
            if (checkISNumber == true && buffer <= 59)
            {
                ;
            }
            else
            {
                MinutesPicker.Text = "";
            }
            if (MinutesPicker.Text.Length >= 2 && (checkISNumber == true && buffer <= 59))
            {
                LocalPanelOFPicture.Focus();
            }
        }

        /// <summary>
        /// If DateDay.Text is Two Zeros then string become empty for don't distract user writing any text ( two zeros desappeared ) 
        /// </summary>
        /// <example>
        /// <c>DateDay.Text = "00"</c> that's means if <c>DateDay.Focus == true</c> then <c>DateDay.Text = ""</c>
        /// </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateDay_Enter(object sender, EventArgs e)
        {
            if (DateDay.Text == "00")
            {
                DateDay.Text = "";
            }
        }

        ///<summary>
        /// void in order to when <c>Focus()</c> leave , <c>DateDay.Text</c> become TWO ZEROS(00) if <c>DateDay.Text</c> is empty or NULL
        ///</summary>
        ///<summary>
        /// also if <c>Focus()</c> is alread leave but <c>DateDay.Text</c> contain one symbol ( always only number ) 
        /// then with <c>if(...){...}</c>  before that number located ZERO(0) 0 always adding with the string bufferOFOneSymbolOFTExt variable
        ///</summary>
        ///  <example>
        ///  <code>
        ///   if(DateDay.Text.Length == 1){
        ///    DateDay.Text = bufferOFOneSymbolOFText + DateDay.Text;
        ///   }
        ///  </code>
        ///  </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <paramref name="bufferOFOneSymbolOFText" > this is the string variable contains ZERO(0) in order to place ZERO(0) before some number in <c>DateDay.Text</c></paramref>
        private void DateDay_Leave(object sender, EventArgs e)
        {
            string bufferOFOneSymbolOFText = "0";
            ISNUllHourPicker = String.IsNullOrEmpty(DateDay.Text);
            if (ISNUllHourPicker == true)
            {
                DateDay.Text = "00";
            }
            if (DateDay.Text.Length == 1)
            {
                DateDay.Text = bufferOFOneSymbolOFText + DateDay.Text;
            }
        }

        /// <summary>
        /// if amount of <c>DateDay.Text</c> will be more that a certain numbers of time that can't be written 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateDay_TextChanged(object sender, EventArgs e)
        {
            // buffer - buffer for transformed number from string to int, this contain certain number from String in order to check if String Text is a number
            bool checkISNumber = int.TryParse(DateDay.Text, out int buffer);
            if (checkISNumber == true && buffer <= 31)
            {
                ;
            }
            else
            {
                DateDay.Text = "";
            }
            if (DateDay.Text.Length >= 2)
            {
                DateMonth.Focus();
            }
        }

        /// <summary>
        /// If DateMonth.Text is Two Zeros then string become empty for don't distract user writing any text ( two zeros desappeared ) 
        /// </summary>
        /// <example>
        /// <c>DateMonth.Text = "00"</c> that's means if <c>DateMonth.Focus == true</c> then <c>DateMonth.Text = ""</c>
        /// </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateMonth_Enter(object sender, EventArgs e)
        {
            if (DateMonth.Text == "00")
            {
                DateMonth.Text = "";
            }
        }

        ///<summary>
        /// void in order to when <c>Focus()</c> leave , <c>DateMonth.Text</c> become TWO ZEROS(00) if <c>DateMonth.Text</c> is empty or NULL
        ///</summary>
        ///<summary>
        /// also if <c>Focus()</c> is alread leave but <c>DateMonth.Text</c> contain one symbol ( always only number ) 
        /// then with <c>if(...){...}</c>  before that number located ZERO(0) 0 always adding with the string bufferOFOneSymbolOFTExt variable
        ///</summary>
        ///  <example>
        ///  <code>
        ///   if(DateMonth.Text.Length == 1){
        ///    DateMonth.Text = bufferOFOneSymbolOFText + DateMonth.Text;
        ///   }
        ///  </code>
        ///  </example>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <paramref name="bufferOFOneSymbolOFText" > this is the string variable contains ZERO(0) in order to place ZERO(0) before some number in <c>DateDay.Text</c></paramref>
        private void DateMonth_Leave(object sender, EventArgs e)
        {
            string bufferOFOneSymbolOFText = "0";
            ISNUllHourPicker = String.IsNullOrEmpty(DateMonth.Text);
            if (ISNUllHourPicker == true)
            {
                DateMonth.Text = "00";
            }
            if (DateMonth.Text.Length == 1)
            {
                DateMonth.Text = bufferOFOneSymbolOFText + DateMonth.Text;
            }
        }

        /// <summary>
        /// if amount of <c>DateMonth.Text</c> will be more that a certain numbers of time that can't be written 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateMonth_TextChanged(object sender, EventArgs e)
        {
            // buffer - buffer for transformed number from string to int, this contain certain number from String in order to check if String Text is a number
            bool checkISNumber = int.TryParse(DateMonth.Text, out int buffer);
            if (checkISNumber == true && buffer <= 12)
            {
                ;
            }
            else
            {
                DateMonth.Text = "";
            }
            if (DateMonth.Text.Length >= 2 && (buffer <= 12 && checkISNumber == true))
            {
                LocalPanelOFPicture.Focus();
            }
        }

        /// <summary>
        /// Choose what exactly starts <see cref="DateANDHourPickertimerClose"/> or <see cref="DateANDHourPickertimerOPen"/>
        /// </summary>
        // dynamically changing variable in order to make move the DateANDHourOPickerOPen(Close)
        private int DateANDHourPickerLocY = 308;

        private void CalendarPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (DateANDHourPicker.Visible == false)
            {
                DateANDHourPickertimerOpen.Start();
            }
            else
            {
                DateANDHourPickertimerClose.Start();
            }
        }

        /// <summary>
        /// starts the <see cref="DateANDHourPickertimerOpen"/>, makes DateANDHourPicker moving down side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateANDHourPickertimerOpen_Tick(object sender, EventArgs e)
        {
            DateANDHourPicker.Visible = true;
            DateANDHourPicker.Location = new Point(DateANDHourPicker.Location.X, DateANDHourPickerLocY);
            if (DateANDHourPickerLocY <= 339)
            {
                DateANDHourPickerLocY += 4;
            }
            else if (DateANDHourPickerLocY >= 339)
            {
                DateANDHourPickerLocY = 339;
                DateANDHourPicker.Location = new Point(DateANDHourPicker.Location.X, DateANDHourPickerLocY);
                DateANDHourPickertimerOpen.Stop();
            }
        }

        /// <summary>
        /// starts the <see cref="DateANDHourPickertimerClose"/>, makes DateANDHourPicker moving top side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateANDHourPickertimerClose_Tick(object sender, EventArgs e)
        {
            DateANDHourPicker.Location = new Point(DateANDHourPicker.Location.X, DateANDHourPickerLocY);
            if (DateANDHourPickerLocY >= 308)
            {
                DateANDHourPickerLocY -= 4;
            }
            else if (DateANDHourPickerLocY <= 308)
            {
                DateANDHourPicker.Visible = false;
                DateANDHourPickerLocY = 308;
                DateANDHourPicker.Location = new Point(DateANDHourPicker.Location.X, DateANDHourPickerLocY);
                DateANDHourPickertimerClose.Stop();
            }
        }

        /// <summary>
        /// makes all spawned forms delete in one repeated click on <see cref="GlobalTrashPicture"/> also if it is pressed then form of <see cref="GlobalTrashPicture"/> change to smallest size 
        /// </summary>
        /// <summary>
        /// if <see cref="GlobalTrashPicture"/> pressed then we remove all elements from <see cref="BufferDelete.ll"/> with foreach cycle also if it is unpressed then form of <see cref="GlobalTrashPicture"/> change from smallest size to normal size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalTrashPicture_MouseClick(object sender, MouseEventArgs e)
        {
                if (DeleteButton.DeleteButtonPressed == false)
                {
                    DeleteButton.DeleteButtonPressed = true;
                    GlobalTrashPicture.Size = new Size(30, 30);
                    GlobalTrashPicture.Location = new Point(182, 9);
            }
                else
                {
                foreach (Control cont in BufferDelete.ll)
                {
                    LayoutPanel.Controls.Remove(cont);
                    BufferDelete.ll.Remove(cont);
                }
                DeleteButton.DeleteButtonPressed = false;
                GlobalTrashPicture.Size = new Size(35, 35);
                GlobalTrashPicture.Location = new Point(180, 8);
            }
            }
        }
    }