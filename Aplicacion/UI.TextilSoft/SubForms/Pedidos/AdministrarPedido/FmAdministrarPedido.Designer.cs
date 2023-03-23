
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
            components = new System.ComponentModel.Container();
            lblPedidos = new System.Windows.Forms.Label();
            txtNO = new AltoControls.AltoTextBox();
            lblNO = new System.Windows.Forms.Label();
            txtDNIcli = new AltoControls.AltoTextBox();
            lblDNIcli = new System.Windows.Forms.Label();
            btnVerEstado = new FontAwesome.Sharp.IconButton();
            IbSA = new FontAwesome.Sharp.IconButton();
            pnlSA = new System.Windows.Forms.Panel();
            IbEP = new FontAwesome.Sharp.IconButton();
            pnlEP = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            lblEstadoSA = new System.Windows.Forms.Label();
            lblEstadoEP = new System.Windows.Forms.Label();
            IbED = new FontAwesome.Sharp.IconButton();
            lblEstadoED = new System.Windows.Forms.Label();
            pnlED = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            IbE = new FontAwesome.Sharp.IconButton();
            lblEstadoE = new System.Windows.Forms.Label();
            tmLbl = new System.Windows.Forms.Timer(components);
            tmLblEP = new System.Windows.Forms.Timer(components);
            tmLblED = new System.Windows.Forms.Timer(components);
            tmLblE = new System.Windows.Forms.Timer(components);
            toolTipError = new System.Windows.Forms.ToolTip(components);
            lblFechaSA = new System.Windows.Forms.Label();
            lblFechaEP = new System.Windows.Forms.Label();
            lblFechaED = new System.Windows.Forms.Label();
            lblFechaE = new System.Windows.Forms.Label();
            pnlEP.SuspendLayout();
            pnlED.SuspendLayout();
            SuspendLayout();
            // 
            // lblPedidos
            // 
            lblPedidos.AutoSize = true;
            lblPedidos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPedidos.ForeColor = System.Drawing.Color.White;
            lblPedidos.Location = new System.Drawing.Point(270, 35);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new System.Drawing.Size(164, 32);
            lblPedidos.TabIndex = 6;
            lblPedidos.Text = "Estado Pedido";
            // 
            // txtNO
            // 
            txtNO.BackColor = System.Drawing.Color.Transparent;
            txtNO.Br = System.Drawing.Color.MidnightBlue;
            txtNO.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNO.ForeColor = System.Drawing.Color.White;
            txtNO.Location = new System.Drawing.Point(123, 122);
            txtNO.Name = "txtNO";
            txtNO.Size = new System.Drawing.Size(92, 29);
            txtNO.TabIndex = 8;
            txtNO.TextChanged += txtNO_TextChanged;
            // 
            // lblNO
            // 
            lblNO.AutoSize = true;
            lblNO.ForeColor = System.Drawing.Color.White;
            lblNO.Location = new System.Drawing.Point(12, 128);
            lblNO.Name = "lblNO";
            lblNO.Size = new System.Drawing.Size(106, 15);
            lblNO.TabIndex = 7;
            lblNO.Text = "Número de Orden:";
            // 
            // txtDNIcli
            // 
            txtDNIcli.BackColor = System.Drawing.Color.Transparent;
            txtDNIcli.Br = System.Drawing.Color.MidnightBlue;
            txtDNIcli.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDNIcli.ForeColor = System.Drawing.Color.White;
            txtDNIcli.Location = new System.Drawing.Point(123, 169);
            txtDNIcli.Name = "txtDNIcli";
            txtDNIcli.Size = new System.Drawing.Size(92, 29);
            txtDNIcli.TabIndex = 10;
            txtDNIcli.TextChanged += txtDNIcli_TextChanged;
            // 
            // lblDNIcli
            // 
            lblDNIcli.AutoSize = true;
            lblDNIcli.ForeColor = System.Drawing.Color.White;
            lblDNIcli.Location = new System.Drawing.Point(12, 175);
            lblDNIcli.Name = "lblDNIcli";
            lblDNIcli.Size = new System.Drawing.Size(87, 15);
            lblDNIcli.TabIndex = 9;
            lblDNIcli.Text = "DNI del cliente:";
            // 
            // btnVerEstado
            // 
            btnVerEstado.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            btnVerEstado.FlatAppearance.BorderSize = 0;
            btnVerEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerEstado.ForeColor = System.Drawing.Color.White;
            btnVerEstado.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            btnVerEstado.IconColor = System.Drawing.Color.White;
            btnVerEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerEstado.IconSize = 35;
            btnVerEstado.Location = new System.Drawing.Point(104, 214);
            btnVerEstado.Name = "btnVerEstado";
            btnVerEstado.Size = new System.Drawing.Size(111, 42);
            btnVerEstado.TabIndex = 11;
            btnVerEstado.Text = "Ver Estado";
            btnVerEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnVerEstado.UseVisualStyleBackColor = false;
            btnVerEstado.Click += btnVerEstado_Click;
            // 
            // IbSA
            // 
            IbSA.BackColor = System.Drawing.Color.Transparent;
            IbSA.FlatAppearance.BorderSize = 0;
            IbSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            IbSA.ForeColor = System.Drawing.Color.Transparent;
            IbSA.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            IbSA.IconColor = System.Drawing.Color.Lime;
            IbSA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IbSA.IconSize = 35;
            IbSA.Location = new System.Drawing.Point(352, 120);
            IbSA.Name = "IbSA";
            IbSA.Size = new System.Drawing.Size(29, 31);
            IbSA.TabIndex = 12;
            IbSA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            IbSA.UseVisualStyleBackColor = false;
            // 
            // pnlSA
            // 
            pnlSA.BackColor = System.Drawing.Color.White;
            pnlSA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlSA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pnlSA.Location = new System.Drawing.Point(363, 146);
            pnlSA.Name = "pnlSA";
            pnlSA.Size = new System.Drawing.Size(5, 50);
            pnlSA.TabIndex = 13;
            // 
            // IbEP
            // 
            IbEP.BackColor = System.Drawing.Color.Transparent;
            IbEP.FlatAppearance.BorderSize = 0;
            IbEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            IbEP.ForeColor = System.Drawing.Color.Transparent;
            IbEP.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            IbEP.IconColor = System.Drawing.Color.Lime;
            IbEP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IbEP.IconSize = 35;
            IbEP.Location = new System.Drawing.Point(352, 193);
            IbEP.Name = "IbEP";
            IbEP.Size = new System.Drawing.Size(29, 31);
            IbEP.TabIndex = 14;
            IbEP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            IbEP.UseVisualStyleBackColor = false;
            // 
            // pnlEP
            // 
            pnlEP.BackColor = System.Drawing.Color.White;
            pnlEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlEP.Controls.Add(panel3);
            pnlEP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pnlEP.Location = new System.Drawing.Point(363, 218);
            pnlEP.Name = "pnlEP";
            pnlEP.Size = new System.Drawing.Size(5, 50);
            pnlEP.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.White;
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel3.Location = new System.Drawing.Point(-1, 76);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(5, 50);
            panel3.TabIndex = 15;
            // 
            // lblEstadoSA
            // 
            lblEstadoSA.AutoSize = true;
            lblEstadoSA.ForeColor = System.Drawing.Color.White;
            lblEstadoSA.Location = new System.Drawing.Point(387, 126);
            lblEstadoSA.Name = "lblEstadoSA";
            lblEstadoSA.Size = new System.Drawing.Size(64, 15);
            lblEstadoSA.TabIndex = 15;
            lblEstadoSA.Text = "Sin asignar";
            // 
            // lblEstadoEP
            // 
            lblEstadoEP.AutoSize = true;
            lblEstadoEP.ForeColor = System.Drawing.Color.White;
            lblEstadoEP.Location = new System.Drawing.Point(387, 199);
            lblEstadoEP.Name = "lblEstadoEP";
            lblEstadoEP.Size = new System.Drawing.Size(84, 15);
            lblEstadoEP.TabIndex = 16;
            lblEstadoEP.Text = "En producción";
            // 
            // IbED
            // 
            IbED.BackColor = System.Drawing.Color.Transparent;
            IbED.FlatAppearance.BorderSize = 0;
            IbED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            IbED.ForeColor = System.Drawing.Color.Transparent;
            IbED.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            IbED.IconColor = System.Drawing.Color.Lime;
            IbED.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IbED.IconSize = 35;
            IbED.Location = new System.Drawing.Point(352, 268);
            IbED.Name = "IbED";
            IbED.Size = new System.Drawing.Size(29, 31);
            IbED.TabIndex = 17;
            IbED.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            IbED.UseVisualStyleBackColor = false;
            // 
            // lblEstadoED
            // 
            lblEstadoED.AutoSize = true;
            lblEstadoED.ForeColor = System.Drawing.Color.White;
            lblEstadoED.Location = new System.Drawing.Point(387, 275);
            lblEstadoED.Name = "lblEstadoED";
            lblEstadoED.Size = new System.Drawing.Size(69, 15);
            lblEstadoED.TabIndex = 18;
            lblEstadoED.Text = "En depósito";
            // 
            // pnlED
            // 
            pnlED.BackColor = System.Drawing.Color.White;
            pnlED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlED.Controls.Add(panel5);
            pnlED.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pnlED.Location = new System.Drawing.Point(363, 295);
            pnlED.Name = "pnlED";
            pnlED.Size = new System.Drawing.Size(5, 50);
            pnlED.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.White;
            panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel5.Location = new System.Drawing.Point(-1, 76);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(5, 50);
            panel5.TabIndex = 15;
            // 
            // IbE
            // 
            IbE.BackColor = System.Drawing.Color.Transparent;
            IbE.FlatAppearance.BorderSize = 0;
            IbE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            IbE.ForeColor = System.Drawing.Color.Transparent;
            IbE.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            IbE.IconColor = System.Drawing.Color.Lime;
            IbE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IbE.IconSize = 35;
            IbE.Location = new System.Drawing.Point(352, 346);
            IbE.Name = "IbE";
            IbE.Size = new System.Drawing.Size(29, 31);
            IbE.TabIndex = 19;
            IbE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            IbE.UseVisualStyleBackColor = false;
            // 
            // lblEstadoE
            // 
            lblEstadoE.AutoSize = true;
            lblEstadoE.ForeColor = System.Drawing.Color.White;
            lblEstadoE.Location = new System.Drawing.Point(387, 353);
            lblEstadoE.Name = "lblEstadoE";
            lblEstadoE.Size = new System.Drawing.Size(61, 15);
            lblEstadoE.TabIndex = 20;
            lblEstadoE.Text = "Entregado";
            // 
            // tmLbl
            // 
            tmLbl.Interval = 10;
            tmLbl.Tick += tmLbl_Tick;
            // 
            // tmLblEP
            // 
            tmLblEP.Interval = 10;
            tmLblEP.Tick += tmLblEP_Tick;
            // 
            // tmLblED
            // 
            tmLblED.Interval = 10;
            tmLblED.Tick += tmLblED_Tick;
            // 
            // tmLblE
            // 
            tmLblE.Interval = 10;
            tmLblE.Tick += tmLblE_Tick;
            // 
            // lblFechaSA
            // 
            lblFechaSA.AutoSize = true;
            lblFechaSA.ForeColor = System.Drawing.Color.White;
            lblFechaSA.Location = new System.Drawing.Point(519, 126);
            lblFechaSA.Name = "lblFechaSA";
            lblFechaSA.Size = new System.Drawing.Size(0, 15);
            lblFechaSA.TabIndex = 21;
            // 
            // lblFechaEP
            // 
            lblFechaEP.AutoSize = true;
            lblFechaEP.ForeColor = System.Drawing.Color.White;
            lblFechaEP.Location = new System.Drawing.Point(519, 199);
            lblFechaEP.Name = "lblFechaEP";
            lblFechaEP.Size = new System.Drawing.Size(0, 15);
            lblFechaEP.TabIndex = 22;
            // 
            // lblFechaED
            // 
            lblFechaED.AutoSize = true;
            lblFechaED.ForeColor = System.Drawing.Color.White;
            lblFechaED.Location = new System.Drawing.Point(519, 275);
            lblFechaED.Name = "lblFechaED";
            lblFechaED.Size = new System.Drawing.Size(0, 15);
            lblFechaED.TabIndex = 23;
            // 
            // lblFechaE
            // 
            lblFechaE.AutoSize = true;
            lblFechaE.ForeColor = System.Drawing.Color.White;
            lblFechaE.Location = new System.Drawing.Point(519, 353);
            lblFechaE.Name = "lblFechaE";
            lblFechaE.Size = new System.Drawing.Size(0, 15);
            lblFechaE.TabIndex = 24;
            // 
            // FmAdministrarPedido
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblFechaE);
            Controls.Add(lblFechaED);
            Controls.Add(lblFechaEP);
            Controls.Add(lblFechaSA);
            Controls.Add(lblEstadoE);
            Controls.Add(IbE);
            Controls.Add(pnlED);
            Controls.Add(lblEstadoED);
            Controls.Add(IbED);
            Controls.Add(lblEstadoEP);
            Controls.Add(lblEstadoSA);
            Controls.Add(pnlEP);
            Controls.Add(IbEP);
            Controls.Add(pnlSA);
            Controls.Add(IbSA);
            Controls.Add(btnVerEstado);
            Controls.Add(txtDNIcli);
            Controls.Add(lblDNIcli);
            Controls.Add(txtNO);
            Controls.Add(lblNO);
            Controls.Add(lblPedidos);
            Name = "FmAdministrarPedido";
            Text = "FmAdministrarPedido";
            Load += FmAdministrarPedido_Load;
            pnlEP.ResumeLayout(false);
            pnlED.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label lblFechaSA;
        private System.Windows.Forms.Label lblFechaEP;
        private System.Windows.Forms.Label lblFechaED;
        private System.Windows.Forms.Label lblFechaE;
    }
}