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
            this.PanelProveedores = new System.Windows.Forms.Panel();
            this.GrillaPedidos = new System.Windows.Forms.DataGridView();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblDateDesde = new System.Windows.Forms.Label();
            this.lblDateHasta = new System.Windows.Forms.Label();
            this.fmDateDesde = new UI.TextilSoft.Tools.FormsTools.FmDateTime();
            this.fmDateHasta = new UI.TextilSoft.Tools.FormsTools.FmDateTime();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblregistros = new System.Windows.Forms.Label();
            this.cboxCantidadRegistros = new UI.TextilSoft.Tools.FormsTools.FmCombobox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnSiguiente = new FontAwesome.Sharp.IconButton();
            this.btnAnterior = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnTercero = new System.Windows.Forms.Button();
            this.panelPaginado = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPedidos)).BeginInit();
            this.panelPaginado.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelProveedores
            // 
            this.PanelProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PanelProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProveedores.Location = new System.Drawing.Point(0, 0);
            this.PanelProveedores.Name = "PanelProveedores";
            this.PanelProveedores.Size = new System.Drawing.Size(800, 450);
            this.PanelProveedores.TabIndex = 16;
            // 
            // GrillaPedidos
            // 
            this.GrillaPedidos.AllowUserToResizeColumns = false;
            this.GrillaPedidos.AllowUserToResizeRows = false;
            this.GrillaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.GrillaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrillaPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GrillaPedidos.EnableHeadersVisualStyles = false;
            this.GrillaPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.GrillaPedidos.Location = new System.Drawing.Point(11, 98);
            this.GrillaPedidos.Name = "GrillaPedidos";
            this.GrillaPedidos.ReadOnly = true;
            this.GrillaPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.GrillaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaPedidos.RowTemplate.Height = 25;
            this.GrillaPedidos.Size = new System.Drawing.Size(881, 285);
            this.GrillaPedidos.TabIndex = 4;
            this.GrillaPedidos.DataSourceChanged += new System.EventHandler(this.GrillaPedidos_DataSourceChanged);
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(303, 9);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(187, 32);
            this.lblPedidos.TabIndex = 5;
            this.lblPedidos.Text = "Lista de pedidos";
            // 
            // lblDateDesde
            // 
            this.lblDateDesde.AutoSize = true;
            this.lblDateDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateDesde.ForeColor = System.Drawing.Color.White;
            this.lblDateDesde.Location = new System.Drawing.Point(519, 72);
            this.lblDateDesde.Name = "lblDateDesde";
            this.lblDateDesde.Size = new System.Drawing.Size(53, 21);
            this.lblDateDesde.TabIndex = 6;
            this.lblDateDesde.Text = "Desde";
            // 
            // lblDateHasta
            // 
            this.lblDateHasta.AutoSize = true;
            this.lblDateHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateHasta.ForeColor = System.Drawing.Color.White;
            this.lblDateHasta.Location = new System.Drawing.Point(707, 72);
            this.lblDateHasta.Name = "lblDateHasta";
            this.lblDateHasta.Size = new System.Drawing.Size(49, 21);
            this.lblDateHasta.TabIndex = 8;
            this.lblDateHasta.Text = "Hasta";
            // 
            // fmDateDesde
            // 
            this.fmDateDesde.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fmDateDesde.BorderSize = 0;
            this.fmDateDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fmDateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fmDateDesde.Location = new System.Drawing.Point(578, 70);
            this.fmDateDesde.MinimumSize = new System.Drawing.Size(4, 10);
            this.fmDateDesde.Name = "fmDateDesde";
            this.fmDateDesde.Size = new System.Drawing.Size(107, 24);
            this.fmDateDesde.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.fmDateDesde.TabIndex = 9;
            this.fmDateDesde.TextColor = System.Drawing.Color.White;
            this.fmDateDesde.ValueChanged += new System.EventHandler(this.fmDateDesde_ValueChanged);
            // 
            // fmDateHasta
            // 
            this.fmDateHasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fmDateHasta.BorderSize = 0;
            this.fmDateHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fmDateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fmDateHasta.Location = new System.Drawing.Point(762, 70);
            this.fmDateHasta.MinimumSize = new System.Drawing.Size(4, 10);
            this.fmDateHasta.Name = "fmDateHasta";
            this.fmDateHasta.Size = new System.Drawing.Size(107, 24);
            this.fmDateHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.fmDateHasta.TabIndex = 10;
            this.fmDateHasta.TextColor = System.Drawing.Color.White;
            this.fmDateHasta.ValueChanged += new System.EventHandler(this.fmDateHasta_ValueChanged);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMostrar.ForeColor = System.Drawing.Color.White;
            this.lblMostrar.Location = new System.Drawing.Point(4, 73);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(65, 21);
            this.lblMostrar.TabIndex = 11;
            this.lblMostrar.Text = "Mostrar";
            // 
            // lblregistros
            // 
            this.lblregistros.AutoSize = true;
            this.lblregistros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblregistros.ForeColor = System.Drawing.Color.White;
            this.lblregistros.Location = new System.Drawing.Point(137, 73);
            this.lblregistros.Name = "lblregistros";
            this.lblregistros.Size = new System.Drawing.Size(75, 21);
            this.lblregistros.TabIndex = 12;
            this.lblregistros.Text = "Registros";
            // 
            // cboxCantidadRegistros
            // 
            this.cboxCantidadRegistros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboxCantidadRegistros.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboxCantidadRegistros.BorderSize = 1;
            this.cboxCantidadRegistros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboxCantidadRegistros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxCantidadRegistros.ForeColor = System.Drawing.Color.DimGray;
            this.cboxCantidadRegistros.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboxCantidadRegistros.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cboxCantidadRegistros.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboxCantidadRegistros.ListTextColor = System.Drawing.Color.DimGray;
            this.cboxCantidadRegistros.Location = new System.Drawing.Point(66, 73);
            this.cboxCantidadRegistros.Name = "cboxCantidadRegistros";
            this.cboxCantidadRegistros.Padding = new System.Windows.Forms.Padding(1);
            this.cboxCantidadRegistros.Size = new System.Drawing.Size(65, 21);
            this.cboxCantidadRegistros.TabIndex = 13;
            this.cboxCantidadRegistros.Texts = "";
            this.cboxCantidadRegistros.OnSelectedIndexChanged += new System.EventHandler(this.cboxCantidadRegistros_OnSelectedIndexChanged);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.ForeColor = System.Drawing.Color.White;
            this.btnPrimero.Location = new System.Drawing.Point(55, 8);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(24, 23);
            this.btnPrimero.TabIndex = 17;
            this.btnPrimero.Text = "1";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSegundo.FlatAppearance.BorderSize = 0;
            this.btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundo.ForeColor = System.Drawing.Color.White;
            this.btnSegundo.Location = new System.Drawing.Point(85, 8);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(24, 23);
            this.btnSegundo.TabIndex = 19;
            this.btnSegundo.Text = "2";
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnSiguiente.IconColor = System.Drawing.Color.White;
            this.btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSiguiente.IconSize = 20;
            this.btnSiguiente.Location = new System.Drawing.Point(141, 10);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(24, 23);
            this.btnSiguiente.TabIndex = 21;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnAnterior.IconColor = System.Drawing.Color.White;
            this.btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnterior.IconSize = 20;
            this.btnAnterior.Location = new System.Drawing.Point(29, 10);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(24, 23);
            this.btnAnterior.TabIndex = 22;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(8, 5);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(19, 27);
            this.btnInicio.TabIndex = 23;
            this.btnInicio.Text = "1";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Location = new System.Drawing.Point(160, 6);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(42, 28);
            this.btnFinal.TabIndex = 24;
            this.btnFinal.Text = "...N";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnTercero
            // 
            this.btnTercero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTercero.FlatAppearance.BorderSize = 0;
            this.btnTercero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTercero.ForeColor = System.Drawing.Color.White;
            this.btnTercero.Location = new System.Drawing.Point(114, 8);
            this.btnTercero.Name = "btnTercero";
            this.btnTercero.Size = new System.Drawing.Size(24, 23);
            this.btnTercero.TabIndex = 25;
            this.btnTercero.Text = "3";
            this.btnTercero.UseVisualStyleBackColor = true;
            this.btnTercero.Click += new System.EventHandler(this.btnTercero_Click);
            // 
            // panelPaginado
            // 
            this.panelPaginado.Controls.Add(this.btnTercero);
            this.panelPaginado.Controls.Add(this.btnAnterior);
            this.panelPaginado.Controls.Add(this.btnPrimero);
            this.panelPaginado.Controls.Add(this.btnFinal);
            this.panelPaginado.Controls.Add(this.btnSegundo);
            this.panelPaginado.Controls.Add(this.btnInicio);
            this.panelPaginado.Controls.Add(this.btnSiguiente);
            this.panelPaginado.Location = new System.Drawing.Point(683, 387);
            this.panelPaginado.Name = "panelPaginado";
            this.panelPaginado.Size = new System.Drawing.Size(209, 36);
            this.panelPaginado.TabIndex = 26;
            // 
            // FmListarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(909, 548);
            this.Controls.Add(this.cboxCantidadRegistros);
            this.Controls.Add(this.lblregistros);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.fmDateHasta);
            this.Controls.Add(this.fmDateDesde);
            this.Controls.Add(this.lblDateHasta);
            this.Controls.Add(this.lblDateDesde);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.GrillaPedidos);
            this.Controls.Add(this.panelPaginado);
            this.Name = "FmListarPedidos";
            this.Text = "FmListarPedidos";
            this.Load += new System.EventHandler(this.FmListarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPedidos)).EndInit();
            this.panelPaginado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}