
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
            lblExtras = new System.Windows.Forms.Label();
            txtSeña = new AltoControls.AltoTextBox();
            label8 = new System.Windows.Forms.Label();
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
            label1.Location = new System.Drawing.Point(7, 5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 21);
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
            panelClientes.Location = new System.Drawing.Point(12, 54);
            panelClientes.Name = "panelClientes";
            panelClientes.Size = new System.Drawing.Size(952, 150);
            panelClientes.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(286, 111);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(66, 15);
            label7.TabIndex = 14;
            label7.Text = "Residencia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(287, 77);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 15);
            label6.TabIndex = 13;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(287, 39);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "Mail:";
            // 
            // txtResidencia
            // 
            txtResidencia.BackColor = System.Drawing.Color.Transparent;
            txtResidencia.Br = System.Drawing.Color.MidnightBlue;
            txtResidencia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtResidencia.ForeColor = System.Drawing.Color.White;
            txtResidencia.Location = new System.Drawing.Point(358, 105);
            txtResidencia.Name = "txtResidencia";
            txtResidencia.Size = new System.Drawing.Size(126, 29);
            txtResidencia.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = System.Drawing.Color.Transparent;
            txtTelefono.Br = System.Drawing.Color.MidnightBlue;
            txtTelefono.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTelefono.ForeColor = System.Drawing.Color.White;
            txtTelefono.Location = new System.Drawing.Point(358, 70);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(126, 29);
            txtTelefono.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.BackColor = System.Drawing.Color.Transparent;
            txtMail.Br = System.Drawing.Color.MidnightBlue;
            txtMail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMail.ForeColor = System.Drawing.Color.White;
            txtMail.Location = new System.Drawing.Point(358, 35);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(126, 29);
            txtMail.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = System.Drawing.Color.Transparent;
            txtApellido.Br = System.Drawing.Color.MidnightBlue;
            txtApellido.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtApellido.ForeColor = System.Drawing.Color.White;
            txtApellido.Location = new System.Drawing.Point(92, 107);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(123, 29);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.Color.Transparent;
            txtNombre.Br = System.Drawing.Color.MidnightBlue;
            txtNombre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombre.ForeColor = System.Drawing.Color.White;
            txtNombre.Location = new System.Drawing.Point(92, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(123, 29);
            txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(38, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 15);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(38, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = System.Drawing.Color.Transparent;
            txtDNI.Br = System.Drawing.Color.MidnightBlue;
            txtDNI.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDNI.ForeColor = System.Drawing.Color.White;
            txtDNI.Location = new System.Drawing.Point(93, 35);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new System.Drawing.Size(122, 29);
            txtDNI.TabIndex = 3;
            txtDNI.TextChanged += txtDNI_TextChanged;
            txtDNI.Click += txtDNI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(49, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "DNI:";
            // 
            // panelProductos
            // 
            panelProductos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelProductos.Controls.Add(btnCancelar);
            panelProductos.Controls.Add(btnAgregarProducto);
            panelProductos.Controls.Add(lblDatoProducto);
            panelProductos.Controls.Add(txtCantidad);
            panelProductos.Controls.Add(txtDescripcion);
            panelProductos.Controls.Add(lblCantidad);
            panelProductos.Controls.Add(lblDescripcion);
            panelProductos.Controls.Add(txtCodigo);
            panelProductos.Controls.Add(lblCodigo);
            panelProductos.Location = new System.Drawing.Point(5, 6);
            panelProductos.Name = "panelProductos";
            panelProductos.Size = new System.Drawing.Size(940, 77);
            panelProductos.TabIndex = 15;
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
            btnCancelar.Location = new System.Drawing.Point(782, 20);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(102, 47);
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
            btnAgregarProducto.Location = new System.Drawing.Point(674, 19);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new System.Drawing.Size(102, 47);
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
            lblDatoProducto.Location = new System.Drawing.Point(3, 7);
            lblDatoProducto.Name = "lblDatoProducto";
            lblDatoProducto.Size = new System.Drawing.Size(158, 21);
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
            txtCantidad.Location = new System.Drawing.Point(607, 31);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(61, 29);
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
            txtDescripcion.Location = new System.Drawing.Point(281, 31);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(256, 29);
            txtDescripcion.TabIndex = 6;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = System.Drawing.Color.White;
            lblCantidad.Location = new System.Drawing.Point(543, 36);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(58, 15);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = System.Drawing.Color.White;
            lblDescripcion.Location = new System.Drawing.Point(207, 36);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(72, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = System.Drawing.Color.Transparent;
            txtCodigo.Br = System.Drawing.Color.MidnightBlue;
            txtCodigo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCodigo.ForeColor = System.Drawing.Color.White;
            txtCodigo.Location = new System.Drawing.Point(55, 31);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(146, 29);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.ForeColor = System.Drawing.Color.White;
            lblCodigo.Location = new System.Drawing.Point(3, 36);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(49, 15);
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
            dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = System.Drawing.Color.FromArgb(0, 80, 200);
            dgvProductos.Location = new System.Drawing.Point(5, 88);
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 32, 40);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(49, 66, 82);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new System.Drawing.Size(940, 183);
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
            btnGenerarPedido.Location = new System.Drawing.Point(7, 275);
            btnGenerarPedido.Name = "btnGenerarPedido";
            btnGenerarPedido.Size = new System.Drawing.Size(102, 42);
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
            txtSubtotal.Location = new System.Drawing.Point(262, 275);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(122, 29);
            txtSubtotal.TabIndex = 19;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.ForeColor = System.Drawing.Color.White;
            lblSubTotal.Location = new System.Drawing.Point(202, 281);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new System.Drawing.Size(54, 15);
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
            txtTotal.Location = new System.Drawing.Point(441, 275);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new System.Drawing.Size(122, 29);
            txtTotal.TabIndex = 21;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = System.Drawing.Color.White;
            lblTotal.Location = new System.Drawing.Point(397, 281);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(35, 15);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Total:";
            // 
            // tbEsPedido
            // 
            tbEsPedido.Checked = true;
            tbEsPedido.CheckState = System.Windows.Forms.CheckState.Checked;
            tbEsPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            tbEsPedido.Location = new System.Drawing.Point(215, 30);
            tbEsPedido.MinimumSize = new System.Drawing.Size(45, 22);
            tbEsPedido.Name = "tbEsPedido";
            tbEsPedido.OffBackColor = System.Drawing.Color.Gray;
            tbEsPedido.OffToggleColor = System.Drawing.Color.Gainsboro;
            tbEsPedido.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            tbEsPedido.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            tbEsPedido.Size = new System.Drawing.Size(55, 22);
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
            lblSi.Location = new System.Drawing.Point(269, 31);
            lblSi.Name = "lblSi";
            lblSi.Size = new System.Drawing.Size(23, 21);
            lblSi.TabIndex = 89;
            lblSi.Text = "Si";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNo.ForeColor = System.Drawing.Color.White;
            lblNo.Location = new System.Drawing.Point(187, 30);
            lblNo.Name = "lblNo";
            lblNo.Size = new System.Drawing.Size(31, 21);
            lblNo.TabIndex = 88;
            lblNo.Text = "No";
            // 
            // lblEsPedido
            // 
            lblEsPedido.AutoSize = true;
            lblEsPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEsPedido.ForeColor = System.Drawing.Color.White;
            lblEsPedido.Location = new System.Drawing.Point(200, 7);
            lblEsPedido.Name = "lblEsPedido";
            lblEsPedido.Size = new System.Drawing.Size(80, 20);
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
            panelProductoDetalle.Location = new System.Drawing.Point(12, 210);
            panelProductoDetalle.Name = "panelProductoDetalle";
            panelProductoDetalle.Size = new System.Drawing.Size(952, 324);
            panelProductoDetalle.TabIndex = 90;
            // 
            // timerSubir
            // 
            timerSubir.Interval = 1;
            timerSubir.Tick += timerSubir_Tick;
            // 
            // timerBajar
            // 
            timerBajar.Interval = 1;
            timerBajar.Tick += timerBajar_Tick;
            // 
            // lblExtras
            // 
            lblExtras.AutoSize = true;
            lblExtras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblExtras.ForeColor = System.Drawing.Color.White;
            lblExtras.Location = new System.Drawing.Point(592, 5);
            lblExtras.Name = "lblExtras";
            lblExtras.Size = new System.Drawing.Size(56, 21);
            lblExtras.TabIndex = 15;
            lblExtras.Text = "Extras";
            // 
            // txtSeña
            // 
            txtSeña.BackColor = System.Drawing.Color.Transparent;
            txtSeña.Br = System.Drawing.Color.MidnightBlue;
            txtSeña.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSeña.ForeColor = System.Drawing.Color.White;
            txtSeña.Location = new System.Drawing.Point(592, 35);
            txtSeña.Name = "txtSeña";
            txtSeña.Size = new System.Drawing.Size(122, 29);
            txtSeña.TabIndex = 17;
            txtSeña.TextChanged += txtSeña_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(548, 41);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(35, 15);
            label8.TabIndex = 16;
            label8.Text = "Seña:";
            // 
            // FmCrearPedido
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
            ClientSize = new System.Drawing.Size(976, 581);
            Controls.Add(tbEsPedido);
            Controls.Add(lblSi);
            Controls.Add(lblNo);
            Controls.Add(lblEsPedido);
            Controls.Add(panelClientes);
            Controls.Add(panelProductoDetalle);
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
    }
}