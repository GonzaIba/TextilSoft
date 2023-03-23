namespace UI.TextilSoft.SubForms.Pedidos.OrdenDeTrabajo
{
    partial class FmAsignarODT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            lblCompanyTitle = new System.Windows.Forms.Label();
            GrillaPedidos = new System.Windows.Forms.DataGridView();
            tbEsPedido = new Tools.FormsTools.ToggleButton();
            lblPed_SI = new System.Windows.Forms.Label();
            lblPed_NO = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            cboxCantidadRegistros = new Tools.FormsTools.FmCombobox();
            lblregistros = new System.Windows.Forms.Label();
            lblMostrar = new System.Windows.Forms.Label();
            panelPaginado = new System.Windows.Forms.Panel();
            btnTercero = new System.Windows.Forms.Button();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnPrimero = new System.Windows.Forms.Button();
            btnFinal = new System.Windows.Forms.Button();
            btnSegundo = new System.Windows.Forms.Button();
            btnInicio = new System.Windows.Forms.Button();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            txtSearch = new AltoControls.AltoTextBox();
            lblFiltradoDeCampo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)GrillaPedidos).BeginInit();
            panelPaginado.SuspendLayout();
            SuspendLayout();
            // 
            // lblCompanyTitle
            // 
            lblCompanyTitle.AutoSize = true;
            lblCompanyTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCompanyTitle.ForeColor = System.Drawing.Color.White;
            lblCompanyTitle.Location = new System.Drawing.Point(290, 20);
            lblCompanyTitle.Name = "lblCompanyTitle";
            lblCompanyTitle.Size = new System.Drawing.Size(385, 45);
            lblCompanyTitle.TabIndex = 44;
            lblCompanyTitle.Text = "Asignar Orden De Trabajo";
            // 
            // GrillaPedidos
            // 
            GrillaPedidos.AllowUserToResizeColumns = false;
            GrillaPedidos.AllowUserToResizeRows = false;
            GrillaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            GrillaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 45);
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
            GrillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GrillaPedidos.EnableHeadersVisualStyles = false;
            GrillaPedidos.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            GrillaPedidos.Location = new System.Drawing.Point(9, 144);
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
            GrillaPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            GrillaPedidos.RowTemplate.Height = 25;
            GrillaPedidos.Size = new System.Drawing.Size(957, 285);
            GrillaPedidos.TabIndex = 45;
            GrillaPedidos.DataSourceChanged += GrillaPedidos_DataSourceChanged;
            // 
            // tbEsPedido
            // 
            tbEsPedido.Checked = true;
            tbEsPedido.CheckState = System.Windows.Forms.CheckState.Checked;
            tbEsPedido.Location = new System.Drawing.Point(517, 118);
            tbEsPedido.MinimumSize = new System.Drawing.Size(45, 22);
            tbEsPedido.Name = "tbEsPedido";
            tbEsPedido.OffBackColor = System.Drawing.Color.Gray;
            tbEsPedido.OffToggleColor = System.Drawing.Color.Gainsboro;
            tbEsPedido.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tbEsPedido.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tbEsPedido.Size = new System.Drawing.Size(55, 22);
            tbEsPedido.TabIndex = 93;
            tbEsPedido.Text = "toggleButton1";
            tbEsPedido.UseVisualStyleBackColor = true;
            tbEsPedido.CheckedChanged += tbEsPedido_CheckedChanged;
            // 
            // lblPed_SI
            // 
            lblPed_SI.AutoSize = true;
            lblPed_SI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPed_SI.ForeColor = System.Drawing.Color.White;
            lblPed_SI.Location = new System.Drawing.Point(575, 118);
            lblPed_SI.Name = "lblPed_SI";
            lblPed_SI.Size = new System.Drawing.Size(23, 21);
            lblPed_SI.TabIndex = 95;
            lblPed_SI.Text = "Si";
            // 
            // lblPed_NO
            // 
            lblPed_NO.AutoSize = true;
            lblPed_NO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPed_NO.ForeColor = System.Drawing.Color.White;
            lblPed_NO.Location = new System.Drawing.Point(489, 118);
            lblPed_NO.Name = "lblPed_NO";
            lblPed_NO.Size = new System.Drawing.Size(31, 21);
            lblPed_NO.TabIndex = 94;
            lblPed_NO.Text = "No";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.ForeColor = System.Drawing.Color.White;
            lbl.Location = new System.Drawing.Point(462, 95);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(164, 20);
            lbl.TabIndex = 92;
            lbl.Text = "Es pedido para cliente?";
            // 
            // cboxCantidadRegistros
            // 
            cboxCantidadRegistros.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxCantidadRegistros.BorderColor = System.Drawing.Color.MediumSlateBlue;
            cboxCantidadRegistros.BorderSize = 1;
            cboxCantidadRegistros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboxCantidadRegistros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboxCantidadRegistros.ForeColor = System.Drawing.Color.DimGray;
            cboxCantidadRegistros.IconColor = System.Drawing.Color.MediumSlateBlue;
            cboxCantidadRegistros.Items.AddRange(new object[] { "5", "10", "20" });
            cboxCantidadRegistros.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            cboxCantidadRegistros.ListTextColor = System.Drawing.Color.DimGray;
            cboxCantidadRegistros.Location = new System.Drawing.Point(71, 112);
            cboxCantidadRegistros.Name = "cboxCantidadRegistros";
            cboxCantidadRegistros.Padding = new System.Windows.Forms.Padding(1);
            cboxCantidadRegistros.Size = new System.Drawing.Size(65, 21);
            cboxCantidadRegistros.TabIndex = 98;
            cboxCantidadRegistros.Texts = "";
            // 
            // lblregistros
            // 
            lblregistros.AutoSize = true;
            lblregistros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblregistros.ForeColor = System.Drawing.Color.White;
            lblregistros.Location = new System.Drawing.Point(139, 112);
            lblregistros.Name = "lblregistros";
            lblregistros.Size = new System.Drawing.Size(75, 21);
            lblregistros.TabIndex = 97;
            lblregistros.Text = "Registros";
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMostrar.ForeColor = System.Drawing.Color.White;
            lblMostrar.Location = new System.Drawing.Point(9, 112);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new System.Drawing.Size(65, 21);
            lblMostrar.TabIndex = 96;
            lblMostrar.Text = "Mostrar";
            // 
            // panelPaginado
            // 
            panelPaginado.Controls.Add(btnTercero);
            panelPaginado.Controls.Add(btnAnterior);
            panelPaginado.Controls.Add(btnPrimero);
            panelPaginado.Controls.Add(btnFinal);
            panelPaginado.Controls.Add(btnSegundo);
            panelPaginado.Controls.Add(btnInicio);
            panelPaginado.Controls.Add(btnSiguiente);
            panelPaginado.Location = new System.Drawing.Point(757, 433);
            panelPaginado.Name = "panelPaginado";
            panelPaginado.Size = new System.Drawing.Size(209, 36);
            panelPaginado.TabIndex = 99;
            // 
            // btnTercero
            // 
            btnTercero.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTercero.FlatAppearance.BorderSize = 0;
            btnTercero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTercero.ForeColor = System.Drawing.Color.White;
            btnTercero.Location = new System.Drawing.Point(114, 8);
            btnTercero.Name = "btnTercero";
            btnTercero.Size = new System.Drawing.Size(24, 23);
            btnTercero.TabIndex = 25;
            btnTercero.Text = "3";
            btnTercero.UseVisualStyleBackColor = true;
            btnTercero.Click += btnTercero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnterior.ForeColor = System.Drawing.Color.White;
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btnAnterior.IconColor = System.Drawing.Color.White;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 20;
            btnAnterior.Location = new System.Drawing.Point(29, 10);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new System.Drawing.Size(24, 23);
            btnAnterior.TabIndex = 22;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPrimero.FlatAppearance.BorderSize = 0;
            btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrimero.ForeColor = System.Drawing.Color.White;
            btnPrimero.Location = new System.Drawing.Point(55, 8);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new System.Drawing.Size(24, 23);
            btnPrimero.TabIndex = 17;
            btnPrimero.Text = "1";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnFinal
            // 
            btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFinal.FlatAppearance.BorderSize = 0;
            btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFinal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFinal.ForeColor = System.Drawing.Color.White;
            btnFinal.Location = new System.Drawing.Point(160, 6);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new System.Drawing.Size(42, 28);
            btnFinal.TabIndex = 24;
            btnFinal.Text = "...N";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // btnSegundo
            // 
            btnSegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSegundo.FlatAppearance.BorderSize = 0;
            btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSegundo.ForeColor = System.Drawing.Color.White;
            btnSegundo.Location = new System.Drawing.Point(85, 8);
            btnSegundo.Name = "btnSegundo";
            btnSegundo.Size = new System.Drawing.Size(24, 23);
            btnSegundo.TabIndex = 19;
            btnSegundo.Text = "2";
            btnSegundo.UseVisualStyleBackColor = true;
            btnSegundo.Click += btnSegundo_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInicio.ForeColor = System.Drawing.Color.White;
            btnInicio.Location = new System.Drawing.Point(8, 5);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new System.Drawing.Size(19, 27);
            btnInicio.TabIndex = 23;
            btnInicio.Text = "1";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSiguiente.ForeColor = System.Drawing.Color.White;
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnSiguiente.IconColor = System.Drawing.Color.White;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new System.Drawing.Point(141, 10);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new System.Drawing.Size(24, 23);
            btnSiguiente.TabIndex = 21;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.Transparent;
            txtSearch.Br = System.Drawing.Color.MidnightBlue;
            txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.ForeColor = System.Drawing.Color.White;
            txtSearch.Location = new System.Drawing.Point(282, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(136, 29);
            txtSearch.TabIndex = 101;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblFiltradoDeCampo
            // 
            lblFiltradoDeCampo.AutoSize = true;
            lblFiltradoDeCampo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFiltradoDeCampo.ForeColor = System.Drawing.Color.White;
            lblFiltradoDeCampo.Location = new System.Drawing.Point(220, 112);
            lblFiltradoDeCampo.Name = "lblFiltradoDeCampo";
            lblFiltradoDeCampo.Size = new System.Drawing.Size(56, 21);
            lblFiltradoDeCampo.TabIndex = 100;
            lblFiltradoDeCampo.Text = "Buscar";
            // 
            // FmAsignarODT
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            ClientSize = new System.Drawing.Size(981, 489);
            Controls.Add(txtSearch);
            Controls.Add(lblFiltradoDeCampo);
            Controls.Add(panelPaginado);
            Controls.Add(cboxCantidadRegistros);
            Controls.Add(lblregistros);
            Controls.Add(lblMostrar);
            Controls.Add(tbEsPedido);
            Controls.Add(lblPed_SI);
            Controls.Add(lblPed_NO);
            Controls.Add(lbl);
            Controls.Add(GrillaPedidos);
            Controls.Add(lblCompanyTitle);
            Name = "FmAsignarODT";
            Text = "FmAsignarODT";
            Load += FmAsignarODT_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaPedidos).EndInit();
            panelPaginado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCompanyTitle;
        private System.Windows.Forms.DataGridView GrillaPedidos;
        private Tools.FormsTools.ToggleButton tbEsPedido;
        private System.Windows.Forms.Label lblPed_SI;
        private System.Windows.Forms.Label lblPed_NO;
        private System.Windows.Forms.Label lbl;
        private Tools.FormsTools.FmCombobox cboxCantidadRegistros;
        private System.Windows.Forms.Label lblregistros;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Panel panelPaginado;
        private System.Windows.Forms.Button btnTercero;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnInicio;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private AltoControls.AltoTextBox txtSearch;
        private System.Windows.Forms.Label lblFiltradoDeCampo;
    }
}