namespace UI.TextilSoft.SubForms.Configuracion.Composite
{
    partial class FmUsuarios
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
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblFamilias = new System.Windows.Forms.Label();
            this.lblPatentes = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.btnConfigUsuario = new FontAwesome.Sharp.IconButton();
            this.btnAgregarPatente = new FontAwesome.Sharp.IconButton();
            this.btnAgregarFamilia = new FontAwesome.Sharp.IconButton();
            this.treeViewUsuarios = new System.Windows.Forms.TreeView();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnGuardarConfiguracion = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Location = new System.Drawing.Point(59, 54);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(104, 15);
            this.lblUsuarios.TabIndex = 0;
            this.lblUsuarios.Text = "Todos los Usuarios";
            // 
            // lblFamilias
            // 
            this.lblFamilias.AutoSize = true;
            this.lblFamilias.ForeColor = System.Drawing.Color.White;
            this.lblFamilias.Location = new System.Drawing.Point(57, 320);
            this.lblFamilias.Name = "lblFamilias";
            this.lblFamilias.Size = new System.Drawing.Size(95, 15);
            this.lblFamilias.TabIndex = 1;
            this.lblFamilias.Text = "Agregar Familias";
            // 
            // lblPatentes
            // 
            this.lblPatentes.AutoSize = true;
            this.lblPatentes.ForeColor = System.Drawing.Color.White;
            this.lblPatentes.Location = new System.Drawing.Point(57, 192);
            this.lblPatentes.Name = "lblPatentes";
            this.lblPatentes.Size = new System.Drawing.Size(97, 15);
            this.lblPatentes.TabIndex = 2;
            this.lblPatentes.Text = "Agregar Patentes";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(59, 81);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(121, 23);
            this.cboUsuarios.TabIndex = 3;
            // 
            // cboPatentes
            // 
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(57, 220);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(121, 23);
            this.cboPatentes.TabIndex = 4;
            this.cboPatentes.SelectedIndexChanged += new System.EventHandler(this.cboPatentes_SelectedIndexChanged);
            // 
            // cboFamilias
            // 
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(57, 347);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(121, 23);
            this.cboFamilias.TabIndex = 5;
            // 
            // btnConfigUsuario
            // 
            this.btnConfigUsuario.FlatAppearance.BorderSize = 0;
            this.btnConfigUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigUsuario.ForeColor = System.Drawing.Color.White;
            this.btnConfigUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnConfigUsuario.IconColor = System.Drawing.Color.Black;
            this.btnConfigUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigUsuario.Location = new System.Drawing.Point(59, 110);
            this.btnConfigUsuario.Name = "btnConfigUsuario";
            this.btnConfigUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnConfigUsuario.TabIndex = 6;
            this.btnConfigUsuario.Text = "Configurar";
            this.btnConfigUsuario.UseVisualStyleBackColor = true;
            this.btnConfigUsuario.Click += new System.EventHandler(this.btnConfigUsuario_Click_1);
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.FlatAppearance.BorderSize = 0;
            this.btnAgregarPatente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPatente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPatente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarPatente.IconColor = System.Drawing.Color.Black;
            this.btnAgregarPatente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarPatente.Location = new System.Drawing.Point(57, 274);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPatente.TabIndex = 9;
            this.btnAgregarPatente.Text = "Agregar";
            this.btnAgregarPatente.UseVisualStyleBackColor = true;
            this.btnAgregarPatente.Click += new System.EventHandler(this.btnAgregarPatente_Click);
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.FlatAppearance.BorderSize = 0;
            this.btnAgregarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFamilia.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFamilia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarFamilia.IconColor = System.Drawing.Color.Black;
            this.btnAgregarFamilia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarFamilia.Location = new System.Drawing.Point(57, 376);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarFamilia.TabIndex = 10;
            this.btnAgregarFamilia.Text = "Agregar";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // treeViewUsuarios
            // 
            this.treeViewUsuarios.Location = new System.Drawing.Point(215, 53);
            this.treeViewUsuarios.Name = "treeViewUsuarios";
            this.treeViewUsuarios.Size = new System.Drawing.Size(494, 351);
            this.treeViewUsuarios.TabIndex = 11;
            this.treeViewUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewUsuarios_MouseClick);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(57, 245);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.ReadOnly = true;
            this.txtPatente.Size = new System.Drawing.Size(121, 23);
            this.txtPatente.TabIndex = 31;
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnGuardarConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarConfiguracion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarConfiguracion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(373, 408);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(144, 30);
            this.btnGuardarConfiguracion.TabIndex = 32;
            this.btnGuardarConfiguracion.Text = "Guardar Configuracion";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = true;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // FmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.btnGuardarConfiguracion);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.treeViewUsuarios);
            this.Controls.Add(this.btnAgregarFamilia);
            this.Controls.Add(this.btnAgregarPatente);
            this.Controls.Add(this.btnConfigUsuario);
            this.Controls.Add(this.cboFamilias);
            this.Controls.Add(this.cboPatentes);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(this.lblPatentes);
            this.Controls.Add(this.lblFamilias);
            this.Controls.Add(this.lblUsuarios);
            this.Name = "FmUsuarios";
            this.Text = "FmUsuarios";
            this.Load += new System.EventHandler(this.FmUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblFamilias;
        private System.Windows.Forms.Label lblPatentes;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.ComboBox cboPatentes;
        private System.Windows.Forms.ComboBox cboFamilias;
        private FontAwesome.Sharp.IconButton btnConfigUsuario;
        private FontAwesome.Sharp.IconButton btnAgregarPatente;
        private FontAwesome.Sharp.IconButton btnAgregarFamilia;
        private System.Windows.Forms.TreeView treeViewUsuarios;
        private System.Windows.Forms.TextBox txtPatente;
        private FontAwesome.Sharp.IconButton btnGuardarConfiguracion;
    }
}