namespace UI.TextilSoft.SubForms.Pedidos.ListarPedidos
{
    partial class FmListarPedidos
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
            PanelProveedores = new System.Windows.Forms.Panel();
            GrillaPedidos = new System.Windows.Forms.DataGridView();
            lblPedidos = new System.Windows.Forms.Label();
            lblDateDesde = new System.Windows.Forms.Label();
            lblDateHasta = new System.Windows.Forms.Label();
            fmDateDesde = new Tools.FormsTools.FmDateTime();
            fmDateHasta = new Tools.FormsTools.FmDateTime();
            lblMostrar = new System.Windows.Forms.Label();
            lblregistros = new System.Windows.Forms.Label();
            cboxCantidadRegistros = new Tools.FormsTools.FmCombobox();
            btnPrimero = new System.Windows.Forms.Button();
            btnSegundo = new System.Windows.Forms.Button();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnInicio = new System.Windows.Forms.Button();
            btnFinal = new System.Windows.Forms.Button();
            btnTercero = new System.Windows.Forms.Button();
            panelPaginado = new System.Windows.Forms.Panel();
            tbMantenerFiltro = new Tools.FormsTools.ToggleButton();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblMantenerFiltro = new System.Windows.Forms.Label();
            lblFiltradoDeCampo = new System.Windows.Forms.Label();
            txtSearch = new AltoControls.AltoTextBox();
            ((System.ComponentModel.ISupportInitialize)GrillaPedidos).BeginInit();
            panelPaginado.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProveedores
            // 
            PanelProveedores.BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            PanelProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelProveedores.Location = new System.Drawing.Point(0, 0);
            PanelProveedores.Name = "PanelProveedores";
            PanelProveedores.Size = new System.Drawing.Size(800, 450);
            PanelProveedores.TabIndex = 16;
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
            GrillaPedidos.Location = new System.Drawing.Point(11, 98);
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            GrillaPedidos.RowTemplate.Height = 25;
            GrillaPedidos.Size = new System.Drawing.Size(881, 285);
            GrillaPedidos.TabIndex = 4;
            GrillaPedidos.DataSourceChanged += GrillaPedidos_DataSourceChanged;
            // 
            // lblPedidos
            // 
            lblPedidos.AutoSize = true;
            lblPedidos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPedidos.ForeColor = System.Drawing.Color.White;
            lblPedidos.Location = new System.Drawing.Point(303, 9);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new System.Drawing.Size(187, 32);
            lblPedidos.TabIndex = 5;
            lblPedidos.Text = "Lista de pedidos";
            // 
            // lblDateDesde
            // 
            lblDateDesde.AutoSize = true;
            lblDateDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateDesde.ForeColor = System.Drawing.Color.White;
            lblDateDesde.Location = new System.Drawing.Point(460, 72);
            lblDateDesde.Name = "lblDateDesde";
            lblDateDesde.Size = new System.Drawing.Size(53, 21);
            lblDateDesde.TabIndex = 6;
            lblDateDesde.Text = "Desde";
            // 
            // lblDateHasta
            // 
            lblDateHasta.AutoSize = true;
            lblDateHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateHasta.ForeColor = System.Drawing.Color.White;
            lblDateHasta.Location = new System.Drawing.Point(631, 72);
            lblDateHasta.Name = "lblDateHasta";
            lblDateHasta.Size = new System.Drawing.Size(49, 21);
            lblDateHasta.TabIndex = 8;
            lblDateHasta.Text = "Hasta";
            // 
            // fmDateDesde
            // 
            fmDateDesde.BorderColor = System.Drawing.Color.PaleVioletRed;
            fmDateDesde.BorderSize = 0;
            fmDateDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmDateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            fmDateDesde.Location = new System.Drawing.Point(519, 70);
            fmDateDesde.MinimumSize = new System.Drawing.Size(4, 10);
            fmDateDesde.Name = "fmDateDesde";
            fmDateDesde.Size = new System.Drawing.Size(107, 24);
            fmDateDesde.SkinColor = System.Drawing.Color.MediumSlateBlue;
            fmDateDesde.TabIndex = 9;
            fmDateDesde.TextColor = System.Drawing.Color.White;
            fmDateDesde.ValueChanged += fmDateDesde_ValueChanged;
            // 
            // fmDateHasta
            // 
            fmDateHasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            fmDateHasta.BorderSize = 0;
            fmDateHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmDateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            fmDateHasta.Location = new System.Drawing.Point(686, 70);
            fmDateHasta.MinimumSize = new System.Drawing.Size(4, 10);
            fmDateHasta.Name = "fmDateHasta";
            fmDateHasta.Size = new System.Drawing.Size(107, 24);
            fmDateHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            fmDateHasta.TabIndex = 10;
            fmDateHasta.TextColor = System.Drawing.Color.White;
            fmDateHasta.ValueChanged += fmDateHasta_ValueChanged;
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMostrar.ForeColor = System.Drawing.Color.White;
            lblMostrar.Location = new System.Drawing.Point(3, 72);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new System.Drawing.Size(65, 21);
            lblMostrar.TabIndex = 11;
            lblMostrar.Text = "Mostrar";
            // 
            // lblregistros
            // 
            lblregistros.AutoSize = true;
            lblregistros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblregistros.ForeColor = System.Drawing.Color.White;
            lblregistros.Location = new System.Drawing.Point(136, 72);
            lblregistros.Name = "lblregistros";
            lblregistros.Size = new System.Drawing.Size(75, 21);
            lblregistros.TabIndex = 12;
            lblregistros.Text = "Registros";
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
            cboxCantidadRegistros.Location = new System.Drawing.Point(65, 72);
            cboxCantidadRegistros.Name = "cboxCantidadRegistros";
            cboxCantidadRegistros.Padding = new System.Windows.Forms.Padding(1);
            cboxCantidadRegistros.Size = new System.Drawing.Size(65, 21);
            cboxCantidadRegistros.TabIndex = 13;
            cboxCantidadRegistros.Texts = "";
            cboxCantidadRegistros.OnSelectedIndexChanged += cboxCantidadRegistros_OnSelectedIndexChanged;
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
            // panelPaginado
            // 
            panelPaginado.Controls.Add(btnTercero);
            panelPaginado.Controls.Add(btnAnterior);
            panelPaginado.Controls.Add(btnPrimero);
            panelPaginado.Controls.Add(btnFinal);
            panelPaginado.Controls.Add(btnSegundo);
            panelPaginado.Controls.Add(btnInicio);
            panelPaginado.Controls.Add(btnSiguiente);
            panelPaginado.Location = new System.Drawing.Point(683, 387);
            panelPaginado.Name = "panelPaginado";
            panelPaginado.Size = new System.Drawing.Size(209, 36);
            panelPaginado.TabIndex = 26;
            // 
            // tbMantenerFiltro
            // 
            tbMantenerFiltro.Checked = true;
            tbMantenerFiltro.CheckState = System.Windows.Forms.CheckState.Checked;
            tbMantenerFiltro.Location = new System.Drawing.Point(830, 72);
            tbMantenerFiltro.MinimumSize = new System.Drawing.Size(45, 22);
            tbMantenerFiltro.Name = "tbMantenerFiltro";
            tbMantenerFiltro.OffBackColor = System.Drawing.Color.Gray;
            tbMantenerFiltro.OffToggleColor = System.Drawing.Color.Gainsboro;
            tbMantenerFiltro.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tbMantenerFiltro.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tbMantenerFiltro.Size = new System.Drawing.Size(55, 22);
            tbMantenerFiltro.TabIndex = 83;
            tbMantenerFiltro.Text = "toggleButton1";
            tbMantenerFiltro.UseVisualStyleBackColor = true;
            tbMantenerFiltro.CheckedChanged += tbMantenerFiltro_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(884, 72);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 21);
            label4.TabIndex = 85;
            label4.Text = "Si";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(802, 71);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 21);
            label5.TabIndex = 84;
            label5.Text = "No";
            // 
            // lblMantenerFiltro
            // 
            lblMantenerFiltro.AutoSize = true;
            lblMantenerFiltro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMantenerFiltro.ForeColor = System.Drawing.Color.White;
            lblMantenerFiltro.Location = new System.Drawing.Point(799, 39);
            lblMantenerFiltro.Name = "lblMantenerFiltro";
            lblMantenerFiltro.Size = new System.Drawing.Size(108, 20);
            lblMantenerFiltro.TabIndex = 82;
            lblMantenerFiltro.Text = "Mantener filtro";
            // 
            // lblFiltradoDeCampo
            // 
            lblFiltradoDeCampo.AutoSize = true;
            lblFiltradoDeCampo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFiltradoDeCampo.ForeColor = System.Drawing.Color.White;
            lblFiltradoDeCampo.Location = new System.Drawing.Point(234, 72);
            lblFiltradoDeCampo.Name = "lblFiltradoDeCampo";
            lblFiltradoDeCampo.Size = new System.Drawing.Size(56, 21);
            lblFiltradoDeCampo.TabIndex = 86;
            lblFiltradoDeCampo.Text = "Buscar";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.Transparent;
            txtSearch.Br = System.Drawing.Color.MidnightBlue;
            txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.ForeColor = System.Drawing.Color.White;
            txtSearch.Location = new System.Drawing.Point(296, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(136, 29);
            txtSearch.TabIndex = 87;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // FmListarPedidos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(919, 548);
            Controls.Add(txtSearch);
            Controls.Add(lblFiltradoDeCampo);
            Controls.Add(tbMantenerFiltro);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lblMantenerFiltro);
            Controls.Add(cboxCantidadRegistros);
            Controls.Add(lblregistros);
            Controls.Add(lblMostrar);
            Controls.Add(fmDateHasta);
            Controls.Add(fmDateDesde);
            Controls.Add(lblDateHasta);
            Controls.Add(lblDateDesde);
            Controls.Add(lblPedidos);
            Controls.Add(GrillaPedidos);
            Controls.Add(panelPaginado);
            Name = "FmListarPedidos";
            Text = "FmListarPedidos";
            Load += FmListarPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaPedidos).EndInit();
            panelPaginado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel PanelProveedores;
        private System.Windows.Forms.DataGridView GrillaPedidos;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblDateDesde;
        private System.Windows.Forms.Label lblDateHasta;
        private Tools.FormsTools.FmDateTime fmDateDesde;
        private Tools.FormsTools.FmDateTime fmDateHasta;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblregistros;
        private Tools.FormsTools.FmCombobox cboxCantidadRegistros;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSegundo;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnTercero;
        private System.Windows.Forms.Panel panelPaginado;
        private Tools.FormsTools.ToggleButton tbMantenerFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMantenerFiltro;
        private System.Windows.Forms.Label lblFiltradoDeCampo;
        private AltoControls.AltoTextBox txtSearch;
    }
}