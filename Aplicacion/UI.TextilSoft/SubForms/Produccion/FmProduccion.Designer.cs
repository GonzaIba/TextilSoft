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
            btnCerrarODT = new FontAwesome.Sharp.IconButton();
            lblPrincipal = new System.Windows.Forms.Label();
            btnAsignarODT = new FontAwesome.Sharp.IconButton();
            btnListarProductos = new FontAwesome.Sharp.IconButton();
            fmCombobox1 = new Tools.FormsTools.FmCombobox();
            label1 = new System.Windows.Forms.Label();
            panelContenedor = new System.Windows.Forms.Panel();
            pnlTop = new System.Windows.Forms.Panel();
            tipABM = new System.Windows.Forms.ToolTip(components);
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
            // btnCerrarODT
            // 
            PanelAnimator.SetDecoration(btnCerrarODT, AnimatorNS.DecorationType.None);
            btnCerrarODT.FlatAppearance.BorderSize = 0;
            btnCerrarODT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrarODT.ForeColor = System.Drawing.Color.White;
            btnCerrarODT.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            btnCerrarODT.IconColor = System.Drawing.Color.White;
            btnCerrarODT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarODT.IconSize = 35;
            btnCerrarODT.Location = new System.Drawing.Point(569, 74);
            btnCerrarODT.Name = "btnCerrarODT";
            btnCerrarODT.Size = new System.Drawing.Size(231, 46);
            btnCerrarODT.TabIndex = 5;
            btnCerrarODT.Text = "Cerrar Orden De Trabajo";
            btnCerrarODT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCerrarODT.UseVisualStyleBackColor = true;
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            PanelAnimator.SetDecoration(lblPrincipal, AnimatorNS.DecorationType.None);
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(336, 9);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(120, 32);
            lblPrincipal.TabIndex = 0;
            lblPrincipal.Text = "Productos";
            // 
            // btnAsignarODT
            // 
            PanelAnimator.SetDecoration(btnAsignarODT, AnimatorNS.DecorationType.None);
            btnAsignarODT.FlatAppearance.BorderSize = 0;
            btnAsignarODT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAsignarODT.ForeColor = System.Drawing.Color.White;
            btnAsignarODT.IconChar = FontAwesome.Sharp.IconChar.Ban;
            btnAsignarODT.IconColor = System.Drawing.Color.White;
            btnAsignarODT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAsignarODT.IconSize = 35;
            btnAsignarODT.Location = new System.Drawing.Point(365, 74);
            btnAsignarODT.Name = "btnAsignarODT";
            btnAsignarODT.Size = new System.Drawing.Size(198, 46);
            btnAsignarODT.TabIndex = 7;
            btnAsignarODT.Text = "Asignar Orden De Trabajo";
            btnAsignarODT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAsignarODT.UseVisualStyleBackColor = true;
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
            btnListarProductos.Location = new System.Drawing.Point(188, 74);
            btnListarProductos.Name = "btnListarProductos";
            btnListarProductos.Size = new System.Drawing.Size(179, 46);
            btnListarProductos.TabIndex = 8;
            btnListarProductos.Text = "Listar Todos Productos";
            btnListarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnListarProductos.UseVisualStyleBackColor = true;
            btnListarProductos.Click += btnListarProductos_Click;
            // 
            // fmCombobox1
            // 
            fmCombobox1.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCombobox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCombobox1.BorderSize = 1;
            PanelAnimator.SetDecoration(fmCombobox1, AnimatorNS.DecorationType.None);
            fmCombobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            fmCombobox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCombobox1.ForeColor = System.Drawing.Color.DimGray;
            fmCombobox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCombobox1.Items.AddRange(new object[] { "Crear Producto", "Modificar Producto", "Eliminar Producto" });
            fmCombobox1.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCombobox1.ListTextColor = System.Drawing.Color.DimGray;
            fmCombobox1.Location = new System.Drawing.Point(3, 84);
            fmCombobox1.Name = "fmCombobox1";
            fmCombobox1.Padding = new System.Windows.Forms.Padding(1);
            fmCombobox1.Size = new System.Drawing.Size(179, 30);
            fmCombobox1.TabIndex = 10;
            fmCombobox1.Texts = "";
            fmCombobox1.OnSelectedIndexChanged += fmCombobox1_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            PanelAnimator.SetDecoration(label1, AnimatorNS.DecorationType.None);
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 25);
            label1.TabIndex = 11;
            label1.Text = "ABM Productos";
            // 
            // panelContenedor
            // 
            PanelAnimator.SetDecoration(panelContenedor, AnimatorNS.DecorationType.None);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(0, 120);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(800, 330);
            panelContenedor.TabIndex = 12;
            // 
            // pnlTop
            // 
            PanelAnimator.SetDecoration(pnlTop, AnimatorNS.DecorationType.None);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(800, 120);
            pnlTop.TabIndex = 0;
            // 
            // FmProduccion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(fmCombobox1);
            Controls.Add(btnListarProductos);
            Controls.Add(btnAsignarODT);
            Controls.Add(lblPrincipal);
            Controls.Add(btnCerrarODT);
            Controls.Add(panelContenedor);
            Controls.Add(pnlTop);
            PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Name = "FmProduccion";
            Text = "FmProduccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private AnimatorNS.Animator PanelAnimator;
        private System.Windows.Forms.ToolTip tipABM;
        private FontAwesome.Sharp.IconButton btnCerrarODT;
        private System.Windows.Forms.Label lblPrincipal;
        private FontAwesome.Sharp.IconButton btnAsignarODT;
        private FontAwesome.Sharp.IconButton btnListarProductos;
        private Tools.FormsTools.FmCombobox fmCombobox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel pnlTop;
    }
}