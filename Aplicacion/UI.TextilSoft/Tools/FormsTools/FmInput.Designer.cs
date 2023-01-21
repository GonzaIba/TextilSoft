namespace UI.TextilSoft.Tools.FormsTools
{
    partial class FmInput
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(141, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 15);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Titulo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptar.IconColor = System.Drawing.Color.Black;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.Location = new System.Drawing.Point(115, 110);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 35);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(104, 42);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(134, 23);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(104, 81);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(134, 23);
            this.txt2.TabIndex = 5;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(40, 45);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(38, 15);
            this.lblInput1.TabIndex = 6;
            this.lblInput1.Text = "label1";
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Location = new System.Drawing.Point(40, 81);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(38, 15);
            this.lblInput2.TabIndex = 7;
            this.lblInput2.Text = "label2";
            // 
            // FmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 151);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmInput";
            this.Text = "FmInput";
            this.Load += new System.EventHandler(this.FmInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
    }
}