namespace UI.TextilSoft.SubForms.Informes_Reportes.Reporte_Ventas
{
    partial class FmReporteVentas
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
            lblPrincipal = new System.Windows.Forms.Label();
            fmDateHasta = new Tools.FormsTools.FmDateTime();
            fmDateDesde = new Tools.FormsTools.FmDateTime();
            lblDateHasta = new System.Windows.Forms.Label();
            lblDateDesde = new System.Windows.Forms.Label();
            GrillaReportes = new System.Windows.Forms.DataGridView();
            fmCboxTipoOperacion = new Tools.FormsTools.FmCombobox();
            lblCollareta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)GrillaReportes).BeginInit();
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(211, 9);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(258, 41);
            lblPrincipal.TabIndex = 37;
            lblPrincipal.Text = "Reporte de ventas";
            // 
            // fmDateHasta
            // 
            fmDateHasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            fmDateHasta.BorderSize = 0;
            fmDateHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmDateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            fmDateHasta.Location = new System.Drawing.Point(373, 190);
            fmDateHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmDateHasta.MinimumSize = new System.Drawing.Size(4, 10);
            fmDateHasta.Name = "fmDateHasta";
            fmDateHasta.Size = new System.Drawing.Size(122, 29);
            fmDateHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            fmDateHasta.TabIndex = 41;
            fmDateHasta.TextColor = System.Drawing.Color.White;
            // 
            // fmDateDesde
            // 
            fmDateDesde.BorderColor = System.Drawing.Color.PaleVioletRed;
            fmDateDesde.BorderSize = 0;
            fmDateDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmDateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            fmDateDesde.Location = new System.Drawing.Point(187, 190);
            fmDateDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmDateDesde.MinimumSize = new System.Drawing.Size(4, 10);
            fmDateDesde.Name = "fmDateDesde";
            fmDateDesde.Size = new System.Drawing.Size(122, 29);
            fmDateDesde.SkinColor = System.Drawing.Color.MediumSlateBlue;
            fmDateDesde.TabIndex = 40;
            fmDateDesde.TextColor = System.Drawing.Color.White;
            // 
            // lblDateHasta
            // 
            lblDateHasta.AutoSize = true;
            lblDateHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateHasta.ForeColor = System.Drawing.Color.White;
            lblDateHasta.Location = new System.Drawing.Point(404, 158);
            lblDateHasta.Name = "lblDateHasta";
            lblDateHasta.Size = new System.Drawing.Size(61, 28);
            lblDateHasta.TabIndex = 39;
            lblDateHasta.Text = "Hasta";
            // 
            // lblDateDesde
            // 
            lblDateDesde.AutoSize = true;
            lblDateDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateDesde.ForeColor = System.Drawing.Color.White;
            lblDateDesde.Location = new System.Drawing.Point(211, 158);
            lblDateDesde.Name = "lblDateDesde";
            lblDateDesde.Size = new System.Drawing.Size(66, 28);
            lblDateDesde.TabIndex = 38;
            lblDateDesde.Text = "Desde";
            // 
            // GrillaReportes
            // 
            GrillaReportes.AllowUserToResizeColumns = false;
            GrillaReportes.AllowUserToResizeRows = false;
            GrillaReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            GrillaReportes.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 50);
            GrillaReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GrillaReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GrillaReportes.ColumnHeadersHeight = 29;
            GrillaReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GrillaReportes.EnableHeadersVisualStyles = false;
            GrillaReportes.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            GrillaReportes.Location = new System.Drawing.Point(42, 227);
            GrillaReportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GrillaReportes.Name = "GrillaReportes";
            GrillaReportes.ReadOnly = true;
            GrillaReportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaReportes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GrillaReportes.RowHeadersWidth = 51;
            GrillaReportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaReportes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            GrillaReportes.RowTemplate.Height = 25;
            GrillaReportes.Size = new System.Drawing.Size(626, 267);
            GrillaReportes.TabIndex = 42;
            // 
            // fmCboxTipoOperacion
            // 
            fmCboxTipoOperacion.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTipoOperacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoOperacion.BorderSize = 0;
            fmCboxTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTipoOperacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTipoOperacion.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTipoOperacion.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoOperacion.Items.AddRange(new object[] { "Prenda Mas Vendida", "Prenda Menos Vendida", "Prenda Mas Defectuosa", "Total Capital Recibido" });
            fmCboxTipoOperacion.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTipoOperacion.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTipoOperacion.Location = new System.Drawing.Point(211, 126);
            fmCboxTipoOperacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxTipoOperacion.Name = "fmCboxTipoOperacion";
            fmCboxTipoOperacion.Size = new System.Drawing.Size(254, 27);
            fmCboxTipoOperacion.TabIndex = 127;
            fmCboxTipoOperacion.Texts = "";
            fmCboxTipoOperacion.OnSelectedIndexChanged += fmCboxTipoArmado_OnSelectedIndexChanged;
            // 
            // lblCollareta
            // 
            lblCollareta.AutoSize = true;
            lblCollareta.ForeColor = System.Drawing.Color.White;
            lblCollareta.Location = new System.Drawing.Point(248, 90);
            lblCollareta.Name = "lblCollareta";
            lblCollareta.Size = new System.Drawing.Size(179, 20);
            lblCollareta.TabIndex = 126;
            lblCollareta.Text = "Seleccione una operación";
            // 
            // FmReporteVentas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(727, 539);
            Controls.Add(fmCboxTipoOperacion);
            Controls.Add(lblCollareta);
            Controls.Add(GrillaReportes);
            Controls.Add(fmDateHasta);
            Controls.Add(fmDateDesde);
            Controls.Add(lblDateHasta);
            Controls.Add(lblDateDesde);
            Controls.Add(lblPrincipal);
            Name = "FmReporteVentas";
            Text = "FmReporteVentas";
            Load += FmReporteVentas_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private Tools.FormsTools.FmDateTime fmDateHasta;
        private Tools.FormsTools.FmDateTime fmDateDesde;
        private System.Windows.Forms.Label lblDateHasta;
        private System.Windows.Forms.Label lblDateDesde;
        private System.Windows.Forms.DataGridView GrillaReportes;
        private Tools.FormsTools.FmCombobox fmCboxTipoOperacion;
        private System.Windows.Forms.Label lblCollareta;
    }
}