namespace UI.TextilSoft.SubForms.Ventas.Prenda_Devuelta
{
    partial class FmPrendaDevuelta
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
            label5 = new System.Windows.Forms.Label();
            txtMotivo = new AltoControls.AltoTextBox();
            txtCantidad = new AltoControls.AltoTextBox();
            lblCantidad = new System.Windows.Forms.Label();
            btnRegistrarDevolucion = new FontAwesome.Sharp.IconButton();
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
            lblPrincipal.Location = new System.Drawing.Point(146, 48);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(391, 41);
            lblPrincipal.TabIndex = 148;
            lblPrincipal.Text = "Anotar Prendas Defectuosas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(245, 247);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 20);
            label5.TabIndex = 174;
            label5.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = System.Drawing.Color.Transparent;
            txtMotivo.Br = System.Drawing.Color.MidnightBlue;
            txtMotivo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMotivo.ForeColor = System.Drawing.Color.White;
            txtMotivo.Location = new System.Drawing.Point(318, 239);
            txtMotivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new System.Drawing.Size(144, 39);
            txtMotivo.TabIndex = 171;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(318, 192);
            txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(141, 39);
            txtCantidad.TabIndex = 170;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(233, 200);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 20);
            lblCantidad.TabIndex = 169;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrarDevolucion.ForeColor = System.Drawing.Color.White;
            btnRegistrarDevolucion.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            btnRegistrarDevolucion.IconColor = System.Drawing.Color.White;
            btnRegistrarDevolucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarDevolucion.IconSize = 35;
            btnRegistrarDevolucion.Location = new System.Drawing.Point(256, 304);
            btnRegistrarDevolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new System.Drawing.Size(202, 61);
            btnRegistrarDevolucion.TabIndex = 168;
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BackColor = System.Drawing.Color.Transparent;
            txtCodigoProducto.Br = System.Drawing.Color.MidnightBlue;
            txtCodigoProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigoProducto.ForeColor = System.Drawing.Color.White;
            txtCodigoProducto.Location = new System.Drawing.Point(318, 144);
            txtCodigoProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new System.Drawing.Size(141, 39);
            txtCodigoProducto.TabIndex = 167;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(158, 154);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(147, 20);
            lblDescripcion.TabIndex = 166;
            lblDescripcion.Text = "Código de producto:";
            // 
            // FmPrendaDevuelta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(713, 396);
            Controls.Add(label5);
            Controls.Add(txtMotivo);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(txtCodigoProducto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrincipal);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmPrendaDevuelta";
            Text = "FmPrendaDevuelta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox txtMotivo;
        private AltoControls.AltoTextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private FontAwesome.Sharp.IconButton btnRegistrarDevolucion;
        private AltoControls.AltoTextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ToolTip toolTipError;
    }
}