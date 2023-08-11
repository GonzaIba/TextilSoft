namespace UI.TextilSoft.SubForms.Proveedores
{
    partial class FmProveedores
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            ProveedoresAnimator = new AnimatorNS.Animator(components);
            label1 = new System.Windows.Forms.Label();
            GrillaProveedores = new System.Windows.Forms.DataGridView();
            btnSaveChanges = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnRejectChanges = new FontAwesome.Sharp.IconButton();
            btnProductoProveedor = new FontAwesome.Sharp.IconButton();
            PanelProveedores = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)GrillaProveedores).BeginInit();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ProveedoresAnimator.SetDecoration(label1, AnimatorNS.DecorationType.None);
            label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(328, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(219, 46);
            label1.TabIndex = 2;
            label1.Text = "Proveedores";
            // 
            // GrillaProveedores
            // 
            GrillaProveedores.AllowUserToResizeColumns = false;
            GrillaProveedores.AllowUserToResizeRows = false;
            GrillaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            GrillaProveedores.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 45);
            GrillaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            GrillaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            GrillaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GrillaProveedores.ColumnHeadersHeight = 29;
            GrillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProveedoresAnimator.SetDecoration(GrillaProveedores, AnimatorNS.DecorationType.None);
            GrillaProveedores.EnableHeadersVisualStyles = false;
            GrillaProveedores.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            GrillaProveedores.Location = new System.Drawing.Point(14, 155);
            GrillaProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GrillaProveedores.Name = "GrillaProveedores";
            GrillaProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            GrillaProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GrillaProveedores.RowHeadersWidth = 51;
            GrillaProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            GrillaProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            GrillaProveedores.RowTemplate.Height = 25;
            GrillaProveedores.Size = new System.Drawing.Size(928, 380);
            GrillaProveedores.TabIndex = 3;
            GrillaProveedores.DataSourceChanged += GrillaProveedores_DataSourceChanged;
            GrillaProveedores.CellBeginEdit += GrillaProveedores_CellBeginEdit;
            GrillaProveedores.CellContentClick += GrillaProveedores_CellContentClick;
            GrillaProveedores.CellDoubleClick += GrillaProveedores_CellDoubleClick;
            GrillaProveedores.CellMouseClick += GrillaProveedores_CellMouseClick;
            GrillaProveedores.CellValueChanged += GrillaProveedores_CellValueChanged;
            GrillaProveedores.MouseClick += GrillaProveedores_MouseClick;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ProveedoresAnimator.SetDecoration(btnSaveChanges, AnimatorNS.DecorationType.None);
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveChanges.ForeColor = System.Drawing.Color.White;
            btnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSaveChanges.IconColor = System.Drawing.Color.White;
            btnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSaveChanges.IconSize = 35;
            btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaveChanges.Location = new System.Drawing.Point(42, 561);
            btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new System.Drawing.Size(185, 59);
            btnSaveChanges.TabIndex = 5;
            btnSaveChanges.Text = "Guardar cambios";
            btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ProveedoresAnimator.SetDecoration(btnRefresh, AnimatorNS.DecorationType.None);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.ForeColor = System.Drawing.Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnRefresh.IconColor = System.Drawing.Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 30;
            btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRefresh.Location = new System.Drawing.Point(42, 104);
            btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(40, 43);
            btnRefresh.TabIndex = 6;
            btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnRejectChanges
            // 
            btnRejectChanges.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ProveedoresAnimator.SetDecoration(btnRejectChanges, AnimatorNS.DecorationType.None);
            btnRejectChanges.FlatAppearance.BorderSize = 0;
            btnRejectChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRejectChanges.ForeColor = System.Drawing.Color.White;
            btnRejectChanges.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnRejectChanges.IconColor = System.Drawing.Color.White;
            btnRejectChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRejectChanges.IconSize = 37;
            btnRejectChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnRejectChanges.Location = new System.Drawing.Point(234, 561);
            btnRejectChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRejectChanges.Name = "btnRejectChanges";
            btnRejectChanges.Size = new System.Drawing.Size(221, 59);
            btnRejectChanges.TabIndex = 7;
            btnRejectChanges.Text = "Cancelar ultimo cambio";
            btnRejectChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnRejectChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRejectChanges.UseVisualStyleBackColor = false;
            btnRejectChanges.Click += btnRejectChanges_Click;
            // 
            // btnProductoProveedor
            // 
            btnProductoProveedor.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ProveedoresAnimator.SetDecoration(btnProductoProveedor, AnimatorNS.DecorationType.None);
            btnProductoProveedor.Enabled = false;
            btnProductoProveedor.FlatAppearance.BorderSize = 0;
            btnProductoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductoProveedor.ForeColor = System.Drawing.Color.White;
            btnProductoProveedor.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            btnProductoProveedor.IconColor = System.Drawing.Color.White;
            btnProductoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProductoProveedor.IconSize = 37;
            btnProductoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProductoProveedor.Location = new System.Drawing.Point(819, 561);
            btnProductoProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnProductoProveedor.Name = "btnProductoProveedor";
            btnProductoProveedor.Size = new System.Drawing.Size(122, 59);
            btnProductoProveedor.TabIndex = 8;
            btnProductoProveedor.Text = "Ver productos";
            btnProductoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProductoProveedor.UseVisualStyleBackColor = false;
            btnProductoProveedor.Click += btnProductoProveedor_Click;
            // 
            // PanelProveedores
            // 
            PanelProveedores.BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            ProveedoresAnimator.SetDecoration(PanelProveedores, AnimatorNS.DecorationType.None);
            PanelProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelProveedores.Location = new System.Drawing.Point(0, 0);
            PanelProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PanelProveedores.Name = "PanelProveedores";
            PanelProveedores.Size = new System.Drawing.Size(955, 633);
            PanelProveedores.TabIndex = 9;
            // 
            // FmProveedores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(955, 633);
            Controls.Add(btnProductoProveedor);
            Controls.Add(btnRejectChanges);
            Controls.Add(btnRefresh);
            Controls.Add(btnSaveChanges);
            Controls.Add(GrillaProveedores);
            Controls.Add(label1);
            Controls.Add(PanelProveedores);
            ProveedoresAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmProveedores";
            Text = "FmProveedores";
            Load += FmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)GrillaProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaProveedores;
        private FontAwesome.Sharp.IconButton btnSaveChanges;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnRejectChanges;
        private FontAwesome.Sharp.IconButton btnProductoProveedor;
        private AnimatorNS.Animator ProveedoresAnimator;
        private System.Windows.Forms.Panel PanelProveedores;
    }
}