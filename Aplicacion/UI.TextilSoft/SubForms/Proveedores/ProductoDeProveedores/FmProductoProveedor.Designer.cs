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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmProductoProveedor));
            lblProductos = new System.Windows.Forms.Label();
            GrillaProductoProveedores = new System.Windows.Forms.DataGridView();
            btnProductoProveedor = new FontAwesome.Sharp.IconButton();
            ProveedoresAnimator = new AnimatorNS.Animator(components);
            PanelProdProveedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)GrillaProductoProveedores).BeginInit();
            PanelProdProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            ProveedoresAnimator.SetDecoration(lblProductos, AnimatorNS.DecorationType.None);
            lblProductos.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProductos.ForeColor = System.Drawing.Color.Transparent;
            lblProductos.Location = new System.Drawing.Point(247, 27);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new System.Drawing.Size(356, 37);
            lblProductos.TabIndex = 3;
            lblProductos.Text = "Productos de proveedores";
            // 
            // GrillaProductoProveedores
            // 
            GrillaProductoProveedores.AllowUserToResizeColumns = false;
            GrillaProductoProveedores.AllowUserToResizeRows = false;
            GrillaProductoProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            GrillaProductoProveedores.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 45);
            GrillaProductoProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GrillaProductoProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaProductoProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaProductoProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GrillaProductoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProveedoresAnimator.SetDecoration(GrillaProductoProveedores, AnimatorNS.DecorationType.None);
            GrillaProductoProveedores.EnableHeadersVisualStyles = false;
            GrillaProductoProveedores.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            GrillaProductoProveedores.Location = new System.Drawing.Point(35, 85);
            GrillaProductoProveedores.Name = "GrillaProductoProveedores";
            GrillaProductoProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaProductoProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GrillaProductoProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaProductoProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            GrillaProductoProveedores.RowTemplate.Height = 25;
            GrillaProductoProveedores.Size = new System.Drawing.Size(812, 335);
            GrillaProductoProveedores.TabIndex = 4;
            GrillaProductoProveedores.MouseClick += GrillaProductoProveedores_MouseClick;
            // 
            // btnProductoProveedor
            // 
            ProveedoresAnimator.SetDecoration(btnProductoProveedor, AnimatorNS.DecorationType.None);
            btnProductoProveedor.FlatAppearance.BorderSize = 0;
            btnProductoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductoProveedor.ForeColor = System.Drawing.Color.White;
            btnProductoProveedor.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnProductoProveedor.IconColor = System.Drawing.Color.White;
            btnProductoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductoProveedor.IconSize = 37;
            btnProductoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProductoProveedor.Location = new System.Drawing.Point(35, 426);
            btnProductoProveedor.Name = "btnProductoProveedor";
            btnProductoProveedor.Size = new System.Drawing.Size(107, 44);
            btnProductoProveedor.TabIndex = 9;
            btnProductoProveedor.Text = "Ver proveedores";
            btnProductoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProductoProveedor.UseVisualStyleBackColor = true;
            btnProductoProveedor.Click += btnProductoProveedor_Click;
            // 
            // ProveedoresAnimator
            // 
            ProveedoresAnimator.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            ProveedoresAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (System.Drawing.PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (System.Drawing.PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (System.Drawing.PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            ProveedoresAnimator.DefaultAnimation = animation1;
            ProveedoresAnimator.TimeStep = 0.01F;
            // 
            // PanelProdProveedor
            // 
            PanelProdProveedor.Controls.Add(btnProductoProveedor);
            PanelProdProveedor.Controls.Add(lblProductos);
            ProveedoresAnimator.SetDecoration(PanelProdProveedor, AnimatorNS.DecorationType.None);
            PanelProdProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelProdProveedor.Location = new System.Drawing.Point(0, 0);
            PanelProdProveedor.Name = "PanelProdProveedor";
            PanelProdProveedor.Size = new System.Drawing.Size(894, 482);
            PanelProdProveedor.TabIndex = 10;
            PanelProdProveedor.Visible = false;
            PanelProdProveedor.Paint += PanelProdProveedor_Paint;
            // 
            // FmProductoProveedor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(894, 482);
            Controls.Add(GrillaProductoProveedores);
            Controls.Add(PanelProdProveedor);
            ProveedoresAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Name = "FmProductoProveedor";
            Text = "FmProductoProveedor";
            Load += FmProductoProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaProductoProveedores).EndInit();
            PanelProdProveedor.ResumeLayout(false);
            PanelProdProveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView GrillaProductoProveedores;
        private FontAwesome.Sharp.IconButton btnProductoProveedor;
        private AnimatorNS.Animator ProveedoresAnimator;
        private System.Windows.Forms.Panel PanelProdProveedor;
    }
}