namespace UI.TextilSoft.Tools.FormsTools
{
    partial class FmMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconMessageBoxType = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconMessageBoxType)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(3, 2);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(51, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Mensaje";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(123, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titulo";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(134, 138);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 35);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Aceptar";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconMessageBoxType
            // 
            this.iconMessageBoxType.BackColor = System.Drawing.SystemColors.Control;
            this.iconMessageBoxType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconMessageBoxType.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMessageBoxType.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconMessageBoxType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMessageBoxType.IconSize = 78;
            this.iconMessageBoxType.Location = new System.Drawing.Point(12, 37);
            this.iconMessageBoxType.Name = "iconMessageBoxType";
            this.iconMessageBoxType.Size = new System.Drawing.Size(92, 78);
            this.iconMessageBoxType.TabIndex = 3;
            this.iconMessageBoxType.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Location = new System.Drawing.Point(121, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 95);
            this.panel1.TabIndex = 4;
            // 
            // FmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 179);
            this.Controls.Add(this.iconMessageBoxType);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmMessageBox";
            this.Text = "FmMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.iconMessageBoxType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconMessageBoxType;
        private System.Windows.Forms.Panel panel1;
    }
}