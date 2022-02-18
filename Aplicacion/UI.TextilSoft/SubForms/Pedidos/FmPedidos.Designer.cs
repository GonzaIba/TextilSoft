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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCrearPedido = new FontAwesome.Sharp.IconButton();
            this.btnAdministrarPedido = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblPrincipal.Location = new System.Drawing.Point(331, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(49, 15);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Pedidos";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(1, 121);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(797, 396);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearPedido.FlatAppearance.BorderSize = 0;
            this.btnCrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPedido.ForeColor = System.Drawing.Color.White;
            this.btnCrearPedido.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCrearPedido.IconColor = System.Drawing.Color.White;
            this.btnCrearPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearPedido.IconSize = 35;
            this.btnCrearPedido.Location = new System.Drawing.Point(158, 74);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(137, 46);
            this.btnCrearPedido.TabIndex = 4;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearPedido.UseVisualStyleBackColor = false;
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // btnAdministrarPedido
            // 
            this.btnAdministrarPedido.FlatAppearance.BorderSize = 0;
            this.btnAdministrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarPedido.ForeColor = System.Drawing.Color.White;
            this.btnAdministrarPedido.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnAdministrarPedido.IconColor = System.Drawing.Color.White;
            this.btnAdministrarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdministrarPedido.IconSize = 35;
            this.btnAdministrarPedido.Location = new System.Drawing.Point(367, 74);
            this.btnAdministrarPedido.Name = "btnAdministrarPedido";
            this.btnAdministrarPedido.Size = new System.Drawing.Size(175, 46);
            this.btnAdministrarPedido.TabIndex = 5;
            this.btnAdministrarPedido.Text = "Administrar Pedido";
            this.btnAdministrarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministrarPedido.UseVisualStyleBackColor = true;
            this.btnAdministrarPedido.Click += new System.EventHandler(this.btnAdministrarPedido_Click);
            // 
            // FmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnAdministrarPedido);
            this.Controls.Add(this.btnCrearPedido);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "FmPedidos";
            this.Text = "FmPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnCrearPedido;
        private FontAwesome.Sharp.IconButton btnAdministrarPedido;
    }
}