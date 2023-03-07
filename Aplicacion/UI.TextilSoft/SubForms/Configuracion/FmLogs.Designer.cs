namespace UI.TextilSoft.SubForms.Configuracion
{
    partial class FmLogs
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
            lbLog = new System.Windows.Forms.ListBox();
            btnError = new FontAwesome.Sharp.IconButton();
            btnWarning = new FontAwesome.Sharp.IconButton();
            btnFatal = new FontAwesome.Sharp.IconButton();
            lblDateHasta = new System.Windows.Forms.Label();
            lblDateDesde = new System.Windows.Forms.Label();
            fmDateDesde = new Tools.FormsTools.FmDateTime();
            fmDateHasta = new Tools.FormsTools.FmDateTime();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cboxUsuarios = new Tools.FormsTools.FmCombobox();
            label3 = new System.Windows.Forms.Label();
            cboxFileType = new Tools.FormsTools.FmCombobox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            panelPaginado = new System.Windows.Forms.Panel();
            btnTercero = new System.Windows.Forms.Button();
            btnAnterior = new FontAwesome.Sharp.IconButton();
            btnPrimero = new System.Windows.Forms.Button();
            btnFinal = new System.Windows.Forms.Button();
            btnSegundo = new System.Windows.Forms.Button();
            btnInicio = new System.Windows.Forms.Button();
            btnSiguiente = new FontAwesome.Sharp.IconButton();
            panelPaginado.SuspendLayout();
            SuspendLayout();
            // 
            // lbLog
            // 
            lbLog.BackColor = System.Drawing.Color.Black;
            lbLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbLog.ForeColor = System.Drawing.Color.White;
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 17;
            lbLog.Location = new System.Drawing.Point(12, 146);
            lbLog.Name = "lbLog";
            lbLog.Size = new System.Drawing.Size(896, 276);
            lbLog.TabIndex = 0;
            // 
            // btnError
            // 
            btnError.Cursor = System.Windows.Forms.Cursors.Hand;
            btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnError.ForeColor = System.Drawing.Color.White;
            btnError.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnError.IconColor = System.Drawing.Color.White;
            btnError.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnError.IconSize = 30;
            btnError.Location = new System.Drawing.Point(630, 95);
            btnError.Name = "btnError";
            btnError.Size = new System.Drawing.Size(88, 42);
            btnError.TabIndex = 69;
            btnError.Text = "Error";
            btnError.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnError.UseVisualStyleBackColor = true;
            btnError.Click += btnError_Click;
            // 
            // btnWarning
            // 
            btnWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            btnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnWarning.ForeColor = System.Drawing.Color.White;
            btnWarning.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            btnWarning.IconColor = System.Drawing.Color.White;
            btnWarning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWarning.IconSize = 30;
            btnWarning.Location = new System.Drawing.Point(717, 95);
            btnWarning.Name = "btnWarning";
            btnWarning.Size = new System.Drawing.Size(111, 42);
            btnWarning.TabIndex = 70;
            btnWarning.Text = "Information";
            btnWarning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnWarning.UseVisualStyleBackColor = true;
            btnWarning.Click += btnWarning_Click;
            // 
            // btnFatal
            // 
            btnFatal.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFatal.ForeColor = System.Drawing.Color.White;
            btnFatal.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnFatal.IconColor = System.Drawing.Color.White;
            btnFatal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFatal.IconSize = 30;
            btnFatal.Location = new System.Drawing.Point(827, 95);
            btnFatal.Name = "btnFatal";
            btnFatal.Size = new System.Drawing.Size(80, 42);
            btnFatal.TabIndex = 72;
            btnFatal.Text = "Fatal";
            btnFatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFatal.UseVisualStyleBackColor = true;
            btnFatal.Click += btnFatal_Click;
            // 
            // lblDateHasta
            // 
            lblDateHasta.AutoSize = true;
            lblDateHasta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateHasta.ForeColor = System.Drawing.Color.White;
            lblDateHasta.Location = new System.Drawing.Point(383, 88);
            lblDateHasta.Name = "lblDateHasta";
            lblDateHasta.Size = new System.Drawing.Size(49, 21);
            lblDateHasta.TabIndex = 75;
            lblDateHasta.Text = "Hasta";
            // 
            // lblDateDesde
            // 
            lblDateDesde.AutoSize = true;
            lblDateDesde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDateDesde.ForeColor = System.Drawing.Color.White;
            lblDateDesde.Location = new System.Drawing.Point(266, 88);
            lblDateDesde.Name = "lblDateDesde";
            lblDateDesde.Size = new System.Drawing.Size(53, 21);
            lblDateDesde.TabIndex = 76;
            lblDateDesde.Text = "Desde";
            // 
            // fmDateDesde
            // 
            fmDateDesde.BorderColor = System.Drawing.Color.PaleVioletRed;
            fmDateDesde.BorderSize = 0;
            fmDateDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmDateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            fmDateDesde.Location = new System.Drawing.Point(240, 112);
            fmDateDesde.MinimumSize = new System.Drawing.Size(4, 10);
            fmDateDesde.Name = "fmDateDesde";
            fmDateDesde.Size = new System.Drawing.Size(107, 24);
            fmDateDesde.SkinColor = System.Drawing.Color.MediumSlateBlue;
            fmDateDesde.TabIndex = 77;
            fmDateDesde.TextColor = System.Drawing.Color.White;
            fmDateDesde.ValueChanged += fmDateDesde_ValueChanged;
            // 
            // fmDateHasta
            // 
            fmDateHasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            fmDateHasta.BorderSize = 0;
            fmDateHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmDateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            fmDateHasta.Location = new System.Drawing.Point(353, 112);
            fmDateHasta.MinimumSize = new System.Drawing.Size(4, 10);
            fmDateHasta.Name = "fmDateHasta";
            fmDateHasta.Size = new System.Drawing.Size(107, 24);
            fmDateHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            fmDateHasta.TabIndex = 78;
            fmDateHasta.TextColor = System.Drawing.Color.White;
            fmDateHasta.ValueChanged += fmDateHasta_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(107, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 20);
            label1.TabIndex = 79;
            label1.Text = "Buscar por usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(290, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(299, 40);
            label2.TabIndex = 80;
            label2.Text = "Registros de Auditoría";
            // 
            // cboxUsuarios
            // 
            cboxUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxUsuarios.BorderColor = System.Drawing.Color.MediumSlateBlue;
            cboxUsuarios.BorderSize = 1;
            cboxUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboxUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboxUsuarios.ForeColor = System.Drawing.Color.DimGray;
            cboxUsuarios.IconColor = System.Drawing.Color.MediumSlateBlue;
            cboxUsuarios.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            cboxUsuarios.ListTextColor = System.Drawing.Color.DimGray;
            cboxUsuarios.Location = new System.Drawing.Point(126, 106);
            cboxUsuarios.Name = "cboxUsuarios";
            cboxUsuarios.Padding = new System.Windows.Forms.Padding(1);
            cboxUsuarios.Size = new System.Drawing.Size(89, 30);
            cboxUsuarios.TabIndex = 81;
            cboxUsuarios.Texts = "";
            cboxUsuarios.OnSelectedIndexChanged += cboxUsuarios_OnSelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(27, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 20);
            label3.TabIndex = 82;
            label3.Text = "Archivo";
            // 
            // cboxFileType
            // 
            cboxFileType.BackColor = System.Drawing.Color.WhiteSmoke;
            cboxFileType.BorderColor = System.Drawing.Color.MediumSlateBlue;
            cboxFileType.BorderSize = 1;
            cboxFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cboxFileType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboxFileType.ForeColor = System.Drawing.Color.DimGray;
            cboxFileType.IconColor = System.Drawing.Color.MediumSlateBlue;
            cboxFileType.Items.AddRange(new object[] { "Log", "Performance" });
            cboxFileType.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            cboxFileType.ListTextColor = System.Drawing.Color.DimGray;
            cboxFileType.Location = new System.Drawing.Point(14, 106);
            cboxFileType.Name = "cboxFileType";
            cboxFileType.Padding = new System.Windows.Forms.Padding(1);
            cboxFileType.Size = new System.Drawing.Size(89, 30);
            cboxFileType.TabIndex = 83;
            cboxFileType.Texts = "";
            cboxFileType.OnSelectedIndexChanged += cboxFileType_OnSelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.ForeColor = System.Drawing.Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLimpiar.IconColor = System.Drawing.Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 30;
            btnLimpiar.Location = new System.Drawing.Point(560, 95);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(72, 42);
            btnLimpiar.TabIndex = 84;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panelPaginado
            // 
            panelPaginado.Controls.Add(btnTercero);
            panelPaginado.Controls.Add(btnAnterior);
            panelPaginado.Controls.Add(btnPrimero);
            panelPaginado.Controls.Add(btnFinal);
            panelPaginado.Controls.Add(btnSegundo);
            panelPaginado.Controls.Add(btnInicio);
            panelPaginado.Controls.Add(btnSiguiente);
            panelPaginado.Location = new System.Drawing.Point(692, 428);
            panelPaginado.Name = "panelPaginado";
            panelPaginado.Size = new System.Drawing.Size(215, 36);
            panelPaginado.TabIndex = 85;
            // 
            // btnTercero
            // 
            btnTercero.Cursor = System.Windows.Forms.Cursors.Hand;
            btnTercero.FlatAppearance.BorderSize = 0;
            btnTercero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTercero.ForeColor = System.Drawing.Color.White;
            btnTercero.Location = new System.Drawing.Point(121, 8);
            btnTercero.Name = "btnTercero";
            btnTercero.Size = new System.Drawing.Size(30, 23);
            btnTercero.TabIndex = 25;
            btnTercero.Text = "3";
            btnTercero.UseVisualStyleBackColor = true;
            btnTercero.Click += btnTercero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAnterior.FlatAppearance.BorderSize = 0;
            btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAnterior.ForeColor = System.Drawing.Color.White;
            btnAnterior.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            btnAnterior.IconColor = System.Drawing.Color.White;
            btnAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnterior.IconSize = 20;
            btnAnterior.Location = new System.Drawing.Point(33, 10);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new System.Drawing.Size(24, 23);
            btnAnterior.TabIndex = 22;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPrimero.FlatAppearance.BorderSize = 0;
            btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrimero.ForeColor = System.Drawing.Color.White;
            btnPrimero.Location = new System.Drawing.Point(59, 8);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new System.Drawing.Size(30, 23);
            btnPrimero.TabIndex = 17;
            btnPrimero.Text = "1";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnFinal
            // 
            btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFinal.FlatAppearance.BorderSize = 0;
            btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFinal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFinal.ForeColor = System.Drawing.Color.White;
            btnFinal.Location = new System.Drawing.Point(170, 6);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new System.Drawing.Size(42, 28);
            btnFinal.TabIndex = 24;
            btnFinal.Text = "...N";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // btnSegundo
            // 
            btnSegundo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSegundo.FlatAppearance.BorderSize = 0;
            btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSegundo.ForeColor = System.Drawing.Color.White;
            btnSegundo.Location = new System.Drawing.Point(91, 8);
            btnSegundo.Name = "btnSegundo";
            btnSegundo.Size = new System.Drawing.Size(30, 23);
            btnSegundo.TabIndex = 19;
            btnSegundo.Text = "2";
            btnSegundo.UseVisualStyleBackColor = true;
            btnSegundo.Click += btnSegundo_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnInicio.ForeColor = System.Drawing.Color.White;
            btnInicio.Location = new System.Drawing.Point(8, 5);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new System.Drawing.Size(19, 27);
            btnInicio.TabIndex = 23;
            btnInicio.Text = "1";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSiguiente.ForeColor = System.Drawing.Color.White;
            btnSiguiente.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            btnSiguiente.IconColor = System.Drawing.Color.White;
            btnSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSiguiente.IconSize = 20;
            btnSiguiente.Location = new System.Drawing.Point(150, 10);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new System.Drawing.Size(24, 23);
            btnSiguiente.TabIndex = 21;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FmLogs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(23, 21, 32);
            ClientSize = new System.Drawing.Size(920, 475);
            Controls.Add(panelPaginado);
            Controls.Add(btnLimpiar);
            Controls.Add(cboxFileType);
            Controls.Add(label3);
            Controls.Add(cboxUsuarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fmDateHasta);
            Controls.Add(fmDateDesde);
            Controls.Add(lblDateDesde);
            Controls.Add(lblDateHasta);
            Controls.Add(btnFatal);
            Controls.Add(btnWarning);
            Controls.Add(btnError);
            Controls.Add(lbLog);
            Name = "FmLogs";
            Text = "FmLogs";
            Load += FmLogs_Load;
            panelPaginado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lbLog;
        private FontAwesome.Sharp.IconButton btnError;
        private FontAwesome.Sharp.IconButton btnWarning;
        private FontAwesome.Sharp.IconButton btnFatal;
        private System.Windows.Forms.Label lblDateHasta;
        private System.Windows.Forms.Label lblDateDesde;
        private Tools.FormsTools.FmDateTime fmDateDesde;
        private Tools.FormsTools.FmDateTime fmDateHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Tools.FormsTools.FmCombobox cboxUsuarios;
        private System.Windows.Forms.Label label3;
        private Tools.FormsTools.FmCombobox cboxFileType;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Panel panelPaginado;
        private System.Windows.Forms.Button btnTercero;
        private FontAwesome.Sharp.IconButton btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnInicio;
        private FontAwesome.Sharp.IconButton btnSiguiente;
    }
}