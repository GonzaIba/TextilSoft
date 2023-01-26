
namespace UI.TextilSoft.MainForm
{
    partial class FmRegistrarse
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
                components.Remove(RegistrarseAnimator);
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
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmRegistrarse));
            this.label5 = new System.Windows.Forms.Label();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MostrarContraseñaCB = new System.Windows.Forms.CheckBox();
            this.BtnRegistrarse = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackLogin = new FontAwesome.Sharp.IconButton();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.carespecial = new System.Windows.Forms.CheckBox();
            this.numero = new System.Windows.Forms.CheckBox();
            this.minuscula = new System.Windows.Forms.CheckBox();
            this.mayuscula = new System.Windows.Forms.CheckBox();
            this.minimo = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlDNI = new System.Windows.Forms.Panel();
            this.pnlTelefono = new System.Windows.Forms.Panel();
            this.pnlRegistrarse = new System.Windows.Forms.Panel();
            this.lblMayuscula = new System.Windows.Forms.Label();
            this.lblEspecial = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblMinuscula = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlConfirmPassword = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.RegistrarseAnimator = new AnimatorNS.Animator(this.components);
            this.tipTelefono = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipError = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnlRegistrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.label5, AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(39, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuario*";
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.lblIniciarSesion, AnimatorNS.DecorationType.None);
            this.lblIniciarSesion.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(189, 33);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(150, 27);
            this.lblIniciarSesion.TabIndex = 12;
            this.lblIniciarSesion.Text = "Registrarse";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistrarseAnimator.SetDecoration(this.txtMail, AnimatorNS.DecorationType.None);
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Location = new System.Drawing.Point(278, 122);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(220, 32);
            this.txtMail.TabIndex = 16;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegistrarseAnimator.SetDecoration(this.txtConfirmPassword, AnimatorNS.DecorationType.None);
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPassword.Location = new System.Drawing.Point(278, 271);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(220, 33);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegistrarseAnimator.SetDecoration(this.txtUsuario, AnimatorNS.DecorationType.None);
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(39, 122);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 32);
            this.txtUsuario.TabIndex = 18;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.label8, AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(39, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Contraseña*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.label9, AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label9.Location = new System.Drawing.Point(278, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Confirmar Contraseña*";
            // 
            // MostrarContraseñaCB
            // 
            this.MostrarContraseñaCB.AutoSize = true;
            this.MostrarContraseñaCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.MostrarContraseñaCB, AnimatorNS.DecorationType.None);
            this.MostrarContraseñaCB.FlatAppearance.BorderSize = 0;
            this.MostrarContraseñaCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostrarContraseñaCB.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MostrarContraseñaCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.MostrarContraseñaCB.Location = new System.Drawing.Point(504, 288);
            this.MostrarContraseñaCB.Name = "MostrarContraseñaCB";
            this.MostrarContraseñaCB.Size = new System.Drawing.Size(145, 21);
            this.MostrarContraseñaCB.TabIndex = 21;
            this.MostrarContraseñaCB.Text = "Mostrar Contraseña";
            this.MostrarContraseñaCB.UseVisualStyleBackColor = false;
            this.MostrarContraseñaCB.CheckedChanged += new System.EventHandler(this.MostrarContraseñaCB_CheckedChanged);
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RegistrarseAnimator.SetDecoration(this.BtnRegistrarse, AnimatorNS.DecorationType.None);
            this.BtnRegistrarse.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarse.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarse.Location = new System.Drawing.Point(157, 436);
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Size = new System.Drawing.Size(220, 28);
            this.BtnRegistrarse.TabIndex = 22;
            this.BtnRegistrarse.Text = "REGISTRARSE";
            this.BtnRegistrarse.UseVisualStyleBackColor = false;
            this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.RegistrarseAnimator.SetDecoration(this.btnLimpiar, AnimatorNS.DecorationType.None);
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLimpiar.Location = new System.Drawing.Point(157, 484);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(220, 29);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnBackLogin);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtNumeroTelefono);
            this.panel1.Controls.Add(this.lblIniciarSesion);
            this.panel1.Controls.Add(this.carespecial);
            this.panel1.Controls.Add(this.numero);
            this.panel1.Controls.Add(this.minuscula);
            this.panel1.Controls.Add(this.mayuscula);
            this.panel1.Controls.Add(this.minimo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.BtnRegistrarse);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.MostrarContraseñaCB);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pnlEmail);
            this.panel1.Controls.Add(this.pnlUsuario);
            this.panel1.Controls.Add(this.pnlDNI);
            this.panel1.Controls.Add(this.pnlTelefono);
            this.panel1.Controls.Add(this.pnlRegistrarse);
            this.RegistrarseAnimator.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 543);
            this.panel1.TabIndex = 24;
            // 
            // btnBackLogin
            // 
            this.RegistrarseAnimator.SetDecoration(this.btnBackLogin, AnimatorNS.DecorationType.None);
            this.btnBackLogin.FlatAppearance.BorderSize = 0;
            this.btnBackLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackLogin.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBackLogin.IconColor = System.Drawing.Color.White;
            this.btnBackLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackLogin.IconSize = 37;
            this.btnBackLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackLogin.Location = new System.Drawing.Point(3, 488);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(119, 44);
            this.btnBackLogin.TabIndex = 37;
            this.btnBackLogin.Text = "Volver a login";
            this.btnBackLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackLogin.UseVisualStyleBackColor = true;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.lblDNI, AnimatorNS.DecorationType.None);
            this.lblDNI.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblDNI.Location = new System.Drawing.Point(39, 168);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(38, 17);
            this.lblDNI.TabIndex = 32;
            this.lblDNI.Text = "DNI*";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegistrarseAnimator.SetDecoration(this.txtDNI, AnimatorNS.DecorationType.None);
            this.txtDNI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.Location = new System.Drawing.Point(39, 195);
            this.txtDNI.Multiline = true;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(220, 32);
            this.txtDNI.TabIndex = 34;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.lblTelefono, AnimatorNS.DecorationType.None);
            this.lblTelefono.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblTelefono.Location = new System.Drawing.Point(278, 169);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(133, 17);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "Número de teléfono";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNumeroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegistrarseAnimator.SetDecoration(this.txtNumeroTelefono, AnimatorNS.DecorationType.None);
            this.txtNumeroTelefono.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroTelefono.Location = new System.Drawing.Point(278, 195);
            this.txtNumeroTelefono.Multiline = true;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(220, 33);
            this.txtNumeroTelefono.TabIndex = 31;
            this.txtNumeroTelefono.TextChanged += new System.EventHandler(this.txtNumeroTelefono_TextChanged);
            // 
            // carespecial
            // 
            this.carespecial.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.carespecial, AnimatorNS.DecorationType.None);
            this.carespecial.Enabled = false;
            this.carespecial.Location = new System.Drawing.Point(39, 392);
            this.carespecial.Name = "carespecial";
            this.carespecial.Size = new System.Drawing.Size(15, 14);
            this.carespecial.TabIndex = 28;
            this.carespecial.UseVisualStyleBackColor = true;
            this.carespecial.CheckedChanged += new System.EventHandler(this.carespecial_CheckedChanged);
            this.carespecial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimo_MouseClick);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.numero, AnimatorNS.DecorationType.None);
            this.numero.Enabled = false;
            this.numero.Location = new System.Drawing.Point(39, 374);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(15, 14);
            this.numero.TabIndex = 27;
            this.numero.UseVisualStyleBackColor = true;
            this.numero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimo_MouseClick);
            // 
            // minuscula
            // 
            this.minuscula.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.minuscula, AnimatorNS.DecorationType.None);
            this.minuscula.Enabled = false;
            this.minuscula.Location = new System.Drawing.Point(39, 336);
            this.minuscula.Name = "minuscula";
            this.minuscula.Size = new System.Drawing.Size(15, 14);
            this.minuscula.TabIndex = 26;
            this.minuscula.UseVisualStyleBackColor = true;
            this.minuscula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimo_MouseClick);
            // 
            // mayuscula
            // 
            this.mayuscula.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.mayuscula, AnimatorNS.DecorationType.None);
            this.mayuscula.Enabled = false;
            this.mayuscula.Location = new System.Drawing.Point(39, 355);
            this.mayuscula.Name = "mayuscula";
            this.mayuscula.Size = new System.Drawing.Size(15, 14);
            this.mayuscula.TabIndex = 25;
            this.mayuscula.UseVisualStyleBackColor = true;
            this.mayuscula.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimo_MouseClick);
            // 
            // minimo
            // 
            this.minimo.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.minimo, AnimatorNS.DecorationType.None);
            this.minimo.Enabled = false;
            this.minimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.minimo.Location = new System.Drawing.Point(39, 317);
            this.minimo.Name = "minimo";
            this.minimo.Size = new System.Drawing.Size(15, 14);
            this.minimo.TabIndex = 24;
            this.minimo.UseVisualStyleBackColor = true;
            this.minimo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimo_MouseClick);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RegistrarseAnimator.SetDecoration(this.txtPassword, AnimatorNS.DecorationType.None);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(39, 271);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 32);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.lblMail, AnimatorNS.DecorationType.None);
            this.lblMail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.lblMail.Location = new System.Drawing.Point(278, 93);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 17);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "Mail*";
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.Red;
            this.RegistrarseAnimator.SetDecoration(this.pnlEmail, AnimatorNS.DecorationType.None);
            this.pnlEmail.Location = new System.Drawing.Point(277, 121);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(222, 35);
            this.pnlEmail.TabIndex = 29;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Red;
            this.RegistrarseAnimator.SetDecoration(this.pnlUsuario, AnimatorNS.DecorationType.None);
            this.pnlUsuario.Location = new System.Drawing.Point(38, 121);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(222, 35);
            this.pnlUsuario.TabIndex = 30;
            // 
            // pnlDNI
            // 
            this.pnlDNI.BackColor = System.Drawing.Color.Red;
            this.RegistrarseAnimator.SetDecoration(this.pnlDNI, AnimatorNS.DecorationType.None);
            this.pnlDNI.Location = new System.Drawing.Point(38, 194);
            this.pnlDNI.Name = "pnlDNI";
            this.pnlDNI.Size = new System.Drawing.Size(222, 35);
            this.pnlDNI.TabIndex = 35;
            // 
            // pnlTelefono
            // 
            this.pnlTelefono.BackColor = System.Drawing.Color.Red;
            this.RegistrarseAnimator.SetDecoration(this.pnlTelefono, AnimatorNS.DecorationType.None);
            this.pnlTelefono.Location = new System.Drawing.Point(277, 194);
            this.pnlTelefono.Name = "pnlTelefono";
            this.pnlTelefono.Size = new System.Drawing.Size(222, 36);
            this.pnlTelefono.TabIndex = 36;
            // 
            // pnlRegistrarse
            // 
            this.pnlRegistrarse.Controls.Add(this.lblMayuscula);
            this.pnlRegistrarse.Controls.Add(this.lblEspecial);
            this.pnlRegistrarse.Controls.Add(this.lblNumero);
            this.pnlRegistrarse.Controls.Add(this.lblMinuscula);
            this.pnlRegistrarse.Controls.Add(this.lblMinimo);
            this.pnlRegistrarse.Controls.Add(this.iconPictureBox1);
            this.pnlRegistrarse.Controls.Add(this.pnlConfirmPassword);
            this.pnlRegistrarse.Controls.Add(this.pnlPassword);
            this.RegistrarseAnimator.SetDecoration(this.pnlRegistrarse, AnimatorNS.DecorationType.None);
            this.pnlRegistrarse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarse.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarse.Name = "pnlRegistrarse";
            this.pnlRegistrarse.Size = new System.Drawing.Size(661, 543);
            this.pnlRegistrarse.TabIndex = 38;
            // 
            // lblMayuscula
            // 
            this.lblMayuscula.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.lblMayuscula, AnimatorNS.DecorationType.None);
            this.lblMayuscula.Location = new System.Drawing.Point(55, 354);
            this.lblMayuscula.Name = "lblMayuscula";
            this.lblMayuscula.Size = new System.Drawing.Size(166, 15);
            this.lblMayuscula.TabIndex = 5;
            this.lblMayuscula.Text = "Al menos una letra mayúscula";
            // 
            // lblEspecial
            // 
            this.lblEspecial.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.lblEspecial, AnimatorNS.DecorationType.None);
            this.lblEspecial.Location = new System.Drawing.Point(55, 392);
            this.lblEspecial.Name = "lblEspecial";
            this.lblEspecial.Size = new System.Drawing.Size(164, 15);
            this.lblEspecial.TabIndex = 4;
            this.lblEspecial.Text = "Al menos un caracter especial";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.lblNumero, AnimatorNS.DecorationType.None);
            this.lblNumero.Location = new System.Drawing.Point(55, 374);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(119, 15);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Al menos un número";
            // 
            // lblMinuscula
            // 
            this.lblMinuscula.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.lblMinuscula, AnimatorNS.DecorationType.None);
            this.lblMinuscula.Location = new System.Drawing.Point(55, 335);
            this.lblMinuscula.Name = "lblMinuscula";
            this.lblMinuscula.Size = new System.Drawing.Size(164, 15);
            this.lblMinuscula.TabIndex = 2;
            this.lblMinuscula.Text = "Al menos una letra minúscula";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.RegistrarseAnimator.SetDecoration(this.lblMinimo, AnimatorNS.DecorationType.None);
            this.lblMinimo.Location = new System.Drawing.Point(55, 317);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(116, 15);
            this.lblMinimo.TabIndex = 1;
            this.lblMinimo.Text = "Minimo 8 Caracteres";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RegistrarseAnimator.SetDecoration(this.iconPictureBox1, AnimatorNS.DecorationType.None);
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 26;
            this.iconPictureBox1.Location = new System.Drawing.Point(408, 169);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(31, 26);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.tipTelefono.SetToolTip(this.iconPictureBox1, "+54 X XX XXXX-XXXX | +54 9 11 6666-6666");
            // 
            // pnlConfirmPassword
            // 
            this.pnlConfirmPassword.BackColor = System.Drawing.Color.Red;
            this.RegistrarseAnimator.SetDecoration(this.pnlConfirmPassword, AnimatorNS.DecorationType.None);
            this.pnlConfirmPassword.Location = new System.Drawing.Point(277, 270);
            this.pnlConfirmPassword.Name = "pnlConfirmPassword";
            this.pnlConfirmPassword.Size = new System.Drawing.Size(222, 35);
            this.pnlConfirmPassword.TabIndex = 37;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.Red;
            this.RegistrarseAnimator.SetDecoration(this.pnlPassword, AnimatorNS.DecorationType.None);
            this.pnlPassword.Location = new System.Drawing.Point(38, 270);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(222, 35);
            this.pnlPassword.TabIndex = 36;
            // 
            // RegistrarseAnimator
            // 
            this.RegistrarseAnimator.AnimationType = AnimatorNS.AnimationType.VertSlide;
            this.RegistrarseAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.RegistrarseAnimator.DefaultAnimation = animation3;
            // 
            // FmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(660, 544);
            this.Controls.Add(this.panel1);
            this.RegistrarseAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Name = "FmRegistrarse";
            this.Text = "FmRegistrarse";
            this.Load += new System.EventHandler(this.FmRegistrarse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRegistrarse.ResumeLayout(false);
            this.pnlRegistrarse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox MostrarContraseñaCB;
        private System.Windows.Forms.Button BtnRegistrarse;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.CheckBox numero;
        private System.Windows.Forms.CheckBox minuscula;
        private System.Windows.Forms.CheckBox mayuscula;
        private System.Windows.Forms.CheckBox minimo;
        private System.Windows.Forms.CheckBox carespecial;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Panel pnlDNI;
        private System.Windows.Forms.Panel pnlTelefono;
        private FontAwesome.Sharp.IconButton btnBackLogin;
        private System.Windows.Forms.Panel pnlRegistrarse;
        private AnimatorNS.Animator RegistrarseAnimator;
        private System.Windows.Forms.ToolTip tipTelefono;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblMayuscula;
        private System.Windows.Forms.Label lblEspecial;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMinuscula;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.ToolTip toolTipError;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlConfirmPassword;
    }
}