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
            lblPrincipal.Location = new System.Drawing.Point(142, 37);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(313, 32);
            lblPrincipal.TabIndex = 148;
            lblPrincipal.Text = "Anotar Prendas Defectuosas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(214, 185);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(48, 15);
            label5.TabIndex = 174;
            label5.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.BackColor = System.Drawing.Color.Transparent;
            txtMotivo.Br = System.Drawing.Color.MidnightBlue;
            txtMotivo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMotivo.ForeColor = System.Drawing.Color.White;
            txtMotivo.Location = new System.Drawing.Point(278, 179);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new System.Drawing.Size(126, 29);
            txtMotivo.TabIndex = 171;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Enabled = false;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(278, 144);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(123, 29);
            txtCantidad.TabIndex = 170;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(204, 150);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(58, 15);
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
            btnRegistrarDevolucion.Location = new System.Drawing.Point(224, 228);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new System.Drawing.Size(177, 46);
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
            txtCodigoProducto.Location = new System.Drawing.Point(278, 108);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new System.Drawing.Size(123, 29);
            txtCodigoProducto.TabIndex = 167;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(145, 113);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(117, 15);
            lblDescripcion.TabIndex = 166;
            lblDescripcion.Text = "Código de producto:";
            // 
            // FmPrendaDevuelta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(624, 297);
            Controls.Add(label5);
            Controls.Add(txtMotivo);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(btnRegistrarDevolucion);
            Controls.Add(txtCodigoProducto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrincipal);
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