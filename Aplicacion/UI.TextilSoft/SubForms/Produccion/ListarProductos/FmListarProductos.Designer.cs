namespace UI.TextilSoft.SubForms.Produccion.ListarProductos
{
    partial class FmListarProductos
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
            txtSearch = new AltoControls.AltoTextBox();
            panelPaginado = new System.Windows.Forms.Panel();
            btnTercero = new System.Windows.Forms.Button();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnPrimero = new System.Windows.Forms.Button();
            btnFinal = new System.Windows.Forms.Button();
            btnSegundo = new System.Windows.Forms.Button();
            btnInicio = new System.Windows.Forms.Button();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            lblFiltradoDeCampo = new System.Windows.Forms.Label();
            lblregistros = new System.Windows.Forms.Label();
            lblMostrar = new System.Windows.Forms.Label();
            lblProductos = new System.Windows.Forms.Label();
            GrillaProductos = new System.Windows.Forms.DataGridView();
            PanelProduccion = new System.Windows.Forms.Panel();
            cboxCantidadRegistros = new Tools.FormsTools.FmCombobox();
            panelPaginado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrillaProductos).BeginInit();
            PanelProduccion.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = System.Drawing.Color.Transparent;
            txtSearch.Br = System.Drawing.Color.MidnightBlue;
            txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearch.ForeColor = System.Drawing.Color.White;
            txtSearch.Location = new System.Drawing.Point(302, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(136, 29);
            txtSearch.TabIndex = 100;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            panelPaginado.Location = new System.Drawing.Point(689, 387);
            panelPaginado.Name = "panelPaginado";
            panelPaginado.Size = new System.Drawing.Size(209, 36);
            panelPaginado.TabIndex = 95;
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
            // lblFiltradoDeCampo
            // 
            lblFiltradoDeCampo.AutoSize = true;
            lblFiltradoDeCampo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFiltradoDeCampo.ForeColor = System.Drawing.Color.White;
            lblFiltradoDeCampo.Location = new System.Drawing.Point(240, 72);
            lblFiltradoDeCampo.Name = "lblFiltradoDeCampo";
            lblFiltradoDeCampo.Size = new System.Drawing.Size(56, 21);
            lblFiltradoDeCampo.TabIndex = 99;
            lblFiltradoDeCampo.Text = "Buscar";
            // 
            // lblregistros
            // 
            lblregistros.AutoSize = true;
            lblregistros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblregistros.ForeColor = System.Drawing.Color.White;
            lblregistros.Location = new System.Drawing.Point(142, 72);
            lblregistros.Name = "lblregistros";
            lblregistros.Size = new System.Drawing.Size(75, 21);
            lblregistros.TabIndex = 93;
            lblregistros.Text = "Registros";
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMostrar.ForeColor = System.Drawing.Color.White;
            lblMostrar.Location = new System.Drawing.Point(9, 72);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new System.Drawing.Size(65, 21);
            lblMostrar.TabIndex = 92;
            lblMostrar.Text = "Mostrar";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProductos.ForeColor = System.Drawing.Color.White;
            lblProductos.Location = new System.Drawing.Point(332, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new System.Drawing.Size(209, 32);
            lblProductos.TabIndex = 89;
            lblProductos.Text = "Lista de productos";
            // 
            // GrillaProductos
            // 
            GrillaProductos.AllowUserToResizeColumns = false;
            GrillaProductos.AllowUserToResizeRows = false;
            GrillaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            GrillaProductos.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 45);
            GrillaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GrillaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GrillaProductos.EnableHeadersVisualStyles = false;
            GrillaProductos.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            GrillaProductos.Location = new System.Drawing.Point(17, 98);
            GrillaProductos.Name = "GrillaProductos";
            GrillaProductos.ReadOnly = true;
            GrillaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            GrillaProductos.RowTemplate.Height = 25;
            GrillaProductos.Size = new System.Drawing.Size(881, 285);
            GrillaProductos.TabIndex = 88;
            GrillaProductos.CellContentClick += GrillaProductos_CellContentClick;
            GrillaProductos.CellMouseClick += GrillaProductos_CellMouseClick_1;
            GrillaProductos.DataBindingComplete += GrillaProductos_DataBindingComplete;
            // 
            // PanelProduccion
            // 
            PanelProduccion.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            PanelProduccion.Controls.Add(cboxCantidadRegistros);
            PanelProduccion.Controls.Add(txtSearch);
            PanelProduccion.Controls.Add(lblProductos);
            PanelProduccion.Controls.Add(GrillaProductos);
            PanelProduccion.Controls.Add(panelPaginado);
            PanelProduccion.Controls.Add(lblMostrar);
            PanelProduccion.Controls.Add(lblFiltradoDeCampo);
            PanelProduccion.Controls.Add(lblregistros);
            PanelProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelProduccion.Location = new System.Drawing.Point(0, 0);
            PanelProduccion.Name = "PanelProduccion";
            PanelProduccion.Size = new System.Drawing.Size(916, 513);
            PanelProduccion.TabIndex = 94;
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
            cboxCantidadRegistros.Location = new System.Drawing.Point(75, 73);
            cboxCantidadRegistros.Name = "cboxCantidadRegistros";
            cboxCantidadRegistros.Padding = new System.Windows.Forms.Padding(1);
            cboxCantidadRegistros.Size = new System.Drawing.Size(65, 21);
            cboxCantidadRegistros.TabIndex = 102;
            cboxCantidadRegistros.Texts = "";
            cboxCantidadRegistros.OnSelectedIndexChanged += cboxCantidadRegistros_OnSelectedIndexChanged;
            // 
            // FmListarProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(916, 513);
            Controls.Add(PanelProduccion);
            Name = "FmListarProductos";
            Text = "FmListarProductos";
            Load += FmListarProductos_Load;
            panelPaginado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrillaProductos).EndInit();
            PanelProduccion.ResumeLayout(false);
            PanelProduccion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AltoControls.AltoTextBox txtSearch;
        private System.Windows.Forms.Panel panelPaginado;
        private System.Windows.Forms.Button btnTercero;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnInicio;
        private FontAwesome.Sharp.IconButton btnSiguiente;
        private System.Windows.Forms.Label lblFiltradoDeCampo;
        private System.Windows.Forms.Label lblregistros;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView GrillaProductos;
        private System.Windows.Forms.Panel PanelProduccion;
        private Tools.FormsTools.FmCombobox cboxCantidadRegistros;
    }
}