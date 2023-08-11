namespace UI.TextilSoft.SubForms.Pedidos.CancelarPedido
{
    partial class FmCancelarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            lblPrincipal = new System.Windows.Forms.Label();
            btnBuscarPedido = new FontAwesome.Sharp.IconButton();
            txtCodigoPedido = new AltoControls.AltoTextBox();
            lblCodigo = new System.Windows.Forms.Label();
            GrillaPedidos = new System.Windows.Forms.DataGridView();
            btnCancelarPedido = new FontAwesome.Sharp.IconButton();
            txtDNI = new AltoControls.AltoTextBox();
            label1 = new System.Windows.Forms.Label();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)GrillaPedidos).BeginInit();
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(304, 9);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(232, 41);
            lblPrincipal.TabIndex = 148;
            lblPrincipal.Text = "Cancelar Pedido";
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
            btnBuscarPedido.Location = new System.Drawing.Point(510, 103);
            btnBuscarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new System.Drawing.Size(132, 64);
            btnBuscarPedido.TabIndex = 151;
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
            txtCodigoPedido.Location = new System.Drawing.Point(346, 91);
            txtCodigoPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigoPedido.Name = "txtCodigoPedido";
            txtCodigoPedido.Size = new System.Drawing.Size(139, 39);
            txtCodigoPedido.TabIndex = 150;
            txtCodigoPedido.TextChanged += txtCodigoPedido_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(189, 99);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(138, 20);
            lblCodigo.TabIndex = 149;
            lblCodigo.Text = "Código del pedido:";
            // 
            // GrillaPedidos
            // 
            GrillaPedidos.AllowUserToResizeColumns = false;
            GrillaPedidos.AllowUserToResizeRows = false;
            GrillaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            GrillaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 50);
            GrillaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GrillaPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GrillaPedidos.ColumnHeadersHeight = 29;
            GrillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GrillaPedidos.EnableHeadersVisualStyles = false;
            GrillaPedidos.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            GrillaPedidos.Location = new System.Drawing.Point(28, 219);
            GrillaPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GrillaPedidos.Name = "GrillaPedidos";
            GrillaPedidos.ReadOnly = true;
            GrillaPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GrillaPedidos.RowHeadersWidth = 51;
            GrillaPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            GrillaPedidos.RowTemplate.Height = 25;
            GrillaPedidos.Size = new System.Drawing.Size(856, 116);
            GrillaPedidos.TabIndex = 152;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Enabled = false;
            btnCancelarPedido.FlatAppearance.BorderSize = 0;
            btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelarPedido.ForeColor = System.Drawing.Color.White;
            btnCancelarPedido.IconChar = FontAwesome.Sharp.IconChar.Ban;
            btnCancelarPedido.IconColor = System.Drawing.Color.White;
            btnCancelarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarPedido.IconSize = 35;
            btnCancelarPedido.Location = new System.Drawing.Point(325, 357);
            btnCancelarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new System.Drawing.Size(189, 45);
            btnCancelarPedido.TabIndex = 153;
            btnCancelarPedido.Text = "Cancelar Pedido";
            btnCancelarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelarPedido.UseVisualStyleBackColor = true;
            btnCancelarPedido.Click += btnCancelarPedido_Click;
            // 
            // txtDNI
            // 
            txtDNI.BackColor = System.Drawing.Color.Transparent;
            txtDNI.Br = System.Drawing.Color.MidnightBlue;
            txtDNI.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDNI.ForeColor = System.Drawing.Color.White;
            txtDNI.Location = new System.Drawing.Point(346, 138);
            txtDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(139, 39);
            txtDNI.TabIndex = 155;
            txtDNI.TextChanged += txtCodigoPedido_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(216, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 20);
            label1.TabIndex = 154;
            label1.Text = "DNI del cliente:";
            // 
            // FmCancelarPedido
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(896, 468);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Controls.Add(btnCancelarPedido);
            Controls.Add(GrillaPedidos);
            Controls.Add(btnBuscarPedido);
            Controls.Add(txtCodigoPedido);
            Controls.Add(lblCodigo);
            Controls.Add(lblPrincipal);
            Name = "FmCancelarPedido";
            Text = "FmCancelarPedido";
            ((System.ComponentModel.ISupportInitialize)GrillaPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private FontAwesome.Sharp.IconButton btnBuscarPedido;
        private AltoControls.AltoTextBox txtCodigoPedido;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView GrillaPedidos;
        private FontAwesome.Sharp.IconButton btnCancelarPedido;
        private AltoControls.AltoTextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipError;
    }
}