namespace UI.TextilSoft.SubForms.Pedidos
{
    partial class FmPedidos
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
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPedidos));
            lblPrincipal = new System.Windows.Forms.Label();
            panelContenedor = new System.Windows.Forms.Panel();
            btnAdministrarPedido = new FontAwesome.Sharp.IconButton();
            btnCrearPedido = new FontAwesome.Sharp.IconButton();
            PanelAnimator = new AnimatorNS.Animator(components);
            panelTop = new System.Windows.Forms.Panel();
            btnListarPedidos = new FontAwesome.Sharp.IconButton();
            btnCancelarPedido = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnCerrarODT = new FontAwesome.Sharp.IconButton();
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
            lblPrincipal.Location = new System.Drawing.Point(336, 9);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(97, 32);
            lblPrincipal.TabIndex = 0;
            lblPrincipal.Text = "Pedidos";
            lblPrincipal.Click += lblPrincipal_Click;
            // 
            // panelContenedor
            // 
            PanelAnimator.SetDecoration(panelContenedor, AnimatorNS.DecorationType.None);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(0, 120);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(914, 397);
            panelContenedor.TabIndex = 3;
            // 
            // btnAdministrarPedido
            // 
            PanelAnimator.SetDecoration(btnAdministrarPedido, AnimatorNS.DecorationType.None);
            btnAdministrarPedido.FlatAppearance.BorderSize = 0;
            btnAdministrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdministrarPedido.ForeColor = System.Drawing.Color.White;
            btnAdministrarPedido.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            btnAdministrarPedido.IconColor = System.Drawing.Color.White;
            btnAdministrarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdministrarPedido.IconSize = 35;
            btnAdministrarPedido.Location = new System.Drawing.Point(439, 75);
            btnAdministrarPedido.Name = "btnAdministrarPedido";
            btnAdministrarPedido.Size = new System.Drawing.Size(127, 46);
            btnAdministrarPedido.TabIndex = 5;
            btnAdministrarPedido.Text = "Estado Pedido";
            btnAdministrarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAdministrarPedido.UseVisualStyleBackColor = true;
            btnAdministrarPedido.Click += btnAdministrarPedido_Click;
            // 
            // btnCrearPedido
            // 
            PanelAnimator.SetDecoration(btnCrearPedido, AnimatorNS.DecorationType.None);
            btnCrearPedido.FlatAppearance.BorderSize = 0;
            btnCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCrearPedido.ForeColor = System.Drawing.Color.White;
            btnCrearPedido.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnCrearPedido.IconColor = System.Drawing.Color.White;
            btnCrearPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrearPedido.IconSize = 35;
            btnCrearPedido.Location = new System.Drawing.Point(0, 74);
            btnCrearPedido.Name = "btnCrearPedido";
            btnCrearPedido.Size = new System.Drawing.Size(138, 46);
            btnCrearPedido.TabIndex = 6;
            btnCrearPedido.Text = "Generar Pedido";
            btnCrearPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCrearPedido.UseVisualStyleBackColor = true;
            btnCrearPedido.Click += btnCrearPedido_Click_1;
            // 
            // PanelAnimator
            // 
            PanelAnimator.AnimationType = AnimatorNS.AnimationType.VertBlind;
            PanelAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = (System.Drawing.PointF)resources.GetObject("animation3.BlindCoeff");
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = (System.Drawing.PointF)resources.GetObject("animation3.MosaicCoeff");
            animation3.MosaicShift = (System.Drawing.PointF)resources.GetObject("animation3.MosaicShift");
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = (System.Drawing.PointF)resources.GetObject("animation3.ScaleCoeff");
            animation3.SlideCoeff = (System.Drawing.PointF)resources.GetObject("animation3.SlideCoeff");
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            PanelAnimator.DefaultAnimation = animation3;
            PanelAnimator.TimeStep = 0.01F;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnCerrarODT);
            panelTop.Controls.Add(iconButton1);
            panelTop.Controls.Add(btnListarPedidos);
            panelTop.Controls.Add(btnCancelarPedido);
            panelTop.Controls.Add(lblPrincipal);
            panelTop.Controls.Add(btnCrearPedido);
            panelTop.Controls.Add(btnAdministrarPedido);
            PanelAnimator.SetDecoration(panelTop, AnimatorNS.DecorationType.None);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(914, 120);
            panelTop.TabIndex = 7;
            // 
            // btnListarPedidos
            // 
            PanelAnimator.SetDecoration(btnListarPedidos, AnimatorNS.DecorationType.None);
            btnListarPedidos.FlatAppearance.BorderSize = 0;
            btnListarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnListarPedidos.ForeColor = System.Drawing.Color.White;
            btnListarPedidos.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnListarPedidos.IconColor = System.Drawing.Color.White;
            btnListarPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListarPedidos.IconSize = 35;
            btnListarPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnListarPedidos.Location = new System.Drawing.Point(300, 75);
            btnListarPedidos.Name = "btnListarPedidos";
            btnListarPedidos.Size = new System.Drawing.Size(133, 46);
            btnListarPedidos.TabIndex = 8;
            btnListarPedidos.Text = "Listar Pedidos";
            btnListarPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnListarPedidos.UseVisualStyleBackColor = true;
            btnListarPedidos.Click += btnListarPedidos_Click;
            // 
            // btnCancelarPedido
            // 
            PanelAnimator.SetDecoration(btnCancelarPedido, AnimatorNS.DecorationType.None);
            btnCancelarPedido.FlatAppearance.BorderSize = 0;
            btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelarPedido.ForeColor = System.Drawing.Color.White;
            btnCancelarPedido.IconChar = FontAwesome.Sharp.IconChar.Ban;
            btnCancelarPedido.IconColor = System.Drawing.Color.White;
            btnCancelarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarPedido.IconSize = 35;
            btnCancelarPedido.Location = new System.Drawing.Point(144, 75);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new System.Drawing.Size(138, 45);
            btnCancelarPedido.TabIndex = 7;
            btnCancelarPedido.Text = "Cancelar Pedido";
            btnCancelarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            PanelAnimator.SetDecoration(iconButton1, AnimatorNS.DecorationType.None);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.ForeColor = System.Drawing.Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            iconButton1.IconColor = System.Drawing.Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new System.Drawing.Point(572, 75);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new System.Drawing.Size(161, 46);
            iconButton1.TabIndex = 9;
            iconButton1.Text = "Asignar Orden De Trabajo";
            iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnCerrarODT
            // 
            PanelAnimator.SetDecoration(btnCerrarODT, AnimatorNS.DecorationType.None);
            btnCerrarODT.FlatAppearance.BorderSize = 0;
            btnCerrarODT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrarODT.ForeColor = System.Drawing.Color.White;
            btnCerrarODT.IconChar = FontAwesome.Sharp.IconChar.Lock;
            btnCerrarODT.IconColor = System.Drawing.Color.White;
            btnCerrarODT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarODT.IconSize = 35;
            btnCerrarODT.Location = new System.Drawing.Point(739, 74);
            btnCerrarODT.Name = "btnCerrarODT";
            btnCerrarODT.Size = new System.Drawing.Size(172, 46);
            btnCerrarODT.TabIndex = 10;
            btnCerrarODT.Text = "Cerrar Orden De Trabajo";
            btnCerrarODT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCerrarODT.UseVisualStyleBackColor = true;
            // 
            // FmPedidos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(914, 517);
            Controls.Add(panelContenedor);
            Controls.Add(panelTop);
            PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Name = "FmPedidos";
            Text = "FmPedidos";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnAdministrarPedido;
        private FontAwesome.Sharp.IconButton btnCrearPedido;
        private AnimatorNS.Animator PanelAnimator;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnCancelarPedido;
        private FontAwesome.Sharp.IconButton btnListarPedidos;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCerrarODT;
    }
}