namespace UI.TextilSoft.MainForm
{
    partial class FmError
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
            pboxError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxError).BeginInit();
            SuspendLayout();
            // 
            // pboxError
            // 
            pboxError.Location = new System.Drawing.Point(61, 61);
            pboxError.Name = "pboxError";
            pboxError.Size = new System.Drawing.Size(554, 314);
            pboxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pboxError.TabIndex = 0;
            pboxError.TabStop = false;
            // 
            // FmError
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            ClientSize = new System.Drawing.Size(691, 450);
            Controls.Add(pboxError);
            Name = "FmError";
            Text = "FmError";
            Load += FmError_Load;
            ((System.ComponentModel.ISupportInitialize)pboxError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pboxError;
    }
}