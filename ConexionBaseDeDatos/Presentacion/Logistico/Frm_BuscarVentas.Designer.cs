namespace ConexionBaseDeDatos.Presentacion.Logistico
{
    partial class Frm_BuscarVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Buscar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvReporteCompras = new Guna.UI2.WinForms.Guna2DataGridView();
            this.OptIdCliente = new Guna.UI2.WinForms.Guna2RadioButton();
            this.OptCajero = new Guna.UI2.WinForms.Guna2RadioButton();
            this.OptAsesor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.OptFecha = new Guna.UI2.WinForms.Guna2RadioButton();
            this.OptValor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.OptCaja = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderRadius = 10;
            this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCliente.DefaultText = "";
            this.txtIdCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCliente.Location = new System.Drawing.Point(140, 26);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.PasswordChar = '\0';
            this.txtIdCliente.PlaceholderText = "";
            this.txtIdCliente.SelectedText = "";
            this.txtIdCliente.Size = new System.Drawing.Size(200, 36);
            this.txtIdCliente.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BorderRadius = 10;
            this.btn_Buscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Buscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Buscar.FillColor = System.Drawing.Color.Teal;
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(436, 26);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(180, 35);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgvReporteCompras
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReporteCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteCompras.ColumnHeadersHeight = 4;
            this.dgvReporteCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteCompras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReporteCompras.Location = new System.Drawing.Point(22, 87);
            this.dgvReporteCompras.Name = "dgvReporteCompras";
            this.dgvReporteCompras.RowHeadersVisible = false;
            this.dgvReporteCompras.Size = new System.Drawing.Size(594, 430);
            this.dgvReporteCompras.TabIndex = 3;
            this.dgvReporteCompras.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReporteCompras.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReporteCompras.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReporteCompras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReporteCompras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReporteCompras.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReporteCompras.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReporteCompras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReporteCompras.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReporteCompras.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteCompras.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteCompras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReporteCompras.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvReporteCompras.ThemeStyle.ReadOnly = false;
            this.dgvReporteCompras.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReporteCompras.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteCompras.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteCompras.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReporteCompras.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReporteCompras.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReporteCompras.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // OptIdCliente
            // 
            this.OptIdCliente.AutoSize = true;
            this.OptIdCliente.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.OptIdCliente.CheckedState.BorderThickness = 0;
            this.OptIdCliente.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.OptIdCliente.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OptIdCliente.CheckedState.InnerOffset = -4;
            this.OptIdCliente.Location = new System.Drawing.Point(26, 540);
            this.OptIdCliente.Name = "OptIdCliente";
            this.OptIdCliente.Size = new System.Drawing.Size(69, 17);
            this.OptIdCliente.TabIndex = 4;
            this.OptIdCliente.Text = "Id Cliente";
            this.OptIdCliente.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OptIdCliente.UncheckedState.BorderThickness = 2;
            this.OptIdCliente.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.OptIdCliente.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // OptCajero
            // 
            this.OptCajero.AutoSize = true;
            this.OptCajero.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.OptCajero.CheckedState.BorderThickness = 0;
            this.OptCajero.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.OptCajero.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OptCajero.CheckedState.InnerOffset = -4;
            this.OptCajero.Location = new System.Drawing.Point(26, 563);
            this.OptCajero.Name = "OptCajero";
            this.OptCajero.Size = new System.Drawing.Size(55, 17);
            this.OptCajero.TabIndex = 5;
            this.OptCajero.Text = "Cajero";
            this.OptCajero.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OptCajero.UncheckedState.BorderThickness = 2;
            this.OptCajero.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.OptCajero.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.OptCajero.Visible = false;
            // 
            // OptAsesor
            // 
            this.OptAsesor.AutoSize = true;
            this.OptAsesor.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.OptAsesor.CheckedState.BorderThickness = 0;
            this.OptAsesor.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.OptAsesor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OptAsesor.CheckedState.InnerOffset = -4;
            this.OptAsesor.Location = new System.Drawing.Point(127, 540);
            this.OptAsesor.Name = "OptAsesor";
            this.OptAsesor.Size = new System.Drawing.Size(57, 17);
            this.OptAsesor.TabIndex = 6;
            this.OptAsesor.Text = "Asesor";
            this.OptAsesor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OptAsesor.UncheckedState.BorderThickness = 2;
            this.OptAsesor.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.OptAsesor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // OptFecha
            // 
            this.OptFecha.AutoSize = true;
            this.OptFecha.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.OptFecha.CheckedState.BorderThickness = 0;
            this.OptFecha.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.OptFecha.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OptFecha.CheckedState.InnerOffset = -4;
            this.OptFecha.Location = new System.Drawing.Point(127, 563);
            this.OptFecha.Name = "OptFecha";
            this.OptFecha.Size = new System.Drawing.Size(55, 17);
            this.OptFecha.TabIndex = 7;
            this.OptFecha.Text = "Fecha";
            this.OptFecha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OptFecha.UncheckedState.BorderThickness = 2;
            this.OptFecha.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.OptFecha.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // OptValor
            // 
            this.OptValor.AutoSize = true;
            this.OptValor.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.OptValor.CheckedState.BorderThickness = 0;
            this.OptValor.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.OptValor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OptValor.CheckedState.InnerOffset = -4;
            this.OptValor.Location = new System.Drawing.Point(229, 540);
            this.OptValor.Name = "OptValor";
            this.OptValor.Size = new System.Drawing.Size(49, 17);
            this.OptValor.TabIndex = 8;
            this.OptValor.Text = "Valor";
            this.OptValor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OptValor.UncheckedState.BorderThickness = 2;
            this.OptValor.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.OptValor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.OptValor.Visible = false;
            // 
            // OptCaja
            // 
            this.OptCaja.AutoSize = true;
            this.OptCaja.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.OptCaja.CheckedState.BorderThickness = 0;
            this.OptCaja.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.OptCaja.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OptCaja.CheckedState.InnerOffset = -4;
            this.OptCaja.Location = new System.Drawing.Point(229, 563);
            this.OptCaja.Name = "OptCaja";
            this.OptCaja.Size = new System.Drawing.Size(46, 17);
            this.OptCaja.TabIndex = 9;
            this.OptCaja.Text = "Caja";
            this.OptCaja.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OptCaja.UncheckedState.BorderThickness = 2;
            this.OptCaja.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.OptCaja.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Frm_BuscarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 654);
            this.Controls.Add(this.OptCaja);
            this.Controls.Add(this.OptValor);
            this.Controls.Add(this.OptFecha);
            this.Controls.Add(this.OptAsesor);
            this.Controls.Add(this.OptCajero);
            this.Controls.Add(this.OptIdCliente);
            this.Controls.Add(this.dgvReporteCompras);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Name = "Frm_BuscarVentas";
            this.Text = "Formulario Buscador Ventas";
            this.Load += new System.EventHandler(this.Frm_BuscarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCliente;
        private Guna.UI2.WinForms.Guna2Button btn_Buscar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReporteCompras;
        private Guna.UI2.WinForms.Guna2RadioButton OptIdCliente;
        private Guna.UI2.WinForms.Guna2RadioButton OptCajero;
        private Guna.UI2.WinForms.Guna2RadioButton OptAsesor;
        private Guna.UI2.WinForms.Guna2RadioButton OptFecha;
        private Guna.UI2.WinForms.Guna2RadioButton OptValor;
        private Guna.UI2.WinForms.Guna2RadioButton OptCaja;
    }
}