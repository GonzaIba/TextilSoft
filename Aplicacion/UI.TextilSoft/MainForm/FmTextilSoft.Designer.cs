
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
            components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTextilSoft));
            panelBotones = new System.Windows.Forms.Panel();
            btnBloquear = new FontAwesome.Sharp.IconButton();
            labelBienvenida = new System.Windows.Forms.Label();
            btnConfiguracion = new FontAwesome.Sharp.IconButton();
            btnVentas = new FontAwesome.Sharp.IconButton();
            btnFacturas = new FontAwesome.Sharp.IconButton();
            btnProduccion = new FontAwesome.Sharp.IconButton();
            btnProveedores = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPedidos = new FontAwesome.Sharp.IconButton();
            panelContenedor = new System.Windows.Forms.Panel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            PanelAnimator = new AnimatorNS.Animator(components);
            panelBotones.SuspendLayout();
            panelContenedor.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.BackColor = System.Drawing.Color.Black;
            panelBotones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panelBotones.Controls.Add(btnBloquear);
            panelBotones.Controls.Add(labelBienvenida);
            panelBotones.Controls.Add(btnConfiguracion);
            panelBotones.Controls.Add(btnVentas);
            panelBotones.Controls.Add(btnFacturas);
            panelBotones.Controls.Add(btnProduccion);
            panelBotones.Controls.Add(btnProveedores);
            panelBotones.Controls.Add(btnReportes);
            panelBotones.Controls.Add(btnPedidos);
            PanelAnimator.SetDecoration(panelBotones, AnimatorNS.DecorationType.None);
            panelBotones.Dock = System.Windows.Forms.DockStyle.Left;
            panelBotones.Location = new System.Drawing.Point(0, 0);
            panelBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelBotones.MaximumSize = new System.Drawing.Size(200, 593);
            panelBotones.MinimumSize = new System.Drawing.Size(43, 200);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new System.Drawing.Size(200, 593);
            panelBotones.TabIndex = 0;
            panelBotones.MouseDown += panelContenedor_MouseDown;
            panelBotones.MouseEnter += panelBotones_MouseEnter;
            panelBotones.MouseLeave += panelBotones_MouseLeave;
            panelBotones.MouseMove += btnBloquear_MouseMove;
            // 
            // btnBloquear
            // 
            btnBloquear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            PanelAnimator.SetDecoration(btnBloquear, AnimatorNS.DecorationType.None);
            btnBloquear.FlatAppearance.BorderSize = 0;
            btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBloquear.ForeColor = System.Drawing.Color.White;
            btnBloquear.IconChar = FontAwesome.Sharp.IconChar.Thumbtack;
            btnBloquear.IconColor = System.Drawing.Color.White;
            btnBloquear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBloquear.Location = new System.Drawing.Point(163, 15);
            btnBloquear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBloquear.Name = "btnBloquear";
            btnBloquear.Size = new System.Drawing.Size(34, 37);
            btnBloquear.TabIndex = 8;
            btnBloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBloquear.UseVisualStyleBackColor = true;
            btnBloquear.Click += btnBloquear_Click;
            btnBloquear.MouseEnter += btnBloquear_MouseEnter;
            btnBloquear.MouseMove += btnBloquear_MouseMove;
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            PanelAnimator.SetDecoration(labelBienvenida, AnimatorNS.DecorationType.None);
            labelBienvenida.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelBienvenida.ForeColor = System.Drawing.Color.Red;
            labelBienvenida.Location = new System.Drawing.Point(42, 36);
            labelBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new System.Drawing.Size(110, 26);
            labelBienvenida.TabIndex = 7;
            labelBienvenida.Text = "TextilSoft";
            labelBienvenida.MouseDown += panelContenedor_MouseDown;
            labelBienvenida.MouseEnter += label1_MouseEnter;
            labelBienvenida.MouseLeave += labelBienvenida_MouseLeave;
            labelBienvenida.MouseMove += btnBloquear_MouseMove;
            // 
            // btnConfiguracion
            // 
            PanelAnimator.SetDecoration(btnConfiguracion, AnimatorNS.DecorationType.None);
            btnConfiguracion.Enabled = false;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnConfiguracion.ForeColor = System.Drawing.Color.White;
            btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnConfiguracion.IconColor = System.Drawing.Color.White;
            btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguracion.IconSize = 35;
            btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new System.Drawing.Point(0, 448);
            btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            btnConfiguracion.Size = new System.Drawing.Size(200, 63);
            btnConfiguracion.TabIndex = 6;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            btnConfiguracion.MouseEnter += btnConfiguracion_MouseEnter;
            btnConfiguracion.MouseLeave += btnConfiguracion_MouseLeave;
            btnConfiguracion.MouseMove += btnBloquear_MouseMove;
            // 
            // btnVentas
            // 
            PanelAnimator.SetDecoration(btnVentas, AnimatorNS.DecorationType.None);
            btnVentas.Enabled = false;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVentas.ForeColor = System.Drawing.Color.White;
            btnVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnVentas.IconColor = System.Drawing.Color.White;
            btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVentas.IconSize = 35;
            btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVentas.Location = new System.Drawing.Point(0, 137);
            btnVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            btnVentas.Size = new System.Drawing.Size(200, 63);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            btnVentas.MouseEnter += btnVentas_MouseEnter;
            btnVentas.MouseLeave += btnVentas_MouseLeave;
            btnVentas.MouseMove += btnBloquear_MouseMove;
            // 
            // btnFacturas
            // 
            PanelAnimator.SetDecoration(btnFacturas, AnimatorNS.DecorationType.None);
            btnFacturas.Enabled = false;
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFacturas.ForeColor = System.Drawing.Color.White;
            btnFacturas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnFacturas.IconColor = System.Drawing.Color.White;
            btnFacturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFacturas.IconSize = 35;
            btnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFacturas.Location = new System.Drawing.Point(0, 197);
            btnFacturas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            btnFacturas.Size = new System.Drawing.Size(200, 63);
            btnFacturas.TabIndex = 4;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFacturas.UseVisualStyleBackColor = false;
            btnFacturas.Click += btnFacturas_Click;
            btnFacturas.MouseEnter += btnFacturas_MouseEnter;
            btnFacturas.MouseLeave += btnFacturas_MouseLeave;
            btnFacturas.MouseMove += btnBloquear_MouseMove;
            // 
            // btnProduccion
            // 
            PanelAnimator.SetDecoration(btnProduccion, AnimatorNS.DecorationType.None);
            btnProduccion.Enabled = false;
            btnProduccion.FlatAppearance.BorderSize = 0;
            btnProduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProduccion.ForeColor = System.Drawing.Color.White;
            btnProduccion.IconChar = FontAwesome.Sharp.IconChar.PersonBooth;
            btnProduccion.IconColor = System.Drawing.Color.White;
            btnProduccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduccion.IconSize = 35;
            btnProduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduccion.Location = new System.Drawing.Point(0, 323);
            btnProduccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            btnProduccion.Size = new System.Drawing.Size(200, 63);
            btnProduccion.TabIndex = 3;
            btnProduccion.Text = "Produccion";
            btnProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProduccion.UseVisualStyleBackColor = false;
            btnProduccion.Click += btnProduccion_Click;
            btnProduccion.MouseEnter += btnProduccion_MouseEnter;
            btnProduccion.MouseLeave += btnProduccion_MouseLeave;
            btnProduccion.MouseMove += btnBloquear_MouseMove;
            // 
            // btnProveedores
            // 
            PanelAnimator.SetDecoration(btnProveedores, AnimatorNS.DecorationType.None);
            btnProveedores.Enabled = false;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnProveedores.ForeColor = System.Drawing.Color.White;
            btnProveedores.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            btnProveedores.IconColor = System.Drawing.Color.White;
            btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedores.IconSize = 35;
            btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.Location = new System.Drawing.Point(0, 389);
            btnProveedores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            btnProveedores.Size = new System.Drawing.Size(200, 63);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            btnProveedores.MouseEnter += btnProveedores_MouseEnter;
            btnProveedores.MouseLeave += btnProveedores_MouseLeave;
            btnProveedores.MouseMove += btnBloquear_MouseMove;
            // 
            // btnReportes
            // 
            PanelAnimator.SetDecoration(btnReportes, AnimatorNS.DecorationType.None);
            btnReportes.Enabled = false;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReportes.ForeColor = System.Drawing.Color.White;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            btnReportes.IconColor = System.Drawing.Color.White;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 35;
            btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReportes.Location = new System.Drawing.Point(0, 257);
            btnReportes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            btnReportes.Size = new System.Drawing.Size(200, 63);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "Informes-Reportes";
            btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            btnReportes.MouseEnter += btnReportes_MouseEnter;
            btnReportes.MouseLeave += btnReportes_MouseLeave;
            btnReportes.MouseMove += btnBloquear_MouseMove;
            // 
            // btnPedidos
            // 
            PanelAnimator.SetDecoration(btnPedidos, AnimatorNS.DecorationType.None);
            btnPedidos.Enabled = false;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPedidos.ForeColor = System.Drawing.Color.White;
            btnPedidos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnPedidos.IconColor = System.Drawing.Color.White;
            btnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPedidos.IconSize = 35;
            btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPedidos.Location = new System.Drawing.Point(0, 77);
            btnPedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            btnPedidos.Size = new System.Drawing.Size(200, 63);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "Pedidos";
            btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            btnPedidos.MouseEnter += btnPedidos_MouseEnter;
            btnPedidos.MouseLeave += btnPedidos_MouseLeave;
            btnPedidos.MouseMove += btnBloquear_MouseMove;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            panelContenedor.Controls.Add(toolStrip1);
            PanelAnimator.SetDecoration(panelContenedor, AnimatorNS.DecorationType.None);
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(200, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(890, 603);
            panelContenedor.TabIndex = 1;
            panelContenedor.MouseDown += panelContenedor_MouseDown;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = System.Drawing.Color.Transparent;
            PanelAnimator.SetDecoration(toolStrip1, AnimatorNS.DecorationType.None);
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(890, 26);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.RendererChanged += toolStrip1_RendererChanged;
            toolStrip1.Paint += toolStrip1_Paint;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            toolStripLabel1.ForeColor = System.Drawing.Color.White;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(51, 23);
            toolStripLabel1.Text = "Hola";
            toolStripLabel1.MouseDown += panelContenedor_MouseDown;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick_1;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // PanelAnimator
            // 
            PanelAnimator.AnimationType = AnimatorNS.AnimationType.Transparent;
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
            animation1.TransparencyCoeff = 1F;
            PanelAnimator.DefaultAnimation = animation1;
            PanelAnimator.TimeStep = 0.01F;
            // 
            // FmTextilSoft
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(1090, 603);
            Controls.Add(panelContenedor);
            Controls.Add(panelBotones);
            PanelAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FmTextilSoft";
            Text = "TextilSoft";
            FormClosing += FmTextilSoft_FormClosing;
            Load += FmTextilSoft_Load;
            panelBotones.ResumeLayout(false);
            panelBotones.PerformLayout();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
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