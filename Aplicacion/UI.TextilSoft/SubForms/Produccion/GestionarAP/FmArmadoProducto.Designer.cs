namespace UI.TextilSoft.SubForms.Produccion.GestionarAP
{
    partial class FmArmadoProducto
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
            lblPrincipal = new System.Windows.Forms.Label();
            fmCboxTipoArmado = new Tools.FormsTools.FmCombobox();
            lblCollareta = new System.Windows.Forms.Label();
            txtCodigo = new AltoControls.AltoTextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            txtEliminarNombre = new AltoControls.AltoTextBox();
            lblNombre = new System.Windows.Forms.Label();
            txtCrearNombre = new AltoControls.AltoTextBox();
            label1 = new System.Windows.Forms.Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lblPrincipal
            // 
            lblPrincipal.AutoSize = true;
            lblPrincipal.BackColor = System.Drawing.Color.Transparent;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrincipal.ForeColor = System.Drawing.Color.White;
            lblPrincipal.Location = new System.Drawing.Point(136, 32);
            lblPrincipal.Name = "lblPrincipal";
            lblPrincipal.Size = new System.Drawing.Size(373, 32);
            lblPrincipal.TabIndex = 33;
            lblPrincipal.Text = "Gestion De Armado De Productos";
            // 
            // fmCboxTipoArmado
            // 
            fmCboxTipoArmado.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTipoArmado.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoArmado.BorderSize = 0;
            fmCboxTipoArmado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTipoArmado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTipoArmado.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTipoArmado.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTipoArmado.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxTipoArmado.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTipoArmado.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTipoArmado.Location = new System.Drawing.Point(265, 97);
            fmCboxTipoArmado.Name = "fmCboxTipoArmado";
            fmCboxTipoArmado.Size = new System.Drawing.Size(126, 20);
            fmCboxTipoArmado.TabIndex = 125;
            fmCboxTipoArmado.Texts = "";
            // 
            // lblCollareta
            // 
            lblCollareta.AutoSize = true;
            lblCollareta.ForeColor = System.Drawing.Color.White;
            lblCollareta.Location = new System.Drawing.Point(278, 79);
            lblCollareta.Name = "lblCollareta";
            lblCollareta.Size = new System.Drawing.Size(93, 15);
            lblCollareta.TabIndex = 124;
            lblCollareta.Text = "Tipo De Armado";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.Color.Transparent;
            txtCodigo.Br = System.Drawing.Color.MidnightBlue;
            txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigo.ForeColor = System.Drawing.Color.White;
            txtCodigo.Location = new System.Drawing.Point(94, 158);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(123, 29);
            txtCodigo.TabIndex = 123;
            txtCodigo.TextChanged += txtDesc_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(36, 164);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(49, 15);
            lblDescripcion.TabIndex = 122;
            lblDescripcion.Text = "Código:";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = System.Drawing.Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 35;
            btnEliminar.Location = new System.Drawing.Point(59, 238);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(123, 46);
            btnEliminar.TabIndex = 126;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEliminarNombre
            // 
            txtEliminarNombre.BackColor = System.Drawing.Color.Transparent;
            txtEliminarNombre.Br = System.Drawing.Color.MidnightBlue;
            txtEliminarNombre.Enabled = false;
            txtEliminarNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEliminarNombre.ForeColor = System.Drawing.Color.White;
            txtEliminarNombre.Location = new System.Drawing.Point(94, 194);
            txtEliminarNombre.Name = "txtEliminarNombre";
            txtEliminarNombre.Size = new System.Drawing.Size(123, 29);
            txtEliminarNombre.TabIndex = 128;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = System.Drawing.Color.White;
            lblNombre.Location = new System.Drawing.Point(31, 200);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(54, 15);
            lblNombre.TabIndex = 127;
            lblNombre.Text = "Nombre:";
            // 
            // txtCrearNombre
            // 
            txtCrearNombre.BackColor = System.Drawing.Color.Transparent;
            txtCrearNombre.Br = System.Drawing.Color.MidnightBlue;
            txtCrearNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCrearNombre.ForeColor = System.Drawing.Color.White;
            txtCrearNombre.Location = new System.Drawing.Point(295, 194);
            txtCrearNombre.Name = "txtCrearNombre";
            txtCrearNombre.Size = new System.Drawing.Size(123, 29);
            txtCrearNombre.TabIndex = 133;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(325, 172);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 132;
            label1.Text = "Nombre:";
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.ForeColor = System.Drawing.Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = System.Drawing.Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new System.Drawing.Point(295, 229);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new System.Drawing.Size(123, 46);
            iconButton1.TabIndex = 131;
            iconButton1.Text = "Crear";
            iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // FmArmadoProducto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(744, 338);
            Controls.Add(txtCrearNombre);
            Controls.Add(label1);
            Controls.Add(iconButton1);
            Controls.Add(txtEliminarNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnEliminar);
            Controls.Add(fmCboxTipoArmado);
            Controls.Add(lblCollareta);
            Controls.Add(txtCodigo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrincipal);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FmArmadoProducto";
            Text = "FmArmadoProducto";
            Load += FmArmadoProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private Tools.FormsTools.FmCombobox fmCboxTipoArmado;
        private System.Windows.Forms.Label lblCollareta;
        private AltoControls.AltoTextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private AltoControls.AltoTextBox txtEliminarNombre;
        private System.Windows.Forms.Label lblNombre;
        private AltoControls.AltoTextBox txtCrearNombre;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}