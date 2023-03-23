namespace UI.TextilSoft.MainForm
{
    partial class FmIniciarSesion
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
            components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmIniciarSesion));
            btnValidarCodigo = new FontAwesome.Sharp.IconButton();
            lnklblCodigo = new System.Windows.Forms.LinkLabel();
            pnlCodigo = new System.Windows.Forms.Panel();
            txtCodigo = new System.Windows.Forms.TextBox();
            lblCodigo = new System.Windows.Forms.Label();
            lblLoginError = new System.Windows.Forms.Label();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            btnLogin = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconUserName = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new System.Windows.Forms.Panel();
            pnlPasswordError = new System.Windows.Forms.Panel();
            lblPasswordError = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            pnlDownPasswordtxt = new System.Windows.Forms.Panel();
            txtPassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            pnlUserNameError = new System.Windows.Forms.Panel();
            lblUserNameError = new System.Windows.Forms.Label();
            pnlUserNameText = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            txtUser = new System.Windows.Forms.TextBox();
            lblLogin = new System.Windows.Forms.Label();
            lblUsuario = new System.Windows.Forms.Label();
            pnlLogin = new System.Windows.Forms.Panel();
            LoginAnimator = new AnimatorNS.Animator(components);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconUserName).BeginInit();
            panel2.SuspendLayout();
            pnlPasswordError.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            pnlUserNameError.SuspendLayout();
            pnlUserNameText.SuspendLayout();
            SuspendLayout();
            // 
            // btnValidarCodigo
            // 
            LoginAnimator.SetDecoration(btnValidarCodigo, AnimatorNS.DecorationType.None);
            btnValidarCodigo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            btnValidarCodigo.FlatAppearance.BorderSize = 0;
            btnValidarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnValidarCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnValidarCodigo.ForeColor = System.Drawing.Color.White;
            btnValidarCodigo.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btnValidarCodigo.IconColor = System.Drawing.Color.White;
            btnValidarCodigo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnValidarCodigo.IconSize = 30;
            btnValidarCodigo.Location = new System.Drawing.Point(622, 275);
            btnValidarCodigo.Name = "btnValidarCodigo";
            btnValidarCodigo.Size = new System.Drawing.Size(100, 31);
            btnValidarCodigo.TabIndex = 34;
            btnValidarCodigo.Text = "Validar";
            btnValidarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnValidarCodigo.UseVisualStyleBackColor = true;
            btnValidarCodigo.Click += btnValidarCodigo_Click;
            // 
            // lnklblCodigo
            // 
            lnklblCodigo.AutoSize = true;
            LoginAnimator.SetDecoration(lnklblCodigo, AnimatorNS.DecorationType.None);
            lnklblCodigo.LinkColor = System.Drawing.Color.White;
            lnklblCodigo.Location = new System.Drawing.Point(609, 314);
            lnklblCodigo.Name = "lnklblCodigo";
            lnklblCodigo.Size = new System.Drawing.Size(127, 15);
            lnklblCodigo.TabIndex = 33;
            lnklblCodigo.TabStop = true;
            lnklblCodigo.Text = "No recibiste el código?";
            lnklblCodigo.LinkClicked += lnklblCodigo_LinkClicked;
            // 
            // pnlCodigo
            // 
            pnlCodigo.BackColor = System.Drawing.Color.White;
            LoginAnimator.SetDecoration(pnlCodigo, AnimatorNS.DecorationType.None);
            pnlCodigo.Location = new System.Drawing.Point(616, 265);
            pnlCodigo.Name = "pnlCodigo";
            pnlCodigo.Size = new System.Drawing.Size(115, 1);
            pnlCodigo.TabIndex = 22;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LoginAnimator.SetDecoration(txtCodigo, AnimatorNS.DecorationType.None);
            txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigo.ForeColor = System.Drawing.Color.Gray;
            txtCodigo.Location = new System.Drawing.Point(616, 237);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(113, 22);
            txtCodigo.TabIndex = 23;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            LoginAnimator.SetDecoration(lblCodigo, AnimatorNS.DecorationType.None);
            lblCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(615, 209);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(113, 19);
            lblCodigo.TabIndex = 32;
            lblCodigo.Text = "Ingrese el código";
            // 
            // lblLoginError
            // 
            lblLoginError.AutoSize = true;
            lblLoginError.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            LoginAnimator.SetDecoration(lblLoginError, AnimatorNS.DecorationType.None);
            lblLoginError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLoginError.ForeColor = System.Drawing.Color.Red;
            lblLoginError.Location = new System.Drawing.Point(294, 292);
            lblLoginError.Name = "lblLoginError";
            lblLoginError.Size = new System.Drawing.Size(208, 19);
            lblLoginError.TabIndex = 25;
            lblLoginError.Text = "Usuario y/o contraseña inválidos";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            LoginAnimator.SetDecoration(linkLabel2, AnimatorNS.DecorationType.None);
            linkLabel2.LinkColor = System.Drawing.Color.White;
            linkLabel2.Location = new System.Drawing.Point(361, 430);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(76, 15);
            linkLabel2.TabIndex = 31;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Crear Cuenta";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            LoginAnimator.SetDecoration(linkLabel1, AnimatorNS.DecorationType.None);
            linkLabel1.LinkColor = System.Drawing.Color.White;
            linkLabel1.Location = new System.Drawing.Point(332, 322);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(136, 15);
            linkLabel1.TabIndex = 30;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvidaste tu contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            LoginAnimator.SetDecoration(btnLogin, AnimatorNS.DecorationType.None);
            btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            btnLogin.IconColor = System.Drawing.Color.White;
            btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogin.Location = new System.Drawing.Point(280, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(227, 67);
            btnLogin.TabIndex = 29;
            btnLogin.Text = "Ingresar";
            btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            LoginAnimator.SetDecoration(iconPictureBox1, AnimatorNS.DecorationType.None);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox1.IconColor = System.Drawing.Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 64;
            iconPictureBox1.Location = new System.Drawing.Point(64, 185);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(64, 64);
            iconPictureBox1.TabIndex = 28;
            iconPictureBox1.TabStop = false;
            // 
            // iconUserName
            // 
            iconUserName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            LoginAnimator.SetDecoration(iconUserName, AnimatorNS.DecorationType.None);
            iconUserName.IconChar = FontAwesome.Sharp.IconChar.User;
            iconUserName.IconColor = System.Drawing.Color.White;
            iconUserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUserName.IconSize = 64;
            iconUserName.Location = new System.Drawing.Point(64, 59);
            iconUserName.Name = "iconUserName";
            iconUserName.Size = new System.Drawing.Size(64, 64);
            iconUserName.TabIndex = 24;
            iconUserName.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlPasswordError);
            panel2.Controls.Add(panel6);
            LoginAnimator.SetDecoration(panel2, AnimatorNS.DecorationType.None);
            panel2.Location = new System.Drawing.Point(221, 186);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(368, 96);
            panel2.TabIndex = 27;
            // 
            // pnlPasswordError
            // 
            pnlPasswordError.Controls.Add(lblPasswordError);
            LoginAnimator.SetDecoration(pnlPasswordError, AnimatorNS.DecorationType.None);
            pnlPasswordError.Dock = System.Windows.Forms.DockStyle.Top;
            pnlPasswordError.Location = new System.Drawing.Point(0, 63);
            pnlPasswordError.Name = "pnlPasswordError";
            pnlPasswordError.Size = new System.Drawing.Size(368, 24);
            pnlPasswordError.TabIndex = 7;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            LoginAnimator.SetDecoration(lblPasswordError, AnimatorNS.DecorationType.None);
            lblPasswordError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPasswordError.ForeColor = System.Drawing.Color.Red;
            lblPasswordError.Location = new System.Drawing.Point(3, 3);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new System.Drawing.Size(130, 19);
            lblPasswordError.TabIndex = 8;
            lblPasswordError.Text = "Contraseña inválido";
            // 
            // panel6
            // 
            panel6.Controls.Add(pnlDownPasswordtxt);
            panel6.Controls.Add(txtPassword);
            LoginAnimator.SetDecoration(panel6, AnimatorNS.DecorationType.None);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(368, 63);
            panel6.TabIndex = 6;
            // 
            // pnlDownPasswordtxt
            // 
            pnlDownPasswordtxt.BackColor = System.Drawing.Color.White;
            LoginAnimator.SetDecoration(pnlDownPasswordtxt, AnimatorNS.DecorationType.None);
            pnlDownPasswordtxt.Location = new System.Drawing.Point(13, 40);
            pnlDownPasswordtxt.Name = "pnlDownPasswordtxt";
            pnlDownPasswordtxt.Size = new System.Drawing.Size(335, 1);
            pnlDownPasswordtxt.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LoginAnimator.SetDecoration(txtPassword, AnimatorNS.DecorationType.None);
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.ForeColor = System.Drawing.Color.Gray;
            txtPassword.Location = new System.Drawing.Point(13, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(335, 22);
            txtPassword.TabIndex = 0;
            txtPassword.Text = "Ingrese una Contraseña";
            txtPassword.Click += txtPassword_Click;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyPress += txtPassword_KeyPress;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            LoginAnimator.SetDecoration(label3, AnimatorNS.DecorationType.None);
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(134, 198);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 19);
            label3.TabIndex = 26;
            label3.Text = "Contraseña";
            // 
            // panel4
            // 
            panel4.Controls.Add(pnlUserNameError);
            panel4.Controls.Add(pnlUserNameText);
            LoginAnimator.SetDecoration(panel4, AnimatorNS.DecorationType.None);
            panel4.Location = new System.Drawing.Point(221, 60);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(368, 96);
            panel4.TabIndex = 21;
            // 
            // pnlUserNameError
            // 
            pnlUserNameError.Controls.Add(lblUserNameError);
            LoginAnimator.SetDecoration(pnlUserNameError, AnimatorNS.DecorationType.None);
            pnlUserNameError.Dock = System.Windows.Forms.DockStyle.Top;
            pnlUserNameError.Location = new System.Drawing.Point(0, 63);
            pnlUserNameError.Name = "pnlUserNameError";
            pnlUserNameError.Size = new System.Drawing.Size(368, 24);
            pnlUserNameError.TabIndex = 7;
            // 
            // lblUserNameError
            // 
            lblUserNameError.AutoSize = true;
            LoginAnimator.SetDecoration(lblUserNameError, AnimatorNS.DecorationType.None);
            lblUserNameError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUserNameError.ForeColor = System.Drawing.Color.Red;
            lblUserNameError.Location = new System.Drawing.Point(3, 3);
            lblUserNameError.Name = "lblUserNameError";
            lblUserNameError.Size = new System.Drawing.Size(107, 19);
            lblUserNameError.TabIndex = 8;
            lblUserNameError.Text = "Usuario inválido";
            // 
            // pnlUserNameText
            // 
            pnlUserNameText.Controls.Add(panel3);
            pnlUserNameText.Controls.Add(txtUser);
            LoginAnimator.SetDecoration(pnlUserNameText, AnimatorNS.DecorationType.None);
            pnlUserNameText.Dock = System.Windows.Forms.DockStyle.Top;
            pnlUserNameText.Location = new System.Drawing.Point(0, 0);
            pnlUserNameText.Name = "pnlUserNameText";
            pnlUserNameText.Size = new System.Drawing.Size(368, 63);
            pnlUserNameText.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            LoginAnimator.SetDecoration(panel3, AnimatorNS.DecorationType.None);
            panel3.Location = new System.Drawing.Point(13, 40);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(335, 1);
            panel3.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LoginAnimator.SetDecoration(txtUser, AnimatorNS.DecorationType.None);
            txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUser.ForeColor = System.Drawing.Color.Gray;
            txtUser.Location = new System.Drawing.Point(13, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(335, 22);
            txtUser.TabIndex = 0;
            txtUser.Text = "Ingrese un Usuario";
            txtUser.Click += txtUser_Click;
            txtUser.TextChanged += txtUser_TextChanged;
            txtUser.KeyPress += txtUser_KeyPress;
            txtUser.Leave += txtUser_Leave;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            LoginAnimator.SetDecoration(lblLogin, AnimatorNS.DecorationType.None);
            lblLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLogin.ForeColor = System.Drawing.Color.White;
            lblLogin.Location = new System.Drawing.Point(295, 5);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(126, 28);
            lblLogin.TabIndex = 19;
            lblLogin.Text = "Iniciar Sesión";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            LoginAnimator.SetDecoration(lblUsuario, AnimatorNS.DecorationType.None);
            lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUsuario.ForeColor = System.Drawing.Color.White;
            lblUsuario.Location = new System.Drawing.Point(134, 72);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(56, 19);
            lblUsuario.TabIndex = 20;
            lblUsuario.Text = "Usuario";
            // 
            // pnlLogin
            // 
            LoginAnimator.SetDecoration(pnlLogin, AnimatorNS.DecorationType.None);
            pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlLogin.Location = new System.Drawing.Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new System.Drawing.Size(800, 482);
            pnlLogin.TabIndex = 35;
            // 
            // LoginAnimator
            // 
            LoginAnimator.AnimationType = AnimatorNS.AnimationType.Leaf;
            LoginAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (System.Drawing.PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (System.Drawing.PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (System.Drawing.PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            LoginAnimator.DefaultAnimation = animation1;
            LoginAnimator.Interval = 14;
            LoginAnimator.TimeStep = 0.01F;
            // 
            // FmIniciarSesion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(800, 482);
            Controls.Add(btnValidarCodigo);
            Controls.Add(lnklblCodigo);
            Controls.Add(pnlCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblLoginError);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(iconPictureBox1);
            Controls.Add(iconUserName);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(lblLogin);
            Controls.Add(lblUsuario);
            Controls.Add(pnlLogin);
            LoginAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Name = "FmIniciarSesion";
            Text = "FmIniciarSesion";
            FormClosing += FmIniciarSesion_FormClosing;
            Load += FmIniciarSesion_Load;
            Click += FmIniciarSesion_Click;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconUserName).EndInit();
            panel2.ResumeLayout(false);
            pnlPasswordError.ResumeLayout(false);
            pnlPasswordError.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            pnlUserNameError.ResumeLayout(false);
            pnlUserNameError.PerformLayout();
            pnlUserNameText.ResumeLayout(false);
            pnlUserNameText.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnValidarCodigo;
        private System.Windows.Forms.LinkLabel lnklblCodigo;
        private System.Windows.Forms.Panel pnlCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPasswordError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlDownPasswordtxt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlUserNameError;
        private System.Windows.Forms.Label lblUserNameError;
        private System.Windows.Forms.Panel pnlUserNameText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlLogin;
        private AnimatorNS.Animator LoginAnimator;
    }
}