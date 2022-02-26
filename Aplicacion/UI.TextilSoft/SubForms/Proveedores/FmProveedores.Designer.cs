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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProveedoresAnimator = new AnimatorNS.Animator(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaProveedores = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnRejectChanges = new FontAwesome.Sharp.IconButton();
            this.btnProductoProveedor = new FontAwesome.Sharp.IconButton();
            this.PanelProveedores = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProveedores)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.ProveedoresAnimator.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedores";
            // 
            // GrillaProveedores
            // 
            this.GrillaProveedores.AllowUserToResizeColumns = false;
            this.GrillaProveedores.AllowUserToResizeRows = false;
            this.GrillaProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.GrillaProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrillaProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrillaProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProveedoresAnimator.SetDecoration(this.GrillaProveedores, AnimatorNS.DecorationType.None);
            this.GrillaProveedores.EnableHeadersVisualStyles = false;
            this.GrillaProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.GrillaProveedores.Location = new System.Drawing.Point(12, 116);
            this.GrillaProveedores.Name = "GrillaProveedores";
            this.GrillaProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.GrillaProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaProveedores.RowTemplate.Height = 25;
            this.GrillaProveedores.Size = new System.Drawing.Size(812, 285);
            this.GrillaProveedores.TabIndex = 3;
            this.GrillaProveedores.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GrillaProveedores_CellBeginEdit);
            this.GrillaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProveedores_CellContentClick);
            this.GrillaProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProveedores_CellDoubleClick);
            this.GrillaProveedores.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrillaProveedores_CellMouseClick);
            this.GrillaProveedores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProveedores_CellValueChanged);
            this.GrillaProveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GrillaProveedores_MouseClick);
            // 
            // btnSaveChanges
            // 
            this.ProveedoresAnimator.SetDecoration(this.btnSaveChanges, AnimatorNS.DecorationType.None);
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveChanges.IconColor = System.Drawing.Color.White;
            this.btnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveChanges.IconSize = 35;
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.Location = new System.Drawing.Point(37, 421);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(162, 44);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Guardar cambios";
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnRefresh
            // 
            this.ProveedoresAnimator.SetDecoration(this.btnRefresh, AnimatorNS.DecorationType.None);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnRefresh.IconColor = System.Drawing.Color.White;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 30;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(37, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(35, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnRejectChanges
            // 
            this.ProveedoresAnimator.SetDecoration(this.btnRejectChanges, AnimatorNS.DecorationType.None);
            this.btnRejectChanges.FlatAppearance.BorderSize = 0;
            this.btnRejectChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectChanges.ForeColor = System.Drawing.Color.White;
            this.btnRejectChanges.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnRejectChanges.IconColor = System.Drawing.Color.White;
            this.btnRejectChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRejectChanges.IconSize = 37;
            this.btnRejectChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRejectChanges.Location = new System.Drawing.Point(205, 421);
            this.btnRejectChanges.Name = "btnRejectChanges";
            this.btnRejectChanges.Size = new System.Drawing.Size(193, 44);
            this.btnRejectChanges.TabIndex = 7;
            this.btnRejectChanges.Text = "Cancelar ultimo cambio";
            this.btnRejectChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRejectChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRejectChanges.UseVisualStyleBackColor = true;
            this.btnRejectChanges.Click += new System.EventHandler(this.btnRejectChanges_Click);
            // 
            // btnProductoProveedor
            // 
            this.ProveedoresAnimator.SetDecoration(this.btnProductoProveedor, AnimatorNS.DecorationType.None);
            this.btnProductoProveedor.FlatAppearance.BorderSize = 0;
            this.btnProductoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProductoProveedor.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnProductoProveedor.IconColor = System.Drawing.Color.White;
            this.btnProductoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductoProveedor.IconSize = 37;
            this.btnProductoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoProveedor.Location = new System.Drawing.Point(717, 421);
            this.btnProductoProveedor.Name = "btnProductoProveedor";
            this.btnProductoProveedor.Size = new System.Drawing.Size(107, 44);
            this.btnProductoProveedor.TabIndex = 8;
            this.btnProductoProveedor.Text = "Ver productos";
            this.btnProductoProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductoProveedor.UseVisualStyleBackColor = true;
            this.btnProductoProveedor.Click += new System.EventHandler(this.btnProductoProveedor_Click);
            // 
            // PanelProveedores
            // 
            this.PanelProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ProveedoresAnimator.SetDecoration(this.PanelProveedores, AnimatorNS.DecorationType.None);
            this.PanelProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProveedores.Location = new System.Drawing.Point(0, 0);
            this.PanelProveedores.Name = "PanelProveedores";
            this.PanelProveedores.Size = new System.Drawing.Size(836, 475);
            this.PanelProveedores.TabIndex = 9;
            // 
            // FmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(836, 475);
            this.Controls.Add(this.btnProductoProveedor);
            this.Controls.Add(this.btnRejectChanges);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.GrillaProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelProveedores);
            this.ProveedoresAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "FmProveedores";
            this.Text = "FmProveedores";
            this.Load += new System.EventHandler(this.FmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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