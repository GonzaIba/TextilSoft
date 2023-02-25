
namespace UI.TextilSoft.MainForm
{
    partial class FmLobby
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
                components.Remove(LoginAnimator);
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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLobby));
            this.pnlUp = new System.Windows.Forms.Panel();
            this.pnlCompanyLogo = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlTimeNow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.LoginAnimator = new AnimatorNS.Animator(this.components);
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlCompanyLogo.SuspendLayout();
            this.pnlTimeNow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LoginAnimator.SetDecoration(this.pnlUp, AnimatorNS.DecorationType.None);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(1, 1);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(977, 52);
            this.pnlUp.TabIndex = 4;
            this.pnlUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCompanyName_MouseDown);
            // 
            // pnlCompanyLogo
            // 
            this.pnlCompanyLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCompanyLogo.Controls.Add(this.lblCompanyName);
            this.pnlCompanyLogo.Controls.Add(this.pnlTimeNow);
            this.pnlCompanyLogo.Controls.Add(this.picCompanyLogo);
            this.LoginAnimator.SetDecoration(this.pnlCompanyLogo, AnimatorNS.DecorationType.None);
            this.pnlCompanyLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCompanyLogo.Location = new System.Drawing.Point(1, 53);
            this.pnlCompanyLogo.Name = "pnlCompanyLogo";
            this.pnlCompanyLogo.Size = new System.Drawing.Size(255, 504);
            this.pnlCompanyLogo.TabIndex = 5;
            this.pnlCompanyLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCompanyName_MouseDown);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.lblCompanyName, AnimatorNS.DecorationType.None);
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(11, 8);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(122, 32);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Compañia";
            this.lblCompanyName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCompanyName_MouseDown);
            // 
            // pnlTimeNow
            // 
            this.pnlTimeNow.Controls.Add(this.panel1);
            this.LoginAnimator.SetDecoration(this.pnlTimeNow, AnimatorNS.DecorationType.None);
            this.pnlTimeNow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTimeNow.Location = new System.Drawing.Point(0, 404);
            this.pnlTimeNow.Name = "pnlTimeNow";
            this.pnlTimeNow.Size = new System.Drawing.Size(255, 100);
            this.pnlTimeNow.TabIndex = 1;
            this.pnlTimeNow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCompanyName_MouseDown);
            // 
            // panel1
            // 
            this.LoginAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(254, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 72);
            this.panel1.TabIndex = 19;
            // 
            // picCompanyLogo
            // 
            this.LoginAnimator.SetDecoration(this.picCompanyLogo, AnimatorNS.DecorationType.None);
            this.picCompanyLogo.Location = new System.Drawing.Point(0, 53);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(255, 193);
            this.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCompanyLogo.TabIndex = 0;
            this.picCompanyLogo.TabStop = false;
            this.picCompanyLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCompanyLogo_MouseDown);
            // 
            // LoginAnimator
            // 
            this.LoginAnimator.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.LoginAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.LoginAnimator.DefaultAnimation = animation1;
            this.LoginAnimator.TimeStep = 0.01F;
            // 
            // pnlLogin
            // 
            this.LoginAnimator.SetDecoration(this.pnlLogin, AnimatorNS.DecorationType.None);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(256, 53);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(722, 504);
            this.pnlLogin.TabIndex = 6;
            // 
            // FmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(979, 558);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlCompanyLogo);
            this.Controls.Add(this.pnlUp);
            this.LoginAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FmLobby";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FmLobby_FormClosing);
            this.Load += new System.EventHandler(this.FmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconPictureBox1_MouseDown);
            this.pnlCompanyLogo.ResumeLayout(false);
            this.pnlCompanyLogo.PerformLayout();
            this.pnlTimeNow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Panel pnlCompanyLogo;
        private System.Windows.Forms.Panel pnlTimeNow;
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.Label lblCompanyName;
        private AnimatorNS.Animator LoginAnimator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLogin;
    }
}