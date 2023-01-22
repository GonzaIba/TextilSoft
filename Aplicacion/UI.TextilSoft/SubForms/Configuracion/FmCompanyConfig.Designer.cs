namespace UI.TextilSoft.SubForms.Configuracion
{
    partial class FmCompanyConfig
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
            this.txtMaxFail = new AltoControls.AltoTextBox();
            this.lblMaxFail = new System.Windows.Forms.Label();
            this.lblCompanyTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaxFail
            // 
            this.txtMaxFail.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxFail.Br = System.Drawing.Color.MidnightBlue;
            this.txtMaxFail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaxFail.ForeColor = System.Drawing.Color.White;
            this.txtMaxFail.Location = new System.Drawing.Point(218, 119);
            this.txtMaxFail.Name = "txtMaxFail";
            this.txtMaxFail.Size = new System.Drawing.Size(51, 29);
            this.txtMaxFail.TabIndex = 5;
            // 
            // lblMaxFail
            // 
            this.lblMaxFail.AutoSize = true;
            this.lblMaxFail.ForeColor = System.Drawing.Color.White;
            this.lblMaxFail.Location = new System.Drawing.Point(18, 126);
            this.lblMaxFail.Name = "lblMaxFail";
            this.lblMaxFail.Size = new System.Drawing.Size(194, 15);
            this.lblMaxFail.TabIndex = 4;
            this.lblMaxFail.Text = "Maximo intentos fallidos al acceder";
            // 
            // lblCompanyTitle
            // 
            this.lblCompanyTitle.AutoSize = true;
            this.lblCompanyTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyTitle.ForeColor = System.Drawing.Color.White;
            this.lblCompanyTitle.Location = new System.Drawing.Point(212, 26);
            this.lblCompanyTitle.Name = "lblCompanyTitle";
            this.lblCompanyTitle.Size = new System.Drawing.Size(445, 45);
            this.lblCompanyTitle.TabIndex = 6;
            this.lblCompanyTitle.Text = "Configuración de la compañía";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail confirmado para ingresar";
            // 
            // FmCompanyConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(877, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompanyTitle);
            this.Controls.Add(this.txtMaxFail);
            this.Controls.Add(this.lblMaxFail);
            this.Name = "FmCompanyConfig";
            this.Text = "FmCompanyConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.AltoTextBox txtMaxFail;
        private System.Windows.Forms.Label lblMaxFail;
        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.Label label1;
    }
}