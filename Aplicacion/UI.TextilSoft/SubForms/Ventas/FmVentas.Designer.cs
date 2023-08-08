namespace UI.TextilSoft.SubForms.Ventas
{
    partial class FmVentas
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
            pnlVentasBottom = new System.Windows.Forms.Panel();
            pnlVentasTop = new System.Windows.Forms.Panel();
            btnSeña = new FontAwesome.Sharp.IconButton();
            btnDevolucionPrenda = new FontAwesome.Sharp.IconButton();
            btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            pnlVentasTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVentasBottom
            // 
            pnlVentasBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlVentasBottom.Location = new System.Drawing.Point(0, 89);
            pnlVentasBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlVentasBottom.Name = "pnlVentasBottom";
            pnlVentasBottom.Size = new System.Drawing.Size(810, 298);
            pnlVentasBottom.TabIndex = 0;
            // 
            // pnlVentasTop
            // 
            pnlVentasTop.Controls.Add(btnSeña);
            pnlVentasTop.Controls.Add(btnDevolucionPrenda);
            pnlVentasTop.Controls.Add(btnRegistrarVenta);
            pnlVentasTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlVentasTop.Location = new System.Drawing.Point(0, 0);
            pnlVentasTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pnlVentasTop.Name = "pnlVentasTop";
            pnlVentasTop.Size = new System.Drawing.Size(810, 88);
            pnlVentasTop.TabIndex = 1;
            // 
            // btnSeña
            // 
            btnSeña.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSeña.FlatAppearance.BorderSize = 0;
            btnSeña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeña.ForeColor = System.Drawing.Color.White;
            btnSeña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnSeña.IconColor = System.Drawing.Color.White;
            btnSeña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeña.IconSize = 35;
            btnSeña.Location = new System.Drawing.Point(620, 40);
            btnSeña.Name = "btnSeña";
            btnSeña.Size = new System.Drawing.Size(138, 46);
            btnSeña.TabIndex = 9;
            btnSeña.Text = "Agregar seña";
            btnSeña.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSeña.UseVisualStyleBackColor = true;
            btnSeña.Click += btnSeña_Click;
            // 
            // btnDevolucionPrenda
            // 
            btnDevolucionPrenda.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDevolucionPrenda.FlatAppearance.BorderSize = 0;
            btnDevolucionPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDevolucionPrenda.ForeColor = System.Drawing.Color.White;
            btnDevolucionPrenda.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            btnDevolucionPrenda.IconColor = System.Drawing.Color.White;
            btnDevolucionPrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDevolucionPrenda.IconSize = 35;
            btnDevolucionPrenda.Location = new System.Drawing.Point(348, 40);
            btnDevolucionPrenda.Name = "btnDevolucionPrenda";
            btnDevolucionPrenda.Size = new System.Drawing.Size(138, 46);
            btnDevolucionPrenda.TabIndex = 8;
            btnDevolucionPrenda.Text = "Devoluciones";
            btnDevolucionPrenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDevolucionPrenda.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarVenta.IconSize = 35;
            btnRegistrarVenta.Location = new System.Drawing.Point(86, 40);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new System.Drawing.Size(138, 46);
            btnRegistrarVenta.TabIndex = 7;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // FmVentas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(810, 387);
            Controls.Add(pnlVentasTop);
            Controls.Add(pnlVentasBottom);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FmVentas";
            Text = "FmVentas";
            pnlVentasTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlVentasBottom;
        private System.Windows.Forms.Panel pnlVentasTop;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private FontAwesome.Sharp.IconButton btnDevolucionPrenda;
        private FontAwesome.Sharp.IconButton btnSeña;
    }
}