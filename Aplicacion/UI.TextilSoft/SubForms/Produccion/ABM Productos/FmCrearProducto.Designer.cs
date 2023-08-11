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
            lblTipoPrenda = new System.Windows.Forms.Label();
            fmCboxTelaCombinacion = new Tools.FormsTools.FmCombobox();
            fmCboxTipoPrenda = new Tools.FormsTools.FmCombobox();
            fmCboxLazo = new Tools.FormsTools.FmCombobox();
            fmCboxTelaBase = new Tools.FormsTools.FmCombobox();
            fmCboxVivo = new Tools.FormsTools.FmCombobox();
            fmCboxBolsilloInt = new Tools.FormsTools.FmCombobox();
            txtComposicion = new AltoControls.AltoTextBox();
            btnImagenPrenda = new FontAwesome.Sharp.IconButton();
            fmCboxCinturaInterior = new Tools.FormsTools.FmCombobox();
            lblCinturaInterior = new System.Windows.Forms.Label();
            fmCboxCollareta = new Tools.FormsTools.FmCombobox();
            lblCollareta = new System.Windows.Forms.Label();
            fmCboxForreria = new Tools.FormsTools.FmCombobox();
            lblForreria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pBoxImagenPrenda).BeginInit();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(358, 443);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 20);
            lblCantidad.TabIndex = 31;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(313, 57);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(218, 41);
            lblPrincipal.TabIndex = 32;
            lblPrincipal.Text = "Crear Producto";
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.FlatAppearance.BorderSize = 0;
            btnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCrearProducto.ForeColor = System.Drawing.Color.White;
            btnCrearProducto.IconChar = FontAwesome.Sharp.IconChar.Tshirt;
            btnCrearProducto.IconColor = System.Drawing.Color.White;
            btnCrearProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearProducto.IconSize = 35;
            btnCrearProducto.Location = new System.Drawing.Point(346, 500);
            btnCrearProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new System.Drawing.Size(141, 61);
            btnCrearProducto.TabIndex = 33;
            btnCrearProducto.Text = "Crear";
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
            txtCantidad.Location = new System.Drawing.Point(430, 434);
            txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(79, 39);
            txtCantidad.TabIndex = 34;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.Click += txtCantidad_Click;
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
            btnSumar.Location = new System.Drawing.Point(509, 440);
            btnSumar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new System.Drawing.Size(32, 37);
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
            btnRestar.Location = new System.Drawing.Point(542, 439);
            btnRestar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new System.Drawing.Size(32, 37);
            btnRestar.TabIndex = 36;
            btnRestar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // txtColor
            // 
            txtColor.BackColor = System.Drawing.Color.White;
            txtColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtColor.Location = new System.Drawing.Point(710, 84);
            txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.ReadOnly = true;
            txtColor.Size = new System.Drawing.Size(143, 31);
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
            btnChangeColor.Location = new System.Drawing.Point(852, 78);
            btnChangeColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new System.Drawing.Size(39, 49);
            btnChangeColor.TabIndex = 39;
            btnChangeColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.ForeColor = System.Drawing.Color.White;
            lblColor.Location = new System.Drawing.Point(655, 88);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(48, 20);
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
            cboxTalles.Location = new System.Drawing.Point(431, 349);
            cboxTalles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cboxTalles.Name = "cboxTalles";
            cboxTalles.Size = new System.Drawing.Size(144, 27);
            cboxTalles.TabIndex = 41;
            cboxTalles.Texts = "";
            // 
            // pBoxImagenPrenda
            // 
            pBoxImagenPrenda.Location = new System.Drawing.Point(618, 187);
            pBoxImagenPrenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pBoxImagenPrenda.Name = "pBoxImagenPrenda";
            pBoxImagenPrenda.Size = new System.Drawing.Size(290, 311);
            pBoxImagenPrenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxImagenPrenda.TabIndex = 107;
            pBoxImagenPrenda.TabStop = false;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.ForeColor = System.Drawing.Color.White;
            lblImagen.Location = new System.Drawing.Point(703, 163);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new System.Drawing.Size(109, 20);
            lblImagen.TabIndex = 106;
            lblImagen.Text = "Imagen Prenda";
            // 
            // lblLazo
            // 
            lblLazo.AutoSize = true;
            lblLazo.ForeColor = System.Drawing.Color.White;
            lblLazo.Location = new System.Drawing.Point(386, 262);
            lblLazo.Name = "lblLazo";
            lblLazo.Size = new System.Drawing.Size(43, 20);
            lblLazo.TabIndex = 104;
            lblLazo.Text = "Lazo:";
            // 
            // lblVivo
            // 
            lblVivo.AutoSize = true;
            lblVivo.ForeColor = System.Drawing.Color.White;
            lblVivo.Location = new System.Drawing.Point(388, 215);
            lblVivo.Name = "lblVivo";
            lblVivo.Size = new System.Drawing.Size(41, 20);
            lblVivo.TabIndex = 102;
            lblVivo.Text = "Vivo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(39, 356);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 20);
            label2.TabIndex = 100;
            label2.Text = "Tela Combinación:";
            // 
            // lblBolsilloInterior
            // 
            lblBolsilloInterior.AutoSize = true;
            lblBolsilloInterior.ForeColor = System.Drawing.Color.White;
            lblBolsilloInterior.Location = new System.Drawing.Point(87, 397);
            lblBolsilloInterior.Name = "lblBolsilloInterior";
            lblBolsilloInterior.Size = new System.Drawing.Size(82, 20);
            lblBolsilloInterior.TabIndex = 98;
            lblBolsilloInterior.Text = "Bolsillo Int:";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = System.Drawing.Color.Transparent;
            txtDesc.Br = System.Drawing.Color.MidnightBlue;
            txtDesc.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDesc.ForeColor = System.Drawing.Color.White;
            txtDesc.Location = new System.Drawing.Point(173, 168);
            txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new System.Drawing.Size(141, 39);
            txtDesc.TabIndex = 96;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(79, 176);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(90, 20);
            lblDescripcion.TabIndex = 95;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblComposicion
            // 
            lblComposicion.AutoSize = true;
            lblComposicion.ForeColor = System.Drawing.Color.White;
            lblComposicion.Location = new System.Drawing.Point(66, 223);
            lblComposicion.Name = "lblComposicion";
            lblComposicion.Size = new System.Drawing.Size(99, 20);
            lblComposicion.TabIndex = 90;
            lblComposicion.Text = "Composicion:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.White;
            lblPrecio.Location = new System.Drawing.Point(372, 395);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(53, 20);
            lblPrecio.TabIndex = 89;
            lblPrecio.Text = "Precio:";
            // 
            // lblTelaBase
            // 
            lblTelaBase.AutoSize = true;
            lblTelaBase.ForeColor = System.Drawing.Color.White;
            lblTelaBase.Location = new System.Drawing.Point(97, 313);
            lblTelaBase.Name = "lblTelaBase";
            lblTelaBase.Size = new System.Drawing.Size(74, 20);
            lblTelaBase.TabIndex = 88;
            lblTelaBase.Text = "Tela Base:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(386, 349);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 20);
            label3.TabIndex = 87;
            label3.Text = "Talle:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = System.Drawing.Color.Transparent;
            txtPrecio.Br = System.Drawing.Color.MidnightBlue;
            txtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPrecio.ForeColor = System.Drawing.Color.White;
            txtPrecio.Location = new System.Drawing.Point(430, 387);
            txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(144, 39);
            txtPrecio.TabIndex = 86;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // lblTipoPrenda
            // 
            lblTipoPrenda.AutoSize = true;
            lblTipoPrenda.ForeColor = System.Drawing.Color.White;
            lblTipoPrenda.Location = new System.Drawing.Point(57, 267);
            lblTipoPrenda.Name = "lblTipoPrenda";
            lblTipoPrenda.Size = new System.Drawing.Size(113, 20);
            lblTipoPrenda.TabIndex = 81;
            lblTipoPrenda.Text = "Tipo de Prenda:";
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
            fmCboxTelaCombinacion.Location = new System.Drawing.Point(169, 352);
            fmCboxTelaCombinacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxTelaCombinacion.Name = "fmCboxTelaCombinacion";
            fmCboxTelaCombinacion.Size = new System.Drawing.Size(144, 27);
            fmCboxTelaCombinacion.TabIndex = 108;
            fmCboxTelaCombinacion.Texts = "";
            // 
            // fmCboxTipoPrenda
            // 
            fmCboxTipoPrenda.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTipoPrenda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoPrenda.BorderSize = 0;
            fmCboxTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTipoPrenda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTipoPrenda.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTipoPrenda.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoPrenda.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxTipoPrenda.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTipoPrenda.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTipoPrenda.Location = new System.Drawing.Point(169, 267);
            fmCboxTipoPrenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxTipoPrenda.Name = "fmCboxTipoPrenda";
            fmCboxTipoPrenda.Size = new System.Drawing.Size(144, 27);
            fmCboxTipoPrenda.TabIndex = 111;
            fmCboxTipoPrenda.Texts = "";
            fmCboxTipoPrenda.OnSelectedIndexChanged += fmCboxTipoProducto_OnSelectedIndexChanged;
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
            fmCboxLazo.Location = new System.Drawing.Point(432, 262);
            fmCboxLazo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxLazo.Name = "fmCboxLazo";
            fmCboxLazo.Size = new System.Drawing.Size(144, 27);
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
            fmCboxTelaBase.Location = new System.Drawing.Point(169, 310);
            fmCboxTelaBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxTelaBase.Name = "fmCboxTelaBase";
            fmCboxTelaBase.Size = new System.Drawing.Size(144, 27);
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
            fmCboxVivo.Location = new System.Drawing.Point(432, 215);
            fmCboxVivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxVivo.Name = "fmCboxVivo";
            fmCboxVivo.Size = new System.Drawing.Size(144, 27);
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
            fmCboxBolsilloInt.Location = new System.Drawing.Point(169, 395);
            fmCboxBolsilloInt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxBolsilloInt.Name = "fmCboxBolsilloInt";
            fmCboxBolsilloInt.Size = new System.Drawing.Size(144, 27);
            fmCboxBolsilloInt.TabIndex = 115;
            fmCboxBolsilloInt.Texts = "";
            // 
            // txtComposicion
            // 
            txtComposicion.BackColor = System.Drawing.Color.Transparent;
            txtComposicion.Br = System.Drawing.Color.MidnightBlue;
            txtComposicion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtComposicion.ForeColor = System.Drawing.Color.White;
            txtComposicion.Location = new System.Drawing.Point(173, 215);
            txtComposicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtComposicion.Name = "txtComposicion";
            txtComposicion.Size = new System.Drawing.Size(141, 39);
            txtComposicion.TabIndex = 116;
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
            btnImagenPrenda.Location = new System.Drawing.Point(677, 505);
            btnImagenPrenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnImagenPrenda.Name = "btnImagenPrenda";
            btnImagenPrenda.Size = new System.Drawing.Size(176, 56);
            btnImagenPrenda.TabIndex = 117;
            btnImagenPrenda.Text = "Cargar Imagen";
            btnImagenPrenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnImagenPrenda.UseVisualStyleBackColor = true;
            btnImagenPrenda.Click += btnImagenPrenda_Click;
            // 
            // fmCboxCinturaInterior
            // 
            fmCboxCinturaInterior.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxCinturaInterior.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxCinturaInterior.BorderSize = 0;
            fmCboxCinturaInterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxCinturaInterior.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxCinturaInterior.ForeColor = System.Drawing.Color.DimGray;
            fmCboxCinturaInterior.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxCinturaInterior.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxCinturaInterior.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxCinturaInterior.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxCinturaInterior.Location = new System.Drawing.Point(169, 438);
            fmCboxCinturaInterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxCinturaInterior.Name = "fmCboxCinturaInterior";
            fmCboxCinturaInterior.Size = new System.Drawing.Size(144, 27);
            fmCboxCinturaInterior.TabIndex = 119;
            fmCboxCinturaInterior.Texts = "";
            // 
            // lblCinturaInterior
            // 
            lblCinturaInterior.AutoSize = true;
            lblCinturaInterior.ForeColor = System.Drawing.Color.White;
            lblCinturaInterior.Location = new System.Drawing.Point(58, 438);
            lblCinturaInterior.Name = "lblCinturaInterior";
            lblCinturaInterior.Size = new System.Drawing.Size(111, 20);
            lblCinturaInterior.TabIndex = 118;
            lblCinturaInterior.Text = "Cintura Interior:";
            // 
            // fmCboxCollareta
            // 
            fmCboxCollareta.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxCollareta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxCollareta.BorderSize = 0;
            fmCboxCollareta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxCollareta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxCollareta.ForeColor = System.Drawing.Color.DimGray;
            fmCboxCollareta.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxCollareta.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxCollareta.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxCollareta.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxCollareta.Location = new System.Drawing.Point(431, 169);
            fmCboxCollareta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxCollareta.Name = "fmCboxCollareta";
            fmCboxCollareta.Size = new System.Drawing.Size(144, 27);
            fmCboxCollareta.TabIndex = 121;
            fmCboxCollareta.Texts = "";
            // 
            // lblCollareta
            // 
            lblCollareta.AutoSize = true;
            lblCollareta.ForeColor = System.Drawing.Color.White;
            lblCollareta.Location = new System.Drawing.Point(357, 169);
            lblCollareta.Name = "lblCollareta";
            lblCollareta.Size = new System.Drawing.Size(72, 20);
            lblCollareta.TabIndex = 120;
            lblCollareta.Text = "Collareta:";
            // 
            // fmCboxForreria
            // 
            fmCboxForreria.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxForreria.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxForreria.BorderSize = 0;
            fmCboxForreria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxForreria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxForreria.ForeColor = System.Drawing.Color.DimGray;
            fmCboxForreria.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxForreria.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxForreria.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxForreria.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxForreria.Location = new System.Drawing.Point(432, 306);
            fmCboxForreria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxForreria.Name = "fmCboxForreria";
            fmCboxForreria.Size = new System.Drawing.Size(144, 27);
            fmCboxForreria.TabIndex = 123;
            fmCboxForreria.Texts = "";
            // 
            // lblForreria
            // 
            lblForreria.AutoSize = true;
            lblForreria.ForeColor = System.Drawing.Color.White;
            lblForreria.Location = new System.Drawing.Point(368, 306);
            lblForreria.Name = "lblForreria";
            lblForreria.Size = new System.Drawing.Size(63, 20);
            lblForreria.TabIndex = 122;
            lblForreria.Text = "Forreria:";
            // 
            // FmCrearProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(950, 620);
            Controls.Add(fmCboxForreria);
            Controls.Add(lblForreria);
            Controls.Add(fmCboxCollareta);
            Controls.Add(lblCollareta);
            Controls.Add(fmCboxCinturaInterior);
            Controls.Add(lblCinturaInterior);
            Controls.Add(btnImagenPrenda);
            Controls.Add(txtComposicion);
            Controls.Add(fmCboxBolsilloInt);
            Controls.Add(fmCboxVivo);
            Controls.Add(fmCboxTelaBase);
            Controls.Add(fmCboxLazo);
            Controls.Add(fmCboxTipoPrenda);
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
            Controls.Add(lblTipoPrenda);
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
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label lblTipoPrenda;
        private Tools.FormsTools.FmCombobox fmCboxTelaCombinacion;
        private Tools.FormsTools.FmCombobox fmCboxTipoPrenda;
        private Tools.FormsTools.FmCombobox fmCboxLazo;
        private Tools.FormsTools.FmCombobox fmCboxTelaBase;
        private Tools.FormsTools.FmCombobox fmCboxVivo;
        private Tools.FormsTools.FmCombobox fmCboxBolsilloInt;
        private AltoControls.AltoTextBox txtComposicion;
        private FontAwesome.Sharp.IconButton btnImagenPrenda;
        private Tools.FormsTools.FmCombobox fmCboxCinturaInterior;
        private System.Windows.Forms.Label lblCinturaInterior;
        private Tools.FormsTools.FmCombobox fmCboxCollareta;
        private System.Windows.Forms.Label lblCollareta;
        private Tools.FormsTools.FmCombobox fmCboxForreria;
        private System.Windows.Forms.Label lblForreria;
    }
}