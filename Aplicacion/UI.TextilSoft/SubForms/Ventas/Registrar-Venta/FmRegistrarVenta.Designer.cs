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
            lblPrincipal = new System.Windows.Forms.Label();
            txtCantidad = new AltoControls.AltoTextBox();
            lblCantidad = new System.Windows.Forms.Label();
            btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            txtCodigoProducto = new AltoControls.AltoTextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(178, 48);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(183, 32);
            lblPrincipal.TabIndex = 34;
            lblPrincipal.Text = "Registrar Ventas";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Enabled = false;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(247, 163);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(123, 29);
            txtCantidad.TabIndex = 133;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(183, 169);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(58, 15);
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
            btnRegistrarVenta.Location = new System.Drawing.Point(199, 212);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new System.Drawing.Size(135, 46);
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
            txtCodigoProducto.Location = new System.Drawing.Point(247, 119);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new System.Drawing.Size(123, 29);
            txtCodigoProducto.TabIndex = 130;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(124, 124);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(117, 15);
            lblDescripcion.TabIndex = 129;
            lblDescripcion.Text = "Código de producto:";
            // 
            // FmRegistrarVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(562, 301);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(txtCodigoProducto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrincipal);
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
    }
}