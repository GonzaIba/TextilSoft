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
            lblMessage = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconMessageBoxType = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new System.Windows.Forms.Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconMessageBoxType).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new System.Drawing.Point(3, 2);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(51, 15);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Mensaje";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(123, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(37, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Titulo";
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = System.Drawing.Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new System.Drawing.Point(134, 138);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new System.Drawing.Size(75, 35);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Aceptar";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconMessageBoxType
            // 
            iconMessageBoxType.BackColor = System.Drawing.SystemColors.Control;
            iconMessageBoxType.ForeColor = System.Drawing.SystemColors.ControlText;
            iconMessageBoxType.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMessageBoxType.IconColor = System.Drawing.SystemColors.ControlText;
            iconMessageBoxType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMessageBoxType.IconSize = 78;
            iconMessageBoxType.Location = new System.Drawing.Point(12, 37);
            iconMessageBoxType.Name = "iconMessageBoxType";
            iconMessageBoxType.Size = new System.Drawing.Size(92, 78);
            iconMessageBoxType.TabIndex = 3;
            iconMessageBoxType.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMessage);
            panel1.Location = new System.Drawing.Point(121, 37);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(220, 95);
            panel1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = System.Drawing.Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new System.Drawing.Point(215, 138);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FmMessageBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(353, 179);
            Controls.Add(btnCancelar);
            Controls.Add(iconMessageBoxType);
            Controls.Add(iconButton1);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FmMessageBox";
            Text = "FmMessageBox";
            ((System.ComponentModel.ISupportInitialize)iconMessageBoxType).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconMessageBoxType;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}