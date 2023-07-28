namespace UI.TextilSoft.SubForms.Produccion.ABM_Productos
{
    partial class FmCrearProducto
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
            lblCantidad = new System.Windows.Forms.Label();
            lblPrincipal = new System.Windows.Forms.Label();
            btnCrearProducto = new FontAwesome.Sharp.IconButton();
            txtCantidad = new AltoControls.AltoTextBox();
            btnSumar = new FontAwesome.Sharp.IconButton();
            btnRestar = new FontAwesome.Sharp.IconButton();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            txtColor = new System.Windows.Forms.TextBox();
            btnChangeColor = new FontAwesome.Sharp.IconButton();
            lblColor = new System.Windows.Forms.Label();
            cboxTalles = new Tools.FormsTools.FmCombobox();
            pBoxImagenPrenda = new System.Windows.Forms.PictureBox();
            lblImagen = new System.Windows.Forms.Label();
            lblLazo = new System.Windows.Forms.Label();
            lblVivo = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblBolsilloInterior = new System.Windows.Forms.Label();
            txtDesc = new AltoControls.AltoTextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            lblComposicion = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblTelaBase = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtPrecio = new AltoControls.AltoTextBox();
            lblTransfer = new System.Windows.Forms.Label();
            lblTipoProducto = new System.Windows.Forms.Label();
            fmCboxTelaCombinacion = new Tools.FormsTools.FmCombobox();
            fmCboxTransfer = new Tools.FormsTools.FmCombobox();
            fmCboxTipoProducto = new Tools.FormsTools.FmCombobox();
            fmCboxLazo = new Tools.FormsTools.FmCombobox();
            fmCboxTelaBase = new Tools.FormsTools.FmCombobox();
            fmCboxVivo = new Tools.FormsTools.FmCombobox();
            fmCboxBolsilloInt = new Tools.FormsTools.FmCombobox();
            altoTextBox1 = new AltoControls.AltoTextBox();
            btnImagenPrenda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pBoxImagenPrenda).BeginInit();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(315, 351);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(58, 15);
            lblCantidad.TabIndex = 31;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(274, 43);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(173, 32);
            lblPrincipal.TabIndex = 32;
            lblPrincipal.Text = "Crear Producto";
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.FlatAppearance.BorderSize = 0;
            btnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCrearProducto.ForeColor = System.Drawing.Color.White;
            btnCrearProducto.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnCrearProducto.IconColor = System.Drawing.Color.White;
            btnCrearProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearProducto.IconSize = 35;
            btnCrearProducto.Location = new System.Drawing.Point(307, 407);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new System.Drawing.Size(123, 46);
            btnCrearProducto.TabIndex = 33;
            btnCrearProducto.Text = "Guardar";
            btnCrearProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCrearProducto.UseVisualStyleBackColor = true;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(378, 344);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(69, 29);
            txtCantidad.TabIndex = 34;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // btnSumar
            // 
            btnSumar.FlatAppearance.BorderSize = 0;
            btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSumar.ForeColor = System.Drawing.Color.White;
            btnSumar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnSumar.IconColor = System.Drawing.Color.White;
            btnSumar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSumar.IconSize = 30;
            btnSumar.Location = new System.Drawing.Point(447, 349);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new System.Drawing.Size(28, 28);
            btnSumar.TabIndex = 35;
            btnSumar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.FlatAppearance.BorderSize = 0;
            btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRestar.ForeColor = System.Drawing.Color.White;
            btnRestar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnRestar.IconColor = System.Drawing.Color.White;
            btnRestar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestar.IconSize = 30;
            btnRestar.Location = new System.Drawing.Point(476, 348);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new System.Drawing.Size(28, 28);
            btnRestar.TabIndex = 36;
            btnRestar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // txtColor
            // 
            txtColor.BackColor = System.Drawing.Color.White;
            txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtColor.Location = new System.Drawing.Point(148, 311);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.ReadOnly = true;
            txtColor.Size = new System.Drawing.Size(125, 23);
            txtColor.TabIndex = 40;
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
            btnChangeColor.Location = new System.Drawing.Point(272, 307);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new System.Drawing.Size(34, 37);
            btnChangeColor.TabIndex = 39;
            btnChangeColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.ForeColor = System.Drawing.Color.White;
            lblColor.Location = new System.Drawing.Point(100, 314);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(39, 15);
            lblColor.TabIndex = 38;
            lblColor.Text = "Color:";
            // 
            // cboxTalles
            // 
            cboxTalles.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxTalles.BorderColor = System.Drawing.Color.MediumSlateBlue;
            cboxTalles.BorderSize = 0;
            cboxTalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboxTalles.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboxTalles.ForeColor = System.Drawing.Color.DimGray;
            cboxTalles.IconColor = System.Drawing.Color.MediumSlateBlue;
            cboxTalles.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            cboxTalles.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            cboxTalles.ListTextColor = System.Drawing.Color.DimGray;
            cboxTalles.Location = new System.Drawing.Point(378, 243);
            cboxTalles.Name = "cboxTalles";
            cboxTalles.Size = new System.Drawing.Size(126, 20);
            cboxTalles.TabIndex = 41;
            cboxTalles.Texts = "";
            // 
            // pBoxImagenPrenda
            // 
            pBoxImagenPrenda.Location = new System.Drawing.Point(541, 140);
            pBoxImagenPrenda.Name = "pBoxImagenPrenda";
            pBoxImagenPrenda.Size = new System.Drawing.Size(254, 233);
            pBoxImagenPrenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxImagenPrenda.TabIndex = 107;
            pBoxImagenPrenda.TabStop = false;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.ForeColor = System.Drawing.Color.White;
            lblImagen.Location = new System.Drawing.Point(615, 122);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new System.Drawing.Size(87, 15);
            lblImagen.TabIndex = 106;
            lblImagen.Text = "Imagen Prenda";
            // 
            // lblLazo
            // 
            lblLazo.AutoSize = true;
            lblLazo.ForeColor = System.Drawing.Color.White;
            lblLazo.Location = new System.Drawing.Point(339, 210);
            lblLazo.Name = "lblLazo";
            lblLazo.Size = new System.Drawing.Size(34, 15);
            lblLazo.TabIndex = 104;
            lblLazo.Text = "Lazo:";
            // 
            // lblVivo
            // 
            lblVivo.AutoSize = true;
            lblVivo.ForeColor = System.Drawing.Color.White;
            lblVivo.Location = new System.Drawing.Point(339, 175);
            lblVivo.Name = "lblVivo";
            lblVivo.Size = new System.Drawing.Size(33, 15);
            lblVivo.TabIndex = 102;
            lblVivo.Text = "Vivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(34, 282);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 15);
            label2.TabIndex = 100;
            label2.Text = "Tela Combinación:";
            // 
            // lblBolsilloInterior
            // 
            lblBolsilloInterior.AutoSize = true;
            lblBolsilloInterior.ForeColor = System.Drawing.Color.White;
            lblBolsilloInterior.Location = new System.Drawing.Point(307, 139);
            lblBolsilloInterior.Name = "lblBolsilloInterior";
            lblBolsilloInterior.Size = new System.Drawing.Size(65, 15);
            lblBolsilloInterior.TabIndex = 98;
            lblBolsilloInterior.Text = "Bolsillo Int:";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = System.Drawing.Color.Transparent;
            txtDesc.Br = System.Drawing.Color.MidnightBlue;
            txtDesc.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDesc.ForeColor = System.Drawing.Color.White;
            txtDesc.Location = new System.Drawing.Point(151, 133);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new System.Drawing.Size(123, 29);
            txtDesc.TabIndex = 96;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(69, 139);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(72, 15);
            lblDescripcion.TabIndex = 95;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblComposicion
            // 
            lblComposicion.AutoSize = true;
            lblComposicion.ForeColor = System.Drawing.Color.White;
            lblComposicion.Location = new System.Drawing.Point(58, 174);
            lblComposicion.Name = "lblComposicion";
            lblComposicion.Size = new System.Drawing.Size(81, 15);
            lblComposicion.TabIndex = 90;
            lblComposicion.Text = "Composicion:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.White;
            lblPrecio.Location = new System.Drawing.Point(327, 315);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(43, 15);
            lblPrecio.TabIndex = 89;
            lblPrecio.Text = "Precio:";
            // 
            // lblTelaBase
            // 
            lblTelaBase.AutoSize = true;
            lblTelaBase.ForeColor = System.Drawing.Color.White;
            lblTelaBase.Location = new System.Drawing.Point(85, 245);
            lblTelaBase.Name = "lblTelaBase";
            lblTelaBase.Size = new System.Drawing.Size(57, 15);
            lblTelaBase.TabIndex = 88;
            lblTelaBase.Text = "Tela Base:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(339, 243);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 87;
            label3.Text = "Talle:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = System.Drawing.Color.Transparent;
            txtPrecio.Br = System.Drawing.Color.MidnightBlue;
            txtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPrecio.ForeColor = System.Drawing.Color.White;
            txtPrecio.Location = new System.Drawing.Point(378, 309);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(126, 29);
            txtPrecio.TabIndex = 86;
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.ForeColor = System.Drawing.Color.White;
            lblTransfer.Location = new System.Drawing.Point(318, 279);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new System.Drawing.Size(51, 15);
            lblTransfer.TabIndex = 82;
            lblTransfer.Text = "Transfer:";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.ForeColor = System.Drawing.Color.White;
            lblTipoProducto.Location = new System.Drawing.Point(39, 207);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new System.Drawing.Size(101, 15);
            lblTipoProducto.TabIndex = 81;
            lblTipoProducto.Text = "Tipo de Producto:";
            // 
            // fmCboxTelaCombinacion
            // 
            fmCboxTelaCombinacion.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTelaCombinacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTelaCombinacion.BorderSize = 0;
            fmCboxTelaCombinacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTelaCombinacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTelaCombinacion.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTelaCombinacion.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTelaCombinacion.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxTelaCombinacion.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTelaCombinacion.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTelaCombinacion.Location = new System.Drawing.Point(148, 277);
            fmCboxTelaCombinacion.Name = "fmCboxTelaCombinacion";
            fmCboxTelaCombinacion.Size = new System.Drawing.Size(126, 20);
            fmCboxTelaCombinacion.TabIndex = 108;
            fmCboxTelaCombinacion.Texts = "";
            // 
            // fmCboxTransfer
            // 
            fmCboxTransfer.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTransfer.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTransfer.BorderSize = 0;
            fmCboxTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTransfer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTransfer.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTransfer.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTransfer.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxTransfer.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTransfer.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTransfer.Location = new System.Drawing.Point(378, 277);
            fmCboxTransfer.Name = "fmCboxTransfer";
            fmCboxTransfer.Size = new System.Drawing.Size(126, 20);
            fmCboxTransfer.TabIndex = 110;
            fmCboxTransfer.Texts = "";
            // 
            // fmCboxTipoProducto
            // 
            fmCboxTipoProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTipoProducto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoProducto.BorderSize = 0;
            fmCboxTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTipoProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTipoProducto.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTipoProducto.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoProducto.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxTipoProducto.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTipoProducto.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTipoProducto.Location = new System.Drawing.Point(148, 207);
            fmCboxTipoProducto.Name = "fmCboxTipoProducto";
            fmCboxTipoProducto.Size = new System.Drawing.Size(126, 20);
            fmCboxTipoProducto.TabIndex = 111;
            fmCboxTipoProducto.Texts = "";
            // 
            // fmCboxLazo
            // 
            fmCboxLazo.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxLazo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxLazo.BorderSize = 0;
            fmCboxLazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxLazo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxLazo.ForeColor = System.Drawing.Color.DimGray;
            fmCboxLazo.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxLazo.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxLazo.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxLazo.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxLazo.Location = new System.Drawing.Point(379, 210);
            fmCboxLazo.Name = "fmCboxLazo";
            fmCboxLazo.Size = new System.Drawing.Size(126, 20);
            fmCboxLazo.TabIndex = 112;
            fmCboxLazo.Texts = "";
            // 
            // fmCboxTelaBase
            // 
            fmCboxTelaBase.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTelaBase.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTelaBase.BorderSize = 0;
            fmCboxTelaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTelaBase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTelaBase.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTelaBase.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTelaBase.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxTelaBase.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTelaBase.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTelaBase.Location = new System.Drawing.Point(148, 243);
            fmCboxTelaBase.Name = "fmCboxTelaBase";
            fmCboxTelaBase.Size = new System.Drawing.Size(126, 20);
            fmCboxTelaBase.TabIndex = 113;
            fmCboxTelaBase.Texts = "";
            // 
            // fmCboxVivo
            // 
            fmCboxVivo.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxVivo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxVivo.BorderSize = 0;
            fmCboxVivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxVivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxVivo.ForeColor = System.Drawing.Color.DimGray;
            fmCboxVivo.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxVivo.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxVivo.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxVivo.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxVivo.Location = new System.Drawing.Point(379, 175);
            fmCboxVivo.Name = "fmCboxVivo";
            fmCboxVivo.Size = new System.Drawing.Size(126, 20);
            fmCboxVivo.TabIndex = 114;
            fmCboxVivo.Texts = "";
            // 
            // fmCboxBolsilloInt
            // 
            fmCboxBolsilloInt.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxBolsilloInt.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxBolsilloInt.BorderSize = 0;
            fmCboxBolsilloInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxBolsilloInt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxBolsilloInt.ForeColor = System.Drawing.Color.DimGray;
            fmCboxBolsilloInt.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxBolsilloInt.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxBolsilloInt.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxBolsilloInt.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxBolsilloInt.Location = new System.Drawing.Point(379, 139);
            fmCboxBolsilloInt.Name = "fmCboxBolsilloInt";
            fmCboxBolsilloInt.Size = new System.Drawing.Size(126, 20);
            fmCboxBolsilloInt.TabIndex = 115;
            fmCboxBolsilloInt.Texts = "";
            // 
            // altoTextBox1
            // 
            altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            altoTextBox1.Br = System.Drawing.Color.MidnightBlue;
            altoTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            altoTextBox1.ForeColor = System.Drawing.Color.White;
            altoTextBox1.Location = new System.Drawing.Point(151, 168);
            altoTextBox1.Name = "altoTextBox1";
            altoTextBox1.Size = new System.Drawing.Size(122, 29);
            altoTextBox1.TabIndex = 116;
            // 
            // btnImagenPrenda
            // 
            btnImagenPrenda.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImagenPrenda.FlatAppearance.BorderSize = 0;
            btnImagenPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImagenPrenda.ForeColor = System.Drawing.Color.White;
            btnImagenPrenda.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnImagenPrenda.IconColor = System.Drawing.Color.White;
            btnImagenPrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImagenPrenda.IconSize = 45;
            btnImagenPrenda.Location = new System.Drawing.Point(592, 379);
            btnImagenPrenda.Name = "btnImagenPrenda";
            btnImagenPrenda.Size = new System.Drawing.Size(154, 42);
            btnImagenPrenda.TabIndex = 117;
            btnImagenPrenda.Text = "Cargar Imagen";
            btnImagenPrenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnImagenPrenda.UseVisualStyleBackColor = true;
            btnImagenPrenda.Click += btnImagenPrenda_Click;
            // 
            // FmCrearProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(831, 465);
            Controls.Add(btnImagenPrenda);
            Controls.Add(altoTextBox1);
            Controls.Add(fmCboxBolsilloInt);
            Controls.Add(fmCboxVivo);
            Controls.Add(fmCboxTelaBase);
            Controls.Add(fmCboxLazo);
            Controls.Add(fmCboxTipoProducto);
            Controls.Add(fmCboxTransfer);
            Controls.Add(fmCboxTelaCombinacion);
            Controls.Add(pBoxImagenPrenda);
            Controls.Add(lblImagen);
            Controls.Add(lblLazo);
            Controls.Add(lblVivo);
            Controls.Add(label2);
            Controls.Add(lblBolsilloInterior);
            Controls.Add(txtDesc);
            Controls.Add(lblDescripcion);
            Controls.Add(lblComposicion);
            Controls.Add(lblPrecio);
            Controls.Add(lblTelaBase);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(lblTransfer);
            Controls.Add(lblTipoProducto);
            Controls.Add(cboxTalles);
            Controls.Add(txtColor);
            Controls.Add(btnChangeColor);
            Controls.Add(lblColor);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtCantidad);
            Controls.Add(btnCrearProducto);
            Controls.Add(lblPrincipal);
            Controls.Add(lblCantidad);
            Name = "FmCrearProducto";
            Text = "FmCrearProducto";
            Load += FmCrearProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxImagenPrenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrincipal;
        private FontAwesome.Sharp.IconButton btnCrearProducto;
        private AltoControls.AltoTextBox txtCantidad;
        private FontAwesome.Sharp.IconButton btnSumar;
        private FontAwesome.Sharp.IconButton btnRestar;
        private System.Windows.Forms.ToolTip toolTipError;
        private System.Windows.Forms.TextBox txtColor;
        private FontAwesome.Sharp.IconButton btnChangeColor;
        private System.Windows.Forms.Label lblColor;
        private Tools.FormsTools.FmCombobox cboxTalles;
        private System.Windows.Forms.PictureBox pBoxImagenPrenda;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblLazo;
        private System.Windows.Forms.Label lblVivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBolsilloInterior;
        private AltoControls.AltoTextBox txtDesc;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblComposicion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTelaBase;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox txtPrecio;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Label lblTipoProducto;
        private Tools.FormsTools.FmCombobox fmCboxTelaCombinacion;
        private Tools.FormsTools.FmCombobox fmCboxTransfer;
        private Tools.FormsTools.FmCombobox fmCboxTipoProducto;
        private Tools.FormsTools.FmCombobox fmCboxLazo;
        private Tools.FormsTools.FmCombobox fmCboxTelaBase;
        private Tools.FormsTools.FmCombobox fmCboxVivo;
        private Tools.FormsTools.FmCombobox fmCboxBolsilloInt;
        private AltoControls.AltoTextBox altoTextBox1;
        private FontAwesome.Sharp.IconButton btnImagenPrenda;
    }
}