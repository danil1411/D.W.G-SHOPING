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

namespace D.W.G_SHOPING
{
    public partial class WroteWorkPlace : UserControl
    {
        // tracks first or secont click on any element of this form
        public bool DeleteThisUser = false;
        // 
        private int startPosHeightForm = 123, startPosHeightPanel = 123, startPosHeightBorder = 84, startPosHeightLable = 78, startLocYExpand = 34, startLocYCheckMark = 39, startLocYAdditional = 33, startLocYHide = 34;
        // checks is additional menu open ? false = no : true = yes
        private bool CheckISAdditionalMenuOpen = false;

        public WroteWorkPlace()
        {
            InitializeComponent();
        }

        public void DeleteThisComponent()
        {
            if (DeleteThisUser == true)
            {
                var s = CheckButton.Parent;
                var g = s.Parent;
                g.Parent.Controls.Remove(g);
            }
        }

        /// <summary>
        /// add text from <see cref="Tasks.TextField"/> to <see cref="WroteWorkPlace.descriptionLable"/>
        /// </summary>
        /// <param name="Desc"> pass <see cref="Tasks.TextField"/> value to <see cref="WroteWorkPlace.descriptionLable"/></param>
        int countLines = 0;
        public WroteWorkPlace(string Desc, string DateMonthDay, string Time)
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.None;
            TextBoxBuffer.Text = Desc;
            countLines = TextBoxBuffer.Lines.Count();
            descriptionLable.Text = Desc;
            DateLabel.Text = DateMonthDay;
            TimeLabel.Text = Time;

            ShowingPanelOFLocalPicture.FillColor = Color.FromArgb(100, 250, 198, 153);
            ShowingPanelOFLocalPicture.BorderColor = Color.FromArgb(150 ,229, 94, 91);
        }

