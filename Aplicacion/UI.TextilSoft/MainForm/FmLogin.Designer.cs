
namespace UI.TextilSoft.MainForm
{
    partial class FmLogin
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
            this.components = new System.ComponentModel.Container();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCompanyLogo = new System.Windows.Forms.Panel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pnlTimeNow = new System.Windows.Forms.Panel();
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconUserName = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPasswordError = new System.Windows.Forms.Panel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlDownPasswordtxt = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlUserNameError = new System.Windows.Forms.Panel();
            this.lblUserNameError = new System.Windows.Forms.Label();
            this.pnlUserNameText = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCompanyLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserName)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPasswordError.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlUserNameError.SuspendLayout();
            this.pnlUserNameText.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(13, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(335, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Ingrese un Usuario";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(503, 77);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(126, 28);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Iniciar Sesión";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 52);
            this.panel1.TabIndex = 4;
            // 
            // pnlCompanyLogo
            // 
            this.pnlCompanyLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlCompanyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCompanyLogo.Controls.Add(this.lblCompanyName);
            this.pnlCompanyLogo.Controls.Add(this.pnlTimeNow);
            this.pnlCompanyLogo.Controls.Add(this.picCompanyLogo);
            this.pnlCompanyLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCompanyLogo.Location = new System.Drawing.Point(1, 53);
            this.pnlCompanyLogo.Name = "pnlCompanyLogo";
            this.pnlCompanyLogo.Size = new System.Drawing.Size(255, 477);
            this.pnlCompanyLogo.TabIndex = 5;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(11, 8);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(122, 32);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Compañia";
            // 
            // pnlTimeNow
            // 
            this.pnlTimeNow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTimeNow.Location = new System.Drawing.Point(0, 375);
            this.pnlTimeNow.Name = "pnlTimeNow";
            this.pnlTimeNow.Size = new System.Drawing.Size(253, 100);
            this.pnlTimeNow.TabIndex = 1;
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Location = new System.Drawing.Point(0, 53);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(255, 193);
            this.picCompanyLogo.TabIndex = 0;
            this.picCompanyLogo.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lblLoginError);
            this.pnlLogin.Controls.Add(this.linkLabel2);
            this.pnlLogin.Controls.Add(this.linkLabel1);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.iconPictureBox1);
            this.pnlLogin.Controls.Add(this.iconUserName);
            this.pnlLogin.Controls.Add(this.panel2);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.panel4);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.lblUsuario);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(1, 1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(881, 529);
            this.pnlLogin.TabIndex = 6;
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblLoginError.Location = new System.Drawing.Point(503, 357);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(208, 19);
            this.lblLoginError.TabIndex = 9;
            this.lblLoginError.Text = "Usuario y/o contraseña inválidos";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(569, 502);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 15);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Crear Cuenta";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(540, 394);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 15);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidaste tu contraseña?";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(488, 422);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(227, 67);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 64;
            this.iconPictureBox1.Location = new System.Drawing.Point(272, 257);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconUserName
            // 
            this.iconUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.iconUserName.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUserName.IconColor = System.Drawing.Color.White;
            this.iconUserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUserName.IconSize = 64;
            this.iconUserName.Location = new System.Drawing.Point(272, 131);
            this.iconUserName.Name = "iconUserName";
            this.iconUserName.Size = new System.Drawing.Size(64, 64);
            this.iconUserName.TabIndex = 8;
            this.iconUserName.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPasswordError);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(429, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 96);
            this.panel2.TabIndex = 10;
            // 
            // pnlPasswordError
            // 
            this.pnlPasswordError.Controls.Add(this.lblPasswordError);
            this.pnlPasswordError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPasswordError.Location = new System.Drawing.Point(0, 63);
            this.pnlPasswordError.Name = "pnlPasswordError";
            this.pnlPasswordError.Size = new System.Drawing.Size(368, 24);
            this.pnlPasswordError.TabIndex = 7;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(3, 3);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(130, 19);
            this.lblPasswordError.TabIndex = 8;
            this.lblPasswordError.Text = "Contraseña inválido";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnlDownPasswordtxt);
            this.panel6.Controls.Add(this.txtPassword);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(368, 63);
            this.panel6.TabIndex = 6;
            // 
            // pnlDownPasswordtxt
            // 
            this.pnlDownPasswordtxt.BackColor = System.Drawing.Color.White;
            this.pnlDownPasswordtxt.Location = new System.Drawing.Point(13, 40);
            this.pnlDownPasswordtxt.Name = "pnlDownPasswordtxt";
            this.pnlDownPasswordtxt.Size = new System.Drawing.Size(335, 1);
            this.pnlDownPasswordtxt.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(13, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(335, 22);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Ingrese una Contraseña";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(342, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlUserNameError);
            this.panel4.Controls.Add(this.pnlUserNameText);
            this.panel4.Location = new System.Drawing.Point(429, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 96);
            this.panel4.TabIndex = 7;
            // 
            // pnlUserNameError
            // 
            this.pnlUserNameError.Controls.Add(this.lblUserNameError);
            this.pnlUserNameError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserNameError.Location = new System.Drawing.Point(0, 63);
            this.pnlUserNameError.Name = "pnlUserNameError";
            this.pnlUserNameError.Size = new System.Drawing.Size(368, 24);
            this.pnlUserNameError.TabIndex = 7;
            // 
            // lblUserNameError
            // 
            this.lblUserNameError.AutoSize = true;
            this.lblUserNameError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserNameError.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameError.Location = new System.Drawing.Point(3, 3);
            this.lblUserNameError.Name = "lblUserNameError";
            this.lblUserNameError.Size = new System.Drawing.Size(107, 19);
            this.lblUserNameError.TabIndex = 8;
            this.lblUserNameError.Text = "Usuario inválido";
            // 
            // pnlUserNameText
            // 
            this.pnlUserNameText.Controls.Add(this.panel3);
            this.pnlUserNameText.Controls.Add(this.txtUser);
            this.pnlUserNameText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserNameText.Location = new System.Drawing.Point(0, 0);
            this.pnlUserNameText.Name = "pnlUserNameText";
            this.pnlUserNameText.Size = new System.Drawing.Size(368, 63);
            this.pnlUserNameText.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 1);
            this.panel3.TabIndex = 7;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(342, 144);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 19);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 531);
            this.Controls.Add(this.pnlCompanyLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmLogin";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FmLogin";
            this.Load += new System.EventHandler(this.FmLogin_Load);
            this.pnlCompanyLogo.ResumeLayout(false);
            this.pnlCompanyLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserName)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlPasswordError.ResumeLayout(false);
            this.pnlPasswordError.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlUserNameError.ResumeLayout(false);
            this.pnlUserNameError.PerformLayout();
            this.pnlUserNameText.ResumeLayout(false);
            this.pnlUserNameText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCompanyLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlUserNameText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlUserNameError;
        private System.Windows.Forms.Label lblUserNameError;
        private FontAwesome.Sharp.IconPictureBox iconUserName;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPasswordError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlDownPasswordtxt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlTimeNow;
        private System.Windows.Forms.PictureBox picCompanyLogo;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Timer timer1;
    }
}