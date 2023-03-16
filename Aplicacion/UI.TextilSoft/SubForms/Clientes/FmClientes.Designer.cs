namespace UI.TextilSoft.SubForms.Clientes
{
    partial class FmClientes
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
            lblClientes = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClientes.ForeColor = System.Drawing.Color.White;
            lblClientes.Location = new System.Drawing.Point(317, 35);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new System.Drawing.Size(133, 45);
            lblClientes.TabIndex = 44;
            lblClientes.Text = "Clientes";
            // 
            // FmClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblClientes);
            Name = "FmClientes";
            Text = "FmClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
    }
}