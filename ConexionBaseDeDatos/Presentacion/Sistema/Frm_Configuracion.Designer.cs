namespace ConexionBaseDeDatos
{
    partial class Frm_Configuracion
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
            this.chkEnviarALaVecindad = new System.Windows.Forms.CheckBox();
            this.chkImprimirEnCarniceria = new System.Windows.Forms.CheckBox();
            this.chkImprimirEnLegumbria = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadenaDeConexion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCadenaDeConexionCallCenter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccionImpresoraLegumbreria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccionImpresoraCarniceria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEnvioPaginaWeb = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkEnviarALaVecindad
            // 
            this.chkEnviarALaVecindad.AutoSize = true;
            this.chkEnviarALaVecindad.Enabled = false;
            this.chkEnviarALaVecindad.Location = new System.Drawing.Point(9, 10);
            this.chkEnviarALaVecindad.Margin = new System.Windows.Forms.Padding(2);
            this.chkEnviarALaVecindad.Name = "chkEnviarALaVecindad";
            this.chkEnviarALaVecindad.Size = new System.Drawing.Size(188, 17);
            this.chkEnviarALaVecindad.TabIndex = 0;
            this.chkEnviarALaVecindad.Text = "Enviar a la Plataforma la Vecindad";
            this.chkEnviarALaVecindad.UseVisualStyleBackColor = true;
            // 
            // chkImprimirEnCarniceria
            // 
            this.chkImprimirEnCarniceria.AutoSize = true;
            this.chkImprimirEnCarniceria.Enabled = false;
            this.chkImprimirEnCarniceria.Location = new System.Drawing.Point(9, 105);
            this.chkImprimirEnCarniceria.Margin = new System.Windows.Forms.Padding(2);
            this.chkImprimirEnCarniceria.Name = "chkImprimirEnCarniceria";
            this.chkImprimirEnCarniceria.Size = new System.Drawing.Size(126, 17);
            this.chkImprimirEnCarniceria.TabIndex = 1;
            this.chkImprimirEnCarniceria.Text = "Imprimir en Carniceria";
            this.chkImprimirEnCarniceria.UseVisualStyleBackColor = true;
            // 
            // chkImprimirEnLegumbria
            // 
            this.chkImprimirEnLegumbria.AutoSize = true;
            this.chkImprimirEnLegumbria.Enabled = false;
            this.chkImprimirEnLegumbria.Location = new System.Drawing.Point(9, 138);
            this.chkImprimirEnLegumbria.Margin = new System.Windows.Forms.Padding(2);
            this.chkImprimirEnLegumbria.Name = "chkImprimirEnLegumbria";
            this.chkImprimirEnLegumbria.Size = new System.Drawing.Size(137, 17);
            this.chkImprimirEnLegumbria.TabIndex = 2;
            this.chkImprimirEnLegumbria.Text = "Imprimir en Legumbreria";
            this.chkImprimirEnLegumbria.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadena de Conexion BD XPOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCadenaDeConexion
            // 
            this.txtCadenaDeConexion.Enabled = false;
            this.txtCadenaDeConexion.Location = new System.Drawing.Point(9, 303);
            this.txtCadenaDeConexion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCadenaDeConexion.Name = "txtCadenaDeConexion";
            this.txtCadenaDeConexion.Size = new System.Drawing.Size(499, 20);
            this.txtCadenaDeConexion.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(14, 404);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 46);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCadenaDeConexionCallCenter
            // 
            this.txtCadenaDeConexionCallCenter.Enabled = false;
            this.txtCadenaDeConexionCallCenter.Location = new System.Drawing.Point(8, 345);
            this.txtCadenaDeConexionCallCenter.Margin = new System.Windows.Forms.Padding(2);
            this.txtCadenaDeConexionCallCenter.Name = "txtCadenaDeConexionCallCenter";
            this.txtCadenaDeConexionCallCenter.Size = new System.Drawing.Size(499, 20);
            this.txtCadenaDeConexionCallCenter.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadena de Conexion BD Call Center";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccionImpresoraLegumbreria
            // 
            this.txtDireccionImpresoraLegumbreria.Enabled = false;
            this.txtDireccionImpresoraLegumbreria.Location = new System.Drawing.Point(8, 241);
            this.txtDireccionImpresoraLegumbreria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionImpresoraLegumbreria.Name = "txtDireccionImpresoraLegumbreria";
            this.txtDireccionImpresoraLegumbreria.Size = new System.Drawing.Size(254, 20);
            this.txtDireccionImpresoraLegumbreria.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direccion Impresora Legumbreria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccionImpresoraCarniceria
            // 
            this.txtDireccionImpresoraCarniceria.Enabled = false;
            this.txtDireccionImpresoraCarniceria.Location = new System.Drawing.Point(8, 193);
            this.txtDireccionImpresoraCarniceria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionImpresoraCarniceria.Name = "txtDireccionImpresoraCarniceria";
            this.txtDireccionImpresoraCarniceria.Size = new System.Drawing.Size(254, 20);
            this.txtDireccionImpresoraCarniceria.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion Impresora Carniceria";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkEnvioPaginaWeb
            // 
            this.chkEnvioPaginaWeb.AutoSize = true;
            this.chkEnvioPaginaWeb.Enabled = false;
            this.chkEnvioPaginaWeb.Location = new System.Drawing.Point(9, 38);
            this.chkEnvioPaginaWeb.Margin = new System.Windows.Forms.Padding(2);
            this.chkEnvioPaginaWeb.Name = "chkEnvioPaginaWeb";
            this.chkEnvioPaginaWeb.Size = new System.Drawing.Size(134, 17);
            this.chkEnvioPaginaWeb.TabIndex = 13;
            this.chkEnvioPaginaWeb.Text = "Envio La Bodega Web";
            this.chkEnvioPaginaWeb.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(9, 68);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(253, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Api Actualizacion Cliente - La Bodega de Nacho";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(369, 68);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(144, 20);
            this.txtContraseña.TabIndex = 15;
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(370, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contraseña Autorizacion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 473);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Version";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Version
            // 
            this.lb_Version.Location = new System.Drawing.Point(11, 492);
            this.lb_Version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(86, 19);
            this.lb_Version.TabIndex = 18;
            this.lb_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 672);
            this.Controls.Add(this.lb_Version);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chkEnvioPaginaWeb);
            this.Controls.Add(this.txtDireccionImpresoraLegumbreria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccionImpresoraCarniceria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCadenaDeConexionCallCenter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCadenaDeConexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkImprimirEnLegumbria);
            this.Controls.Add(this.chkImprimirEnCarniceria);
            this.Controls.Add(this.chkEnviarALaVecindad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Configuracion";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Frm_Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnviarALaVecindad;
        private System.Windows.Forms.CheckBox chkImprimirEnCarniceria;
        private System.Windows.Forms.CheckBox chkImprimirEnLegumbria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadenaDeConexion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCadenaDeConexionCallCenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccionImpresoraLegumbreria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccionImpresoraCarniceria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkEnvioPaginaWeb;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Version;
    }
}