namespace UI.TextilSoft.SubForms.Ventas.Registrar_Venta
{
    partial class FmRegistrarVenta
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
            lblPrincipal = new System.Windows.Forms.Label();
            txtCantidad = new AltoControls.AltoTextBox();
            lblCantidad = new System.Windows.Forms.Label();
            btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            txtCodigoProducto = new AltoControls.AltoTextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(203, 64);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(230, 41);
            lblPrincipal.TabIndex = 34;
            lblPrincipal.Text = "Registrar Ventas";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(282, 217);
            txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(141, 39);
            txtCantidad.TabIndex = 133;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(209, 225);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 20);
            lblCantidad.TabIndex = 132;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarVenta.IconSize = 35;
            btnRegistrarVenta.Location = new System.Drawing.Point(227, 283);
            btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new System.Drawing.Size(154, 61);
            btnRegistrarVenta.TabIndex = 131;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BackColor = System.Drawing.Color.Transparent;
            txtCodigoProducto.Br = System.Drawing.Color.MidnightBlue;
            txtCodigoProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigoProducto.ForeColor = System.Drawing.Color.White;
            txtCodigoProducto.Location = new System.Drawing.Point(282, 159);
            txtCodigoProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new System.Drawing.Size(141, 39);
            txtCodigoProducto.TabIndex = 130;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(132, 168);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(147, 20);
            lblDescripcion.TabIndex = 129;
            lblDescripcion.Text = "Código de producto:";
            // 
            // FmRegistrarVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(642, 401);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(txtCodigoProducto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrincipal);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmRegistrarVenta";
            Text = "FmRegistrarVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private AltoControls.AltoTextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private AltoControls.AltoTextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ToolTip toolTipError;
    }
}