namespace UI.TextilSoft.SubForms.Informes_Reportes
{
    partial class FmInformes
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
            components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmInformes));
            lblPrincipal = new System.Windows.Forms.Label();
            panelContenedor = new System.Windows.Forms.Panel();
            panelTop = new System.Windows.Forms.Panel();
            btnReporteStock = new FontAwesome.Sharp.IconButton();
            btnReporteVenta = new FontAwesome.Sharp.IconButton();
            PanelAnimator = new AnimatorNS.Animator(components);
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            PanelAnimator.SetDecoration(lblPrincipal, AnimatorNS.DecorationType.None);
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(232, 9);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(286, 41);
            lblPrincipal.TabIndex = 36;
            lblPrincipal.Text = "Informes Y Reportes";
            // 
            // panelContenedor
            // 
            PanelAnimator.SetDecoration(panelContenedor, AnimatorNS.DecorationType.None);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(0, 158);
            panelContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(812, 355);
            panelContenedor.TabIndex = 37;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnReporteStock);
            panelTop.Controls.Add(btnReporteVenta);
            panelTop.Controls.Add(lblPrincipal);
            PanelAnimator.SetDecoration(panelTop, AnimatorNS.DecorationType.None);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(812, 158);
            panelTop.TabIndex = 38;
            // 
            // btnReporteStock
            // 
            btnReporteStock.Cursor = System.Windows.Forms.Cursors.Hand;
            PanelAnimator.SetDecoration(btnReporteStock, AnimatorNS.DecorationType.None);
            btnReporteStock.FlatAppearance.BorderSize = 0;
            btnReporteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReporteStock.ForeColor = System.Drawing.Color.White;
            btnReporteStock.IconChar = FontAwesome.Sharp.IconChar.Ban;
            btnReporteStock.IconColor = System.Drawing.Color.White;
            btnReporteStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporteStock.IconSize = 35;
            btnReporteStock.Location = new System.Drawing.Point(443, 94);
            btnReporteStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReporteStock.Name = "btnReporteStock";
            btnReporteStock.Size = new System.Drawing.Size(222, 60);
            btnReporteStock.TabIndex = 38;
            btnReporteStock.Text = "Reporte de stock";
            btnReporteStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnReporteStock.UseVisualStyleBackColor = true;
            btnReporteStock.Click += btnReporteStock_Click;
            // 
            // btnReporteVenta
            // 
            btnReporteVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            PanelAnimator.SetDecoration(btnReporteVenta, AnimatorNS.DecorationType.None);
            btnReporteVenta.FlatAppearance.BorderSize = 0;
            btnReporteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReporteVenta.ForeColor = System.Drawing.Color.White;
            btnReporteVenta.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnReporteVenta.IconColor = System.Drawing.Color.White;
            btnReporteVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporteVenta.IconSize = 35;
            btnReporteVenta.Location = new System.Drawing.Point(152, 93);
            btnReporteVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReporteVenta.Name = "btnReporteVenta";
            btnReporteVenta.Size = new System.Drawing.Size(181, 61);
            btnReporteVenta.TabIndex = 37;
            btnReporteVenta.Text = "Reporte de ventas";
            btnReporteVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnReporteVenta.UseVisualStyleBackColor = true;
            btnReporteVenta.Click += btnReporteVenta_Click;
            // 
            // PanelAnimator
            // 
            PanelAnimator.AnimationType = AnimatorNS.AnimationType.VertSlide;
            PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (System.Drawing.PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (System.Drawing.PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (System.Drawing.PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            PanelAnimator.DefaultAnimation = animation1;
            // 
            // FmInformes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(812, 513);
            Controls.Add(panelContenedor);
            Controls.Add(panelTop);
            PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Name = "FmInformes";
            Text = "FmInformes";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnReporteStock;
        private FontAwesome.Sharp.IconButton btnReporteVenta;
        private AnimatorNS.Animator PanelAnimator;
    }
}