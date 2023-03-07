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
            components = new System.ComponentModel.Container();
            txtMaxFail = new AltoControls.AltoTextBox();
            lblMaxFail = new System.Windows.Forms.Label();
            lblCompanyTitle = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tgBtnEmailConfirmed = new Tools.FormsTools.ToggleButton();
            lblMailConfirmNo = new System.Windows.Forms.Label();
            lblConfirmMailSi = new System.Windows.Forms.Label();
            tgBtnMinuscula = new Tools.FormsTools.ToggleButton();
            lblMinusculaSi = new System.Windows.Forms.Label();
            lblMinusculaNo = new System.Windows.Forms.Label();
            lblMinuscula = new System.Windows.Forms.Label();
            tgBtnMayus = new Tools.FormsTools.ToggleButton();
            lblMayusSi = new System.Windows.Forms.Label();
            lblMayusNo = new System.Windows.Forms.Label();
            lblMayuscula = new System.Windows.Forms.Label();
            tgBtnNumero = new Tools.FormsTools.ToggleButton();
            lblNumeroSi = new System.Windows.Forms.Label();
            lblNumeroNo = new System.Windows.Forms.Label();
            lblNumero = new System.Windows.Forms.Label();
            tgBtnEspecial = new Tools.FormsTools.ToggleButton();
            lblEspecialSi = new System.Windows.Forms.Label();
            lblespecialNo = new System.Windows.Forms.Label();
            lblEspecial = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblCaracMinimo = new System.Windows.Forms.Label();
            txtCarMinimo = new AltoControls.AltoTextBox();
            btnSavePrefPW = new FontAwesome.Sharp.IconButton();
            btnSavePrefAuth = new FontAwesome.Sharp.IconButton();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            lblAuth = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblLogo = new System.Windows.Forms.Label();
            lblColor = new System.Windows.Forms.Label();
            btnChangeColor = new FontAwesome.Sharp.IconButton();
            txtColor = new System.Windows.Forms.TextBox();
            pboxLogo = new System.Windows.Forms.PictureBox();
            btnLogo = new FontAwesome.Sharp.IconButton();
            btnSavePersonalization = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtMaxFail
            // 
            txtMaxFail.BackColor = System.Drawing.Color.Transparent;
            txtMaxFail.Br = System.Drawing.Color.MidnightBlue;
            txtMaxFail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMaxFail.ForeColor = System.Drawing.Color.White;
            txtMaxFail.Location = new System.Drawing.Point(483, 185);
            txtMaxFail.Name = "txtMaxFail";
            txtMaxFail.Size = new System.Drawing.Size(55, 29);
            txtMaxFail.TabIndex = 5;
            txtMaxFail.TextChanged += txtMaxFail_TextChanged;
            // 
            // lblMaxFail
            // 
            lblMaxFail.AutoSize = true;
            lblMaxFail.ForeColor = System.Drawing.Color.White;
            lblMaxFail.Location = new System.Drawing.Point(283, 192);
            lblMaxFail.Name = "lblMaxFail";
            lblMaxFail.Size = new System.Drawing.Size(194, 15);
            lblMaxFail.TabIndex = 4;
            lblMaxFail.Text = "Maximo intentos fallidos al acceder";
            // 
            // lblCompanyTitle
            // 
            lblCompanyTitle.AutoSize = true;
            lblCompanyTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCompanyTitle.ForeColor = System.Drawing.Color.White;
            lblCompanyTitle.Location = new System.Drawing.Point(212, 26);
            lblCompanyTitle.Name = "lblCompanyTitle";
            lblCompanyTitle.Size = new System.Drawing.Size(445, 45);
            lblCompanyTitle.TabIndex = 6;
            lblCompanyTitle.Text = "Configuración de la compañía";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(283, 231);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(166, 15);
            label1.TabIndex = 7;
            label1.Text = "Mail confirmado para ingresar";
            // 
            // tgBtnEmailConfirmed
            // 
            tgBtnEmailConfirmed.Checked = true;
            tgBtnEmailConfirmed.CheckState = System.Windows.Forms.CheckState.Checked;
            tgBtnEmailConfirmed.Location = new System.Drawing.Point(483, 229);
            tgBtnEmailConfirmed.MinimumSize = new System.Drawing.Size(45, 22);
            tgBtnEmailConfirmed.Name = "tgBtnEmailConfirmed";
            tgBtnEmailConfirmed.OffBackColor = System.Drawing.Color.Gray;
            tgBtnEmailConfirmed.OffToggleColor = System.Drawing.Color.Gainsboro;
            tgBtnEmailConfirmed.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tgBtnEmailConfirmed.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tgBtnEmailConfirmed.Size = new System.Drawing.Size(55, 22);
            tgBtnEmailConfirmed.TabIndex = 8;
            tgBtnEmailConfirmed.Text = "toggleButton1";
            tgBtnEmailConfirmed.UseVisualStyleBackColor = true;
            tgBtnEmailConfirmed.CheckedChanged += toggleButton1_CheckedChanged;
            // 
            // lblMailConfirmNo
            // 
            lblMailConfirmNo.AutoSize = true;
            lblMailConfirmNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMailConfirmNo.ForeColor = System.Drawing.Color.White;
            lblMailConfirmNo.Location = new System.Drawing.Point(455, 228);
            lblMailConfirmNo.Name = "lblMailConfirmNo";
            lblMailConfirmNo.Size = new System.Drawing.Size(31, 21);
            lblMailConfirmNo.TabIndex = 9;
            lblMailConfirmNo.Text = "No";
            // 
            // lblConfirmMailSi
            // 
            lblConfirmMailSi.AutoSize = true;
            lblConfirmMailSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblConfirmMailSi.ForeColor = System.Drawing.Color.White;
            lblConfirmMailSi.Location = new System.Drawing.Point(537, 229);
            lblConfirmMailSi.Name = "lblConfirmMailSi";
            lblConfirmMailSi.Size = new System.Drawing.Size(23, 21);
            lblConfirmMailSi.TabIndex = 10;
            lblConfirmMailSi.Text = "Si";
            // 
            // tgBtnMinuscula
            // 
            tgBtnMinuscula.Checked = true;
            tgBtnMinuscula.CheckState = System.Windows.Forms.CheckState.Checked;
            tgBtnMinuscula.Location = new System.Drawing.Point(793, 185);
            tgBtnMinuscula.MinimumSize = new System.Drawing.Size(45, 22);
            tgBtnMinuscula.Name = "tgBtnMinuscula";
            tgBtnMinuscula.OffBackColor = System.Drawing.Color.Gray;
            tgBtnMinuscula.OffToggleColor = System.Drawing.Color.Gainsboro;
            tgBtnMinuscula.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tgBtnMinuscula.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tgBtnMinuscula.Size = new System.Drawing.Size(55, 22);
            tgBtnMinuscula.TabIndex = 12;
            tgBtnMinuscula.Text = "toggleButton2";
            tgBtnMinuscula.UseVisualStyleBackColor = true;
            // 
            // lblMinusculaSi
            // 
            lblMinusculaSi.AutoSize = true;
            lblMinusculaSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMinusculaSi.ForeColor = System.Drawing.Color.White;
            lblMinusculaSi.Location = new System.Drawing.Point(847, 185);
            lblMinusculaSi.Name = "lblMinusculaSi";
            lblMinusculaSi.Size = new System.Drawing.Size(23, 21);
            lblMinusculaSi.TabIndex = 14;
            lblMinusculaSi.Text = "Si";
            // 
            // lblMinusculaNo
            // 
            lblMinusculaNo.AutoSize = true;
            lblMinusculaNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMinusculaNo.ForeColor = System.Drawing.Color.White;
            lblMinusculaNo.Location = new System.Drawing.Point(765, 184);
            lblMinusculaNo.Name = "lblMinusculaNo";
            lblMinusculaNo.Size = new System.Drawing.Size(31, 21);
            lblMinusculaNo.TabIndex = 13;
            lblMinusculaNo.Text = "No";
            // 
            // lblMinuscula
            // 
            lblMinuscula.AutoSize = true;
            lblMinuscula.ForeColor = System.Drawing.Color.White;
            lblMinuscula.Location = new System.Drawing.Point(587, 187);
            lblMinuscula.Name = "lblMinuscula";
            lblMinuscula.Size = new System.Drawing.Size(158, 15);
            lblMinuscula.TabIndex = 11;
            lblMinuscula.Text = "Requiere de letra minúscula?";
            // 
            // tgBtnMayus
            // 
            tgBtnMayus.Checked = true;
            tgBtnMayus.CheckState = System.Windows.Forms.CheckState.Checked;
            tgBtnMayus.Location = new System.Drawing.Point(793, 221);
            tgBtnMayus.MinimumSize = new System.Drawing.Size(45, 22);
            tgBtnMayus.Name = "tgBtnMayus";
            tgBtnMayus.OffBackColor = System.Drawing.Color.Gray;
            tgBtnMayus.OffToggleColor = System.Drawing.Color.Gainsboro;
            tgBtnMayus.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tgBtnMayus.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tgBtnMayus.Size = new System.Drawing.Size(55, 22);
            tgBtnMayus.TabIndex = 16;
            tgBtnMayus.Text = "toggleButton2";
            tgBtnMayus.UseVisualStyleBackColor = true;
            // 
            // lblMayusSi
            // 
            lblMayusSi.AutoSize = true;
            lblMayusSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMayusSi.ForeColor = System.Drawing.Color.White;
            lblMayusSi.Location = new System.Drawing.Point(847, 221);
            lblMayusSi.Name = "lblMayusSi";
            lblMayusSi.Size = new System.Drawing.Size(23, 21);
            lblMayusSi.TabIndex = 18;
            lblMayusSi.Text = "Si";
            // 
            // lblMayusNo
            // 
            lblMayusNo.AutoSize = true;
            lblMayusNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMayusNo.ForeColor = System.Drawing.Color.White;
            lblMayusNo.Location = new System.Drawing.Point(765, 220);
            lblMayusNo.Name = "lblMayusNo";
            lblMayusNo.Size = new System.Drawing.Size(31, 21);
            lblMayusNo.TabIndex = 17;
            lblMayusNo.Text = "No";
            // 
            // lblMayuscula
            // 
            lblMayuscula.AutoSize = true;
            lblMayuscula.ForeColor = System.Drawing.Color.White;
            lblMayuscula.Location = new System.Drawing.Point(587, 223);
            lblMayuscula.Name = "lblMayuscula";
            lblMayuscula.Size = new System.Drawing.Size(160, 15);
            lblMayuscula.TabIndex = 15;
            lblMayuscula.Text = "Requiere de letra mayúscula?";
            // 
            // tgBtnNumero
            // 
            tgBtnNumero.Checked = true;
            tgBtnNumero.CheckState = System.Windows.Forms.CheckState.Checked;
            tgBtnNumero.Location = new System.Drawing.Point(793, 256);
            tgBtnNumero.MinimumSize = new System.Drawing.Size(45, 22);
            tgBtnNumero.Name = "tgBtnNumero";
            tgBtnNumero.OffBackColor = System.Drawing.Color.Gray;
            tgBtnNumero.OffToggleColor = System.Drawing.Color.Gainsboro;
            tgBtnNumero.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tgBtnNumero.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tgBtnNumero.Size = new System.Drawing.Size(55, 22);
            tgBtnNumero.TabIndex = 20;
            tgBtnNumero.Text = "toggleButton2";
            tgBtnNumero.UseVisualStyleBackColor = true;
            // 
            // lblNumeroSi
            // 
            lblNumeroSi.AutoSize = true;
            lblNumeroSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumeroSi.ForeColor = System.Drawing.Color.White;
            lblNumeroSi.Location = new System.Drawing.Point(847, 256);
            lblNumeroSi.Name = "lblNumeroSi";
            lblNumeroSi.Size = new System.Drawing.Size(23, 21);
            lblNumeroSi.TabIndex = 22;
            lblNumeroSi.Text = "Si";
            // 
            // lblNumeroNo
            // 
            lblNumeroNo.AutoSize = true;
            lblNumeroNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumeroNo.ForeColor = System.Drawing.Color.White;
            lblNumeroNo.Location = new System.Drawing.Point(765, 255);
            lblNumeroNo.Name = "lblNumeroNo";
            lblNumeroNo.Size = new System.Drawing.Size(31, 21);
            lblNumeroNo.TabIndex = 21;
            lblNumeroNo.Text = "No";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.ForeColor = System.Drawing.Color.White;
            lblNumero.Location = new System.Drawing.Point(587, 258);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(136, 15);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Requiere de un número?";
            // 
            // tgBtnEspecial
            // 
            tgBtnEspecial.Checked = true;
            tgBtnEspecial.CheckState = System.Windows.Forms.CheckState.Checked;
            tgBtnEspecial.Location = new System.Drawing.Point(793, 291);
            tgBtnEspecial.MinimumSize = new System.Drawing.Size(45, 22);
            tgBtnEspecial.Name = "tgBtnEspecial";
            tgBtnEspecial.OffBackColor = System.Drawing.Color.Gray;
            tgBtnEspecial.OffToggleColor = System.Drawing.Color.Gainsboro;
            tgBtnEspecial.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tgBtnEspecial.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tgBtnEspecial.Size = new System.Drawing.Size(55, 22);
            tgBtnEspecial.TabIndex = 24;
            tgBtnEspecial.Text = "toggleButton2";
            tgBtnEspecial.UseVisualStyleBackColor = true;
            // 
            // lblEspecialSi
            // 
            lblEspecialSi.AutoSize = true;
            lblEspecialSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEspecialSi.ForeColor = System.Drawing.Color.White;
            lblEspecialSi.Location = new System.Drawing.Point(847, 291);
            lblEspecialSi.Name = "lblEspecialSi";
            lblEspecialSi.Size = new System.Drawing.Size(23, 21);
            lblEspecialSi.TabIndex = 26;
            lblEspecialSi.Text = "Si";
            // 
            // lblespecialNo
            // 
            lblespecialNo.AutoSize = true;
            lblespecialNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblespecialNo.ForeColor = System.Drawing.Color.White;
            lblespecialNo.Location = new System.Drawing.Point(765, 290);
            lblespecialNo.Name = "lblespecialNo";
            lblespecialNo.Size = new System.Drawing.Size(31, 21);
            lblespecialNo.TabIndex = 25;
            lblespecialNo.Text = "No";
            // 
            // lblEspecial
            // 
            lblEspecial.AutoSize = true;
            lblEspecial.ForeColor = System.Drawing.Color.White;
            lblEspecial.Location = new System.Drawing.Point(586, 294);
            lblEspecial.Name = "lblEspecial";
            lblEspecial.Size = new System.Drawing.Size(181, 15);
            lblEspecial.TabIndex = 23;
            lblEspecial.Text = "Requiere de un carácter especial?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(617, 135);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(240, 25);
            label2.TabIndex = 27;
            label2.Text = "Preferencias en contraseña";
            // 
            // lblCaracMinimo
            // 
            lblCaracMinimo.AutoSize = true;
            lblCaracMinimo.ForeColor = System.Drawing.Color.White;
            lblCaracMinimo.Location = new System.Drawing.Point(586, 330);
            lblCaracMinimo.Name = "lblCaracMinimo";
            lblCaracMinimo.Size = new System.Drawing.Size(171, 15);
            lblCaracMinimo.TabIndex = 28;
            lblCaracMinimo.Text = "Cantidad minima de caracteres";
            // 
            // txtCarMinimo
            // 
            txtCarMinimo.BackColor = System.Drawing.Color.Transparent;
            txtCarMinimo.Br = System.Drawing.Color.MidnightBlue;
            txtCarMinimo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCarMinimo.ForeColor = System.Drawing.Color.White;
            txtCarMinimo.Location = new System.Drawing.Point(766, 323);
            txtCarMinimo.Name = "txtCarMinimo";
            txtCarMinimo.Size = new System.Drawing.Size(51, 29);
            txtCarMinimo.TabIndex = 29;
            txtCarMinimo.TextChanged += txtCarMinimo_TextChanged;
            // 
            // btnSavePrefPW
            // 
            btnSavePrefPW.FlatAppearance.BorderSize = 0;
            btnSavePrefPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSavePrefPW.ForeColor = System.Drawing.Color.White;
            btnSavePrefPW.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSavePrefPW.IconColor = System.Drawing.Color.White;
            btnSavePrefPW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSavePrefPW.IconSize = 35;
            btnSavePrefPW.Location = new System.Drawing.Point(670, 369);
            btnSavePrefPW.Name = "btnSavePrefPW";
            btnSavePrefPW.Size = new System.Drawing.Size(101, 42);
            btnSavePrefPW.TabIndex = 30;
            btnSavePrefPW.Text = "Guardar";
            btnSavePrefPW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSavePrefPW.UseVisualStyleBackColor = true;
            btnSavePrefPW.Click += btnSavePrefPW_Click;
            // 
            // btnSavePrefAuth
            // 
            btnSavePrefAuth.FlatAppearance.BorderSize = 0;
            btnSavePrefAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSavePrefAuth.ForeColor = System.Drawing.Color.White;
            btnSavePrefAuth.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSavePrefAuth.IconColor = System.Drawing.Color.White;
            btnSavePrefAuth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSavePrefAuth.IconSize = 35;
            btnSavePrefAuth.Location = new System.Drawing.Point(362, 261);
            btnSavePrefAuth.Name = "btnSavePrefAuth";
            btnSavePrefAuth.Size = new System.Drawing.Size(101, 42);
            btnSavePrefAuth.TabIndex = 31;
            btnSavePrefAuth.Text = "Guardar";
            btnSavePrefAuth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSavePrefAuth.UseVisualStyleBackColor = true;
            btnSavePrefAuth.Click += btnSavePrefAuth_Click;
            // 
            // lblAuth
            // 
            lblAuth.AutoSize = true;
            lblAuth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAuth.ForeColor = System.Drawing.Color.White;
            lblAuth.Location = new System.Drawing.Point(283, 135);
            lblAuth.Name = "lblAuth";
            lblAuth.Size = new System.Drawing.Size(272, 25);
            lblAuth.TabIndex = 32;
            lblAuth.Text = "Preferencias en authenticación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(18, 135);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(144, 25);
            label3.TabIndex = 33;
            label3.Text = "Personalización";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(18, 246);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(34, 15);
            lblLogo.TabIndex = 34;
            lblLogo.Text = "Logo";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.ForeColor = System.Drawing.Color.White;
            lblColor.Location = new System.Drawing.Point(21, 200);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(36, 15);
            lblColor.TabIndex = 35;
            lblColor.Text = "Color";
            lblColor.Click += lblColor_Click;
            // 
            // btnChangeColor
            // 
            btnChangeColor.FlatAppearance.BorderSize = 0;
            btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChangeColor.ForeColor = System.Drawing.Color.White;
            btnChangeColor.IconChar = FontAwesome.Sharp.IconChar.Palette;
            btnChangeColor.IconColor = System.Drawing.Color.Red;
            btnChangeColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChangeColor.IconSize = 40;
            btnChangeColor.Location = new System.Drawing.Point(151, 194);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new System.Drawing.Size(34, 37);
            btnChangeColor.TabIndex = 36;
            btnChangeColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // txtColor
            // 
            txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtColor.Location = new System.Drawing.Point(66, 200);
            txtColor.Name = "txtColor";
            txtColor.ReadOnly = true;
            txtColor.Size = new System.Drawing.Size(80, 16);
            txtColor.TabIndex = 37;
            txtColor.TextChanged += txtColor_TextChanged;
            // 
            // pboxLogo
            // 
            pboxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pboxLogo.Location = new System.Drawing.Point(66, 246);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new System.Drawing.Size(154, 130);
            pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pboxLogo.TabIndex = 38;
            pboxLogo.TabStop = false;
            // 
            // btnLogo
            // 
            btnLogo.FlatAppearance.BorderSize = 0;
            btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogo.ForeColor = System.Drawing.Color.White;
            btnLogo.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnLogo.IconColor = System.Drawing.Color.White;
            btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogo.IconSize = 45;
            btnLogo.Location = new System.Drawing.Point(66, 381);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new System.Drawing.Size(154, 42);
            btnLogo.TabIndex = 39;
            btnLogo.Text = "Cargar Imagen";
            btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogo.UseVisualStyleBackColor = true;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnSavePersonalization
            // 
            btnSavePersonalization.FlatAppearance.BorderSize = 0;
            btnSavePersonalization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSavePersonalization.ForeColor = System.Drawing.Color.White;
            btnSavePersonalization.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSavePersonalization.IconColor = System.Drawing.Color.White;
            btnSavePersonalization.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSavePersonalization.IconSize = 35;
            btnSavePersonalization.Location = new System.Drawing.Point(45, 447);
            btnSavePersonalization.Name = "btnSavePersonalization";
            btnSavePersonalization.Size = new System.Drawing.Size(101, 42);
            btnSavePersonalization.TabIndex = 40;
            btnSavePersonalization.Text = "Guardar";
            btnSavePersonalization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSavePersonalization.UseVisualStyleBackColor = true;
            btnSavePersonalization.Click += btnSavePersonalization_Click;
            // 
            // FmCompanyConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            ClientSize = new System.Drawing.Size(877, 508);
            Controls.Add(txtMaxFail);
            Controls.Add(btnSavePersonalization);
            Controls.Add(btnLogo);
            Controls.Add(pboxLogo);
            Controls.Add(txtColor);
            Controls.Add(btnChangeColor);
            Controls.Add(lblColor);
            Controls.Add(lblLogo);
            Controls.Add(label3);
            Controls.Add(lblAuth);
            Controls.Add(btnSavePrefAuth);
            Controls.Add(btnSavePrefPW);
            Controls.Add(txtCarMinimo);
            Controls.Add(lblCaracMinimo);
            Controls.Add(label2);
            Controls.Add(tgBtnEspecial);
            Controls.Add(lblEspecialSi);
            Controls.Add(lblespecialNo);
            Controls.Add(lblEspecial);
            Controls.Add(tgBtnNumero);
            Controls.Add(lblNumeroSi);
            Controls.Add(lblNumeroNo);
            Controls.Add(lblNumero);
            Controls.Add(tgBtnMayus);
            Controls.Add(lblMayusSi);
            Controls.Add(lblMayusNo);
            Controls.Add(lblMayuscula);
            Controls.Add(tgBtnMinuscula);
            Controls.Add(lblMinusculaSi);
            Controls.Add(lblMinusculaNo);
            Controls.Add(lblMinuscula);
            Controls.Add(tgBtnEmailConfirmed);
            Controls.Add(lblConfirmMailSi);
            Controls.Add(lblMailConfirmNo);
            Controls.Add(label1);
            Controls.Add(lblCompanyTitle);
            Controls.Add(lblMaxFail);
            Name = "FmCompanyConfig";
            Text = "FmCompanyConfig";
            Load += FmCompanyConfig_Load;
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
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