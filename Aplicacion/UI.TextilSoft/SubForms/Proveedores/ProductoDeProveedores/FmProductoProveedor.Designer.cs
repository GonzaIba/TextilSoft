namespace UI.TextilSoft.SubForms.Proveedores.Producto_de_proveedores
{
    partial class FmProductoProveedor
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
                components.Remove(ProveedoresAnimator);
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmProductoProveedor));
            this.lblProductos = new System.Windows.Forms.Label();
            this.GrillaProductoProveedores = new System.Windows.Forms.DataGridView();
            this.btnProductoProveedor = new FontAwesome.Sharp.IconButton();
            this.ProveedoresAnimator = new AnimatorNS.Animator(this.components);
            this.PanelProdProveedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductoProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.ProveedoresAnimator.SetDecoration(this.lblProductos, AnimatorNS.DecorationType.None);
            this.lblProductos.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductos.ForeColor = System.Drawing.Color.Transparent;
            this.lblProductos.Location = new System.Drawing.Point(225, 25);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(356, 37);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos de proveedores";
            // 
            // GrillaProductoProveedores
            // 
            this.GrillaProductoProveedores.AllowUserToResizeColumns = false;
            this.GrillaProductoProveedores.AllowUserToResizeRows = false;
            this.GrillaProductoProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaProductoProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.GrillaProductoProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaProductoProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrillaProductoProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaProductoProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaProductoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProveedoresAnimator.SetDecoration(this.GrillaProductoProveedores, AnimatorNS.DecorationType.None);
            this.GrillaProductoProveedores.EnableHeadersVisualStyles = false;
            this.GrillaProductoProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.GrillaProductoProveedores.Location = new System.Drawing.Point(35, 85);
            this.GrillaProductoProveedores.Name = "GrillaProductoProveedores";
            this.GrillaProductoProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaProductoProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaProductoProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.GrillaProductoProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaProductoProveedores.RowTemplate.Height = 25;
            this.GrillaProductoProveedores.Size = new System.Drawing.Size(812, 285);
            this.GrillaProductoProveedores.TabIndex = 4;
            this.GrillaProductoProveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GrillaProductoProveedores_MouseClick);
            // 
            // btnProductoProveedor
            // 
            this.ProveedoresAnimator.SetDecoration(this.btnProductoProveedor, AnimatorNS.DecorationType.None);
            this.btnProductoProveedor.FlatAppearance.BorderSize = 0;
            this.btnProductoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProductoProveedor.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnProductoProveedor.IconColor = System.Drawing.Color.White;
            this.btnProductoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductoProveedor.IconSize = 37;
            this.btnProductoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoProveedor.Location = new System.Drawing.Point(35, 394);
            this.btnProductoProveedor.Name = "btnProductoProveedor";
            this.btnProductoProveedor.Size = new System.Drawing.Size(107, 44);
            this.btnProductoProveedor.TabIndex = 9;
            this.btnProductoProveedor.Text = "Ver proveedores";
            this.btnProductoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductoProveedor.UseVisualStyleBackColor = true;
            this.btnProductoProveedor.Click += new System.EventHandler(this.btnProductoProveedor_Click);
            // 
            // ProveedoresAnimator
            // 
            this.ProveedoresAnimator.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.ProveedoresAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.ProveedoresAnimator.DefaultAnimation = animation1;
            this.ProveedoresAnimator.TimeStep = 0.01F;
            // 
            // PanelProdProveedor
            // 
            this.ProveedoresAnimator.SetDecoration(this.PanelProdProveedor, AnimatorNS.DecorationType.None);
            this.PanelProdProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProdProveedor.Location = new System.Drawing.Point(0, 0);
            this.PanelProdProveedor.Name = "PanelProdProveedor";
            this.PanelProdProveedor.Size = new System.Drawing.Size(894, 450);
            this.PanelProdProveedor.TabIndex = 10;
            this.PanelProdProveedor.Visible = false;
            this.PanelProdProveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProdProveedor_Paint);
            // 
            // FmProductoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.btnProductoProveedor);
            this.Controls.Add(this.GrillaProductoProveedores);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.PanelProdProveedor);
            this.ProveedoresAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "FmProductoProveedor";
            this.Text = "FmProductoProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductoProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView GrillaProductoProveedores;
        private FontAwesome.Sharp.IconButton btnProductoProveedor;
        private AnimatorNS.Animator ProveedoresAnimator;
        private System.Windows.Forms.Panel PanelProdProveedor;
    }
}