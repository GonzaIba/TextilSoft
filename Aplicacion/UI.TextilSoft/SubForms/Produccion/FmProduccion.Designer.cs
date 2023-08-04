namespace UI.TextilSoft.SubForms.Produccion
{
    partial class FmProduccion
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
                components.Remove(PanelAnimator);
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
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmProduccion));
            PanelAnimator = new AnimatorNS.Animator(components);
            lblPrincipal = new System.Windows.Forms.Label();
            btnListarProductos = new FontAwesome.Sharp.IconButton();
            label1 = new System.Windows.Forms.Label();
            panelContenedor = new System.Windows.Forms.Panel();
            pnlTop = new System.Windows.Forms.Panel();
            fmCboxABM = new Tools.FormsTools.FmCombobox();
            btnGestionarAP = new FontAwesome.Sharp.IconButton();
            tipABM = new System.Windows.Forms.ToolTip(components);
            btnGestionarT = new FontAwesome.Sharp.IconButton();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAnimator
            // 
            PanelAnimator.AnimationType = AnimatorNS.AnimationType.VertBlind;
            PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = (System.Drawing.PointF)resources.GetObject("animation2.BlindCoeff");
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = (System.Drawing.PointF)resources.GetObject("animation2.MosaicCoeff");
            animation2.MosaicShift = (System.Drawing.PointF)resources.GetObject("animation2.MosaicShift");
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation2.ScaleCoeff");
            animation2.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation2.SlideCoeff");
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            PanelAnimator.DefaultAnimation = animation2;
            PanelAnimator.TimeStep = 0.01F;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            PanelAnimator.SetDecoration(lblPrincipal, AnimatorNS.DecorationType.None);
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(365, 9);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(153, 41);
            lblPrincipal.TabIndex = 0;
            lblPrincipal.Text = "Productos";
            // 
            // btnListarProductos
            // 
            PanelAnimator.SetDecoration(btnListarProductos, AnimatorNS.DecorationType.None);
            btnListarProductos.FlatAppearance.BorderSize = 0;
            btnListarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnListarProductos.ForeColor = System.Drawing.Color.White;
            btnListarProductos.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnListarProductos.IconColor = System.Drawing.Color.White;
            btnListarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarProductos.IconSize = 35;
            btnListarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnListarProductos.Location = new System.Drawing.Point(3, 94);
            btnListarProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new System.Drawing.Size(205, 61);
            btnListarProductos.TabIndex = 8;
            btnListarProductos.Text = "Listar Todos Productos";
            btnListarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            PanelAnimator.SetDecoration(label1, AnimatorNS.DecorationType.None);
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(724, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(178, 32);
            label1.TabIndex = 11;
            label1.Text = "ABM Productos";
            // 
            // panelContenedor
            // 
            PanelAnimator.SetDecoration(panelContenedor, AnimatorNS.DecorationType.None);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(0, 160);
            panelContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(914, 440);
            panelContenedor.TabIndex = 12;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(btnGestionarT);
            pnlTop.Controls.Add(lblPrincipal);
            pnlTop.Controls.Add(fmCboxABM);
            pnlTop.Controls.Add(btnGestionarAP);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(btnListarProductos);
            PanelAnimator.SetDecoration(pnlTop, AnimatorNS.DecorationType.None);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(914, 160);
            pnlTop.TabIndex = 0;
            // 
            // fmCboxABM
            // 
            fmCboxABM.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxABM.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxABM.BorderSize = 0;
            PanelAnimator.SetDecoration(fmCboxABM, AnimatorNS.DecorationType.None);
            fmCboxABM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxABM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxABM.ForeColor = System.Drawing.Color.DimGray;
            fmCboxABM.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxABM.Items.AddRange(new object[] { "Crear Producto", "Modificar Producto", "Eliminar Producto" });
            fmCboxABM.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxABM.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxABM.Location = new System.Drawing.Point(724, 128);
            fmCboxABM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxABM.Name = "fmCboxABM";
            fmCboxABM.Size = new System.Drawing.Size(178, 27);
            fmCboxABM.TabIndex = 122;
            fmCboxABM.Texts = "";
            fmCboxABM.OnSelectedIndexChanged += fmCboxABM_OnSelectedIndexChanged;
            // 
            // btnGestionarAP
            // 
            PanelAnimator.SetDecoration(btnGestionarAP, AnimatorNS.DecorationType.None);
            btnGestionarAP.FlatAppearance.BorderSize = 0;
            btnGestionarAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGestionarAP.ForeColor = System.Drawing.Color.White;
            btnGestionarAP.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnGestionarAP.IconColor = System.Drawing.Color.White;
            btnGestionarAP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionarAP.IconSize = 35;
            btnGestionarAP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGestionarAP.Location = new System.Drawing.Point(214, 94);
            btnGestionarAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGestionarAP.Name = "btnGestionarAP";
            btnGestionarAP.Size = new System.Drawing.Size(243, 61);
            btnGestionarAP.TabIndex = 12;
            btnGestionarAP.Text = "Gestionar Armado Productos";
            btnGestionarAP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGestionarAP.UseVisualStyleBackColor = true;
            btnGestionarAP.Click += btnGestionarAP_Click;
            // 
            // btnGestionarT
            // 
            PanelAnimator.SetDecoration(btnGestionarT, AnimatorNS.DecorationType.None);
            btnGestionarT.FlatAppearance.BorderSize = 0;
            btnGestionarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGestionarT.ForeColor = System.Drawing.Color.White;
            btnGestionarT.IconChar = FontAwesome.Sharp.IconChar.DrawPolygon;
            btnGestionarT.IconColor = System.Drawing.Color.White;
            btnGestionarT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGestionarT.IconSize = 35;
            btnGestionarT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGestionarT.Location = new System.Drawing.Point(463, 95);
            btnGestionarT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGestionarT.Name = "btnGestionarT";
            btnGestionarT.Size = new System.Drawing.Size(181, 61);
            btnGestionarT.TabIndex = 123;
            btnGestionarT.Text = "Gestionar Transfer";
            btnGestionarT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGestionarT.UseVisualStyleBackColor = true;
            btnGestionarT.Click += btnGestionarT_Click;
            // 
            // FmProduccion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(panelContenedor);
            Controls.Add(pnlTop);
            PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmProduccion";
            Text = "FmProduccion";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private AnimatorNS.Animator PanelAnimator;
        private System.Windows.Forms.ToolTip tipABM;
        private System.Windows.Forms.Label lblPrincipal;
        private FontAwesome.Sharp.IconButton btnListarProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlTop;
        private FontAwesome.Sharp.IconButton btnGestionarAP;
        private Tools.FormsTools.FmCombobox fmCboxABM;
        private FontAwesome.Sharp.IconButton btnGestionarT;
    }
}