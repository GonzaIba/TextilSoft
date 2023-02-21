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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelProveedores = new System.Windows.Forms.Panel();
            this.GrillaPedidos = new System.Windows.Forms.DataGridView();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblDateDesde = new System.Windows.Forms.Label();
            this.lblDateHasta = new System.Windows.Forms.Label();
            this.fmDateDesde = new UI.TextilSoft.Tools.FormsTools.FmDateTime();
            this.fmDateHasta = new UI.TextilSoft.Tools.FormsTools.FmDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPedidos)).BeginInit();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GrillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GrillaPedidos.EnableHeadersVisualStyles = false;
            this.GrillaPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.GrillaPedidos.Location = new System.Drawing.Point(4, 125);
            this.GrillaPedidos.Name = "GrillaPedidos";
            this.GrillaPedidos.ReadOnly = true;
            this.GrillaPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.GrillaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.GrillaPedidos.RowTemplate.Height = 25;
            this.GrillaPedidos.Size = new System.Drawing.Size(876, 285);
            this.GrillaPedidos.TabIndex = 4;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(333, 21);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(187, 32);
            this.lblPedidos.TabIndex = 5;
            this.lblPedidos.Text = "Lista de pedidos";
            // 
            // lblDateDesde
            // 
            this.lblDateDesde.AutoSize = true;
            this.lblDateDesde.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateDesde.ForeColor = System.Drawing.Color.White;
            this.lblDateDesde.Location = new System.Drawing.Point(56, 93);
            this.lblDateDesde.Name = "lblDateDesde";
            this.lblDateDesde.Size = new System.Drawing.Size(64, 25);
            this.lblDateDesde.TabIndex = 6;
            this.lblDateDesde.Text = "Desde";
            // 
            // lblDateHasta
            // 
            this.lblDateHasta.AutoSize = true;
            this.lblDateHasta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateHasta.ForeColor = System.Drawing.Color.White;
            this.lblDateHasta.Location = new System.Drawing.Point(252, 93);
            this.lblDateHasta.Name = "lblDateHasta";
            this.lblDateHasta.Size = new System.Drawing.Size(59, 25);
            this.lblDateHasta.TabIndex = 8;
            this.lblDateHasta.Text = "Hasta";
            // 
            // fmDateDesde
            // 
            this.fmDateDesde.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fmDateDesde.BorderSize = 0;
            this.fmDateDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fmDateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fmDateDesde.Location = new System.Drawing.Point(126, 88);
            this.fmDateDesde.MinimumSize = new System.Drawing.Size(0, 35);
            this.fmDateDesde.Name = "fmDateDesde";
            this.fmDateDesde.Size = new System.Drawing.Size(107, 35);
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
            this.fmDateHasta.Location = new System.Drawing.Point(317, 88);
            this.fmDateHasta.MinimumSize = new System.Drawing.Size(0, 35);
            this.fmDateHasta.Name = "fmDateHasta";
            this.fmDateHasta.Size = new System.Drawing.Size(107, 35);
            this.fmDateHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.fmDateHasta.TabIndex = 10;
            this.fmDateHasta.TextColor = System.Drawing.Color.White;
            this.fmDateHasta.ValueChanged += new System.EventHandler(this.fmDateHasta_ValueChanged);
            // 
            // FmListarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(892, 522);
            this.Controls.Add(this.fmDateHasta);
            this.Controls.Add(this.fmDateDesde);
            this.Controls.Add(this.lblDateHasta);
            this.Controls.Add(this.lblDateDesde);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.GrillaPedidos);
            this.Name = "FmListarPedidos";
            this.Text = "FmListarPedidos";
            this.Load += new System.EventHandler(this.FmListarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPedidos)).EndInit();
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
    }
}