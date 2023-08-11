namespace UI.TextilSoft.SubForms.Facturas
{
    partial class FmFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            lblPrincipal = new System.Windows.Forms.Label();
            panelClientes = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtResidencia = new AltoControls.AltoTextBox();
            txtTelefono = new AltoControls.AltoTextBox();
            txtMail = new AltoControls.AltoTextBox();
            txtApellido = new AltoControls.AltoTextBox();
            txtNombre = new AltoControls.AltoTextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtDNI = new AltoControls.AltoTextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            GrillaDetallePedido = new System.Windows.Forms.DataGridView();
            lblSubTotal = new System.Windows.Forms.Label();
            txtTotal = new AltoControls.AltoTextBox();
            txtSubtotal = new AltoControls.AltoTextBox();
            lblTotal = new System.Windows.Forms.Label();
            btnBuscarPedido = new FontAwesome.Sharp.IconButton();
            txtCodigoPedido = new AltoControls.AltoTextBox();
            lblCodigo = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            btnGenerarFactura = new FontAwesome.Sharp.IconButton();
            txtNota = new AltoControls.AltoTextBox();
            lblNota = new System.Windows.Forms.Label();
            panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrillaDetallePedido).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(476, 21);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(226, 41);
            lblPrincipal.TabIndex = 35;
            lblPrincipal.Text = "Generar Factura";
            // 
            // panelClientes
            // 
            panelClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelClientes.Controls.Add(label7);
            panelClientes.Controls.Add(label6);
            panelClientes.Controls.Add(label5);
            panelClientes.Controls.Add(txtResidencia);
            panelClientes.Controls.Add(txtTelefono);
            panelClientes.Controls.Add(txtMail);
            panelClientes.Controls.Add(txtApellido);
            panelClientes.Controls.Add(txtNombre);
            panelClientes.Controls.Add(label4);
            panelClientes.Controls.Add(label3);
            panelClientes.Controls.Add(txtDNI);
            panelClientes.Controls.Add(label2);
            panelClientes.Controls.Add(label1);
            panelClientes.Location = new System.Drawing.Point(31, 197);
            panelClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new System.Drawing.Size(1142, 177);
            panelClientes.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(289, 129);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 20);
            label7.TabIndex = 14;
            label7.Text = "Residencia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(603, 128);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 20);
            label6.TabIndex = 13;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(59, 126);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Mail:";
            // 
            // txtResidencia
            // 
            txtResidencia.BackColor = System.Drawing.Color.Transparent;
            txtResidencia.Br = System.Drawing.Color.MidnightBlue;
            txtResidencia.Enabled = false;
            txtResidencia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtResidencia.ForeColor = System.Drawing.Color.White;
            txtResidencia.Location = new System.Drawing.Point(386, 121);
            txtResidencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtResidencia.Name = "txtResidencia";
            txtResidencia.Size = new System.Drawing.Size(141, 39);
            txtResidencia.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = System.Drawing.Color.Transparent;
            txtTelefono.Br = System.Drawing.Color.MidnightBlue;
            txtTelefono.Enabled = false;
            txtTelefono.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTelefono.ForeColor = System.Drawing.Color.White;
            txtTelefono.Location = new System.Drawing.Point(684, 121);
            txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(144, 39);
            txtTelefono.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.BackColor = System.Drawing.Color.Transparent;
            txtMail.Br = System.Drawing.Color.MidnightBlue;
            txtMail.Enabled = false;
            txtMail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMail.ForeColor = System.Drawing.Color.White;
            txtMail.Location = new System.Drawing.Point(106, 121);
            txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(139, 39);
            txtMail.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = System.Drawing.Color.Transparent;
            txtApellido.Br = System.Drawing.Color.MidnightBlue;
            txtApellido.Enabled = false;
            txtApellido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtApellido.ForeColor = System.Drawing.Color.White;
            txtApellido.Location = new System.Drawing.Point(684, 46);
            txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(141, 39);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.Color.Transparent;
            txtNombre.Br = System.Drawing.Color.MidnightBlue;
            txtNombre.Enabled = false;
            txtNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombre.ForeColor = System.Drawing.Color.White;
            txtNombre.Location = new System.Drawing.Point(386, 46);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(141, 39);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(602, 53);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(305, 53);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = System.Drawing.Color.Transparent;
            txtDNI.Br = System.Drawing.Color.MidnightBlue;
            txtDNI.Enabled = false;
            txtDNI.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDNI.ForeColor = System.Drawing.Color.White;
            txtDNI.Location = new System.Drawing.Point(106, 47);
            txtDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(139, 39);
            txtDNI.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(62, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(8, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Datos Del Cliente";
            // 
            // GrillaDetallePedido
            // 
            GrillaDetallePedido.AllowUserToResizeColumns = false;
            GrillaDetallePedido.AllowUserToResizeRows = false;
            GrillaDetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            GrillaDetallePedido.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 50);
            GrillaDetallePedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GrillaDetallePedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaDetallePedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaDetallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            GrillaDetallePedido.ColumnHeadersHeight = 29;
            GrillaDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GrillaDetallePedido.EnableHeadersVisualStyles = false;
            GrillaDetallePedido.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            GrillaDetallePedido.Location = new System.Drawing.Point(31, 57);
            GrillaDetallePedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GrillaDetallePedido.Name = "GrillaDetallePedido";
            GrillaDetallePedido.ReadOnly = true;
            GrillaDetallePedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaDetallePedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            GrillaDetallePedido.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaDetallePedido.RowsDefaultCellStyle = dataGridViewCellStyle6;
            GrillaDetallePedido.RowTemplate.Height = 25;
            GrillaDetallePedido.Size = new System.Drawing.Size(1074, 242);
            GrillaDetallePedido.TabIndex = 37;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.ForeColor = System.Drawing.Color.White;
            lblSubTotal.Location = new System.Drawing.Point(259, 316);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new System.Drawing.Size(68, 20);
            lblSubTotal.TabIndex = 38;
            lblSubTotal.Text = "Subtotal:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.Color.Transparent;
            txtTotal.Br = System.Drawing.Color.MidnightBlue;
            txtTotal.Enabled = false;
            txtTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.Color.White;
            txtTotal.Location = new System.Drawing.Point(529, 307);
            txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(139, 39);
            txtTotal.TabIndex = 41;
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = System.Drawing.Color.Transparent;
            txtSubtotal.Br = System.Drawing.Color.MidnightBlue;
            txtSubtotal.Enabled = false;
            txtSubtotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSubtotal.ForeColor = System.Drawing.Color.White;
            txtSubtotal.Location = new System.Drawing.Point(333, 307);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(139, 39);
            txtSubtotal.TabIndex = 39;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = System.Drawing.Color.White;
            lblTotal.Location = new System.Drawing.Point(478, 316);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(45, 20);
            lblTotal.TabIndex = 40;
            lblTotal.Text = "Total:";
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.FlatAppearance.BorderSize = 0;
            btnBuscarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscarPedido.ForeColor = System.Drawing.Color.White;
            btnBuscarPedido.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarPedido.IconColor = System.Drawing.Color.White;
            btnBuscarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarPedido.IconSize = 35;
            btnBuscarPedido.Location = new System.Drawing.Point(388, 125);
            btnBuscarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new System.Drawing.Size(132, 64);
            btnBuscarPedido.TabIndex = 158;
            btnBuscarPedido.Text = "Buscar";
            btnBuscarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBuscarPedido.UseVisualStyleBackColor = true;
            btnBuscarPedido.Click += btnBuscarPedido_Click;
            // 
            // txtCodigoPedido
            // 
            txtCodigoPedido.BackColor = System.Drawing.Color.Transparent;
            txtCodigoPedido.Br = System.Drawing.Color.MidnightBlue;
            txtCodigoPedido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigoPedido.ForeColor = System.Drawing.Color.White;
            txtCodigoPedido.Location = new System.Drawing.Point(219, 137);
            txtCodigoPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigoPedido.Name = "txtCodigoPedido";
            txtCodigoPedido.Size = new System.Drawing.Size(139, 39);
            txtCodigoPedido.TabIndex = 157;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(62, 145);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(138, 20);
            lblCodigo.TabIndex = 156;
            lblCodigo.Text = "Código del pedido:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(8, 9);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(195, 28);
            label9.TabIndex = 15;
            label9.Text = "Detalles del pedido";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(txtSubtotal);
            panel1.Controls.Add(GrillaDetallePedido);
            panel1.Controls.Add(lblSubTotal);
            panel1.Controls.Add(lblTotal);
            panel1.Location = new System.Drawing.Point(31, 381);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1142, 359);
            panel1.TabIndex = 161;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.FlatAppearance.BorderSize = 0;
            btnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerarFactura.ForeColor = System.Drawing.Color.White;
            btnGenerarFactura.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnGenerarFactura.IconColor = System.Drawing.Color.White;
            btnGenerarFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarFactura.IconSize = 35;
            btnGenerarFactura.Location = new System.Drawing.Point(445, 756);
            btnGenerarFactura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new System.Drawing.Size(193, 64);
            btnGenerarFactura.TabIndex = 162;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // txtNota
            // 
            txtNota.BackColor = System.Drawing.Color.Transparent;
            txtNota.Br = System.Drawing.Color.MidnightBlue;
            txtNota.Enabled = false;
            txtNota.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNota.ForeColor = System.Drawing.Color.White;
            txtNota.Location = new System.Drawing.Point(111, 769);
            txtNota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNota.Name = "txtNota";
            txtNota.Size = new System.Drawing.Size(312, 39);
            txtNota.TabIndex = 43;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.ForeColor = System.Drawing.Color.White;
            lblNota.Location = new System.Drawing.Point(60, 778);
            lblNota.Name = "lblNota";
            lblNota.Size = new System.Drawing.Size(45, 20);
            lblNota.TabIndex = 42;
            lblNota.Text = "Nota:";
            // 
            // FmFacturas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(1240, 835);
            Controls.Add(txtNota);
            Controls.Add(lblNota);
            Controls.Add(btnGenerarFactura);
            Controls.Add(btnBuscarPedido);
            Controls.Add(txtCodigoPedido);
            Controls.Add(lblCodigo);
            Controls.Add(panelClientes);
            Controls.Add(lblPrincipal);
            Controls.Add(panel1);
            Name = "FmFacturas";
            Text = "FmFacturas";
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GrillaDetallePedido).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox txtResidencia;
        private AltoControls.AltoTextBox txtTelefono;
        private AltoControls.AltoTextBox txtMail;
        private AltoControls.AltoTextBox txtApellido;
        private AltoControls.AltoTextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaDetallePedido;
        private System.Windows.Forms.Label lblSubTotal;
        private AltoControls.AltoTextBox txtTotal;
        private AltoControls.AltoTextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private FontAwesome.Sharp.IconButton btnBuscarPedido;
        private AltoControls.AltoTextBox txtCodigoPedido;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipError;
        private FontAwesome.Sharp.IconButton btnGenerarFactura;
        private AltoControls.AltoTextBox txtNota;
        private System.Windows.Forms.Label lblNota;
    }
}