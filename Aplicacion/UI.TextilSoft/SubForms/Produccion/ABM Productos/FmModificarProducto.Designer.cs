namespace UI.TextilSoft.SubForms.Produccion.ABM_Productos
{
    partial class FmModificarProducto
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
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            btnActualizarProducto = new FontAwesome.Sharp.IconButton();
            txtNombreProducto = new AltoControls.AltoTextBox();
            lblNombre = new System.Windows.Forms.Label();
            txtCantidad = new AltoControls.AltoTextBox();
            lblPrincipal = new System.Windows.Forms.Label();
            lblCantidad = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblTalle = new System.Windows.Forms.Label();
            txtPrecio = new AltoControls.AltoTextBox();
            txtTalle = new AltoControls.AltoTextBox();
            txtCodigoProd = new AltoControls.AltoTextBox();
            lblCodigo = new System.Windows.Forms.Label();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarProducto.IconColor = System.Drawing.Color.White;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProducto.IconSize = 35;
            btnBuscarProducto.Location = new System.Drawing.Point(425, 98);
            btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new System.Drawing.Size(105, 45);
            btnBuscarProducto.TabIndex = 82;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.FlatAppearance.BorderSize = 0;
            btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizarProducto.ForeColor = System.Drawing.Color.White;
            btnActualizarProducto.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnActualizarProducto.IconColor = System.Drawing.Color.White;
            btnActualizarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActualizarProducto.IconSize = 35;
            btnActualizarProducto.Location = new System.Drawing.Point(314, 313);
            btnActualizarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnActualizarProducto.Name = "btnActualizarProducto";
            btnActualizarProducto.Size = new System.Drawing.Size(141, 61);
            btnActualizarProducto.TabIndex = 81;
            btnActualizarProducto.Text = "Actualizar";
            btnActualizarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnActualizarProducto.UseVisualStyleBackColor = true;
            btnActualizarProducto.Click += btnEliminarProducto_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = System.Drawing.Color.Transparent;
            txtNombreProducto.Br = System.Drawing.Color.MidnightBlue;
            txtNombreProducto.Enabled = false;
            txtNombreProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombreProducto.ForeColor = System.Drawing.Color.White;
            txtNombreProducto.Location = new System.Drawing.Point(210, 198);
            txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new System.Drawing.Size(141, 39);
            txtNombreProducto.TabIndex = 80;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = System.Drawing.Color.White;
            lblNombre.Location = new System.Drawing.Point(135, 205);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 79;
            lblNombre.Text = "Nombre:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Enabled = false;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(438, 245);
            txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(144, 39);
            txtCantidad.TabIndex = 78;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(257, 24);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(273, 41);
            lblPrincipal.TabIndex = 77;
            lblPrincipal.Text = "Modificar Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(364, 253);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 20);
            lblCantidad.TabIndex = 76;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.White;
            lblPrecio.Location = new System.Drawing.Point(383, 206);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(53, 20);
            lblPrecio.TabIndex = 73;
            lblPrecio.Text = "Precio:";
            // 
            // lblTalle
            // 
            lblTalle.AutoSize = true;
            lblTalle.ForeColor = System.Drawing.Color.White;
            lblTalle.Location = new System.Drawing.Point(160, 253);
            lblTalle.Name = "lblTalle";
            lblTalle.Size = new System.Drawing.Size(42, 20);
            lblTalle.TabIndex = 71;
            lblTalle.Text = "Talle:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = System.Drawing.Color.Transparent;
            txtPrecio.Br = System.Drawing.Color.MidnightBlue;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPrecio.ForeColor = System.Drawing.Color.White;
            txtPrecio.Location = new System.Drawing.Point(438, 198);
            txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(144, 39);
            txtPrecio.TabIndex = 70;
            // 
            // txtTalle
            // 
            txtTalle.BackColor = System.Drawing.Color.Transparent;
            txtTalle.Br = System.Drawing.Color.MidnightBlue;
            txtTalle.Enabled = false;
            txtTalle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTalle.ForeColor = System.Drawing.Color.White;
            txtTalle.Location = new System.Drawing.Point(210, 245);
            txtTalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new System.Drawing.Size(144, 39);
            txtTalle.TabIndex = 68;
            // 
            // txtCodigoProd
            // 
            txtCodigoProd.BackColor = System.Drawing.Color.Transparent;
            txtCodigoProd.Br = System.Drawing.Color.MidnightBlue;
            txtCodigoProd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigoProd.ForeColor = System.Drawing.Color.White;
            txtCodigoProd.Location = new System.Drawing.Point(278, 100);
            txtCodigoProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigoProd.Name = "txtCodigoProd";
            txtCodigoProd.Size = new System.Drawing.Size(139, 39);
            txtCodigoProd.TabIndex = 63;
            txtCodigoProd.TextChanged += txtCodigoProd_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(121, 108);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(151, 20);
            lblCodigo.TabIndex = 62;
            lblCodigo.Text = "Código del producto:";
            // 
            // FmModificarProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(799, 492);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnActualizarProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombre);
            Controls.Add(txtCantidad);
            Controls.Add(lblPrincipal);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblTalle);
            Controls.Add(txtPrecio);
            Controls.Add(txtTalle);
            Controls.Add(txtCodigoProd);
            Controls.Add(lblCodigo);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmModificarProducto";
            Text = "FmModificarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private FontAwesome.Sharp.IconButton btnActualizarProducto;
        private AltoControls.AltoTextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private AltoControls.AltoTextBox txtCantidad;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTalle;
        private AltoControls.AltoTextBox txtPrecio;
        private AltoControls.AltoTextBox txtTalle;
        private AltoControls.AltoTextBox txtCodigoProd;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ToolTip toolTipError;
    }
}