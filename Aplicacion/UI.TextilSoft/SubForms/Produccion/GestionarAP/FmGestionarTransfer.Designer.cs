namespace UI.TextilSoft.SubForms.Produccion.GestionarAP
{
    partial class FmGestionarTransfer
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
            btnCrear = new FontAwesome.Sharp.IconButton();
            txtCodigo = new AltoControls.AltoTextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            lblPrincipal = new System.Windows.Forms.Label();
            btnImagenPrenda = new FontAwesome.Sharp.IconButton();
            pBoxImagenTransfer = new System.Windows.Forms.PictureBox();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            pBoxImagenTransferBuscar = new System.Windows.Forms.PictureBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtTransferBuscar = new AltoControls.AltoTextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pBoxImagenTransfer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxImagenTransferBuscar).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCrear.ForeColor = System.Drawing.Color.White;
            btnCrear.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnCrear.IconColor = System.Drawing.Color.White;
            btnCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCrear.IconSize = 35;
            btnCrear.Location = new System.Drawing.Point(82, 425);
            btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new System.Drawing.Size(95, 45);
            btnCrear.TabIndex = 131;
            btnCrear.Text = "Crear";
            btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.Color.Transparent;
            txtCodigo.Br = System.Drawing.Color.MidnightBlue;
            txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigo.ForeColor = System.Drawing.Color.White;
            txtCodigo.Location = new System.Drawing.Point(57, 128);
            txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(141, 39);
            txtCodigo.TabIndex = 130;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(91, 95);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(61, 20);
            lblDescripcion.TabIndex = 129;
            lblDescripcion.Text = "Código:";
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(156, 22);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(467, 41);
            lblPrincipal.TabIndex = 134;
            lblPrincipal.Text = "Gestion De Armado De Productos";
            // 
            // btnImagenPrenda
            // 
            btnImagenPrenda.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImagenPrenda.FlatAppearance.BorderSize = 0;
            btnImagenPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImagenPrenda.ForeColor = System.Drawing.Color.White;
            btnImagenPrenda.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnImagenPrenda.IconColor = System.Drawing.Color.White;
            btnImagenPrenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImagenPrenda.IconSize = 45;
            btnImagenPrenda.Location = new System.Drawing.Point(43, 175);
            btnImagenPrenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnImagenPrenda.Name = "btnImagenPrenda";
            btnImagenPrenda.Size = new System.Drawing.Size(176, 40);
            btnImagenPrenda.TabIndex = 137;
            btnImagenPrenda.Text = "Cargar Imagen";
            btnImagenPrenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnImagenPrenda.UseVisualStyleBackColor = true;
            btnImagenPrenda.Click += btnImagenPrenda_Click;
            // 
            // pBoxImagenTransfer
            // 
            pBoxImagenTransfer.Location = new System.Drawing.Point(12, 223);
            pBoxImagenTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pBoxImagenTransfer.Name = "pBoxImagenTransfer";
            pBoxImagenTransfer.Size = new System.Drawing.Size(264, 194);
            pBoxImagenTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxImagenTransfer.TabIndex = 136;
            pBoxImagenTransfer.TabStop = false;
            // 
            // pBoxImagenTransferBuscar
            // 
            pBoxImagenTransferBuscar.Location = new System.Drawing.Point(456, 223);
            pBoxImagenTransferBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pBoxImagenTransferBuscar.Name = "pBoxImagenTransferBuscar";
            pBoxImagenTransferBuscar.Size = new System.Drawing.Size(264, 194);
            pBoxImagenTransferBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pBoxImagenTransferBuscar.TabIndex = 141;
            pBoxImagenTransferBuscar.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = System.Drawing.Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 35;
            btnSearch.Location = new System.Drawing.Point(540, 175);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(95, 36);
            btnSearch.TabIndex = 140;
            btnSearch.Text = "Buscar";
            btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTransferBuscar
            // 
            txtTransferBuscar.BackColor = System.Drawing.Color.Transparent;
            txtTransferBuscar.Br = System.Drawing.Color.MidnightBlue;
            txtTransferBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTransferBuscar.ForeColor = System.Drawing.Color.White;
            txtTransferBuscar.Location = new System.Drawing.Point(518, 128);
            txtTransferBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTransferBuscar.Name = "txtTransferBuscar";
            txtTransferBuscar.Size = new System.Drawing.Size(141, 39);
            txtTransferBuscar.TabIndex = 139;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(562, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 20);
            label1.TabIndex = 138;
            label1.Text = "Código:";
            // 
            // FmGestionarTransfer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(800, 523);
            Controls.Add(pBoxImagenTransferBuscar);
            Controls.Add(btnSearch);
            Controls.Add(txtTransferBuscar);
            Controls.Add(label1);
            Controls.Add(btnImagenPrenda);
            Controls.Add(pBoxImagenTransfer);
            Controls.Add(lblPrincipal);
            Controls.Add(btnCrear);
            Controls.Add(txtCodigo);
            Controls.Add(lblDescripcion);
            Name = "FmGestionarTransfer";
            Text = "FmGestionarTransfer";
            ((System.ComponentModel.ISupportInitialize)pBoxImagenTransfer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxImagenTransferBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCrear;
        private AltoControls.AltoTextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrincipal;
        private FontAwesome.Sharp.IconButton btnImagenPrenda;
        private System.Windows.Forms.PictureBox pBoxImagenTransfer;
        private System.Windows.Forms.ToolTip toolTipError;
        private System.Windows.Forms.PictureBox pBoxImagenTransferBuscar;
        private FontAwesome.Sharp.IconButton btnSearch;
        private AltoControls.AltoTextBox txtTransferBuscar;
        private System.Windows.Forms.Label label1;
    }
}