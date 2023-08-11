namespace UI.TextilSoft.SubForms.Produccion.ABM_Productos
{
    partial class FmEliminarProducto
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
            txtCantidad = new AltoControls.AltoTextBox();
            lblPrincipal = new System.Windows.Forms.Label();
            lblCantidad = new System.Windows.Forms.Label();
            lblPrecio = new System.Windows.Forms.Label();
            lblTalle = new System.Windows.Forms.Label();
            txtPrecio = new AltoControls.AltoTextBox();
            txtTalle = new AltoControls.AltoTextBox();
            txtTipoProducto = new AltoControls.AltoTextBox();
            lblTipoProducto = new System.Windows.Forms.Label();
            txtCodigoProd = new AltoControls.AltoTextBox();
            lblCodigo = new System.Windows.Forms.Label();
            txtNombreProducto = new AltoControls.AltoTextBox();
            lblNombre = new System.Windows.Forms.Label();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Enabled = false;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(343, 324);
            txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(80, 39);
            txtCantidad.TabIndex = 54;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(226, 9);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(252, 41);
            lblPrincipal.TabIndex = 52;
            lblPrincipal.Text = "Eliminar Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(271, 334);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 20);
            lblCantidad.TabIndex = 51;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.ForeColor = System.Drawing.Color.White;
            lblPrecio.Location = new System.Drawing.Point(391, 269);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new System.Drawing.Size(53, 20);
            lblPrecio.TabIndex = 48;
            lblPrecio.Text = "Precio:";
            // 
            // lblTalle
            // 
            lblTalle.AutoSize = true;
            lblTalle.ForeColor = System.Drawing.Color.White;
            lblTalle.Location = new System.Drawing.Point(401, 220);
            lblTalle.Name = "lblTalle";
            lblTalle.Size = new System.Drawing.Size(42, 20);
            lblTalle.TabIndex = 46;
            lblTalle.Text = "Talle:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = System.Drawing.Color.Transparent;
            txtPrecio.Br = System.Drawing.Color.MidnightBlue;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPrecio.ForeColor = System.Drawing.Color.White;
            txtPrecio.Location = new System.Drawing.Point(445, 261);
            txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new System.Drawing.Size(144, 39);
            txtPrecio.TabIndex = 45;
            // 
            // txtTalle
            // 
            txtTalle.BackColor = System.Drawing.Color.Transparent;
            txtTalle.Br = System.Drawing.Color.MidnightBlue;
            txtTalle.Enabled = false;
            txtTalle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTalle.ForeColor = System.Drawing.Color.White;
            txtTalle.Location = new System.Drawing.Point(445, 214);
            txtTalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new System.Drawing.Size(144, 39);
            txtTalle.TabIndex = 43;
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.BackColor = System.Drawing.Color.Transparent;
            txtTipoProducto.Br = System.Drawing.Color.MidnightBlue;
            txtTipoProducto.Enabled = false;
            txtTipoProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTipoProducto.ForeColor = System.Drawing.Color.White;
            txtTipoProducto.Location = new System.Drawing.Point(226, 261);
            txtTipoProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.Size = new System.Drawing.Size(141, 39);
            txtTipoProducto.TabIndex = 41;
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.ForeColor = System.Drawing.Color.White;
            lblTipoProducto.Location = new System.Drawing.Point(98, 268);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new System.Drawing.Size(127, 20);
            lblTipoProducto.TabIndex = 39;
            lblTipoProducto.Text = "Tipo de Producto:";
            // 
            // txtCodigoProd
            // 
            txtCodigoProd.BackColor = System.Drawing.Color.Transparent;
            txtCodigoProd.Br = System.Drawing.Color.MidnightBlue;
            txtCodigoProd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigoProd.ForeColor = System.Drawing.Color.White;
            txtCodigoProd.Location = new System.Drawing.Point(303, 97);
            txtCodigoProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigoProd.Name = "txtCodigoProd";
            txtCodigoProd.Size = new System.Drawing.Size(139, 39);
            txtCodigoProd.TabIndex = 38;
            txtCodigoProd.TextChanged += txtCodigoProd_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(148, 105);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(151, 20);
            lblCodigo.TabIndex = 37;
            lblCodigo.Text = "Código del producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = System.Drawing.Color.Transparent;
            txtNombreProducto.Br = System.Drawing.Color.MidnightBlue;
            txtNombreProducto.Enabled = false;
            txtNombreProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombreProducto.ForeColor = System.Drawing.Color.White;
            txtNombreProducto.Location = new System.Drawing.Point(226, 214);
            txtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new System.Drawing.Size(141, 39);
            txtNombreProducto.TabIndex = 56;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = System.Drawing.Color.White;
            lblNombre.Location = new System.Drawing.Point(151, 221);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 55;
            lblNombre.Text = "Nombre:";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminarProducto.IconColor = System.Drawing.Color.White;
            btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarProducto.IconSize = 35;
            btnEliminarProducto.Location = new System.Drawing.Point(303, 382);
            btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new System.Drawing.Size(141, 61);
            btnEliminarProducto.TabIndex = 57;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click_1;
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
            btnBuscarProducto.Location = new System.Drawing.Point(467, 94);
            btnBuscarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new System.Drawing.Size(105, 45);
            btnBuscarProducto.TabIndex = 58;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // FmEliminarProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(801, 544);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombre);
            Controls.Add(txtCantidad);
            Controls.Add(lblPrincipal);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblTalle);
            Controls.Add(txtPrecio);
            Controls.Add(txtTalle);
            Controls.Add(txtTipoProducto);
            Controls.Add(lblTipoProducto);
            Controls.Add(txtCodigoProd);
            Controls.Add(lblCodigo);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmEliminarProducto";
            Text = "FmEliminarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRestar;
        private FontAwesome.Sharp.IconButton btnSumar;
        private AltoControls.AltoTextBox txtCantidad;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTalle;
        private AltoControls.AltoTextBox txtPrecio;
        private AltoControls.AltoTextBox txtTalle;
        private AltoControls.AltoTextBox txtTipoProducto;
        private System.Windows.Forms.Label lblTipoProducto;
        private AltoControls.AltoTextBox txtCodigoProd;
        private System.Windows.Forms.Label lblCodigo;
        private AltoControls.AltoTextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolTip toolTipError;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
    }
}