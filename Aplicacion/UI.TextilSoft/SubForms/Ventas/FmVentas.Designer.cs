namespace UI.TextilSoft.SubForms.Ventas
{
    partial class FmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmVentas));
            panelContenedor = new System.Windows.Forms.Panel();
            panelTop = new System.Windows.Forms.Panel();
            btnSeña = new FontAwesome.Sharp.IconButton();
            btnDevolucionPrenda = new FontAwesome.Sharp.IconButton();
            btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            PanelAnimator = new AnimatorNS.Animator(components);
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            PanelAnimator.SetDecoration(panelContenedor, AnimatorNS.DecorationType.None);
            panelContenedor.Location = new System.Drawing.Point(0, 121);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(846, 395);
            panelContenedor.TabIndex = 0;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnSeña);
            panelTop.Controls.Add(btnDevolucionPrenda);
            panelTop.Controls.Add(btnRegistrarVenta);
            PanelAnimator.SetDecoration(panelTop, AnimatorNS.DecorationType.None);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(846, 123);
            panelTop.TabIndex = 1;
            // 
            // btnSeña
            // 
            btnSeña.Cursor = System.Windows.Forms.Cursors.Hand;
            PanelAnimator.SetDecoration(btnSeña, AnimatorNS.DecorationType.None);
            btnSeña.FlatAppearance.BorderSize = 0;
            btnSeña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSeña.ForeColor = System.Drawing.Color.White;
            btnSeña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnSeña.IconColor = System.Drawing.Color.White;
            btnSeña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSeña.IconSize = 35;
            btnSeña.Location = new System.Drawing.Point(676, 53);
            btnSeña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSeña.Name = "btnSeña";
            btnSeña.Size = new System.Drawing.Size(158, 61);
            btnSeña.TabIndex = 9;
            btnSeña.Text = "Agregar seña";
            btnSeña.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSeña.UseVisualStyleBackColor = true;
            btnSeña.Click += btnSeña_Click;
            // 
            // btnDevolucionPrenda
            // 
            btnDevolucionPrenda.Cursor = System.Windows.Forms.Cursors.Hand;
            PanelAnimator.SetDecoration(btnDevolucionPrenda, AnimatorNS.DecorationType.None);
            btnDevolucionPrenda.FlatAppearance.BorderSize = 0;
            btnDevolucionPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDevolucionPrenda.ForeColor = System.Drawing.Color.White;
            btnDevolucionPrenda.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            btnDevolucionPrenda.IconColor = System.Drawing.Color.White;
            btnDevolucionPrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDevolucionPrenda.IconSize = 35;
            btnDevolucionPrenda.Location = new System.Drawing.Point(356, 53);
            btnDevolucionPrenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDevolucionPrenda.Name = "btnDevolucionPrenda";
            btnDevolucionPrenda.Size = new System.Drawing.Size(158, 61);
            btnDevolucionPrenda.TabIndex = 8;
            btnDevolucionPrenda.Text = "Devoluciones";
            btnDevolucionPrenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDevolucionPrenda.UseVisualStyleBackColor = true;
            btnDevolucionPrenda.Click += btnDevolucionPrenda_Click;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            PanelAnimator.SetDecoration(btnRegistrarVenta, AnimatorNS.DecorationType.None);
            btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            btnRegistrarVenta.IconColor = System.Drawing.Color.White;
            btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarVenta.IconSize = 35;
            btnRegistrarVenta.Location = new System.Drawing.Point(53, 53);
            btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new System.Drawing.Size(158, 61);
            btnRegistrarVenta.TabIndex = 7;
            btnRegistrarVenta.Text = "Registrar venta";
            btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
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
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            PanelAnimator.DefaultAnimation = animation1;
            // 
            // FmVentas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(846, 516);
            Controls.Add(panelTop);
            Controls.Add(panelContenedor);
            PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Name = "FmVentas";
            Text = "FmVentas";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private FontAwesome.Sharp.IconButton btnDevolucionPrenda;
        private FontAwesome.Sharp.IconButton btnSeña;
        private AnimatorNS.Animator PanelAnimator;
    }
}