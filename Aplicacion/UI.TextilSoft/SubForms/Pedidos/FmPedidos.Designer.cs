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
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation5 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPedidos));
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnAdministrarPedido = new FontAwesome.Sharp.IconButton();
            this.btnCrearPedido = new FontAwesome.Sharp.IconButton();
            this.PanelAnimator = new AnimatorNS.Animator(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCancelarPedido = new FontAwesome.Sharp.IconButton();
            this.btnListarPedidos = new FontAwesome.Sharp.IconButton();
            this.btnPresupuesto = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.lblPrincipal, AnimatorNS.DecorationType.None);
            this.lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblPrincipal.Location = new System.Drawing.Point(336, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(97, 32);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Pedidos";
            this.lblPrincipal.Click += new System.EventHandler(this.lblPrincipal_Click);
            // 
            // panelContenedor
            // 
            this.PanelAnimator.SetDecoration(this.panelContenedor, AnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 120);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 397);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnAdministrarPedido
            // 
            this.PanelAnimator.SetDecoration(this.btnAdministrarPedido, AnimatorNS.DecorationType.None);
            this.btnAdministrarPedido.FlatAppearance.BorderSize = 0;
            this.btnAdministrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAdministrarPedido.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnAdministrarPedido.IconColor = System.Drawing.Color.White;
            this.btnAdministrarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministrarPedido.IconSize = 35;
            this.btnAdministrarPedido.Location = new System.Drawing.Point(625, 74);
            this.btnAdministrarPedido.Name = "btnAdministrarPedido";
            this.btnAdministrarPedido.Size = new System.Drawing.Size(175, 46);
            this.btnAdministrarPedido.TabIndex = 5;
            this.btnAdministrarPedido.Text = "Estado Pedido";
            this.btnAdministrarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrarPedido.UseVisualStyleBackColor = true;
            this.btnAdministrarPedido.Click += new System.EventHandler(this.btnAdministrarPedido_Click);
            // 
            // btnCrearPedido
            // 
            this.PanelAnimator.SetDecoration(this.btnCrearPedido, AnimatorNS.DecorationType.None);
            this.btnCrearPedido.FlatAppearance.BorderSize = 0;
            this.btnCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPedido.ForeColor = System.Drawing.Color.White;
            this.btnCrearPedido.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCrearPedido.IconColor = System.Drawing.Color.White;
            this.btnCrearPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearPedido.IconSize = 35;
            this.btnCrearPedido.Location = new System.Drawing.Point(0, 74);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(150, 46);
            this.btnCrearPedido.TabIndex = 6;
            this.btnCrearPedido.Text = "Generar Pedido";
            this.btnCrearPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click_1);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = AnimatorNS.AnimationType.VertBlind;
            this.PanelAnimator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation5;
            this.PanelAnimator.TimeStep = 0.01F;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnPresupuesto);
            this.panelTop.Controls.Add(this.btnListarPedidos);
            this.panelTop.Controls.Add(this.btnCancelarPedido);
            this.panelTop.Controls.Add(this.lblPrincipal);
            this.panelTop.Controls.Add(this.btnCrearPedido);
            this.panelTop.Controls.Add(this.btnAdministrarPedido);
            this.PanelAnimator.SetDecoration(this.panelTop, AnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 120);
            this.panelTop.TabIndex = 7;
            // 
            // btnCancelarPedido
            // 
            this.PanelAnimator.SetDecoration(this.btnCancelarPedido, AnimatorNS.DecorationType.None);
            this.btnCancelarPedido.FlatAppearance.BorderSize = 0;
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPedido.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelarPedido.IconColor = System.Drawing.Color.White;
            this.btnCancelarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarPedido.IconSize = 35;
            this.btnCancelarPedido.Location = new System.Drawing.Point(313, 74);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(150, 46);
            this.btnCancelarPedido.TabIndex = 7;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            // 
            // btnListarPedidos
            // 
            this.PanelAnimator.SetDecoration(this.btnListarPedidos, AnimatorNS.DecorationType.None);
            this.btnListarPedidos.FlatAppearance.BorderSize = 0;
            this.btnListarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnListarPedidos.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListarPedidos.IconColor = System.Drawing.Color.White;
            this.btnListarPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarPedidos.IconSize = 35;
            this.btnListarPedidos.Location = new System.Drawing.Point(469, 74);
            this.btnListarPedidos.Name = "btnListarPedidos";
            this.btnListarPedidos.Size = new System.Drawing.Size(150, 46);
            this.btnListarPedidos.TabIndex = 8;
            this.btnListarPedidos.Text = "Listar Pedidos";
            this.btnListarPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListarPedidos.UseVisualStyleBackColor = true;
            this.btnListarPedidos.Click += new System.EventHandler(this.btnListarPedidos_Click);
            // 
            // btnPresupuesto
            // 
            this.PanelAnimator.SetDecoration(this.btnPresupuesto, AnimatorNS.DecorationType.None);
            this.btnPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnPresupuesto.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnPresupuesto.IconColor = System.Drawing.Color.White;
            this.btnPresupuesto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPresupuesto.IconSize = 35;
            this.btnPresupuesto.Location = new System.Drawing.Point(156, 74);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(150, 46);
            this.btnPresupuesto.TabIndex = 9;
            this.btnPresupuesto.Text = "Presupuestos";
            this.btnPresupuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // FmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTop);
            this.PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "FmPedidos";
            this.Text = "FmPedidos";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

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
        private FontAwesome.Sharp.IconButton btnPresupuesto;
    }
}