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
            lblPrecio = new System.Windows.Forms.Label();
            lblTejido = new System.Windows.Forms.Label();
            lblTalle = new System.Windows.Forms.Label();
            txtPrecio = new AltoControls.AltoTextBox();
            txtTejido = new AltoControls.AltoTextBox();
            txtEstampa = new AltoControls.AltoTextBox();
            txtTipoProducto = new AltoControls.AltoTextBox();
            lblEstampa = new System.Windows.Forms.Label();
            lblTipoProducto = new System.Windows.Forms.Label();
            txtNombreProducto = new AltoControls.AltoTextBox();
            lblCodigo = new System.Windows.Forms.Label();
            txtComposicion = new AltoControls.AltoTextBox();
            lblComposicion = new System.Windows.Forms.Label();
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
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.White;
            lblPrecio.Location = new System.Drawing.Point(404, 159);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(43, 15);
            lblPrecio.TabIndex = 26;
            lblPrecio.Text = "Precio:";
            // 
            // lblTejido
            // 
            lblTejido.AutoSize = true;
            lblTejido.ForeColor = System.Drawing.Color.White;
            lblTejido.Location = new System.Drawing.Point(405, 125);
            lblTejido.Name = "lblTejido";
            lblTejido.Size = new System.Drawing.Size(41, 15);
            lblTejido.TabIndex = 25;
            lblTejido.Text = "Tejido:";
            // 
            // lblTalle
            // 
            lblTalle.AutoSize = true;
            lblTalle.ForeColor = System.Drawing.Color.White;
            lblTalle.Location = new System.Drawing.Point(413, 87);
            lblTalle.Name = "lblTalle";
            lblTalle.Size = new System.Drawing.Size(33, 15);
            lblTalle.TabIndex = 24;
            lblTalle.Text = "Talle:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = System.Drawing.Color.Transparent;
            txtPrecio.Br = System.Drawing.Color.MidnightBlue;
            txtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPrecio.ForeColor = System.Drawing.Color.White;
            txtPrecio.Location = new System.Drawing.Point(452, 153);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(126, 29);
            txtPrecio.TabIndex = 23;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // txtTejido
            // 
            txtTejido.BackColor = System.Drawing.Color.Transparent;
            txtTejido.Br = System.Drawing.Color.MidnightBlue;
            txtTejido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTejido.ForeColor = System.Drawing.Color.White;
            txtTejido.Location = new System.Drawing.Point(452, 118);
            txtTejido.Name = "txtTejido";
            txtTejido.Size = new System.Drawing.Size(126, 29);
            txtTejido.TabIndex = 22;
            txtTejido.TextChanged += txtNombreProducto_TextChanged;
            // 
            // txtEstampa
            // 
            txtEstampa.BackColor = System.Drawing.Color.Transparent;
            txtEstampa.Br = System.Drawing.Color.MidnightBlue;
            txtEstampa.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEstampa.ForeColor = System.Drawing.Color.White;
            txtEstampa.Location = new System.Drawing.Point(210, 155);
            txtEstampa.Name = "txtEstampa";
            txtEstampa.Size = new System.Drawing.Size(123, 29);
            txtEstampa.TabIndex = 20;
            txtEstampa.TextChanged += txtNombreProducto_TextChanged;
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.BackColor = System.Drawing.Color.Transparent;
            txtTipoProducto.Br = System.Drawing.Color.MidnightBlue;
            txtTipoProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTipoProducto.ForeColor = System.Drawing.Color.White;
            txtTipoProducto.Location = new System.Drawing.Point(210, 120);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.Size = new System.Drawing.Size(123, 29);
            txtTipoProducto.TabIndex = 19;
            // 
            // lblEstampa
            // 
            lblEstampa.AutoSize = true;
            lblEstampa.ForeColor = System.Drawing.Color.White;
            lblEstampa.Location = new System.Drawing.Point(144, 159);
            lblEstampa.Name = "lblEstampa";
            lblEstampa.Size = new System.Drawing.Size(55, 15);
            lblEstampa.TabIndex = 18;
            lblEstampa.Text = "Estampa:";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.ForeColor = System.Drawing.Color.White;
            lblTipoProducto.Location = new System.Drawing.Point(98, 125);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new System.Drawing.Size(101, 15);
            lblTipoProducto.TabIndex = 17;
            lblTipoProducto.Text = "Tipo de Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = System.Drawing.Color.Transparent;
            txtNombreProducto.Br = System.Drawing.Color.MidnightBlue;
            txtNombreProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombreProducto.ForeColor = System.Drawing.Color.White;
            txtNombreProducto.Location = new System.Drawing.Point(211, 83);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new System.Drawing.Size(122, 29);
            txtNombreProducto.TabIndex = 16;
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(144, 87);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(54, 15);
            lblCodigo.TabIndex = 15;
            lblCodigo.Text = "Nombre:";
            // 
            // txtComposicion
            // 
            txtComposicion.BackColor = System.Drawing.Color.Transparent;
            txtComposicion.Br = System.Drawing.Color.MidnightBlue;
            txtComposicion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtComposicion.ForeColor = System.Drawing.Color.White;
            txtComposicion.Location = new System.Drawing.Point(210, 191);
            txtComposicion.Name = "txtComposicion";
            txtComposicion.Size = new System.Drawing.Size(123, 29);
            txtComposicion.TabIndex = 28;
            txtComposicion.TextChanged += txtNombreProducto_TextChanged;
            // 
            // lblComposicion
            // 
            lblComposicion.AutoSize = true;
            lblComposicion.ForeColor = System.Drawing.Color.White;
            lblComposicion.Location = new System.Drawing.Point(117, 198);
            lblComposicion.Name = "lblComposicion";
            lblComposicion.Size = new System.Drawing.Size(81, 15);
            lblComposicion.TabIndex = 27;
            lblComposicion.Text = "Composicion:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(389, 195);
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
            lblPrincipal.Location = new System.Drawing.Point(274, 9);
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
            btnCrearProducto.Location = new System.Drawing.Point(296, 292);
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
            txtCantidad.Location = new System.Drawing.Point(452, 188);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(51, 29);
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
            btnSumar.Location = new System.Drawing.Point(509, 191);
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
            btnRestar.Location = new System.Drawing.Point(538, 190);
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
            txtColor.Location = new System.Drawing.Point(211, 236);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.ReadOnly = true;
            txtColor.Size = new System.Drawing.Size(118, 23);
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
            btnChangeColor.Location = new System.Drawing.Point(335, 232);
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
            lblColor.Location = new System.Drawing.Point(159, 238);
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
            cboxTalles.Location = new System.Drawing.Point(452, 84);
            cboxTalles.Name = "cboxTalles";
            cboxTalles.Size = new System.Drawing.Size(126, 20);
            cboxTalles.TabIndex = 41;
            cboxTalles.Texts = "";
            // 
            // FmCrearProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(718, 443);
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
            Controls.Add(txtComposicion);
            Controls.Add(lblComposicion);
            Controls.Add(lblPrecio);
            Controls.Add(lblTejido);
            Controls.Add(lblTalle);
            Controls.Add(txtPrecio);
            Controls.Add(txtTejido);
            Controls.Add(txtEstampa);
            Controls.Add(txtTipoProducto);
            Controls.Add(lblEstampa);
            Controls.Add(lblTipoProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblCodigo);
            Name = "FmCrearProducto";
            Text = "FmCrearProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTejido;
        private System.Windows.Forms.Label lblTalle;
        private AltoControls.AltoTextBox txtPrecio;
        private AltoControls.AltoTextBox txtTejido;
        private AltoControls.AltoTextBox txtEstampa;
        private AltoControls.AltoTextBox txtTipoProducto;
        private System.Windows.Forms.Label lblEstampa;
        private System.Windows.Forms.Label lblTipoProducto;
        private AltoControls.AltoTextBox txtNombreProducto;
        private System.Windows.Forms.Label lblCodigo;
        private AltoControls.AltoTextBox txtComposicion;
        private System.Windows.Forms.Label lblComposicion;
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
    }
}