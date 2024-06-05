namespace Tomapedidos.Presentacion.Sistema
{
    partial class Frm_FormatoDireccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Dir = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_Direccion_Completa = new System.Windows.Forms.Label();
            this.cb_unidades = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_letra_1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_torres = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_numero_1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero_2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_letra_2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numero_3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Interior = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_apartamento = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Opt1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Opt2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.PanelUnidad = new System.Windows.Forms.Panel();
            this.PanelCasa = new System.Windows.Forms.Panel();
            this.PanelDireccion = new System.Windows.Forms.Panel();
            this.btnAceptar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelUnidad.SuspendLayout();
            this.PanelCasa.SuspendLayout();
            this.PanelDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calle - Carrera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Dir
            // 
            this.cb_Dir.BackColor = System.Drawing.Color.Transparent;
            this.cb_Dir.BorderRadius = 10;
            this.cb_Dir.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Dir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Dir.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Dir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Dir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_Dir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Dir.ItemHeight = 30;
            this.cb_Dir.Items.AddRange(new object[] {
            "Calle",
            "Carrera",
            "Circular",
            "Diagonal",
            "Transversal"});
            this.cb_Dir.Location = new System.Drawing.Point(3, 35);
            this.cb_Dir.Name = "cb_Dir";
            this.cb_Dir.Size = new System.Drawing.Size(134, 36);
            this.cb_Dir.TabIndex = 1;
            this.cb_Dir.SelectedIndexChanged += new System.EventHandler(this.cb_Dir_SelectedIndexChanged);
            // 
            // lb_Direccion_Completa
            // 
            this.lb_Direccion_Completa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Direccion_Completa.Location = new System.Drawing.Point(247, 8);
            this.lb_Direccion_Completa.Name = "lb_Direccion_Completa";
            this.lb_Direccion_Completa.Size = new System.Drawing.Size(375, 31);
            this.lb_Direccion_Completa.TabIndex = 2;
            this.lb_Direccion_Completa.Text = "label2";
            this.lb_Direccion_Completa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_unidades
            // 
            this.cb_unidades.BackColor = System.Drawing.Color.Transparent;
            this.cb_unidades.BorderRadius = 10;
            this.cb_unidades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_unidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_unidades.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_unidades.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_unidades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_unidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_unidades.ItemHeight = 30;
            this.cb_unidades.Location = new System.Drawing.Point(12, 35);
            this.cb_unidades.Name = "cb_unidades";
            this.cb_unidades.Size = new System.Drawing.Size(257, 36);
            this.cb_unidades.TabIndex = 4;
            this.cb_unidades.SelectedIndexChanged += new System.EventHandler(this.cb_unidades_SelectedIndexChanged);
            // 
            // cb_letra_1
            // 
            this.cb_letra_1.BackColor = System.Drawing.Color.Transparent;
            this.cb_letra_1.BorderRadius = 10;
            this.cb_letra_1.BorderThickness = 0;
            this.cb_letra_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_letra_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_letra_1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_letra_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_letra_1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_letra_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_letra_1.ItemHeight = 30;
            this.cb_letra_1.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "AA"});
            this.cb_letra_1.Location = new System.Drawing.Point(196, 35);
            this.cb_letra_1.Name = "cb_letra_1";
            this.cb_letra_1.Size = new System.Drawing.Size(78, 36);
            this.cb_letra_1.TabIndex = 5;
            this.cb_letra_1.SelectedIndexChanged += new System.EventHandler(this.cb_letra_1_SelectedIndexChanged);
            // 
            // cb_torres
            // 
            this.cb_torres.BackColor = System.Drawing.Color.Transparent;
            this.cb_torres.BorderRadius = 10;
            this.cb_torres.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_torres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_torres.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_torres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_torres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_torres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_torres.ItemHeight = 30;
            this.cb_torres.Items.AddRange(new object[] {
            "",
            "T1",
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            "T7",
            "T8",
            "T9",
            "T10",
            "T11",
            "T12"});
            this.cb_torres.Location = new System.Drawing.Point(278, 35);
            this.cb_torres.Name = "cb_torres";
            this.cb_torres.Size = new System.Drawing.Size(80, 36);
            this.cb_torres.TabIndex = 6;
            this.cb_torres.SelectedIndexChanged += new System.EventHandler(this.cb_torres_SelectedIndexChanged);
            // 
            // txt_numero_1
            // 
            this.txt_numero_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numero_1.DefaultText = "";
            this.txt_numero_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_numero_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_numero_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numero_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numero_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numero_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_numero_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numero_1.Location = new System.Drawing.Point(143, 35);
            this.txt_numero_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_numero_1.Name = "txt_numero_1";
            this.txt_numero_1.PasswordChar = '\0';
            this.txt_numero_1.PlaceholderText = "";
            this.txt_numero_1.SelectedText = "";
            this.txt_numero_1.Size = new System.Drawing.Size(47, 36);
            this.txt_numero_1.TabIndex = 9;
            this.txt_numero_1.TextChanged += new System.EventHandler(this.txt_numero_1_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "#";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_numero_2
            // 
            this.txt_numero_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numero_2.DefaultText = "";
            this.txt_numero_2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_numero_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_numero_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numero_2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numero_2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numero_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_numero_2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numero_2.Location = new System.Drawing.Point(322, 35);
            this.txt_numero_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_numero_2.Name = "txt_numero_2";
            this.txt_numero_2.PasswordChar = '\0';
            this.txt_numero_2.PlaceholderText = "";
            this.txt_numero_2.SelectedText = "";
            this.txt_numero_2.Size = new System.Drawing.Size(45, 36);
            this.txt_numero_2.TabIndex = 11;
            this.txt_numero_2.TextChanged += new System.EventHandler(this.txt_numero_2_TextChanged);
            // 
            // cb_letra_2
            // 
            this.cb_letra_2.BackColor = System.Drawing.Color.Transparent;
            this.cb_letra_2.BorderRadius = 10;
            this.cb_letra_2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_letra_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_letra_2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_letra_2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_letra_2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_letra_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_letra_2.ItemHeight = 30;
            this.cb_letra_2.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "AA"});
            this.cb_letra_2.Location = new System.Drawing.Point(373, 35);
            this.cb_letra_2.Name = "cb_letra_2";
            this.cb_letra_2.Size = new System.Drawing.Size(78, 36);
            this.cb_letra_2.TabIndex = 12;
            this.cb_letra_2.SelectedIndexChanged += new System.EventHandler(this.cb_letra_2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_numero_3
            // 
            this.txt_numero_3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numero_3.DefaultText = "";
            this.txt_numero_3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_numero_3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_numero_3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numero_3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_numero_3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numero_3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_numero_3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_numero_3.Location = new System.Drawing.Point(507, 35);
            this.txt_numero_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_numero_3.Name = "txt_numero_3";
            this.txt_numero_3.PasswordChar = '\0';
            this.txt_numero_3.PlaceholderText = "";
            this.txt_numero_3.SelectedText = "";
            this.txt_numero_3.Size = new System.Drawing.Size(68, 36);
            this.txt_numero_3.TabIndex = 14;
            this.txt_numero_3.TextChanged += new System.EventHandler(this.txt_numero_3_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(143, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "1-100";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(196, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "A-Z";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(322, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "1-100";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(373, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "A-Z";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(507, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "1-100";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(612, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "Interior";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Interior
            // 
            this.txt_Interior.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Interior.DefaultText = "";
            this.txt_Interior.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Interior.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Interior.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Interior.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Interior.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Interior.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Interior.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Interior.Location = new System.Drawing.Point(704, 35);
            this.txt_Interior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Interior.Name = "txt_Interior";
            this.txt_Interior.PasswordChar = '\0';
            this.txt_Interior.PlaceholderText = "";
            this.txt_Interior.SelectedText = "";
            this.txt_Interior.Size = new System.Drawing.Size(68, 36);
            this.txt_Interior.TabIndex = 21;
            this.txt_Interior.TextChanged += new System.EventHandler(this.txt_Interior_TextChanged);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 31);
            this.label12.TabIndex = 23;
            this.label12.Text = "APT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_apartamento
            // 
            this.txt_apartamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apartamento.DefaultText = "";
            this.txt_apartamento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_apartamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_apartamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apartamento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apartamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_apartamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_apartamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_apartamento.Location = new System.Drawing.Point(420, 35);
            this.txt_apartamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_apartamento.Name = "txt_apartamento";
            this.txt_apartamento.PasswordChar = '\0';
            this.txt_apartamento.PlaceholderText = "";
            this.txt_apartamento.SelectedText = "";
            this.txt_apartamento.Size = new System.Drawing.Size(92, 36);
            this.txt_apartamento.TabIndex = 24;
            this.txt_apartamento.TextChanged += new System.EventHandler(this.txt_apartamento_TextChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(704, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 23);
            this.label13.TabIndex = 25;
            this.label13.Text = "1-4000";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "Unidades";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(275, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 23);
            this.label15.TabIndex = 27;
            this.label15.Text = "Torre";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(417, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 23);
            this.label16.TabIndex = 28;
            this.label16.Text = "99-99";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Opt1
            // 
            this.Opt1.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.Opt1.CheckedState.BorderThickness = 0;
            this.Opt1.CheckedState.FillColor = System.Drawing.Color.Green;
            this.Opt1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Opt1.CheckedState.InnerOffset = -4;
            this.Opt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Opt1.Location = new System.Drawing.Point(12, 6);
            this.Opt1.Name = "Opt1";
            this.Opt1.Size = new System.Drawing.Size(69, 29);
            this.Opt1.TabIndex = 29;
            this.Opt1.Text = "Unidad";
            this.Opt1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Opt1.UncheckedState.BorderThickness = 2;
            this.Opt1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Opt1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Opt1.CheckedChanged += new System.EventHandler(this.Opt1_CheckedChanged);
            // 
            // Opt2
            // 
            this.Opt2.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.Opt2.CheckedState.BorderThickness = 0;
            this.Opt2.CheckedState.FillColor = System.Drawing.Color.Green;
            this.Opt2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Opt2.CheckedState.InnerOffset = -4;
            this.Opt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Opt2.Location = new System.Drawing.Point(87, 6);
            this.Opt2.Name = "Opt2";
            this.Opt2.Size = new System.Drawing.Size(59, 29);
            this.Opt2.TabIndex = 30;
            this.Opt2.Text = "Casa";
            this.Opt2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Opt2.UncheckedState.BorderThickness = 2;
            this.Opt2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Opt2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // PanelUnidad
            // 
            this.PanelUnidad.Controls.Add(this.label16);
            this.PanelUnidad.Controls.Add(this.txt_apartamento);
            this.PanelUnidad.Controls.Add(this.label12);
            this.PanelUnidad.Controls.Add(this.label14);
            this.PanelUnidad.Controls.Add(this.label15);
            this.PanelUnidad.Controls.Add(this.cb_torres);
            this.PanelUnidad.Controls.Add(this.cb_unidades);
            this.PanelUnidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUnidad.Location = new System.Drawing.Point(0, 0);
            this.PanelUnidad.Name = "PanelUnidad";
            this.PanelUnidad.Size = new System.Drawing.Size(800, 85);
            this.PanelUnidad.TabIndex = 31;
            // 
            // PanelCasa
            // 
            this.PanelCasa.Controls.Add(this.cb_Dir);
            this.PanelCasa.Controls.Add(this.label1);
            this.PanelCasa.Controls.Add(this.cb_letra_1);
            this.PanelCasa.Controls.Add(this.txt_numero_1);
            this.PanelCasa.Controls.Add(this.label10);
            this.PanelCasa.Controls.Add(this.label13);
            this.PanelCasa.Controls.Add(this.txt_Interior);
            this.PanelCasa.Controls.Add(this.label3);
            this.PanelCasa.Controls.Add(this.txt_numero_2);
            this.PanelCasa.Controls.Add(this.cb_letra_2);
            this.PanelCasa.Controls.Add(this.label9);
            this.PanelCasa.Controls.Add(this.label4);
            this.PanelCasa.Controls.Add(this.label8);
            this.PanelCasa.Controls.Add(this.txt_numero_3);
            this.PanelCasa.Controls.Add(this.label7);
            this.PanelCasa.Controls.Add(this.label5);
            this.PanelCasa.Controls.Add(this.label6);
            this.PanelCasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCasa.Location = new System.Drawing.Point(0, 85);
            this.PanelCasa.Name = "PanelCasa";
            this.PanelCasa.Size = new System.Drawing.Size(800, 85);
            this.PanelCasa.TabIndex = 32;
            // 
            // PanelDireccion
            // 
            this.PanelDireccion.Controls.Add(this.btnAceptar);
            this.PanelDireccion.Controls.Add(this.label2);
            this.PanelDireccion.Controls.Add(this.Opt1);
            this.PanelDireccion.Controls.Add(this.Opt2);
            this.PanelDireccion.Controls.Add(this.lb_Direccion_Completa);
            this.PanelDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDireccion.Location = new System.Drawing.Point(0, 170);
            this.PanelDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDireccion.Name = "PanelDireccion";
            this.PanelDireccion.Size = new System.Drawing.Size(800, 45);
            this.PanelDireccion.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Animated = true;
            this.btnAceptar.BorderRadius = 10;
            this.btnAceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAceptar.FillColor = System.Drawing.Color.Green;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(654, 2);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 37);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Dirección:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_FormatoDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 130);
            this.Controls.Add(this.PanelDireccion);
            this.Controls.Add(this.PanelCasa);
            this.Controls.Add(this.PanelUnidad);
            this.Name = "Frm_FormatoDireccion";
            this.Text = "Formulario Dirección";
            this.Load += new System.EventHandler(this.Frm_FormatoDireccion_Load);
            this.PanelUnidad.ResumeLayout(false);
            this.PanelCasa.ResumeLayout(false);
            this.PanelDireccion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel PanelDireccion;
        private System.Windows.Forms.Panel PanelUnidad;
        private System.Windows.Forms.Panel PanelCasa;
        
        private System.Windows.Forms.Label label2;
        
        private Guna.UI2.WinForms.Guna2Button btnAceptar;
        public Guna.UI2.WinForms.Guna2ComboBox cb_Dir;
        public System.Windows.Forms.Label lb_Direccion_Completa;
        public Guna.UI2.WinForms.Guna2ComboBox cb_unidades;
        public Guna.UI2.WinForms.Guna2ComboBox cb_letra_1;
        public Guna.UI2.WinForms.Guna2ComboBox cb_torres;
        public Guna.UI2.WinForms.Guna2TextBox txt_numero_1;
        public Guna.UI2.WinForms.Guna2TextBox txt_numero_2;
        public Guna.UI2.WinForms.Guna2ComboBox cb_letra_2;
        public Guna.UI2.WinForms.Guna2TextBox txt_numero_3;
        public Guna.UI2.WinForms.Guna2TextBox txt_Interior;
        public Guna.UI2.WinForms.Guna2TextBox txt_apartamento;
        public Guna.UI2.WinForms.Guna2RadioButton Opt1;
        public Guna.UI2.WinForms.Guna2RadioButton Opt2;
        public System.Windows.Forms.Label label12;
    }
}