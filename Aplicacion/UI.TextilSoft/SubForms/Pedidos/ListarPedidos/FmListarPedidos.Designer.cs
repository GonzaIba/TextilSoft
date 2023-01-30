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
            this.GrillaPedidos.Location = new System.Drawing.Point(4, 125);
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
            this.GrillaPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.GrillaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.lblDateDesde.Location = new System.Drawing.Point(80, 99);
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
            this.lblDateHasta.Location = new System.Drawing.Point(310, 99);
            this.lblDateHasta.Name = "lblDateHasta";
            this.lblDateHasta.Size = new System.Drawing.Size(59, 25);
            this.lblDateHasta.TabIndex = 8;
            this.lblDateHasta.Text = "Hasta";
            // 
            // FmListarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(892, 522);
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
    }
}