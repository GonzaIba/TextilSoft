
namespace UI.TextilSoft.MainForm
{
    partial class FmTextilSoft
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
                //panelBotones.Dispose();
                //panelContenedor.Dispose();
                //btnBloquear.Dispose();
                //btnConfiguracion.Dispose();
                //btnFacturas.Dispose();
                //btnPedidos.Dispose();
                //btnProduccion.Dispose();
                //btnProveedores.Dispose();
                //btnReportes.Dispose();
                //btnVentas.Dispose();
                //labelBienvenida.Dispose();
                //timer1.Dispose();
                //timer2.Dispose();
                //timer3.Dispose();
                //timer4.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTextilSoft));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnBloquear = new FontAwesome.Sharp.IconButton();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnFacturas = new FontAwesome.Sharp.IconButton();
            this.btnProduccion = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnPedidos = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.PanelAnimator = new AnimatorNS.Animator(this.components);
            this.panelBotones.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Black;
            this.panelBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBotones.Controls.Add(this.btnBloquear);
            this.panelBotones.Controls.Add(this.labelBienvenida);
            this.panelBotones.Controls.Add(this.btnConfiguracion);
            this.panelBotones.Controls.Add(this.btnVentas);
            this.panelBotones.Controls.Add(this.btnFacturas);
            this.panelBotones.Controls.Add(this.btnProduccion);
            this.panelBotones.Controls.Add(this.btnProveedores);
            this.panelBotones.Controls.Add(this.btnReportes);
            this.panelBotones.Controls.Add(this.btnPedidos);
            this.PanelAnimator.SetDecoration(this.panelBotones, AnimatorNS.DecorationType.None);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBotones.MaximumSize = new System.Drawing.Size(200, 593);
            this.panelBotones.MinimumSize = new System.Drawing.Size(43, 200);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(200, 511);
            this.panelBotones.TabIndex = 0;
            this.panelBotones.MouseEnter += new System.EventHandler(this.panelBotones_MouseEnter);
            this.panelBotones.MouseLeave += new System.EventHandler(this.panelBotones_MouseLeave);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnimator.SetDecoration(this.btnBloquear, AnimatorNS.DecorationType.None);
            this.btnBloquear.FlatAppearance.BorderSize = 0;
            this.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBloquear.ForeColor = System.Drawing.Color.White;
            this.btnBloquear.IconChar = FontAwesome.Sharp.IconChar.Thumbtack;
            this.btnBloquear.IconColor = System.Drawing.Color.White;
            this.btnBloquear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBloquear.Location = new System.Drawing.Point(163, 15);
            this.btnBloquear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(34, 37);
            this.btnBloquear.TabIndex = 8;
            this.btnBloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            this.btnBloquear.MouseEnter += new System.EventHandler(this.btnBloquear_MouseEnter);
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.labelBienvenida, AnimatorNS.DecorationType.None);
            this.labelBienvenida.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBienvenida.ForeColor = System.Drawing.Color.Red;
            this.labelBienvenida.Location = new System.Drawing.Point(42, 36);
            this.labelBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(110, 26);
            this.labelBienvenida.TabIndex = 7;
            this.labelBienvenida.Text = "TextilSoft";
            this.labelBienvenida.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.labelBienvenida.MouseLeave += new System.EventHandler(this.labelBienvenida_MouseLeave);
            // 
            // btnConfiguracion
            // 
            this.PanelAnimator.SetDecoration(this.btnConfiguracion, AnimatorNS.DecorationType.None);
            this.btnConfiguracion.Enabled = false;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnConfiguracion.IconColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 35;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 448);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(200, 63);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            this.btnConfiguracion.MouseEnter += new System.EventHandler(this.btnConfiguracion_MouseEnter);
            this.btnConfiguracion.MouseLeave += new System.EventHandler(this.btnConfiguracion_MouseLeave);
            // 
            // btnVentas
            // 
            this.PanelAnimator.SetDecoration(this.btnVentas, AnimatorNS.DecorationType.None);
            this.btnVentas.Enabled = false;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 35;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 137);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(200, 63);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            this.btnVentas.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            // 
            // btnFacturas
            // 
            this.PanelAnimator.SetDecoration(this.btnFacturas, AnimatorNS.DecorationType.None);
            this.btnFacturas.Enabled = false;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnFacturas.IconColor = System.Drawing.Color.White;
            this.btnFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturas.IconSize = 35;
            this.btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Location = new System.Drawing.Point(0, 197);
            this.btnFacturas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnFacturas.Size = new System.Drawing.Size(200, 63);
            this.btnFacturas.TabIndex = 4;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            this.btnFacturas.MouseEnter += new System.EventHandler(this.btnFacturas_MouseEnter);
            this.btnFacturas.MouseLeave += new System.EventHandler(this.btnFacturas_MouseLeave);
            // 
            // btnProduccion
            // 
            this.PanelAnimator.SetDecoration(this.btnProduccion, AnimatorNS.DecorationType.None);
            this.btnProduccion.Enabled = false;
            this.btnProduccion.FlatAppearance.BorderSize = 0;
            this.btnProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduccion.ForeColor = System.Drawing.Color.White;
            this.btnProduccion.IconChar = FontAwesome.Sharp.IconChar.PersonBooth;
            this.btnProduccion.IconColor = System.Drawing.Color.White;
            this.btnProduccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduccion.IconSize = 35;
            this.btnProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduccion.Location = new System.Drawing.Point(0, 323);
            this.btnProduccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProduccion.Size = new System.Drawing.Size(200, 63);
            this.btnProduccion.TabIndex = 3;
            this.btnProduccion.Text = "Produccion";
            this.btnProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduccion.UseVisualStyleBackColor = false;
            this.btnProduccion.Click += new System.EventHandler(this.btnProduccion_Click);
            this.btnProduccion.MouseEnter += new System.EventHandler(this.btnProduccion_MouseEnter);
            this.btnProduccion.MouseLeave += new System.EventHandler(this.btnProduccion_MouseLeave);
            // 
            // btnProveedores
            // 
            this.PanelAnimator.SetDecoration(this.btnProveedores, AnimatorNS.DecorationType.None);
            this.btnProveedores.Enabled = false;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 35;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 389);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(200, 63);
            this.btnProveedores.TabIndex = 2;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            this.btnProveedores.MouseEnter += new System.EventHandler(this.btnProveedores_MouseEnter);
            this.btnProveedores.MouseLeave += new System.EventHandler(this.btnProveedores_MouseLeave);
            // 
            // btnReportes
            // 
            this.PanelAnimator.SetDecoration(this.btnReportes, AnimatorNS.DecorationType.None);
            this.btnReportes.Enabled = false;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 35;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 257);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(200, 63);
            this.btnReportes.TabIndex = 1;
            this.btnReportes.Text = "Informes-Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.MouseEnter += new System.EventHandler(this.btnReportes_MouseEnter);
            this.btnReportes.MouseLeave += new System.EventHandler(this.btnReportes_MouseLeave);
            // 
            // btnPedidos
            // 
            this.PanelAnimator.SetDecoration(this.btnPedidos, AnimatorNS.DecorationType.None);
            this.btnPedidos.Enabled = false;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnPedidos.IconColor = System.Drawing.Color.White;
            this.btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPedidos.IconSize = 35;
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 77);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnPedidos.Size = new System.Drawing.Size(200, 63);
            this.btnPedidos.TabIndex = 0;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            this.btnPedidos.MouseEnter += new System.EventHandler(this.btnPedidos_MouseEnter);
            this.btnPedidos.MouseLeave += new System.EventHandler(this.btnPedidos_MouseLeave);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelContenedor.Controls.Add(this.toolStrip1);
            this.PanelAnimator.SetDecoration(this.panelContenedor, AnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(687, 511);
            this.panelContenedor.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.toolStrip1, AnimatorNS.DecorationType.None);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(687, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.RendererChanged += new System.EventHandler(this.toolStrip1_RendererChanged);
            this.toolStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStrip1_Paint);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 23);
            this.toolStripLabel1.Text = "Hola";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.PanelAnimator.Cursor = null;
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
            animation1.TransparencyCoeff = 1F;
            this.PanelAnimator.DefaultAnimation = animation1;
            this.PanelAnimator.TimeStep = 0.01F;
            // 
            // FmTextilSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(887, 511);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBotones);
            this.PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FmTextilSoft";
            this.Text = "TextilSoft";
            this.Load += new System.EventHandler(this.FmTextilSoft_Load);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnBloquear;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private AnimatorNS.Animator PanelAnimator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public FontAwesome.Sharp.IconButton btnPedidos;
        public FontAwesome.Sharp.IconButton btnVentas;
        public FontAwesome.Sharp.IconButton btnFacturas;
        public FontAwesome.Sharp.IconButton btnProduccion;
        public FontAwesome.Sharp.IconButton btnProveedores;
        public FontAwesome.Sharp.IconButton btnReportes;
        public FontAwesome.Sharp.IconButton btnConfiguracion;
    }
}