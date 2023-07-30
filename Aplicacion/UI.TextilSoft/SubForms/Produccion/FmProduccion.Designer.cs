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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
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
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAnimator
            // 
            PanelAnimator.AnimationType = AnimatorNS.AnimationType.VertBlind;
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
            PanelAnimator.TimeStep = 0.01F;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            PanelAnimator.SetDecoration(lblPrincipal, AnimatorNS.DecorationType.None);
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(384, 12);
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
            label1.Location = new System.Drawing.Point(494, 96);
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
            fmCboxABM.Location = new System.Drawing.Point(494, 130);
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
            btnGestionarAP.Location = new System.Drawing.Point(214, 96);
            btnGestionarAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGestionarAP.Name = "btnGestionarAP";
            btnGestionarAP.Size = new System.Drawing.Size(243, 61);
            btnGestionarAP.TabIndex = 12;
            btnGestionarAP.Text = "Gestionar Armado Productos";
            btnGestionarAP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGestionarAP.UseVisualStyleBackColor = true;
            btnGestionarAP.Click += btnGestionarAP_Click;
            // 
            // FmProduccion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(lblPrincipal);
            Controls.Add(panelContenedor);
            Controls.Add(pnlTop);
            PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmProduccion";
            Text = "FmProduccion";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}