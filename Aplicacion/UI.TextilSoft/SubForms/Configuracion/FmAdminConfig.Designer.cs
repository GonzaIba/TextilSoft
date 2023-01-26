﻿namespace UI.TextilSoft.SubForms.Configuracion
{
    partial class FmAdminConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfigCompany = new FontAwesome.Sharp.IconButton();
            this.btnPatenteFamilia = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfigCompany);
            this.panel1.Controls.Add(this.btnPatenteFamilia);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnConfigCompany
            // 
            this.btnConfigCompany.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfigCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigCompany.ForeColor = System.Drawing.Color.White;
            this.btnConfigCompany.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnConfigCompany.IconColor = System.Drawing.Color.White;
            this.btnConfigCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigCompany.IconSize = 35;
            this.btnConfigCompany.Location = new System.Drawing.Point(748, 0);
            this.btnConfigCompany.Name = "btnConfigCompany";
            this.btnConfigCompany.Size = new System.Drawing.Size(137, 47);
            this.btnConfigCompany.TabIndex = 2;
            this.btnConfigCompany.Text = "Configuración de la compañía";
            this.btnConfigCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigCompany.UseVisualStyleBackColor = true;
            this.btnConfigCompany.Click += new System.EventHandler(this.btnConfigCompany_Click);
            // 
            // btnPatenteFamilia
            // 
            this.btnPatenteFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatenteFamilia.ForeColor = System.Drawing.Color.White;
            this.btnPatenteFamilia.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnPatenteFamilia.IconColor = System.Drawing.Color.White;
            this.btnPatenteFamilia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPatenteFamilia.IconSize = 35;
            this.btnPatenteFamilia.Location = new System.Drawing.Point(113, 0);
            this.btnPatenteFamilia.Name = "btnPatenteFamilia";
            this.btnPatenteFamilia.Size = new System.Drawing.Size(118, 46);
            this.btnPatenteFamilia.TabIndex = 1;
            this.btnPatenteFamilia.Text = "Patentes y Familias";
            this.btnPatenteFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatenteFamilia.UseVisualStyleBackColor = true;
            this.btnPatenteFamilia.Click += new System.EventHandler(this.btnPatenteFamilia_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 35;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(112, 46);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 47);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(886, 446);
            this.panelContenedor.TabIndex = 1;
            // 
            // FmAdminConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(886, 493);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FmAdminConfig";
            this.Text = "FmAdminConfig";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPatenteFamilia;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnConfigCompany;
    }
}