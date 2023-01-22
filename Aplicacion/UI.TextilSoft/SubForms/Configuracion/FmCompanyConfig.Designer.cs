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
            this.components = new System.ComponentModel.Container();
            this.txtMaxFail = new AltoControls.AltoTextBox();
            this.lblMaxFail = new System.Windows.Forms.Label();
            this.lblCompanyTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tgBtnEmailConfirmed = new UI.TextilSoft.Tools.FormsTools.ToggleButton();
            this.lblMailConfirmNo = new System.Windows.Forms.Label();
            this.lblConfirmMailSi = new System.Windows.Forms.Label();
            this.tgBtnMinuscula = new UI.TextilSoft.Tools.FormsTools.ToggleButton();
            this.lblMinusculaSi = new System.Windows.Forms.Label();
            this.lblMinusculaNo = new System.Windows.Forms.Label();
            this.lblMinuscula = new System.Windows.Forms.Label();
            this.tgBtnMayus = new UI.TextilSoft.Tools.FormsTools.ToggleButton();
            this.lblMayusSi = new System.Windows.Forms.Label();
            this.lblMayusNo = new System.Windows.Forms.Label();
            this.lblMayuscula = new System.Windows.Forms.Label();
            this.tgBtnNumero = new UI.TextilSoft.Tools.FormsTools.ToggleButton();
            this.lblNumeroSi = new System.Windows.Forms.Label();
            this.lblNumeroNo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tgBtnEspecial = new UI.TextilSoft.Tools.FormsTools.ToggleButton();
            this.lblEspecialSi = new System.Windows.Forms.Label();
            this.lblespecialNo = new System.Windows.Forms.Label();
            this.lblEspecial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCaracMinimo = new System.Windows.Forms.Label();
            this.txtCarMinimo = new AltoControls.AltoTextBox();
            this.btnSavePrefPW = new FontAwesome.Sharp.IconButton();
            this.btnSavePrefAuth = new FontAwesome.Sharp.IconButton();
            this.toolTipError = new System.Windows.Forms.ToolTip(this.components);
            this.lblAuth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnChangeColor = new FontAwesome.Sharp.IconButton();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.btnLogo = new FontAwesome.Sharp.IconButton();
            this.btnSavePersonalization = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaxFail
            // 
            this.txtMaxFail.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxFail.Br = System.Drawing.Color.MidnightBlue;
            this.txtMaxFail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaxFail.ForeColor = System.Drawing.Color.White;
            this.txtMaxFail.Location = new System.Drawing.Point(483, 185);
            this.txtMaxFail.Name = "txtMaxFail";
            this.txtMaxFail.Size = new System.Drawing.Size(55, 29);
            this.txtMaxFail.TabIndex = 5;
            this.txtMaxFail.TextChanged += new System.EventHandler(this.txtMaxFail_TextChanged);
            // 
            // lblMaxFail
            // 
            this.lblMaxFail.AutoSize = true;
            this.lblMaxFail.ForeColor = System.Drawing.Color.White;
            this.lblMaxFail.Location = new System.Drawing.Point(283, 192);
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
            this.label1.Location = new System.Drawing.Point(283, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail confirmado para ingresar";
            // 
            // tgBtnEmailConfirmed
            // 
            this.tgBtnEmailConfirmed.Checked = true;
            this.tgBtnEmailConfirmed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnEmailConfirmed.Location = new System.Drawing.Point(483, 229);
            this.tgBtnEmailConfirmed.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBtnEmailConfirmed.Name = "tgBtnEmailConfirmed";
            this.tgBtnEmailConfirmed.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnEmailConfirmed.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnEmailConfirmed.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnEmailConfirmed.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnEmailConfirmed.Size = new System.Drawing.Size(55, 22);
            this.tgBtnEmailConfirmed.TabIndex = 8;
            this.tgBtnEmailConfirmed.Text = "toggleButton1";
            this.tgBtnEmailConfirmed.UseVisualStyleBackColor = true;
            this.tgBtnEmailConfirmed.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // lblMailConfirmNo
            // 
            this.lblMailConfirmNo.AutoSize = true;
            this.lblMailConfirmNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMailConfirmNo.ForeColor = System.Drawing.Color.White;
            this.lblMailConfirmNo.Location = new System.Drawing.Point(455, 228);
            this.lblMailConfirmNo.Name = "lblMailConfirmNo";
            this.lblMailConfirmNo.Size = new System.Drawing.Size(31, 21);
            this.lblMailConfirmNo.TabIndex = 9;
            this.lblMailConfirmNo.Text = "No";
            // 
            // lblConfirmMailSi
            // 
            this.lblConfirmMailSi.AutoSize = true;
            this.lblConfirmMailSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmMailSi.ForeColor = System.Drawing.Color.White;
            this.lblConfirmMailSi.Location = new System.Drawing.Point(537, 229);
            this.lblConfirmMailSi.Name = "lblConfirmMailSi";
            this.lblConfirmMailSi.Size = new System.Drawing.Size(23, 21);
            this.lblConfirmMailSi.TabIndex = 10;
            this.lblConfirmMailSi.Text = "Si";
            // 
            // tgBtnMinuscula
            // 
            this.tgBtnMinuscula.Checked = true;
            this.tgBtnMinuscula.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnMinuscula.Location = new System.Drawing.Point(793, 185);
            this.tgBtnMinuscula.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBtnMinuscula.Name = "tgBtnMinuscula";
            this.tgBtnMinuscula.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnMinuscula.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnMinuscula.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnMinuscula.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnMinuscula.Size = new System.Drawing.Size(55, 22);
            this.tgBtnMinuscula.TabIndex = 12;
            this.tgBtnMinuscula.Text = "toggleButton2";
            this.tgBtnMinuscula.UseVisualStyleBackColor = true;
            // 
            // lblMinusculaSi
            // 
            this.lblMinusculaSi.AutoSize = true;
            this.lblMinusculaSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinusculaSi.ForeColor = System.Drawing.Color.White;
            this.lblMinusculaSi.Location = new System.Drawing.Point(847, 185);
            this.lblMinusculaSi.Name = "lblMinusculaSi";
            this.lblMinusculaSi.Size = new System.Drawing.Size(23, 21);
            this.lblMinusculaSi.TabIndex = 14;
            this.lblMinusculaSi.Text = "Si";
            // 
            // lblMinusculaNo
            // 
            this.lblMinusculaNo.AutoSize = true;
            this.lblMinusculaNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinusculaNo.ForeColor = System.Drawing.Color.White;
            this.lblMinusculaNo.Location = new System.Drawing.Point(765, 184);
            this.lblMinusculaNo.Name = "lblMinusculaNo";
            this.lblMinusculaNo.Size = new System.Drawing.Size(31, 21);
            this.lblMinusculaNo.TabIndex = 13;
            this.lblMinusculaNo.Text = "No";
            // 
            // lblMinuscula
            // 
            this.lblMinuscula.AutoSize = true;
            this.lblMinuscula.ForeColor = System.Drawing.Color.White;
            this.lblMinuscula.Location = new System.Drawing.Point(587, 187);
            this.lblMinuscula.Name = "lblMinuscula";
            this.lblMinuscula.Size = new System.Drawing.Size(158, 15);
            this.lblMinuscula.TabIndex = 11;
            this.lblMinuscula.Text = "Requiere de letra minúscula?";
            // 
            // tgBtnMayus
            // 
            this.tgBtnMayus.Checked = true;
            this.tgBtnMayus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnMayus.Location = new System.Drawing.Point(793, 221);
            this.tgBtnMayus.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBtnMayus.Name = "tgBtnMayus";
            this.tgBtnMayus.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnMayus.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnMayus.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnMayus.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnMayus.Size = new System.Drawing.Size(55, 22);
            this.tgBtnMayus.TabIndex = 16;
            this.tgBtnMayus.Text = "toggleButton2";
            this.tgBtnMayus.UseVisualStyleBackColor = true;
            // 
            // lblMayusSi
            // 
            this.lblMayusSi.AutoSize = true;
            this.lblMayusSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMayusSi.ForeColor = System.Drawing.Color.White;
            this.lblMayusSi.Location = new System.Drawing.Point(847, 221);
            this.lblMayusSi.Name = "lblMayusSi";
            this.lblMayusSi.Size = new System.Drawing.Size(23, 21);
            this.lblMayusSi.TabIndex = 18;
            this.lblMayusSi.Text = "Si";
            // 
            // lblMayusNo
            // 
            this.lblMayusNo.AutoSize = true;
            this.lblMayusNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMayusNo.ForeColor = System.Drawing.Color.White;
            this.lblMayusNo.Location = new System.Drawing.Point(765, 220);
            this.lblMayusNo.Name = "lblMayusNo";
            this.lblMayusNo.Size = new System.Drawing.Size(31, 21);
            this.lblMayusNo.TabIndex = 17;
            this.lblMayusNo.Text = "No";
            // 
            // lblMayuscula
            // 
            this.lblMayuscula.AutoSize = true;
            this.lblMayuscula.ForeColor = System.Drawing.Color.White;
            this.lblMayuscula.Location = new System.Drawing.Point(587, 223);
            this.lblMayuscula.Name = "lblMayuscula";
            this.lblMayuscula.Size = new System.Drawing.Size(160, 15);
            this.lblMayuscula.TabIndex = 15;
            this.lblMayuscula.Text = "Requiere de letra mayúscula?";
            // 
            // tgBtnNumero
            // 
            this.tgBtnNumero.Checked = true;
            this.tgBtnNumero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnNumero.Location = new System.Drawing.Point(793, 256);
            this.tgBtnNumero.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBtnNumero.Name = "tgBtnNumero";
            this.tgBtnNumero.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnNumero.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnNumero.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnNumero.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnNumero.Size = new System.Drawing.Size(55, 22);
            this.tgBtnNumero.TabIndex = 20;
            this.tgBtnNumero.Text = "toggleButton2";
            this.tgBtnNumero.UseVisualStyleBackColor = true;
            // 
            // lblNumeroSi
            // 
            this.lblNumeroSi.AutoSize = true;
            this.lblNumeroSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroSi.ForeColor = System.Drawing.Color.White;
            this.lblNumeroSi.Location = new System.Drawing.Point(847, 256);
            this.lblNumeroSi.Name = "lblNumeroSi";
            this.lblNumeroSi.Size = new System.Drawing.Size(23, 21);
            this.lblNumeroSi.TabIndex = 22;
            this.lblNumeroSi.Text = "Si";
            // 
            // lblNumeroNo
            // 
            this.lblNumeroNo.AutoSize = true;
            this.lblNumeroNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroNo.ForeColor = System.Drawing.Color.White;
            this.lblNumeroNo.Location = new System.Drawing.Point(765, 255);
            this.lblNumeroNo.Name = "lblNumeroNo";
            this.lblNumeroNo.Size = new System.Drawing.Size(31, 21);
            this.lblNumeroNo.TabIndex = 21;
            this.lblNumeroNo.Text = "No";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(587, 258);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(136, 15);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Requiere de un número?";
            // 
            // tgBtnEspecial
            // 
            this.tgBtnEspecial.Checked = true;
            this.tgBtnEspecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tgBtnEspecial.Location = new System.Drawing.Point(793, 291);
            this.tgBtnEspecial.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBtnEspecial.Name = "tgBtnEspecial";
            this.tgBtnEspecial.OffBackColor = System.Drawing.Color.Gray;
            this.tgBtnEspecial.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgBtnEspecial.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgBtnEspecial.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBtnEspecial.Size = new System.Drawing.Size(55, 22);
            this.tgBtnEspecial.TabIndex = 24;
            this.tgBtnEspecial.Text = "toggleButton2";
            this.tgBtnEspecial.UseVisualStyleBackColor = true;
            // 
            // lblEspecialSi
            // 
            this.lblEspecialSi.AutoSize = true;
            this.lblEspecialSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEspecialSi.ForeColor = System.Drawing.Color.White;
            this.lblEspecialSi.Location = new System.Drawing.Point(847, 291);
            this.lblEspecialSi.Name = "lblEspecialSi";
            this.lblEspecialSi.Size = new System.Drawing.Size(23, 21);
            this.lblEspecialSi.TabIndex = 26;
            this.lblEspecialSi.Text = "Si";
            // 
            // lblespecialNo
            // 
            this.lblespecialNo.AutoSize = true;
            this.lblespecialNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblespecialNo.ForeColor = System.Drawing.Color.White;
            this.lblespecialNo.Location = new System.Drawing.Point(765, 290);
            this.lblespecialNo.Name = "lblespecialNo";
            this.lblespecialNo.Size = new System.Drawing.Size(31, 21);
            this.lblespecialNo.TabIndex = 25;
            this.lblespecialNo.Text = "No";
            // 
            // lblEspecial
            // 
            this.lblEspecial.AutoSize = true;
            this.lblEspecial.ForeColor = System.Drawing.Color.White;
            this.lblEspecial.Location = new System.Drawing.Point(586, 294);
            this.lblEspecial.Name = "lblEspecial";
            this.lblEspecial.Size = new System.Drawing.Size(181, 15);
            this.lblEspecial.TabIndex = 23;
            this.lblEspecial.Text = "Requiere de un carácter especial?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(617, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Preferencias en contraseña";
            // 
            // lblCaracMinimo
            // 
            this.lblCaracMinimo.AutoSize = true;
            this.lblCaracMinimo.ForeColor = System.Drawing.Color.White;
            this.lblCaracMinimo.Location = new System.Drawing.Point(586, 330);
            this.lblCaracMinimo.Name = "lblCaracMinimo";
            this.lblCaracMinimo.Size = new System.Drawing.Size(171, 15);
            this.lblCaracMinimo.TabIndex = 28;
            this.lblCaracMinimo.Text = "Cantidad minima de caracteres";
            // 
            // txtCarMinimo
            // 
            this.txtCarMinimo.BackColor = System.Drawing.Color.Transparent;
            this.txtCarMinimo.Br = System.Drawing.Color.MidnightBlue;
            this.txtCarMinimo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCarMinimo.ForeColor = System.Drawing.Color.White;
            this.txtCarMinimo.Location = new System.Drawing.Point(766, 323);
            this.txtCarMinimo.Name = "txtCarMinimo";
            this.txtCarMinimo.Size = new System.Drawing.Size(51, 29);
            this.txtCarMinimo.TabIndex = 29;
            this.txtCarMinimo.TextChanged += new System.EventHandler(this.txtCarMinimo_TextChanged);
            // 
            // btnSavePrefPW
            // 
            this.btnSavePrefPW.FlatAppearance.BorderSize = 0;
            this.btnSavePrefPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrefPW.ForeColor = System.Drawing.Color.White;
            this.btnSavePrefPW.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSavePrefPW.IconColor = System.Drawing.Color.White;
            this.btnSavePrefPW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSavePrefPW.IconSize = 35;
            this.btnSavePrefPW.Location = new System.Drawing.Point(670, 369);
            this.btnSavePrefPW.Name = "btnSavePrefPW";
            this.btnSavePrefPW.Size = new System.Drawing.Size(101, 42);
            this.btnSavePrefPW.TabIndex = 30;
            this.btnSavePrefPW.Text = "Guardar";
            this.btnSavePrefPW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePrefPW.UseVisualStyleBackColor = true;
            this.btnSavePrefPW.Click += new System.EventHandler(this.btnSavePrefPW_Click);
            // 
            // btnSavePrefAuth
            // 
            this.btnSavePrefAuth.FlatAppearance.BorderSize = 0;
            this.btnSavePrefAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrefAuth.ForeColor = System.Drawing.Color.White;
            this.btnSavePrefAuth.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSavePrefAuth.IconColor = System.Drawing.Color.White;
            this.btnSavePrefAuth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSavePrefAuth.IconSize = 35;
            this.btnSavePrefAuth.Location = new System.Drawing.Point(362, 261);
            this.btnSavePrefAuth.Name = "btnSavePrefAuth";
            this.btnSavePrefAuth.Size = new System.Drawing.Size(101, 42);
            this.btnSavePrefAuth.TabIndex = 31;
            this.btnSavePrefAuth.Text = "Guardar";
            this.btnSavePrefAuth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePrefAuth.UseVisualStyleBackColor = true;
            this.btnSavePrefAuth.Click += new System.EventHandler(this.btnSavePrefAuth_Click);
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuth.ForeColor = System.Drawing.Color.White;
            this.lblAuth.Location = new System.Drawing.Point(283, 135);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(272, 25);
            this.lblAuth.TabIndex = 32;
            this.lblAuth.Text = "Preferencias en authenticación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Personalización";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(18, 246);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(34, 15);
            this.lblLogo.TabIndex = 34;
            this.lblLogo.Text = "Logo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(21, 200);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(36, 15);
            this.lblColor.TabIndex = 35;
            this.lblColor.Text = "Color";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.FlatAppearance.BorderSize = 0;
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor.ForeColor = System.Drawing.Color.White;
            this.btnChangeColor.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.btnChangeColor.IconColor = System.Drawing.Color.Red;
            this.btnChangeColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeColor.IconSize = 40;
            this.btnChangeColor.Location = new System.Drawing.Point(151, 194);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(34, 37);
            this.btnChangeColor.TabIndex = 36;
            this.btnChangeColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColor.Location = new System.Drawing.Point(66, 200);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(80, 16);
            this.txtColor.TabIndex = 37;
            // 
            // pboxLogo
            // 
            this.pboxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxLogo.Location = new System.Drawing.Point(66, 246);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(154, 130);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxLogo.TabIndex = 38;
            this.pboxLogo.TabStop = false;
            // 
            // btnLogo
            // 
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnLogo.IconColor = System.Drawing.Color.White;
            this.btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogo.IconSize = 45;
            this.btnLogo.Location = new System.Drawing.Point(66, 381);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(154, 42);
            this.btnLogo.TabIndex = 39;
            this.btnLogo.Text = "Cargar Imagen";
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnSavePersonalization
            // 
            this.btnSavePersonalization.FlatAppearance.BorderSize = 0;
            this.btnSavePersonalization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePersonalization.ForeColor = System.Drawing.Color.White;
            this.btnSavePersonalization.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSavePersonalization.IconColor = System.Drawing.Color.White;
            this.btnSavePersonalization.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSavePersonalization.IconSize = 35;
            this.btnSavePersonalization.Location = new System.Drawing.Point(45, 447);
            this.btnSavePersonalization.Name = "btnSavePersonalization";
            this.btnSavePersonalization.Size = new System.Drawing.Size(101, 42);
            this.btnSavePersonalization.TabIndex = 40;
            this.btnSavePersonalization.Text = "Guardar";
            this.btnSavePersonalization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePersonalization.UseVisualStyleBackColor = true;
            this.btnSavePersonalization.Click += new System.EventHandler(this.btnSavePersonalization_Click);
            // 
            // FmCompanyConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(877, 508);
            this.Controls.Add(this.txtMaxFail);
            this.Controls.Add(this.btnSavePersonalization);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.btnSavePrefAuth);
            this.Controls.Add(this.btnSavePrefPW);
            this.Controls.Add(this.txtCarMinimo);
            this.Controls.Add(this.lblCaracMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tgBtnEspecial);
            this.Controls.Add(this.lblEspecialSi);
            this.Controls.Add(this.lblespecialNo);
            this.Controls.Add(this.lblEspecial);
            this.Controls.Add(this.tgBtnNumero);
            this.Controls.Add(this.lblNumeroSi);
            this.Controls.Add(this.lblNumeroNo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.tgBtnMayus);
            this.Controls.Add(this.lblMayusSi);
            this.Controls.Add(this.lblMayusNo);
            this.Controls.Add(this.lblMayuscula);
            this.Controls.Add(this.tgBtnMinuscula);
            this.Controls.Add(this.lblMinusculaSi);
            this.Controls.Add(this.lblMinusculaNo);
            this.Controls.Add(this.lblMinuscula);
            this.Controls.Add(this.tgBtnEmailConfirmed);
            this.Controls.Add(this.lblConfirmMailSi);
            this.Controls.Add(this.lblMailConfirmNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompanyTitle);
            this.Controls.Add(this.lblMaxFail);
            this.Name = "FmCompanyConfig";
            this.Text = "FmCompanyConfig";
            this.Load += new System.EventHandler(this.FmCompanyConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.AltoTextBox txtMaxFail;
        private System.Windows.Forms.Label lblMaxFail;
        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.Label label1;
        private Tools.FormsTools.ToggleButton tgBtnEmailConfirmed;
        private System.Windows.Forms.Label lblMailConfirmNo;
        private System.Windows.Forms.Label lblConfirmMailSi;
        private Tools.FormsTools.ToggleButton tgBtnMinuscula;
        private System.Windows.Forms.Label lblMinusculaSi;
        private System.Windows.Forms.Label lblMinusculaNo;
        private System.Windows.Forms.Label lblMinuscula;
        private Tools.FormsTools.ToggleButton tgBtnMayus;
        private System.Windows.Forms.Label lblMayusSi;
        private System.Windows.Forms.Label lblMayusNo;
        private System.Windows.Forms.Label lblMayuscula;
        private Tools.FormsTools.ToggleButton tgBtnNumero;
        private System.Windows.Forms.Label lblNumeroSi;
        private System.Windows.Forms.Label lblNumeroNo;
        private System.Windows.Forms.Label lblNumero;
        private Tools.FormsTools.ToggleButton tgBtnEspecial;
        private System.Windows.Forms.Label lblEspecialSi;
        private System.Windows.Forms.Label lblespecialNo;
        private System.Windows.Forms.Label lblEspecial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCaracMinimo;
        private AltoControls.AltoTextBox txtCarMinimo;
        private FontAwesome.Sharp.IconButton btnSavePrefPW;
        private FontAwesome.Sharp.IconButton btnSavePrefAuth;
        private System.Windows.Forms.ToolTip toolTipError;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblColor;
        private FontAwesome.Sharp.IconButton btnChangeColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.PictureBox pboxLogo;
        private FontAwesome.Sharp.IconButton btnLogo;
        private FontAwesome.Sharp.IconButton btnSavePersonalization;
        private System.Windows.Forms.Panel pnlAuthAndPassword;
    }
}