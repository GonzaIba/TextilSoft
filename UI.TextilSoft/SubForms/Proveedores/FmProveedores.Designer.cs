namespace UI.TextilSoft.SubForms.Proveedores
{
    partial class FmProveedores
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaProveedores = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnRejectChanges = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proveedores";
            // 
            // GrillaProveedores
            // 
            this.GrillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProveedores.Location = new System.Drawing.Point(113, 211);
            this.GrillaProveedores.Name = "GrillaProveedores";
            this.GrillaProveedores.RowTemplate.Height = 25;
            this.GrillaProveedores.Size = new System.Drawing.Size(551, 202);
            this.GrillaProveedores.TabIndex = 3;
            this.GrillaProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProveedores_CellContentClick);
            this.GrillaProveedores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProveedores_CellValueChanged);
            this.GrillaProveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GrillaProveedores_MouseClick);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveChanges.IconColor = System.Drawing.Color.White;
            this.btnSaveChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveChanges.IconSize = 35;
            this.btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChanges.Location = new System.Drawing.Point(163, 419);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(162, 44);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnRefresh.IconColor = System.Drawing.Color.White;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 35;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(113, 161);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(42, 44);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnRejectChanges
            // 
            this.btnRejectChanges.FlatAppearance.BorderSize = 0;
            this.btnRejectChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectChanges.ForeColor = System.Drawing.Color.White;
            this.btnRejectChanges.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnRejectChanges.IconColor = System.Drawing.Color.White;
            this.btnRejectChanges.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRejectChanges.IconSize = 37;
            this.btnRejectChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRejectChanges.Location = new System.Drawing.Point(435, 419);
            this.btnRejectChanges.Name = "btnRejectChanges";
            this.btnRejectChanges.Size = new System.Drawing.Size(162, 44);
            this.btnRejectChanges.TabIndex = 7;
            this.btnRejectChanges.Text = "Cancelar Cambios";
            this.btnRejectChanges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRejectChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRejectChanges.UseVisualStyleBackColor = true;
            this.btnRejectChanges.Click += new System.EventHandler(this.btnRejectChanges_Click);
            // 
            // FmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnRejectChanges);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.GrillaProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FmProveedores";
            this.Text = "FmProveedores";
            this.Load += new System.EventHandler(this.FmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaProveedores;
        private FontAwesome.Sharp.IconButton btnSaveChanges;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnRejectChanges;
    }
}