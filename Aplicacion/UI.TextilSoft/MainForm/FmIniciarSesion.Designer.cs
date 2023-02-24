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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmIniciarSesion));
            this.btnValidarCodigo = new FontAwesome.Sharp.IconButton();
            this.lnklblCodigo = new System.Windows.Forms.LinkLabel();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.LoginAnimator = new AnimatorNS.Animator(this.components);
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
            // btnValidarCodigo
            // 
            this.LoginAnimator.SetDecoration(this.btnValidarCodigo, AnimatorNS.DecorationType.None);
            this.btnValidarCodigo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnValidarCodigo.FlatAppearance.BorderSize = 0;
            this.btnValidarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnValidarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnValidarCodigo.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnValidarCodigo.IconColor = System.Drawing.Color.White;
            this.btnValidarCodigo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidarCodigo.IconSize = 30;
            this.btnValidarCodigo.Location = new System.Drawing.Point(622, 275);
            this.btnValidarCodigo.Name = "btnValidarCodigo";
            this.btnValidarCodigo.Size = new System.Drawing.Size(100, 31);
            this.btnValidarCodigo.TabIndex = 34;
            this.btnValidarCodigo.Text = "Validar";
            this.btnValidarCodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidarCodigo.UseVisualStyleBackColor = true;
            this.btnValidarCodigo.Click += new System.EventHandler(this.btnValidarCodigo_Click);
            // 
            // lnklblCodigo
            // 
            this.lnklblCodigo.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.lnklblCodigo, AnimatorNS.DecorationType.None);
            this.lnklblCodigo.LinkColor = System.Drawing.Color.White;
            this.lnklblCodigo.Location = new System.Drawing.Point(609, 314);
            this.lnklblCodigo.Name = "lnklblCodigo";
            this.lnklblCodigo.Size = new System.Drawing.Size(127, 15);
            this.lnklblCodigo.TabIndex = 33;
            this.lnklblCodigo.TabStop = true;
            this.lnklblCodigo.Text = "No recibiste el código?";
            this.lnklblCodigo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCodigo_LinkClicked);
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.BackColor = System.Drawing.Color.White;
            this.LoginAnimator.SetDecoration(this.pnlCodigo, AnimatorNS.DecorationType.None);
            this.pnlCodigo.Location = new System.Drawing.Point(616, 265);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(115, 1);
            this.pnlCodigo.TabIndex = 22;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginAnimator.SetDecoration(this.txtCodigo, AnimatorNS.DecorationType.None);
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigo.Location = new System.Drawing.Point(616, 237);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(113, 22);
            this.txtCodigo.TabIndex = 23;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.lblCodigo, AnimatorNS.DecorationType.None);
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(615, 209);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(113, 19);
            this.lblCodigo.TabIndex = 32;
            this.lblCodigo.Text = "Ingrese el código";
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LoginAnimator.SetDecoration(this.lblLoginError, AnimatorNS.DecorationType.None);
            this.lblLoginError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(294, 292);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(208, 19);
            this.lblLoginError.TabIndex = 25;
            this.lblLoginError.Text = "Usuario y/o contraseña inválidos";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.linkLabel2, AnimatorNS.DecorationType.None);
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(361, 430);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 15);
            this.linkLabel2.TabIndex = 31;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Crear Cuenta";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.linkLabel1, AnimatorNS.DecorationType.None);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(332, 322);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 15);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvidaste tu contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnLogin
            // 
            this.LoginAnimator.SetDecoration(this.btnLogin, AnimatorNS.DecorationType.None);
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(280, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(227, 67);
            this.btnLogin.TabIndex = 29;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LoginAnimator.SetDecoration(this.iconPictureBox1, AnimatorNS.DecorationType.None);
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 64;
            this.iconPictureBox1.Location = new System.Drawing.Point(64, 185);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.iconPictureBox1.TabIndex = 28;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconUserName
            // 
            this.iconUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LoginAnimator.SetDecoration(this.iconUserName, AnimatorNS.DecorationType.None);
            this.iconUserName.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUserName.IconColor = System.Drawing.Color.White;
            this.iconUserName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUserName.IconSize = 64;
            this.iconUserName.Location = new System.Drawing.Point(64, 59);
            this.iconUserName.Name = "iconUserName";
            this.iconUserName.Size = new System.Drawing.Size(64, 64);
            this.iconUserName.TabIndex = 24;
            this.iconUserName.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPasswordError);
            this.panel2.Controls.Add(this.panel6);
            this.LoginAnimator.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(221, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 96);
            this.panel2.TabIndex = 27;
            // 
            // pnlPasswordError
            // 
            this.pnlPasswordError.Controls.Add(this.lblPasswordError);
            this.LoginAnimator.SetDecoration(this.pnlPasswordError, AnimatorNS.DecorationType.None);
            this.pnlPasswordError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPasswordError.Location = new System.Drawing.Point(0, 63);
            this.pnlPasswordError.Name = "pnlPasswordError";
            this.pnlPasswordError.Size = new System.Drawing.Size(368, 24);
            this.pnlPasswordError.TabIndex = 7;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.lblPasswordError, AnimatorNS.DecorationType.None);
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
            this.LoginAnimator.SetDecoration(this.panel6, AnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(368, 63);
            this.panel6.TabIndex = 6;
            // 
            // pnlDownPasswordtxt
            // 
            this.pnlDownPasswordtxt.BackColor = System.Drawing.Color.White;
            this.LoginAnimator.SetDecoration(this.pnlDownPasswordtxt, AnimatorNS.DecorationType.None);
            this.pnlDownPasswordtxt.Location = new System.Drawing.Point(13, 40);
            this.pnlDownPasswordtxt.Name = "pnlDownPasswordtxt";
            this.pnlDownPasswordtxt.Size = new System.Drawing.Size(335, 1);
            this.pnlDownPasswordtxt.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginAnimator.SetDecoration(this.txtPassword, AnimatorNS.DecorationType.None);
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
            this.LoginAnimator.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(134, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Contraseña";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlUserNameError);
            this.panel4.Controls.Add(this.pnlUserNameText);
            this.LoginAnimator.SetDecoration(this.panel4, AnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(221, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 96);
            this.panel4.TabIndex = 21;
            // 
            // pnlUserNameError
            // 
            this.pnlUserNameError.Controls.Add(this.lblUserNameError);
            this.LoginAnimator.SetDecoration(this.pnlUserNameError, AnimatorNS.DecorationType.None);
            this.pnlUserNameError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserNameError.Location = new System.Drawing.Point(0, 63);
            this.pnlUserNameError.Name = "pnlUserNameError";
            this.pnlUserNameError.Size = new System.Drawing.Size(368, 24);
            this.pnlUserNameError.TabIndex = 7;
            // 
            // lblUserNameError
            // 
            this.lblUserNameError.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.lblUserNameError, AnimatorNS.DecorationType.None);
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
            this.LoginAnimator.SetDecoration(this.pnlUserNameText, AnimatorNS.DecorationType.None);
            this.pnlUserNameText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserNameText.Location = new System.Drawing.Point(0, 0);
            this.pnlUserNameText.Name = "pnlUserNameText";
            this.pnlUserNameText.Size = new System.Drawing.Size(368, 63);
            this.pnlUserNameText.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.LoginAnimator.SetDecoration(this.panel3, AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(13, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 1);
            this.panel3.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginAnimator.SetDecoration(this.txtUser, AnimatorNS.DecorationType.None);
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(13, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(335, 22);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Ingrese un Usuario";
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.lblLogin, AnimatorNS.DecorationType.None);
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(295, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(126, 28);
            this.lblLogin.TabIndex = 19;
            this.lblLogin.Text = "Iniciar Sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.LoginAnimator.SetDecoration(this.lblUsuario, AnimatorNS.DecorationType.None);
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(134, 72);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 19);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuario";
            // 
            // pnlLogin
            // 
            this.LoginAnimator.SetDecoration(this.pnlLogin, AnimatorNS.DecorationType.None);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(800, 570);
            this.pnlLogin.TabIndex = 35;
            // 
            // LoginAnimator
            // 
            this.LoginAnimator.AnimationType = AnimatorNS.AnimationType.Leaf;
            this.LoginAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            animation1.TransparencyCoeff = 0F;
            this.LoginAnimator.DefaultAnimation = animation1;
            this.LoginAnimator.Interval = 14;
            this.LoginAnimator.TimeStep = 0.01F;
            // 
            // FmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnValidarCodigo);
            this.Controls.Add(this.lnklblCodigo);
            this.Controls.Add(this.pnlCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconUserName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlLogin);
            this.LoginAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "FmIniciarSesion";
            this.Text = "FmIniciarSesion";
            this.Load += new System.EventHandler(this.FmIniciarSesion_Load);
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
            this.PerformLayout();

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