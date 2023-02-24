
namespace UI.TextilSoft.SubForms.Pedidos.AdministrarPedido
{
    partial class FmAdministrarPedido
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
            this.components = new System.ComponentModel.Container();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.txtNO = new AltoControls.AltoTextBox();
            this.lblNO = new System.Windows.Forms.Label();
            this.txtDNIcli = new AltoControls.AltoTextBox();
            this.lblDNIcli = new System.Windows.Forms.Label();
            this.btnVerEstado = new FontAwesome.Sharp.IconButton();
            this.IbSA = new FontAwesome.Sharp.IconButton();
            this.pnlSA = new System.Windows.Forms.Panel();
            this.IbEP = new FontAwesome.Sharp.IconButton();
            this.pnlEP = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEstadoSA = new System.Windows.Forms.Label();
            this.lblEstadoEP = new System.Windows.Forms.Label();
            this.IbED = new FontAwesome.Sharp.IconButton();
            this.lblEstadoED = new System.Windows.Forms.Label();
            this.pnlED = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.IbE = new FontAwesome.Sharp.IconButton();
            this.lblEstadoE = new System.Windows.Forms.Label();
            this.tmLbl = new System.Windows.Forms.Timer(this.components);
            this.tmLblEP = new System.Windows.Forms.Timer(this.components);
            this.tmLblED = new System.Windows.Forms.Timer(this.components);
            this.tmLblE = new System.Windows.Forms.Timer(this.components);
            this.toolTipError = new System.Windows.Forms.ToolTip(this.components);
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pnlEP.SuspendLayout();
            this.pnlED.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(270, 35);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(164, 32);
            this.lblPedidos.TabIndex = 6;
            this.lblPedidos.Text = "Estado Pedido";
            // 
            // txtNO
            // 
            this.txtNO.BackColor = System.Drawing.Color.Transparent;
            this.txtNO.Br = System.Drawing.Color.MidnightBlue;
            this.txtNO.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNO.ForeColor = System.Drawing.Color.White;
            this.txtNO.Location = new System.Drawing.Point(123, 122);
            this.txtNO.Name = "txtNO";
            this.txtNO.Size = new System.Drawing.Size(92, 29);
            this.txtNO.TabIndex = 8;
            this.txtNO.TextChanged += new System.EventHandler(this.txtNO_TextChanged);
            // 
            // lblNO
            // 
            this.lblNO.AutoSize = true;
            this.lblNO.ForeColor = System.Drawing.Color.White;
            this.lblNO.Location = new System.Drawing.Point(12, 128);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(106, 15);
            this.lblNO.TabIndex = 7;
            this.lblNO.Text = "Número de Orden:";
            // 
            // txtDNIcli
            // 
            this.txtDNIcli.BackColor = System.Drawing.Color.Transparent;
            this.txtDNIcli.Br = System.Drawing.Color.MidnightBlue;
            this.txtDNIcli.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNIcli.ForeColor = System.Drawing.Color.White;
            this.txtDNIcli.Location = new System.Drawing.Point(123, 169);
            this.txtDNIcli.Name = "txtDNIcli";
            this.txtDNIcli.Size = new System.Drawing.Size(92, 29);
            this.txtDNIcli.TabIndex = 10;
            this.txtDNIcli.TextChanged += new System.EventHandler(this.txtDNIcli_TextChanged);
            // 
            // lblDNIcli
            // 
            this.lblDNIcli.AutoSize = true;
            this.lblDNIcli.ForeColor = System.Drawing.Color.White;
            this.lblDNIcli.Location = new System.Drawing.Point(12, 175);
            this.lblDNIcli.Name = "lblDNIcli";
            this.lblDNIcli.Size = new System.Drawing.Size(87, 15);
            this.lblDNIcli.TabIndex = 9;
            this.lblDNIcli.Text = "DNI del cliente:";
            // 
            // btnVerEstado
            // 
            this.btnVerEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVerEstado.FlatAppearance.BorderSize = 0;
            this.btnVerEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEstado.ForeColor = System.Drawing.Color.White;
            this.btnVerEstado.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnVerEstado.IconColor = System.Drawing.Color.White;
            this.btnVerEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerEstado.IconSize = 35;
            this.btnVerEstado.Location = new System.Drawing.Point(104, 214);
            this.btnVerEstado.Name = "btnVerEstado";
            this.btnVerEstado.Size = new System.Drawing.Size(111, 42);
            this.btnVerEstado.TabIndex = 11;
            this.btnVerEstado.Text = "Ver Estado";
            this.btnVerEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerEstado.UseVisualStyleBackColor = false;
            this.btnVerEstado.Click += new System.EventHandler(this.btnVerEstado_Click);
            // 
            // IbSA
            // 
            this.IbSA.BackColor = System.Drawing.Color.Transparent;
            this.IbSA.FlatAppearance.BorderSize = 0;
            this.IbSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbSA.ForeColor = System.Drawing.Color.Transparent;
            this.IbSA.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.IbSA.IconColor = System.Drawing.Color.Lime;
            this.IbSA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbSA.IconSize = 35;
            this.IbSA.Location = new System.Drawing.Point(352, 120);
            this.IbSA.Name = "IbSA";
            this.IbSA.Size = new System.Drawing.Size(29, 31);
            this.IbSA.TabIndex = 12;
            this.IbSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbSA.UseVisualStyleBackColor = false;
            // 
            // pnlSA
            // 
            this.pnlSA.BackColor = System.Drawing.Color.White;
            this.pnlSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlSA.Location = new System.Drawing.Point(363, 146);
            this.pnlSA.Name = "pnlSA";
            this.pnlSA.Size = new System.Drawing.Size(5, 50);
            this.pnlSA.TabIndex = 13;
            // 
            // IbEP
            // 
            this.IbEP.BackColor = System.Drawing.Color.Transparent;
            this.IbEP.FlatAppearance.BorderSize = 0;
            this.IbEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbEP.ForeColor = System.Drawing.Color.Transparent;
            this.IbEP.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.IbEP.IconColor = System.Drawing.Color.Lime;
            this.IbEP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbEP.IconSize = 35;
            this.IbEP.Location = new System.Drawing.Point(352, 193);
            this.IbEP.Name = "IbEP";
            this.IbEP.Size = new System.Drawing.Size(29, 31);
            this.IbEP.TabIndex = 14;
            this.IbEP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbEP.UseVisualStyleBackColor = false;
            // 
            // pnlEP
            // 
            this.pnlEP.BackColor = System.Drawing.Color.White;
            this.pnlEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEP.Controls.Add(this.panel3);
            this.pnlEP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlEP.Location = new System.Drawing.Point(363, 218);
            this.pnlEP.Name = "pnlEP";
            this.pnlEP.Size = new System.Drawing.Size(5, 50);
            this.pnlEP.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(-1, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 50);
            this.panel3.TabIndex = 15;
            // 
            // lblEstadoSA
            // 
            this.lblEstadoSA.AutoSize = true;
            this.lblEstadoSA.ForeColor = System.Drawing.Color.White;
            this.lblEstadoSA.Location = new System.Drawing.Point(387, 126);
            this.lblEstadoSA.Name = "lblEstadoSA";
            this.lblEstadoSA.Size = new System.Drawing.Size(64, 15);
            this.lblEstadoSA.TabIndex = 15;
            this.lblEstadoSA.Text = "Sin asignar";
            // 
            // lblEstadoEP
            // 
            this.lblEstadoEP.AutoSize = true;
            this.lblEstadoEP.ForeColor = System.Drawing.Color.White;
            this.lblEstadoEP.Location = new System.Drawing.Point(387, 199);
            this.lblEstadoEP.Name = "lblEstadoEP";
            this.lblEstadoEP.Size = new System.Drawing.Size(84, 15);
            this.lblEstadoEP.TabIndex = 16;
            this.lblEstadoEP.Text = "En producción";
            // 
            // IbED
            // 
            this.IbED.BackColor = System.Drawing.Color.Transparent;
            this.IbED.FlatAppearance.BorderSize = 0;
            this.IbED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbED.ForeColor = System.Drawing.Color.Transparent;
            this.IbED.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.IbED.IconColor = System.Drawing.Color.Lime;
            this.IbED.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbED.IconSize = 35;
            this.IbED.Location = new System.Drawing.Point(352, 268);
            this.IbED.Name = "IbED";
            this.IbED.Size = new System.Drawing.Size(29, 31);
            this.IbED.TabIndex = 17;
            this.IbED.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbED.UseVisualStyleBackColor = false;
            // 
            // lblEstadoED
            // 
            this.lblEstadoED.AutoSize = true;
            this.lblEstadoED.ForeColor = System.Drawing.Color.White;
            this.lblEstadoED.Location = new System.Drawing.Point(387, 275);
            this.lblEstadoED.Name = "lblEstadoED";
            this.lblEstadoED.Size = new System.Drawing.Size(69, 15);
            this.lblEstadoED.TabIndex = 18;
            this.lblEstadoED.Text = "En depósito";
            // 
            // pnlED
            // 
            this.pnlED.BackColor = System.Drawing.Color.White;
            this.pnlED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlED.Controls.Add(this.panel5);
            this.pnlED.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlED.Location = new System.Drawing.Point(363, 295);
            this.pnlED.Name = "pnlED";
            this.pnlED.Size = new System.Drawing.Size(5, 50);
            this.pnlED.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(-1, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 50);
            this.panel5.TabIndex = 15;
            // 
            // IbE
            // 
            this.IbE.BackColor = System.Drawing.Color.Transparent;
            this.IbE.FlatAppearance.BorderSize = 0;
            this.IbE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IbE.ForeColor = System.Drawing.Color.Transparent;
            this.IbE.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.IbE.IconColor = System.Drawing.Color.Lime;
            this.IbE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IbE.IconSize = 35;
            this.IbE.Location = new System.Drawing.Point(352, 346);
            this.IbE.Name = "IbE";
            this.IbE.Size = new System.Drawing.Size(29, 31);
            this.IbE.TabIndex = 19;
            this.IbE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IbE.UseVisualStyleBackColor = false;
            // 
            // lblEstadoE
            // 
            this.lblEstadoE.AutoSize = true;
            this.lblEstadoE.ForeColor = System.Drawing.Color.White;
            this.lblEstadoE.Location = new System.Drawing.Point(387, 353);
            this.lblEstadoE.Name = "lblEstadoE";
            this.lblEstadoE.Size = new System.Drawing.Size(61, 15);
            this.lblEstadoE.TabIndex = 20;
            this.lblEstadoE.Text = "Entregado";
            // 
            // tmLbl
            // 
            this.tmLbl.Interval = 10;
            this.tmLbl.Tick += new System.EventHandler(this.tmLbl_Tick);
            // 
            // tmLblEP
            // 
            this.tmLblEP.Interval = 10;
            this.tmLblEP.Tick += new System.EventHandler(this.tmLblEP_Tick);
            // 
            // tmLblED
            // 
            this.tmLblED.Interval = 10;
            this.tmLblED.Tick += new System.EventHandler(this.tmLblED_Tick);
            // 
            // tmLblE
            // 
            this.tmLblE.Interval = 10;
            this.tmLblE.Tick += new System.EventHandler(this.tmLblE_Tick);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(544, 175);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(200, 100);
            this.cartesianChart1.TabIndex = 21;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // FmAdministrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.lblEstadoE);
            this.Controls.Add(this.IbE);
            this.Controls.Add(this.pnlED);
            this.Controls.Add(this.lblEstadoED);
            this.Controls.Add(this.IbED);
            this.Controls.Add(this.lblEstadoEP);
            this.Controls.Add(this.lblEstadoSA);
            this.Controls.Add(this.pnlEP);
            this.Controls.Add(this.IbEP);
            this.Controls.Add(this.pnlSA);
            this.Controls.Add(this.IbSA);
            this.Controls.Add(this.btnVerEstado);
            this.Controls.Add(this.txtDNIcli);
            this.Controls.Add(this.lblDNIcli);
            this.Controls.Add(this.txtNO);
            this.Controls.Add(this.lblNO);
            this.Controls.Add(this.lblPedidos);
            this.Name = "FmAdministrarPedido";
            this.Text = "FmAdministrarPedido";
            this.Load += new System.EventHandler(this.FmAdministrarPedido_Load);
            this.pnlEP.ResumeLayout(false);
            this.pnlED.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedidos;
        private AltoControls.AltoTextBox txtNO;
        private System.Windows.Forms.Label lblNO;
        private AltoControls.AltoTextBox txtDNIcli;
        private System.Windows.Forms.Label lblDNIcli;
        private FontAwesome.Sharp.IconButton btnVerEstado;
        private FontAwesome.Sharp.IconButton IbSA;
        private System.Windows.Forms.Panel pnlSA;
        private FontAwesome.Sharp.IconButton IbEP;
        private System.Windows.Forms.Panel pnlEP;
        private System.Windows.Forms.Label lblEstadoSA;
        private System.Windows.Forms.Label lblEstadoEP;
        private FontAwesome.Sharp.IconButton IbED;
        private System.Windows.Forms.Label lblEstadoED;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlED;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton IbE;
        private System.Windows.Forms.Label lblEstadoE;
        private System.Windows.Forms.Timer tmLbl;
        private System.Windows.Forms.Timer tmLblEP;
        private System.Windows.Forms.Timer tmLblED;
        private System.Windows.Forms.Timer tmLblE;
        private System.Windows.Forms.ToolTip toolTipError;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}