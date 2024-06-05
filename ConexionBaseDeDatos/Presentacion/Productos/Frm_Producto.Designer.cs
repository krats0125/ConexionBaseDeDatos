namespace ConexionBaseDeDatos
{
    partial class Frm_Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tap = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscado = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBuscado2 = new System.Windows.Forms.TextBox();
            this.btnBuscarCarne = new System.Windows.Forms.Button();
            this.dvgProductosCarniceria = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBuscado3 = new System.Windows.Forms.TextBox();
            this.btnBuscarPromocion = new System.Windows.Forms.Button();
            this.dvgProductosPromocion = new System.Windows.Forms.DataGridView();
            this.Tap.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosCarniceria)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // Tap
            // 
            this.Tap.AccessibleName = "";
            this.Tap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tap.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tap.Controls.Add(this.tabPage1);
            this.Tap.Controls.Add(this.tabPage2);
            this.Tap.Controls.Add(this.tabPage3);
            this.Tap.Location = new System.Drawing.Point(0, 0);
            this.Tap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tap.Name = "Tap";
            this.Tap.SelectedIndex = 0;
            this.Tap.Size = new System.Drawing.Size(884, 450);
            this.Tap.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Tap.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscado);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Controls.Add(this.dgv_Productos);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(876, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscado
            // 
            this.txtBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtBuscado.Location = new System.Drawing.Point(8, 21);
            this.txtBuscado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscado.Name = "txtBuscado";
            this.txtBuscado.Size = new System.Drawing.Size(335, 28);
            this.txtBuscado.TabIndex = 0;
            this.txtBuscado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscado_KeyDown);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(348, 21);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(143, 28);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.AllowUserToAddRows = false;
            this.dgv_Productos.AllowUserToDeleteRows = false;
            this.dgv_Productos.AllowUserToResizeColumns = false;
            this.dgv_Productos.AllowUserToResizeRows = false;
            this.dgv_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Productos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Productos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Productos.Location = new System.Drawing.Point(8, 55);
            this.dgv_Productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Productos.MultiSelect = false;
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.ReadOnly = true;
            this.dgv_Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Productos.RowHeadersWidth = 51;
            this.dgv_Productos.RowTemplate.Height = 24;
            this.dgv_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Productos.Size = new System.Drawing.Size(853, 355);
            this.dgv_Productos.TabIndex = 3;
            this.dgv_Productos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Productos_KeyDown_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBuscado2);
            this.tabPage2.Controls.Add(this.btnBuscarCarne);
            this.tabPage2.Controls.Add(this.dvgProductosCarniceria);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(876, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "";
            this.tabPage2.Text = "Carnes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBuscado2
            // 
            this.txtBuscado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtBuscado2.Location = new System.Drawing.Point(11, 18);
            this.txtBuscado2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscado2.Name = "txtBuscado2";
            this.txtBuscado2.Size = new System.Drawing.Size(335, 28);
            this.txtBuscado2.TabIndex = 5;
            this.txtBuscado2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscado2_KeyDown);
            // 
            // btnBuscarCarne
            // 
            this.btnBuscarCarne.Location = new System.Drawing.Point(349, 18);
            this.btnBuscarCarne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCarne.Name = "btnBuscarCarne";
            this.btnBuscarCarne.Size = new System.Drawing.Size(143, 30);
            this.btnBuscarCarne.TabIndex = 6;
            this.btnBuscarCarne.Text = "Buscar";
            this.btnBuscarCarne.UseVisualStyleBackColor = true;
            this.btnBuscarCarne.Click += new System.EventHandler(this.btnBuscarCarne_Click);
            // 
            // dvgProductosCarniceria
            // 
            this.dvgProductosCarniceria.AllowUserToOrderColumns = true;
            this.dvgProductosCarniceria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProductosCarniceria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dvgProductosCarniceria.BackgroundColor = System.Drawing.Color.White;
            this.dvgProductosCarniceria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProductosCarniceria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProductosCarniceria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProductosCarniceria.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProductosCarniceria.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgProductosCarniceria.GridColor = System.Drawing.Color.Maroon;
            this.dvgProductosCarniceria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dvgProductosCarniceria.Location = new System.Drawing.Point(11, 53);
            this.dvgProductosCarniceria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgProductosCarniceria.MultiSelect = false;
            this.dvgProductosCarniceria.Name = "dvgProductosCarniceria";
            this.dvgProductosCarniceria.ReadOnly = true;
            this.dvgProductosCarniceria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dvgProductosCarniceria.RowHeadersWidth = 51;
            this.dvgProductosCarniceria.RowTemplate.Height = 24;
            this.dvgProductosCarniceria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProductosCarniceria.ShowEditingIcon = false;
            this.dvgProductosCarniceria.Size = new System.Drawing.Size(857, 355);
            this.dvgProductosCarniceria.TabIndex = 7;
            this.dvgProductosCarniceria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dvgProductosCarniceria_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBuscado3);
            this.tabPage3.Controls.Add(this.btnBuscarPromocion);
            this.tabPage3.Controls.Add(this.dvgProductosPromocion);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(876, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Promociones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBuscado3
            // 
            this.txtBuscado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtBuscado3.Location = new System.Drawing.Point(9, 17);
            this.txtBuscado3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscado3.Name = "txtBuscado3";
            this.txtBuscado3.Size = new System.Drawing.Size(335, 28);
            this.txtBuscado3.TabIndex = 9;
            // 
            // btnBuscarPromocion
            // 
            this.btnBuscarPromocion.Location = new System.Drawing.Point(348, 17);
            this.btnBuscarPromocion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPromocion.Name = "btnBuscarPromocion";
            this.btnBuscarPromocion.Size = new System.Drawing.Size(143, 30);
            this.btnBuscarPromocion.TabIndex = 10;
            this.btnBuscarPromocion.Text = "Buscar";
            this.btnBuscarPromocion.UseVisualStyleBackColor = true;
            this.btnBuscarPromocion.Click += new System.EventHandler(this.btnBuscarPromocion_Click);
            // 
            // dvgProductosPromocion
            // 
            this.dvgProductosPromocion.AllowUserToOrderColumns = true;
            this.dvgProductosPromocion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProductosPromocion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dvgProductosPromocion.BackgroundColor = System.Drawing.Color.White;
            this.dvgProductosPromocion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProductosPromocion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgProductosPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProductosPromocion.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProductosPromocion.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgProductosPromocion.GridColor = System.Drawing.Color.Maroon;
            this.dvgProductosPromocion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dvgProductosPromocion.Location = new System.Drawing.Point(9, 52);
            this.dvgProductosPromocion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgProductosPromocion.MultiSelect = false;
            this.dvgProductosPromocion.Name = "dvgProductosPromocion";
            this.dvgProductosPromocion.ReadOnly = true;
            this.dvgProductosPromocion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dvgProductosPromocion.RowHeadersWidth = 51;
            this.dvgProductosPromocion.RowTemplate.Height = 24;
            this.dvgProductosPromocion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProductosPromocion.ShowEditingIcon = false;
            this.dvgProductosPromocion.Size = new System.Drawing.Size(857, 355);
            this.dvgProductosPromocion.TabIndex = 8;
            // 
            // Frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.Tap);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Frm_Producto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salirAlPresionarScape);
            this.Tap.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosCarniceria)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductosPromocion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txtBuscado2;
        private System.Windows.Forms.Button btnBuscarCarne;
        private System.Windows.Forms.DataGridView dvgProductosCarniceria;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBuscado3;
        private System.Windows.Forms.Button btnBuscarPromocion;
        private System.Windows.Forms.DataGridView dvgProductosPromocion;
    }
}