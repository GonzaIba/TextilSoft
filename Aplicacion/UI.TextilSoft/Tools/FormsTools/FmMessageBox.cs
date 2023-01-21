﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.Tools.FormsTools
{
    public partial class FmMessageBox : Form
    {
        public FmMessageBox(MessageBoxType messageBoxType, string title, string message, Point location)
        {
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.Manual;
            BringToFront();
            Location = new Point(location.X, location.Y);
            this.Refresh();
            InitializeComponent();
            this.lblTitle.Text = title;
            //Ajust message into panel
            this.lblMessage.Text = message;
            this.lblMessage.MaximumSize = new Size(this.panel1.Width - 10, 0);
            this.lblMessage.AutoSize = true;
            this.lblMessage.Refresh();
            this.panel1.Refresh();          
            //this.lblTitle.Left = (this.Width - this.lblTitle.Width) / 2;
            this.lblMessage.Text = message;
            switch (messageBoxType)
            {
                case MessageBoxType.Error:
                    this.BackColor = Color.FromArgb(255, 128, 128);
                    this.lblMessage.ForeColor = Color.White;
                    this.iconMessageBoxType.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                    break;
                case MessageBoxType.Warning:
                    this.BackColor = Color.FromArgb(255, 255, 128);
                    this.lblMessage.ForeColor = Color.Black;
                    this.iconMessageBoxType.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                    break;
                case MessageBoxType.Information:
                    this.BackColor = Color.FromArgb(128, 255, 128);
                    this.lblMessage.ForeColor = Color.Black;
                    this.iconMessageBoxType.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    break;
                case MessageBoxType.Question:
                    this.BackColor = Color.FromArgb(128, 255, 255);
                    this.lblMessage.ForeColor = Color.Black;
                    this.iconMessageBoxType.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
                    break;
                case MessageBoxType.Success:
                    this.BackColor = Color.FromArgb(128, 255, 128);
                    this.lblMessage.ForeColor = Color.Black;
                    this.iconMessageBoxType.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    break;
                default:
                    break;
            }
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