        /// <summary>
        /// Delete panel from <seealso cref="Tasks.LayoutPanel"/> this panel across Parent value also if <see cref="Tasks.GlobalTrashPicture"/>
        /// was pressed then we change color of <see cref="RoundedConrnersSpawnPanel"/> and add it in the <see cref="BufferDelete.ll"/>
        /// in order to delete this by pressing again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == true) {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }else
            {
                var pictureParent = ((PictureBox)sender).Parent;
                var RoundedParent = pictureParent.Parent;
                RoundedParent.Parent.Controls.Remove(RoundedParent);
            }
        }

        /// <summary>
        /// if additional menu is close and text is hide then that icon decreases
        /// if additional menu is close and text is expanded then we changing location with through math formula - length of All expanded text divided by 2 - and this is the new position for that icon
        /// if additional mune is open then changing location 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HIdeExpandedText_MouseLeave(object sender, EventArgs e)
        {
            if (CheckISAdditionalMenuOpen == false && ExpandORHide == false) {
                HIdeExpandedText.Location = new Point(1125, 46);
                HIdeExpandedText.Size = new Size(57, 55);
            }
            else if (CheckISAdditionalMenuOpen == false && ExpandORHide == true)
            {
                HIdeExpandedText.Location = new Point(1125, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))));
                HIdeExpandedText.Size = new Size(57, 55);
            }
            else if (CheckISAdditionalMenuOpen == true)
            {
                HIdeExpandedText.Location = new Point(886, 46);
                HIdeExpandedText.Size = new Size(57, 55);
            }
        }

        /// <summary>
        /// if additional menu is close and text is hide then that icon increases
        /// if additional menu is close and text is expanded then we changing location with through math formula - length of All expanded text divided by 2 - and this is the new position for that icon
        /// if additional mune is open then changing location 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HIdeExpandedText_MouseEnter(object sender, EventArgs e)
        {
            if (CheckISAdditionalMenuOpen == false && ExpandORHide == false) {
                HIdeExpandedText.Location = new Point(1127, 46);
                HIdeExpandedText.Size = new Size(52, 50);
            }
            else if (CheckISAdditionalMenuOpen == false && ExpandORHide == true)
            {
                HIdeExpandedText.Location = new Point(1127, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))));
                HIdeExpandedText.Size = new Size(52, 50);
            }
            else if (CheckISAdditionalMenuOpen == true)
            {
                HIdeExpandedText.Location = new Point(889, 46);
                HIdeExpandedText.Size = new Size(52, 50);
            }
        }

        /// <summary>
        /// if additional menu is close then as usually this icon desreases
        /// if additional menu is open then changed location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Expand_MouseLeave(object sender, EventArgs e)
        {
            if (CheckISAdditionalMenuOpen == false)
            {
                Expand.Location = new Point(1125, 46);
                Expand.Size = new Size(57, 55);
            }
            else if (CheckISAdditionalMenuOpen == true)
            {
                Expand.Location = new Point(886, 46);
                Expand.Size = new Size(57, 55);
            }
            }

        /// <summary>
        /// if additional menu is close then as usually this icon inceases
        /// if additional menu is open then changed location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Expand_MouseEnter(object sender, EventArgs e)
        {
            if (CheckISAdditionalMenuOpen == false)
            {
                Expand.Location = new Point(1127, 49);
                Expand.Size = new Size(52, 50);
            }
            else if (CheckISAdditionalMenuOpen == true){
                Expand.Location = new Point(889, 49);
                Expand.Size = new Size(52, 50);
            }
        }

        /// <summary>
        /// if expand text is open then we changed location with math formula - length of whole text /2 and -2
        /// else simple increasing location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdditionalFunc_MouseEnter(object sender, EventArgs e)
        {
            if (ExpandORHide == true)
            {
                AdditionalFunc.Location = new Point(1243, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))) - 2);
                AdditionalFunc.Size = new Size(53, 51);
            }
            else {
                AdditionalFunc.Location = new Point(1243, 48);
                AdditionalFunc.Size = new Size(53, 51);
            }
        }

        /// <summary>
        /// if expand text is open then we changed location with math formula - length of whole text /2 and -2
        /// else simple decreasing location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdditionalFunc_MouseLeave(object sender, EventArgs e)
        {
            if (ExpandORHide == true)
            {
                AdditionalFunc.Location = new Point(1241, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))) - 2);
                AdditionalFunc.Size = new Size(58, 56);
            }
            else
            {
                AdditionalFunc.Location = new Point(1241, 45);
                AdditionalFunc.Size = new Size(58, 56);
            }
        }

        ///<summary>
        /// <code>if (DeleteButton.DeleteButtonPressed == false)</code> - if <see cref="GlobalTrashPicture"/> weren't pressed then :
        ///     <code>if (checkIsMoved == false)</code> - if addititonal menu is close then : 
        ///         <see cref="ShowingPanelOFLocalPicture"/> bring to front, make her visible, set the start location and size, also launch the timer <see cref="MovingEverything"/>, and set start value for variables in order to changing location and size of <see cref="ShowingPanelOFLocalPicture"/>, <see cref="Expand"/>, <see cref="HIdeExpandedText"/>, <see cref="CheckButton"/>
        ///             ( <seealso cref="descriptionLabelMov"/>, <seealso cref="descriptionPanelMov"/>, <seealso cref="expand"/>, <seealso cref="hideExpanded"/>, <seealso cref="checkButton"/>, <seealso cref="MovingPanelSize"/>, <seealso cref="BackMovingPanelLoc"/> )
        ///     <code>if (checkIsMoved == true)</code> - if additional panel already open then :
        ///         launch the <see cref="MoveBackMovingEverything"/>, changed <see cref="checkISMoved"/> variable to false, and <see cref="CheckISAdditionalMenuOpen"/> also set the back variables value
        /// <code>if (DeleteButton.DeleteButtonPressed == true)</code> or <code>else</code> - if <see cref="GlobalTrashPicture"/> were pressed then :
        ///     <code>if (DeleteThisUser == false)</code> - if this element never wasn't pressed then :
        ///         <see cref="DeleteThisUser"/> (first or second click on this element), changing color of <see cref="RoundedConrnersSpawnPanel"/> and add whole <see cref="WroteWorkPlace"/> to <see cref="BufferDelete.ll"/> list
        ///     <code>else</code> or <code>if (DeleteThisUser == true)</code> - if DeleteThisUser equal true ( if we ever pressed on this element) then :
        ///         <see cref="DeleteThisUser"/> set false value, remove whole <see cref="WroteWorkPlace"/> from <see cref="BufferDelete.ll"/> list and come back color of <see cref="RoundedConrnersSpawnPanel"/>
        /// </summary>
        private void AdditionalFunc_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == false) {
                if (ExpandORHide == false) {
                    if (checkISMoved == false) {
                        ShowingPanelOFLocalPicture.BringToFront();
                        ShowingPanelOFLocalPicture.Visible = true;
                        ShowingPanelOFLocalPicture.Location = new Point(1159, 40);
                        ShowingPanelOFLocalPicture.Size = new Size(153, 67);
                        MovingEverything.Start();
                        descriptionPanelMov = 1086; descriptionLabelMov = 1069; expand = 1125; hideExpanded = 1125; checkButton = 1188; MovingPanelSize = 153; MovingPanelLoc = 1159;
                        CheckISAdditionalMenuOpen = true;
                    }
                    if (checkISMoved == true)
                    {
                        MoveBackMovingEverything.Start();
                        checkISMoved = false;
                        CheckISAdditionalMenuOpen = false;
                        BackdescriptionPanelMov = 853; BackdescriptionLabelMov = 837; Backexpand = 886; BackhideExpanded = 886; BackMovingPanelSize = 229; BackMovingPanelLoc = 1013;
                    }
                }
            }
            else{
                    if (DeleteThisUser == false)
                    {
                        DeleteThisUser = true;
                        RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                        BufferDelete.ll.Add(this);
                    }
                    else
                    {
                        DeleteThisUser = false;
                        BufferDelete.ll.Remove(this);
                        RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                    }
            }
        }

        // start positions (locations and sizes of elements ) for MovingEverything
        private int descriptionPanelMov = 1086, descriptionLabelMov = 1069, expand = 1125, hideExpanded = 1125, checkButton = 1188, MovingPanelSize = 153, MovingPanelLoc = 1159;
        //start positions ( locations and sizes of elements) for BackMovingEverithing
        private int BackdescriptionPanelMov = 853, BackdescriptionLabelMov = 837, Backexpand = 886, BackhideExpanded = 886, BackcheckButton = 956, BackMovingPanelSize = 229, BackMovingPanelLoc = 1013;

        /// <summary>
        /// IF <see cref="GlobalTrashPicture"/> were pressed :
        /// IF this element were pressed first time :
        /// we add whole this <see cref="WroteWorkPlace"/> to <see cref="BufferDelete.ll"/> list and changing the color of <see cref="RoundedConrnersSpawnPanel"/> also we changing <see cref="DeleteThisUser"/> to true
        /// 
        /// IF this element were pressed second time :
        /// we remove this <see cref="WroteWorkPlace"/> to <see cref="BufferDelete.ll"/> list and changing the color of <see cref="RoundedConrnersSpawnPanel"/> back also we changing <see cref="DeleteThisUser"/> to false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void descriptionLable_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == true)
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        /// <summary>
        /// <code>if (Deletebutton.DeleteButtonPressed == true)</code> - if <see cref="GlobalTrashPicture"/> were pressed then :
        ///     <code>if (DeleteThisUser == false)</code> - if that was first click on this panel then :
        ///         <see cref="DeleteThisUser"/> changing on true, <see cref="RoundedConrnersSpawnPanel"/> change ourself color and whole <see cref="WroteWorkPlace"/> add to the <see cref="BufferDelete.ll"/> list
        ///  <code> else or if(DeleteThisUser == true)</code> - if that was clicked second time then : 
        ///         <see cref="DeleteThisUser"/> changing on false, remove whole <see cref="WroteWorkPlace"/> from the <see cref="BufferDelete.ll"/> list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptoinPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == true)
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        /// <summary>
        /// <code>if (Deletebutton.DeleteButtonPressed == true)</code> - if <see cref="GlobalTrashPicture"/> were pressed then :
        ///     <code>if (DeleteThisUser == false)</code> - if that was first click on this panel then :
        ///         <see cref="DeleteThisUser"/> changing on true, <see cref="RoundedConrnersSpawnPanel"/> change ourself color and whole <see cref="WroteWorkPlace"/> add to the <see cref="BufferDelete.ll"/> list
        ///  <code> else or if(DeleteThisUser == true)</code> - if that was clicked second time then : 
        ///         <see cref="DeleteThisUser"/> changing on false, remove whole <see cref="WroteWorkPlace"/> from the <see cref="BufferDelete.ll"/> list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == true)
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        /// <summary>
        /// <code>if (Deletebutton.DeleteButtonPressed == true)</code> - if <see cref="GlobalTrashPicture"/> were pressed then :
        ///     <code>if (DeleteThisUser == false)</code> - if that was first click on this panel then :
        ///         <see cref="DeleteThisUser"/> changing on true, <see cref="RoundedConrnersSpawnPanel"/> change ourself color and whole <see cref="WroteWorkPlace"/> add to the <see cref="BufferDelete.ll"/> list
        ///  <code> else or if(DeleteThisUser == true)</code> - if that was clicked second time then : 
        ///         <see cref="DeleteThisUser"/> changing on false, remove whole <see cref="WroteWorkPlace"/> from the <see cref="BufferDelete.ll"/> list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == true)
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        /// <summary>
        /// <code>if (Deletebutton.DeleteButtonPressed == true)</code> - if <see cref="GlobalTrashPicture"/> were pressed then :
        ///     <code>if (DeleteThisUser == false)</code> - if that was first click on this panel then :
        ///         <see cref="DeleteThisUser"/> changing on true, <see cref="RoundedConrnersSpawnPanel"/> change ourself color and whole <see cref="WroteWorkPlace"/> add to the <see cref="BufferDelete.ll"/> list
        ///  <code> else or if(DeleteThisUser == true)</code> - if that was clicked second time then : 
        ///         <see cref="DeleteThisUser"/> changing on false, remove whole <see cref="WroteWorkPlace"/> from the <see cref="BufferDelete.ll"/> list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == true)
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        /// <summary>
        /// <code>if (Deletebutton.DeleteButtonPressed == true)</code> - if <see cref="GlobalTrashPicture"/> were pressed then :
        ///     <code>if (DeleteThisUser == false)</code> - if that was first click on this panel then :
        ///         <see cref="DeleteThisUser"/> changing on true, <see cref="RoundedConrnersSpawnPanel"/> change ourself color and whole <see cref="WroteWorkPlace"/> add to the <see cref="BufferDelete.ll"/> list
        ///  <code> else or if(DeleteThisUser == true)</code> - if that was clicked second time then : 
        ///         <see cref="DeleteThisUser"/> changing on false, remove whole <see cref="WroteWorkPlace"/> from the <see cref="BufferDelete.ll"/> list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoundedConrnersSpawnPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == true)
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        // checks is Additional Menu hide? false == yes : true == no 
        private bool checkISMoved = false;
        
        /// <summary>
        /// moves back <see cref="ShowingPanelOFLocalPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveBackMovingEverything_Tick(object sender, EventArgs e)
        {
            DescriptoinPanel.Size = new Size(BackdescriptionPanelMov, 84);
            if (BackdescriptionPanelMov <= 1086)
            {
                BackdescriptionPanelMov += 7;
            }
            else if (BackdescriptionPanelMov >= 1086)
            {
                DescriptoinPanel.Size = new Size(1086, DescriptoinPanel.Size.Height);
            }

            descriptionLable.Size = new Size(BackdescriptionLabelMov, 76);
            if (BackdescriptionLabelMov <= 1069)
            {
                BackdescriptionLabelMov += 7;
            }
            else if (BackdescriptionLabelMov >= 1069)
            {
                descriptionLable.Size = new Size(1069, descriptionLable.Size.Height);
            }

            Expand.Location = new Point(Backexpand, 46);
            if (Backexpand <= 1125)
            {
                Backexpand += 7;
            }
            else if (Backexpand >= 1125)
            {
                Expand.Location = new Point(1125, 46);
                MoveBackMovingEverything.Stop();

            }

            HIdeExpandedText.Location = new Point(BackhideExpanded, 46);
            if (BackhideExpanded <= 1125)
            {
                BackhideExpanded += 7;
            }
            else if (BackhideExpanded >= 1125)
            {
                HIdeExpandedText.Location = new Point(1125, 46);
            }

            CheckButton.Location = new Point(BackcheckButton, 51);
            if (BackcheckButton <= 1188)
            {
                BackcheckButton += 7;
            }
            else if (BackcheckButton >= 1188)
            {
                CheckButton.Location = new Point(1188, 51);
            }

            ShowingPanelOFLocalPicture.Size = new Size(BackMovingPanelSize, 67);
            if (BackMovingPanelSize >= 68)
            {
                BackMovingPanelSize -= 7;
            }
            else if (BackMovingPanelSize <= 68)
            {
                ShowingPanelOFLocalPicture.Size = new Size(68, 67);
            }

            ShowingPanelOFLocalPicture.Location = new Point(BackMovingPanelLoc, 40);
            if (BackMovingPanelLoc <= 1165)
            {
                BackMovingPanelLoc += 7;
            }
            else if (BackMovingPanelLoc >= 1165)
            {
                ShowingPanelOFLocalPicture.Location = new Point(1165, 40);
                ShowingPanelOFLocalPicture.SendToBack();
                ShowingPanelOFLocalPicture.Visible = false;
            }
        }
        
        /// <summary>
        /// moves in order to show us <see cref="ShowingPanelOFLocalPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovingEverything_Tick(object sender, EventArgs e)
        {
            DescriptoinPanel.Size = new Size(descriptionPanelMov, 84);
            if (descriptionPanelMov >= 853)
            {
                descriptionPanelMov -= 7;
            }
            else if (descriptionPanelMov <= 853)
            {
                DescriptoinPanel.Size = new Size(853, DescriptoinPanel.Size.Height);
            }

            descriptionLable.Size = new Size(descriptionLabelMov, 76);
            if (descriptionLabelMov >= 837)
            {
                descriptionLabelMov -= 7;
            } else if (descriptionLabelMov <= 837)
            {
                descriptionLable.Size = new Size(837, descriptionLable.Size.Height);
            }

            Expand.Location = new Point(expand, 46);
            if (expand >= 886)
            {
                expand -= 7;
            }else if (expand <= 886)
            {
                Expand.Location = new Point(886, 46);
            }

            HIdeExpandedText.Location = new Point(hideExpanded, 46);
            if (hideExpanded >= 886)
            {
                hideExpanded -= 7;
            }else if (hideExpanded <= 886)
            {
                HIdeExpandedText.Location = new Point(886, 46);
                MovingEverything.Stop();
                checkISMoved = true;
            }

            CheckButton.Location = new Point(checkButton, 51);
            if (checkButton >= 956)
            {
                checkButton -= 7;
            }else if (checkButton <= 956)
            {
                CheckButton.Location = new Point(956, 51);
            }

            ShowingPanelOFLocalPicture.Size = new Size(MovingPanelSize, 67);
            if (MovingPanelSize <= 299)
            {
                MovingPanelSize += 7;
            }else if (MovingPanelSize >= 299)
            {
                ShowingPanelOFLocalPicture.Size = new Size(229, 67);
            }

            ShowingPanelOFLocalPicture.Location = new Point(MovingPanelLoc, 40);
            if (MovingPanelLoc >= 1013)
            {
                MovingPanelLoc -= 7;
            }else if (MovingPanelLoc <= 1013)
            {
                ShowingPanelOFLocalPicture.Location = new Point(1013, 40);
            }
        }

        /// <summary>
        /// <code>if (CheckISAdditionalMenuOpen == false && ExpandORHide == false) { </code> - if Additional menu is close and Text don't show up then :
        ///     Change Location and size
        /// <code> else if (CheckISAdditionalMenuOpen == false && ExpandORHide == true) </code> - if Additional menu is close and Text show up then :
        ///     Change size and location with formula : we are get <see cref="descriptionLable"/> size height divide by 2 and plus 4
        /// <code>else if (CheckISAdditionalMenuOpen == true) </code> - if Additional menu is open then : 
        ///     we are change location and size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckButton_MouseLeave(object sender, EventArgs e)
        {
            if (CheckISAdditionalMenuOpen == false && ExpandORHide == false) {
                CheckButton.Location = new Point(1188, 51);
                CheckButton.Size = new Size(46, 44);
            }
            else if (CheckISAdditionalMenuOpen == false && ExpandORHide == true) 
            {
                CheckButton.Location = new Point(1188, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))) + 4);
                CheckButton.Size = new Size(46, 44);
            }
            else if (CheckISAdditionalMenuOpen == true)
            {
                CheckButton.Location = new Point(956, 51);
                CheckButton.Size = new Size(46, 44);
            }
        }

        /// <summary>
        /// <code>if (CheckISAdditionalMenuOpen == false && ExpandORHide == false) { </code> - if Additional menu is close and Text don't show up then :
        ///     Change Location and size
        /// <code> else if (CheckISAdditionalMenuOpen == false && ExpandORHide == true) </code> - if Additional menu is close and Text show up then :
        ///     Change size and location with formula : we are get <see cref="descriptionLable"/> size height divide by 2 and plus 4
        /// <code>else if (CheckISAdditionalMenuOpen == true) </code> - if Additional menu is open then : 
        ///     we are change location and size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckButton_MouseEnter(object sender, EventArgs e)
        {
            if (CheckISAdditionalMenuOpen == false && ExpandORHide == false) {
                CheckButton.Location = new Point(1190, 52);
                CheckButton.Size = new Size(41, 39);
            }
            else if (CheckISAdditionalMenuOpen == false && ExpandORHide == true)
            {
                CheckButton.Location = new Point(1190, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))) + 4);
                CheckButton.Size = new Size(41, 39);
            }
            else if (CheckISAdditionalMenuOpen == true)
            {
                CheckButton.Location = new Point(958, 54);
                CheckButton.Size = new Size(41, 39);
            }
        }

        /// <summary>
        /// <code> if (DeleteButton.DeleteButtonPressed == false) { </code> - if <see cref="GlobalTrashPicture"/> didn't pressed then :
        ///     we are changing the size or location (or both) of : <see cref="RoundedConrnersSpawnPanel"/>, <see cref="DescriptoinPanel"/>, <see cref="descriptionLable"/>, <see cref="Expand"/>,
        ///     <see cref="CheckButton"/>, <see cref="AdditionalFunc"/>, <see cref="HIdeExpandedText"/>, <see cref="ExpandORHide"/>
        /// <code>else</code> or <code>if (DeleteButton.DeleteButtonPressed == true) {</code> - else then : 
        ///     <code>if (DeleteThisUser == false)</code> - if that was first click on this panel then :
        ///         <see cref="DeleteThisUser"/> changing on true, <see cref="RoundedConrnersSpawnPanel"/> change ourself color and whole <see cref="WroteWorkPlace"/> add to the <see cref="BufferDelete.ll"/> list
        ///     <code>else</code> or <code>if (DeleteThisUser == true)</code> - if that was clicked second time then : 
        ///         <see cref="DeleteThisUser"/> changing on false, remove whole <see cref="WroteWorkPlace"/> from the <see cref="BufferDelete.ll"/> list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HIdeExpandedText_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == false) {
                    this.Size = new Size(1334, 123);
                    RoundedConrnersSpawnPanel.Size = new Size(1334, 123);
                    DescriptoinPanel.Size = new Size(1086, 84);
                    descriptionLable.Size = new Size(1056, 76);
                    Expand.Location = new Point(1125, 46);
                    CheckButton.Location = new Point(1188, 51);
                    AdditionalFunc.Location = new Point(1241, 45);
                    HIdeExpandedText.Location = new Point(1125, 46);
                    ExpandORHide = false;
                    HIdeExpandedText.Visible = false;
                    Expand.Visible = true;
            }
            else
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        /// <summary>
        /// we'r counting how much elements on a form will be resizing in order to contain all text
        /// </summary>
        /// <param name="sizeHeightForm"> Height of this Form</param>
        /// <param name="sizeHeightPanel"> Height of <see cref="RoundedConrnersSpawnPanel"/></param>
        /// <param name="sizeHeightBorder"> Height of Border <see cref="DescriptoinPanel"/></param>
        /// <param name="sizeHeightLabel"> Height of <see cref="descriptionLable"/></param>
        private void ResizingForm(int sizeHeightForm, int sizeHeightPanel, int sizeHeightBorder, int sizeHeightLabel)
        {
            this.Size = new Size(this.Size.Width, sizeHeightForm);
            RoundedConrnersSpawnPanel.Size = new Size(RoundedConrnersSpawnPanel.Size.Width, sizeHeightPanel);
            DescriptoinPanel.Size = new Size(DescriptoinPanel.Size.Width, sizeHeightBorder);
            descriptionLable.Size = new Size(descriptionLable.Size.Width, sizeHeightLabel);
                Expand.Location = new Point(Expand.Location.X, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))));
                CheckButton.Location = new Point(CheckButton.Location.X, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))) + 4);
                AdditionalFunc.Location = new Point(AdditionalFunc.Location.X, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))) - 2);
                HIdeExpandedText.Location = new Point(HIdeExpandedText.Location.X, (int)(Math.Floor(Convert.ToDecimal(descriptionLable.Size.Height / 2))));
        }

        // checks is Text expand or hide ? false == hide : true == yes
        private bool ExpandORHide = false;

        /// <summary>
        /// <code> if (DeleteButton.DeleteButtonPressed == false) </code> - if <see cref="GlobalTrashPicture"/> wasn't pressed then :
        ///     <code> if (CheckISAdditionalMenuOpen == false) </code> - if <see cref="ShowingPanelOFLocalPicture"/> didn't opened(showed) then :
        ///         <code>if (e.Button == MouseButtons.Left && ExpandORHide == false)</code> - if was left clik of mouse and <see cref="descriptionLable"/> don't open ( whole text still hide ) then : 
        ///             we choosen some cases, in every case we'r call <see cref="ResizingForm(int, int, int, int)"/> method exept 0, 1, 2, 3, 4 Cases. 
        ///     <code>else</code> or <code>if (CheckISAdditionalMenuOpen == true)</code> - if <see cref="ShowingPanelOFLocalPicture"/> was opened(showed) then :
        ///         nothing will happen 
        /// <code>else</code> or <code> if (DeleteButton.DeleteButtonPressed == false) </code> - if <see cref="GlobalTrashPicture"/> was pressed then :
        ///     <code>if (DeleteThisUser == false)</code> - if that was first click on this panel then :
        ///         <see cref="DeleteThisUser"/> changing on true, <see cref="RoundedConrnersSpawnPanel"/> change ourself color and whole <see cref="WroteWorkPlace"/> add to the <see cref="BufferDelete.ll"/> list
        ///  <code> else or if(DeleteThisUser == true)</code> - if that was clicked second time then : 
        ///         <see cref="DeleteThisUser"/> changing on false, remove whole <see cref="WroteWorkPlace"/> from the <see cref="BufferDelete.ll"/> list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Expand_MouseClick(object sender, MouseEventArgs e)
        {
            if (DeleteButton.DeleteButtonPressed == false) {
                if (CheckISAdditionalMenuOpen == false) {
                    if (e.Button == MouseButtons.Left && ExpandORHide == false)
                    {
                        ExpandORHide = true;
                        HIdeExpandedText.Visible = true;
                        Expand.Visible = false;
                        switch (countLines)
                        {
                            case 0:
                                break;
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                ResizingForm(startPosHeightForm + 23, startPosHeightPanel + 23, startPosHeightBorder + 24, startPosHeightLable + 23);
                                break;
                            case 5:
                                ResizingForm(startPosHeightForm + 24 * 2, startPosHeightPanel + 24 * 2, startPosHeightBorder + 24 * 2, startPosHeightLable + 23 * 2);
                                break;
                            default:
                                ResizingForm(startPosHeightForm + 25 * (countLines - 3), startPosHeightPanel + 25 * (countLines - 3), startPosHeightBorder + 25 * (countLines - 3), startPosHeightLable + 25 * (countLines - 3));
                                break;
                        }
                    }
                } else
                {
                    ;
                }
            }
            else
            {
                if (DeleteThisUser == false)
                {
                    DeleteThisUser = true;
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(70, 250, 198, 153);
                    BufferDelete.ll.Add(this);
                }
                else
                {
                    DeleteThisUser = false;
                    BufferDelete.ll.Remove(this);
                    RoundedConrnersSpawnPanel.FillColor = Color.FromArgb(250, 198, 153);
                }
            }
        }

        /// <summary>
        /// Resizing <see cref="GlobalListPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalListPicture_MouseEnter(object sender, EventArgs e)
        {
            GlobalListPicture.Size = new Size(28, 28);
            GlobalListPicture.Location = new Point(GlobalListPicture.Location.X + 2, GlobalListPicture.Location.Y + 3);
        }

        /// <summary>
        /// Resizing <see cref="GlobalListPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalListPicture_MouseLeave(object sender, EventArgs e)
        {
            GlobalListPicture.Size = new Size(33, 33);
            GlobalListPicture.Location = new Point(GlobalListPicture.Location.X - 2, GlobalListPicture.Location.Y - 3);
        }

        /// <summary>
        /// Resizing <see cref="GlobalPersonPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalPersonPicture_MouseEnter(object sender, EventArgs e)
        {
            GlobalPersonPicture.Size = new Size(37, 30);
            GlobalPersonPicture.Location = new Point(GlobalPersonPicture.Location.X + 3, GlobalPersonPicture.Location.Y + 3);
        }

        /// <summary>
        /// Resizing <see cref="GlobalPersonPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalPersonPicture_MouseLeave(object sender, EventArgs e)
        {
            GlobalPersonPicture.Size = new Size(42, 35);
            GlobalPersonPicture.Location = new Point(GlobalPersonPicture.Location.X - 3, GlobalPersonPicture.Location.Y - 3);
        }

        /// <summary>
        /// Resizing <see cref="GlobalRePlayPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalRePlayPicture_MouseEnter(object sender, EventArgs e)
        {
            GlobalRePlayPicture.Size = new Size(35, 30);
            GlobalRePlayPicture.Location = new Point(GlobalRePlayPicture.Location.X + 2, GlobalRePlayPicture.Location.Y + 1);
        }

        /// <summary>
        /// Resizing <see cref="GlobalRePlayPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalRePlayPicture_MouseLeave(object sender, EventArgs e)
        {
            GlobalRePlayPicture.Size = new Size(40, 35);
            GlobalRePlayPicture.Location = new Point(GlobalRePlayPicture.Location.X - 2, GlobalRePlayPicture.Location.Y - 1);
        }

        /// <summary>
        /// Resizing <see cref="GlobalTrashPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalTrashPicture_MouseLeave(object sender, EventArgs e)
        {
            GlobalTrashPicture.Size = new Size(35, 35);
            GlobalTrashPicture.Location = new Point(GlobalTrashPicture.Location.X - 2, GlobalTrashPicture.Location.Y - 2);
        }

        /// <summary>
        /// Resizing <see cref="GlobalTrashPicture"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalTrashPicture_MouseEnter(object sender, EventArgs e)
        {
            GlobalTrashPicture.Size = new Size(30, 30);
            GlobalTrashPicture.Location = new Point(GlobalTrashPicture.Location.X + 2, GlobalTrashPicture.Location.Y + 2);
        }

        /// <summary>
        /// Remove this <see cref="WroteWorkPlace"/> element from <see cref="Tasks.LayoutPanel"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalTrashPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pictureParent = ((PictureBox)sender).Parent;
                var MovingPanelParent = pictureParent.Parent;
                var PanelParent = MovingPanelParent.Parent;
                PanelParent.Parent.Controls.Remove(PanelParent);
            }
        }

    }
}