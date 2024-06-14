namespace ConexionBaseDeDatos.Presentacion.Clientes
{
    partial class Frm_Clientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdTipoCliente2 = new System.Windows.Forms.RadioButton();
            this.rdTipoCliente1 = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cb_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit_Cedula = new System.Windows.Forms.TextBox();
            this.Label_Apellido = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCumpleaños = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_MenuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_DatosCliente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionBuscada = new System.Windows.Forms.TextBox();
            this.btnBuscarDireccion = new System.Windows.Forms.Button();
            this.btnDireccion2 = new System.Windows.Forms.Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtTelefono4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.lb_Idcliente = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosCliente)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(171, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 28);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tipo Persona";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(64, 432);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "Direccion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(92, 512);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 30);
            this.label6.TabIndex = 36;
            this.label6.Text = "Correo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdTipoCliente2
            // 
            this.rdTipoCliente2.AutoSize = true;
            this.rdTipoCliente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdTipoCliente2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdTipoCliente2.Location = new System.Drawing.Point(188, 117);
            this.rdTipoCliente2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTipoCliente2.Name = "rdTipoCliente2";
            this.rdTipoCliente2.Size = new System.Drawing.Size(96, 28);
            this.rdTipoCliente2.TabIndex = 35;
            this.rdTipoCliente2.TabStop = true;
            this.rdTipoCliente2.Text = "Juridica";
            this.rdTipoCliente2.UseVisualStyleBackColor = true;
            // 
            // rdTipoCliente1
            // 
            this.rdTipoCliente1.AutoSize = true;
            this.rdTipoCliente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rdTipoCliente1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdTipoCliente1.Location = new System.Drawing.Point(188, 82);
            this.rdTipoCliente1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTipoCliente1.Name = "rdTipoCliente1";
            this.rdTipoCliente1.Size = new System.Drawing.Size(90, 28);
            this.rdTipoCliente1.TabIndex = 34;
            this.rdTipoCliente1.TabStop = true;
            this.rdTipoCliente1.Text = "Natural";
            this.rdTipoCliente1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpiar.Location = new System.Drawing.Point(309, 620);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 46);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardar.Location = new System.Drawing.Point(21, 620);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 46);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Crear";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cb_TipoDocumento
            // 
            this.cb_TipoDocumento.FormattingEnabled = true;
            this.cb_TipoDocumento.Location = new System.Drawing.Point(21, 116);
            this.cb_TipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_TipoDocumento.Name = "cb_TipoDocumento";
            this.cb_TipoDocumento.Size = new System.Drawing.Size(140, 24);
            this.cb_TipoDocumento.TabIndex = 2;
            this.cb_TipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cb_TipoDocumento_SelectedIndexChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(20, 545);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(256, 22);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 465);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(256, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(155, 241);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(123, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(16, 241);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 22);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 181);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtNit_Cedula
            // 
            this.txtNit_Cedula.Location = new System.Drawing.Point(21, 55);
            this.txtNit_Cedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNit_Cedula.Name = "txtNit_Cedula";
            this.txtNit_Cedula.Size = new System.Drawing.Size(140, 22);
            this.txtNit_Cedula.TabIndex = 1;
            // 
            // Label_Apellido
            // 
            this.Label_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Label_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_Apellido.Location = new System.Drawing.Point(153, 209);
            this.Label_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Apellido.Name = "Label_Apellido";
            this.Label_Apellido.Size = new System.Drawing.Size(124, 28);
            this.Label_Apellido.TabIndex = 24;
            this.Label_Apellido.Text = "Apellido";
            this.Label_Apellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Label_Telefono.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_Telefono.Location = new System.Drawing.Point(16, 209);
            this.Label_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(128, 28);
            this.Label_Telefono.TabIndex = 23;
            this.Label_Telefono.Text = "Telefono";
            this.Label_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_Nombre.Location = new System.Drawing.Point(20, 149);
            this.Label_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(257, 28);
            this.Label_Nombre.TabIndex = 22;
            this.Label_Nombre.Text = "Nombre";
            this.Label_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo Documento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nit ó Cedula";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCumpleaños
            // 
            this.txtCumpleaños.Location = new System.Drawing.Point(155, 375);
            this.txtCumpleaños.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCumpleaños.Name = "txtCumpleaños";
            this.txtCumpleaños.Size = new System.Drawing.Size(123, 22);
            this.txtCumpleaños.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(152, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cumpleaños";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefono3
            // 
            this.txtTelefono3.Location = new System.Drawing.Point(152, 302);
            this.txtTelefono3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono3.Name = "txtTelefono3";
            this.txtTelefono3.Size = new System.Drawing.Size(127, 22);
            this.txtTelefono3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(151, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Telefono";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(16, 302);
            this.txtTelefono2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(128, 22);
            this.txtTelefono2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Telefono";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_MenuConsulta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 28);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_MenuConsulta
            // 
            this.btn_MenuConsulta.Name = "btn_MenuConsulta";
            this.btn_MenuConsulta.Size = new System.Drawing.Size(80, 24);
            this.btn_MenuConsulta.Text = "Consulta";
            this.btn_MenuConsulta.Click += new System.EventHandler(this.btn_MenuConsulta_Click_1);
            // 
            // dgv_DatosCliente
            // 
            this.dgv_DatosCliente.AllowUserToAddRows = false;
            this.dgv_DatosCliente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_DatosCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DatosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DatosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_DatosCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DatosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DatosCliente.ColumnHeadersHeight = 21;
            this.dgv_DatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DatosCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DatosCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DatosCliente.Location = new System.Drawing.Point(16, 198);
            this.dgv_DatosCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DatosCliente.Name = "dgv_DatosCliente";
            this.dgv_DatosCliente.RowHeadersVisible = false;
            this.dgv_DatosCliente.RowHeadersWidth = 21;
            this.dgv_DatosCliente.Size = new System.Drawing.Size(491, 274);
            this.dgv_DatosCliente.TabIndex = 15;
            this.dgv_DatosCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DatosCliente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DatosCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DatosCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DatosCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DatosCliente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DatosCliente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DatosCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DatosCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_DatosCliente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DatosCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DatosCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DatosCliente.ThemeStyle.HeaderStyle.Height = 21;
            this.dgv_DatosCliente.ThemeStyle.ReadOnly = false;
            this.dgv_DatosCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DatosCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DatosCliente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_DatosCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DatosCliente.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_DatosCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DatosCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DatosCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DatosCliente_CellContentClick);
            // 
            // btnDireccion
            // 
            this.btnDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDireccion.Location = new System.Drawing.Point(185, 436);
            this.btnDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(55, 27);
            this.btnDireccion.TabIndex = 47;
            this.btnDireccion.Text = "dir";
            this.btnDireccion.UseVisualStyleBackColor = true;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(81, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 28);
            this.label9.TabIndex = 48;
            this.label9.Text = "Buscar Dato";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccionBuscada
            // 
            this.txtDireccionBuscada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionBuscada.Location = new System.Drawing.Point(85, 92);
            this.txtDireccionBuscada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionBuscada.Name = "txtDireccionBuscada";
            this.txtDireccionBuscada.Size = new System.Drawing.Size(360, 22);
            this.txtDireccionBuscada.TabIndex = 49;
            // 
            // btnBuscarDireccion
            // 
            this.btnBuscarDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarDireccion.Location = new System.Drawing.Point(192, 124);
            this.btnBuscarDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarDireccion.Name = "btnBuscarDireccion";
            this.btnBuscarDireccion.Size = new System.Drawing.Size(136, 46);
            this.btnBuscarDireccion.TabIndex = 14;
            this.btnBuscarDireccion.Text = "Buscar";
            this.btnBuscarDireccion.UseVisualStyleBackColor = true;
            this.btnBuscarDireccion.Click += new System.EventHandler(this.btnBuscarDireccion_Click);
            // 
            // btnDireccion2
            // 
            this.btnDireccion2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDireccion2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDireccion2.Location = new System.Drawing.Point(347, 58);
            this.btnDireccion2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDireccion2.Name = "btnDireccion2";
            this.btnDireccion2.Size = new System.Drawing.Size(55, 27);
            this.btnDireccion2.TabIndex = 13;
            this.btnDireccion2.Text = "dir";
            this.btnDireccion2.UseVisualStyleBackColor = true;
            this.btnDireccion2.Click += new System.EventHandler(this.btnDireccion2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2Panel1.Controls.Add(this.btnDireccion2);
            this.guna2Panel1.Controls.Add(this.btnBuscarDireccion);
            this.guna2Panel1.Controls.Add(this.dgv_DatosCliente);
            this.guna2Panel1.Controls.Add(this.txtDireccionBuscada);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Location = new System.Drawing.Point(320, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(528, 494);
            this.guna2Panel1.TabIndex = 54;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.guna2Panel1;
            // 
            // txtTelefono4
            // 
            this.txtTelefono4.Location = new System.Drawing.Point(19, 375);
            this.txtTelefono4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono4.Name = "txtTelefono4";
            this.txtTelefono4.Size = new System.Drawing.Size(125, 22);
            this.txtTelefono4.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(17, 343);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 55;
            this.label10.Text = "Telefono";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Actualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Actualizar.Location = new System.Drawing.Point(165, 620);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(136, 46);
            this.btn_Actualizar.TabIndex = 57;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // lb_Idcliente
            // 
            this.lb_Idcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Idcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lb_Idcliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_Idcliente.Location = new System.Drawing.Point(316, 497);
            this.lb_Idcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Idcliente.Name = "lb_Idcliente";
            this.lb_Idcliente.Size = new System.Drawing.Size(157, 28);
            this.lb_Idcliente.TabIndex = 58;
            this.lb_Idcliente.Text = "IdCliente";
            this.lb_Idcliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.lb_Idcliente);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.txtTelefono4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCumpleaños);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdTipoCliente2);
            this.Controls.Add(this.rdTipoCliente1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cb_TipoDocumento);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNit_Cedula);
            this.Controls.Add(this.Label_Apellido);
            this.Controls.Add(this.Label_Telefono);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Clientes";
            this.Text = "Formulario Cliente";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DatosCliente)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdTipoCliente2;
        private System.Windows.Forms.RadioButton rdTipoCliente1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cb_TipoDocumento;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit_Cedula;
        private System.Windows.Forms.Label Label_Apellido;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCumpleaños;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_MenuConsulta;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_DatosCliente;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionBuscada;
        private System.Windows.Forms.Button btnBuscarDireccion;
        private System.Windows.Forms.Button btnDireccion2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox txtTelefono4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label lb_Idcliente;
    }
}