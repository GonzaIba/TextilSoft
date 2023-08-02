
namespace UI.TextilSoft.SubForms.Pedidos.CargarPedido
{
    partial class FmCrearPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            panelClientes = new System.Windows.Forms.Panel();
            txtSeña = new AltoControls.AltoTextBox();
            label8 = new System.Windows.Forms.Label();
            lblExtras = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtResidencia = new AltoControls.AltoTextBox();
            txtTelefono = new AltoControls.AltoTextBox();
            txtMail = new AltoControls.AltoTextBox();
            txtApellido = new AltoControls.AltoTextBox();
            txtNombre = new AltoControls.AltoTextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtDNI = new AltoControls.AltoTextBox();
            label2 = new System.Windows.Forms.Label();
            panelProductos = new System.Windows.Forms.Panel();
            txtColor = new AltoControls.AltoTextBox();
            label9 = new System.Windows.Forms.Label();
            fmCboxTransfer = new Tools.FormsTools.FmCombobox();
            lblTransfer = new System.Windows.Forms.Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            lblDatoProducto = new System.Windows.Forms.Label();
            txtCantidad = new AltoControls.AltoTextBox();
            txtDescripcion = new AltoControls.AltoTextBox();
            lblCantidad = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            txtCodigo = new AltoControls.AltoTextBox();
            lblCodigo = new System.Windows.Forms.Label();
            dgvProductos = new System.Windows.Forms.DataGridView();
            btnGenerarPedido = new FontAwesome.Sharp.IconButton();
            txtSubtotal = new AltoControls.AltoTextBox();
            lblSubTotal = new System.Windows.Forms.Label();
            txtTotal = new AltoControls.AltoTextBox();
            lblTotal = new System.Windows.Forms.Label();
            toolTipError = new System.Windows.Forms.ToolTip(components);
            tbEsPedido = new Tools.FormsTools.ToggleButton();
            lblSi = new System.Windows.Forms.Label();
            lblNo = new System.Windows.Forms.Label();
            lblEsPedido = new System.Windows.Forms.Label();
            panelProductoDetalle = new System.Windows.Forms.Panel();
            timerSubir = new System.Windows.Forms.Timer(components);
            timerBajar = new System.Windows.Forms.Timer(components);
            panelClientes.SuspendLayout();
            panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panelProductoDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(8, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Datos Del Cliente";
            // 
            // panelClientes
            // 
            panelClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelClientes.Controls.Add(txtSeña);
            panelClientes.Controls.Add(label8);
            panelClientes.Controls.Add(lblExtras);
            panelClientes.Controls.Add(label7);
            panelClientes.Controls.Add(label6);
            panelClientes.Controls.Add(label5);
            panelClientes.Controls.Add(txtResidencia);
            panelClientes.Controls.Add(txtTelefono);
            panelClientes.Controls.Add(txtMail);
            panelClientes.Controls.Add(txtApellido);
            panelClientes.Controls.Add(txtNombre);
            panelClientes.Controls.Add(label4);
            panelClientes.Controls.Add(label3);
            panelClientes.Controls.Add(txtDNI);
            panelClientes.Controls.Add(label2);
            panelClientes.Controls.Add(label1);
            panelClientes.Location = new System.Drawing.Point(14, 72);
            panelClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new System.Drawing.Size(1142, 200);
            panelClientes.TabIndex = 1;
            // 
            // txtSeña
            // 
            txtSeña.BackColor = System.Drawing.Color.Transparent;
            txtSeña.Br = System.Drawing.Color.MidnightBlue;
            txtSeña.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSeña.ForeColor = System.Drawing.Color.White;
            txtSeña.Location = new System.Drawing.Point(677, 47);
            txtSeña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSeña.Name = "txtSeña";
            txtSeña.Size = new System.Drawing.Size(139, 39);
            txtSeña.TabIndex = 17;
            txtSeña.TextChanged += txtSeña_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(626, 55);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(44, 20);
            label8.TabIndex = 16;
            label8.Text = "Seña:";
            // 
            // lblExtras
            // 
            lblExtras.AutoSize = true;
            lblExtras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExtras.ForeColor = System.Drawing.Color.White;
            lblExtras.Location = new System.Drawing.Point(677, 7);
            lblExtras.Name = "lblExtras";
            lblExtras.Size = new System.Drawing.Size(70, 28);
            lblExtras.TabIndex = 15;
            lblExtras.Text = "Extras";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(323, 151);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 20);
            label7.TabIndex = 14;
            label7.Text = "Residencia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(328, 106);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 20);
            label6.TabIndex = 13;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(328, 52);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Mail:";
            // 
            // txtResidencia
            // 
            txtResidencia.BackColor = System.Drawing.Color.Transparent;
            txtResidencia.Br = System.Drawing.Color.MidnightBlue;
            txtResidencia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtResidencia.ForeColor = System.Drawing.Color.White;
            txtResidencia.Location = new System.Drawing.Point(409, 143);
            txtResidencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtResidencia.Name = "txtResidencia";
            txtResidencia.Size = new System.Drawing.Size(144, 39);
            txtResidencia.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = System.Drawing.Color.Transparent;
            txtTelefono.Br = System.Drawing.Color.MidnightBlue;
            txtTelefono.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTelefono.ForeColor = System.Drawing.Color.White;
            txtTelefono.Location = new System.Drawing.Point(409, 96);
            txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(144, 39);
            txtTelefono.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.BackColor = System.Drawing.Color.Transparent;
            txtMail.Br = System.Drawing.Color.MidnightBlue;
            txtMail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMail.ForeColor = System.Drawing.Color.White;
            txtMail.Location = new System.Drawing.Point(409, 47);
            txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(144, 39);
            txtMail.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = System.Drawing.Color.Transparent;
            txtApellido.Br = System.Drawing.Color.MidnightBlue;
            txtApellido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtApellido.ForeColor = System.Drawing.Color.White;
            txtApellido.Location = new System.Drawing.Point(105, 143);
            txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(141, 39);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.Color.Transparent;
            txtNombre.Br = System.Drawing.Color.MidnightBlue;
            txtNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombre.ForeColor = System.Drawing.Color.White;
            txtNombre.Location = new System.Drawing.Point(105, 96);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(141, 39);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(35, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(37, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = System.Drawing.Color.Transparent;
            txtDNI.Br = System.Drawing.Color.MidnightBlue;
            txtDNI.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDNI.ForeColor = System.Drawing.Color.White;
            txtDNI.Location = new System.Drawing.Point(106, 47);
            txtDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(139, 39);
            txtDNI.TabIndex = 3;
            txtDNI.TextChanged += txtDNI_TextChanged;
            txtDNI.Click += txtDNI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(56, 52);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "DNI:";
            // 
            // panelProductos
            // 
            panelProductos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelProductos.Controls.Add(txtColor);
            panelProductos.Controls.Add(label9);
            panelProductos.Controls.Add(fmCboxTransfer);
            panelProductos.Controls.Add(lblTransfer);
            panelProductos.Controls.Add(btnCancelar);
            panelProductos.Controls.Add(btnAgregarProducto);
            panelProductos.Controls.Add(lblDatoProducto);
            panelProductos.Controls.Add(txtCantidad);
            panelProductos.Controls.Add(txtDescripcion);
            panelProductos.Controls.Add(lblCantidad);
            panelProductos.Controls.Add(lblDescripcion);
            panelProductos.Controls.Add(txtCodigo);
            panelProductos.Controls.Add(lblCodigo);
            panelProductos.Location = new System.Drawing.Point(6, 8);
            panelProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new System.Drawing.Size(1128, 103);
            panelProductos.TabIndex = 15;
            // 
            // txtColor
            // 
            txtColor.BackColor = System.Drawing.Color.Transparent;
            txtColor.Br = System.Drawing.Color.MidnightBlue;
            txtColor.Enabled = false;
            txtColor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtColor.ForeColor = System.Drawing.Color.White;
            txtColor.Location = new System.Drawing.Point(698, 55);
            txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtColor.Name = "txtColor";
            txtColor.Size = new System.Drawing.Size(102, 39);
            txtColor.TabIndex = 118;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(642, 66);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(48, 20);
            label9.TabIndex = 117;
            label9.Text = "Color:";
            // 
            // fmCboxTransfer
            // 
            fmCboxTransfer.BackColor = System.Drawing.Color.WhiteSmoke;
            fmCboxTransfer.BorderColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTransfer.BorderSize = 0;
            fmCboxTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            fmCboxTransfer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fmCboxTransfer.ForeColor = System.Drawing.Color.DimGray;
            fmCboxTransfer.IconColor = System.Drawing.Color.MediumSlateBlue;
            fmCboxTransfer.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "XXXL" });
            fmCboxTransfer.ListBackColor = System.Drawing.Color.FromArgb(230, 228, 245);
            fmCboxTransfer.ListTextColor = System.Drawing.Color.DimGray;
            fmCboxTransfer.Location = new System.Drawing.Point(817, 40);
            fmCboxTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fmCboxTransfer.Name = "fmCboxTransfer";
            fmCboxTransfer.Size = new System.Drawing.Size(134, 27);
            fmCboxTransfer.TabIndex = 116;
            fmCboxTransfer.Texts = "";
            // 
            // lblTransfer
            // 
            lblTransfer.AutoSize = true;
            lblTransfer.ForeColor = System.Drawing.Color.White;
            lblTransfer.Location = new System.Drawing.Point(854, 16);
            lblTransfer.Name = "lblTransfer";
            lblTransfer.Size = new System.Drawing.Size(64, 20);
            lblTransfer.TabIndex = 115;
            lblTransfer.Text = "Transfer:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            btnCancelar.IconColor = System.Drawing.Color.White;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 35;
            btnCancelar.Location = new System.Drawing.Point(972, 55);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(133, 42);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAgregarProducto.Enabled = false;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnAgregarProducto.IconColor = System.Drawing.Color.White;
            btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProducto.IconSize = 35;
            btnAgregarProducto.Location = new System.Drawing.Point(972, 5);
            btnAgregarProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new System.Drawing.Size(133, 48);
            btnAgregarProducto.TabIndex = 8;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // lblDatoProducto
            // 
            lblDatoProducto.AutoSize = true;
            lblDatoProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDatoProducto.ForeColor = System.Drawing.Color.White;
            lblDatoProducto.Location = new System.Drawing.Point(3, 9);
            lblDatoProducto.Name = "lblDatoProducto";
            lblDatoProducto.Size = new System.Drawing.Size(197, 28);
            lblDatoProducto.TabIndex = 16;
            lblDatoProducto.Text = "Datos Del Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = System.Drawing.Color.Transparent;
            txtCantidad.Br = System.Drawing.Color.MidnightBlue;
            txtCantidad.Enabled = false;
            txtCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCantidad.ForeColor = System.Drawing.Color.White;
            txtCantidad.Location = new System.Drawing.Point(698, 9);
            txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(102, 39);
            txtCantidad.TabIndex = 7;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            txtDescripcion.Br = System.Drawing.Color.MidnightBlue;
            txtDescripcion.Enabled = false;
            txtDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDescripcion.ForeColor = System.Drawing.Color.White;
            txtDescripcion.Location = new System.Drawing.Point(322, 10);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(293, 87);
            txtDescripcion.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(620, 19);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 20);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(230, 48);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(90, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.Color.Transparent;
            txtCodigo.Br = System.Drawing.Color.MidnightBlue;
            txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigo.ForeColor = System.Drawing.Color.White;
            txtCodigo.Location = new System.Drawing.Point(63, 41);
            txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(167, 39);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(3, 48);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(61, 20);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Codigo:";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            dgvProductos.Location = new System.Drawing.Point(6, 117);
            dgvProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new System.Drawing.Size(1074, 244);
            dgvProductos.TabIndex = 17;
            dgvProductos.DataSourceChanged += dgvProductos_DataSourceChanged;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.DataError += dgvProductos_DataError;
            // 
            // btnGenerarPedido
            // 
            btnGenerarPedido.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            btnGenerarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerarPedido.FlatAppearance.BorderSize = 0;
            btnGenerarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerarPedido.ForeColor = System.Drawing.Color.White;
            btnGenerarPedido.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            btnGenerarPedido.IconColor = System.Drawing.Color.White;
            btnGenerarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarPedido.IconSize = 35;
            btnGenerarPedido.Location = new System.Drawing.Point(8, 367);
            btnGenerarPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGenerarPedido.Name = "btnGenerarPedido";
            btnGenerarPedido.Size = new System.Drawing.Size(117, 56);
            btnGenerarPedido.TabIndex = 9;
            btnGenerarPedido.Text = "Generar Pedido";
            btnGenerarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnGenerarPedido.UseVisualStyleBackColor = false;
            btnGenerarPedido.Click += btnGenerarPedido_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = System.Drawing.Color.Transparent;
            txtSubtotal.Br = System.Drawing.Color.MidnightBlue;
            txtSubtotal.Enabled = false;
            txtSubtotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSubtotal.ForeColor = System.Drawing.Color.White;
            txtSubtotal.Location = new System.Drawing.Point(299, 367);
            txtSubtotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(139, 39);
            txtSubtotal.TabIndex = 19;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.ForeColor = System.Drawing.Color.White;
            lblSubTotal.Location = new System.Drawing.Point(231, 375);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new System.Drawing.Size(68, 20);
            lblSubTotal.TabIndex = 18;
            lblSubTotal.Text = "Subtotal:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.Color.Transparent;
            txtTotal.Br = System.Drawing.Color.MidnightBlue;
            txtTotal.Enabled = false;
            txtTotal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTotal.ForeColor = System.Drawing.Color.White;
            txtTotal.Location = new System.Drawing.Point(504, 367);
            txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(139, 39);
            txtTotal.TabIndex = 21;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = System.Drawing.Color.White;
            lblTotal.Location = new System.Drawing.Point(454, 375);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(45, 20);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Total:";
            // 
            // tbEsPedido
            // 
            tbEsPedido.Checked = true;
            tbEsPedido.CheckState = System.Windows.Forms.CheckState.Checked;
            tbEsPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            tbEsPedido.Location = new System.Drawing.Point(246, 40);
            tbEsPedido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbEsPedido.MinimumSize = new System.Drawing.Size(51, 29);
            tbEsPedido.Name = "tbEsPedido";
            tbEsPedido.OffBackColor = System.Drawing.Color.Gray;
            tbEsPedido.OffToggleColor = System.Drawing.Color.Gainsboro;
            tbEsPedido.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tbEsPedido.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tbEsPedido.Size = new System.Drawing.Size(63, 29);
            tbEsPedido.TabIndex = 87;
            tbEsPedido.Text = "toggleButton1";
            tbEsPedido.UseVisualStyleBackColor = true;
            tbEsPedido.CheckedChanged += tbMantenerFiltro_CheckedChanged;
            // 
            // lblSi
            // 
            lblSi.AutoSize = true;
            lblSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSi.ForeColor = System.Drawing.Color.White;
            lblSi.Location = new System.Drawing.Point(307, 41);
            lblSi.Name = "lblSi";
            lblSi.Size = new System.Drawing.Size(28, 28);
            lblSi.TabIndex = 89;
            lblSi.Text = "Si";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNo.ForeColor = System.Drawing.Color.White;
            lblNo.Location = new System.Drawing.Point(214, 40);
            lblNo.Name = "lblNo";
            lblNo.Size = new System.Drawing.Size(39, 28);
            lblNo.TabIndex = 88;
            lblNo.Text = "No";
            // 
            // lblEsPedido
            // 
            lblEsPedido.AutoSize = true;
            lblEsPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEsPedido.ForeColor = System.Drawing.Color.White;
            lblEsPedido.Location = new System.Drawing.Point(229, 9);
            lblEsPedido.Name = "lblEsPedido";
            lblEsPedido.Size = new System.Drawing.Size(102, 25);
            lblEsPedido.TabIndex = 86;
            lblEsPedido.Text = "Es Pedido?";
            // 
            // panelProductoDetalle
            // 
            panelProductoDetalle.Controls.Add(dgvProductos);
            panelProductoDetalle.Controls.Add(btnGenerarPedido);
            panelProductoDetalle.Controls.Add(lblSubTotal);
            panelProductoDetalle.Controls.Add(panelProductos);
            panelProductoDetalle.Controls.Add(txtTotal);
            panelProductoDetalle.Controls.Add(txtSubtotal);
            panelProductoDetalle.Controls.Add(lblTotal);
            panelProductoDetalle.Location = new System.Drawing.Point(14, 280);
            panelProductoDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelProductoDetalle.Name = "panelProductoDetalle";
            panelProductoDetalle.Size = new System.Drawing.Size(1142, 432);
            panelProductoDetalle.TabIndex = 90;
            // 
            // timerSubir
            // 
            timerSubir.Interval = 10;
            timerSubir.Tick += timerSubir_Tick;
            // 
            // timerBajar
            // 
            timerBajar.Interval = 10;
            timerBajar.Tick += timerBajar_Tick;
            // 
            // FmCrearPedido
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(1169, 775);
            Controls.Add(tbEsPedido);
            Controls.Add(lblSi);
            Controls.Add(lblNo);
            Controls.Add(lblEsPedido);
            Controls.Add(panelClientes);
            Controls.Add(panelProductoDetalle);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FmCrearPedido";
            Text = "FmCrearPedido";
            FormClosing += FmCrearPedido_FormClosing;
            Load += FmCrearPedido_Load;
            panelClientes.ResumeLayout(false);
            panelClientes.PerformLayout();
            panelProductos.ResumeLayout(false);
            panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panelProductoDetalle.ResumeLayout(false);
            panelProductoDetalle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoTextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private AltoControls.AltoTextBox txtApellido;
        private AltoControls.AltoTextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private AltoControls.AltoTextBox txtResidencia;
        private AltoControls.AltoTextBox txtTelefono;
        private AltoControls.AltoTextBox txtMail;
        private System.Windows.Forms.Panel panelProductos;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private AltoControls.AltoTextBox txtCantidad;
        private AltoControls.AltoTextBox txtDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private AltoControls.AltoTextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDatoProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private FontAwesome.Sharp.IconButton btnGenerarPedido;
        private AltoControls.AltoTextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubTotal;
        private AltoControls.AltoTextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolTip toolTipError;
        private Tools.FormsTools.ToggleButton tbEsPedido;
        private System.Windows.Forms.Label lblSi;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblEsPedido;
        private System.Windows.Forms.Panel panelProductoDetalle;
        private System.Windows.Forms.Timer timerSubir;
        private System.Windows.Forms.Timer timerBajar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private AltoControls.AltoTextBox txtSeña;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblExtras;
        private Tools.FormsTools.FmCombobox fmCboxTransfer;
        private System.Windows.Forms.Label lblTransfer;
        private AltoControls.AltoTextBox txtColor;
        private System.Windows.Forms.Label label9;
    }
}