namespace ConexionBaseDeDatos
{
    partial class InputBoxForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.Etiqueta = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.Opt1 = new System.Windows.Forms.RadioButton();
            this.Opt2 = new System.Windows.Forms.RadioButton();
            this.Opt3 = new System.Windows.Forms.RadioButton();
            this.Opt4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(25, 100);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(214, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // Etiqueta
            // 
            this.Etiqueta.Location = new System.Drawing.Point(12, 9);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(145, 66);
            this.Etiqueta.TabIndex = 1;
            this.Etiqueta.Text = "label1";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(25, 126);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(69, 24);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click_1);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(170, 126);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(69, 24);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // Opt1
            // 
            this.Opt1.AutoSize = true;
            this.Opt1.Location = new System.Drawing.Point(170, 7);
            this.Opt1.Name = "Opt1";
            this.Opt1.Size = new System.Drawing.Size(49, 17);
            this.Opt1.TabIndex = 3;
            this.Opt1.TabStop = true;
            this.Opt1.Text = "UND";
            this.Opt1.UseVisualStyleBackColor = true;
            this.Opt1.Visible = false;
            // 
            // Opt2
            // 
            this.Opt2.AutoSize = true;
            this.Opt2.Location = new System.Drawing.Point(170, 28);
            this.Opt2.Name = "Opt2";
            this.Opt2.Size = new System.Drawing.Size(56, 17);
            this.Opt2.TabIndex = 4;
            this.Opt2.TabStop = true;
            this.Opt2.Text = "LIBRA";
            this.Opt2.UseVisualStyleBackColor = true;
            this.Opt2.Visible = false;
            // 
            // Opt3
            // 
            this.Opt3.AutoSize = true;
            this.Opt3.Location = new System.Drawing.Point(170, 49);
            this.Opt3.Name = "Opt3";
            this.Opt3.Size = new System.Drawing.Size(49, 17);
            this.Opt3.TabIndex = 5;
            this.Opt3.TabStop = true;
            this.Opt3.Text = "KILO";
            this.Opt3.UseVisualStyleBackColor = true;
            this.Opt3.Visible = false;
            // 
            // Opt4
            // 
            this.Opt4.AutoSize = true;
            this.Opt4.Location = new System.Drawing.Point(170, 70);
            this.Opt4.Name = "Opt4";
            this.Opt4.Size = new System.Drawing.Size(70, 17);
            this.Opt4.TabIndex = 6;
            this.Opt4.TabStop = true;
            this.Opt4.Text = "MANOJO";
            this.Opt4.UseVisualStyleBackColor = true;
            this.Opt4.Visible = false;
            // 
            // InputBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 159);
            this.Controls.Add(this.Opt4);
            this.Controls.Add(this.Opt3);
            this.Controls.Add(this.Opt2);
            this.Controls.Add(this.Opt1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.Etiqueta);
            this.Controls.Add(this.txtInput);
            this.KeyPreview = true;
            this.Name = "InputBoxForm";
            this.Text = "InputBoxForm";
            this.Load += new System.EventHandler(this.InputBoxForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LecturaDeTeclasParaAccesosDirectos);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtInput;
        public System.Windows.Forms.Label Etiqueta;
        public System.Windows.Forms.Button btn_Aceptar;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.RadioButton Opt1;
        public System.Windows.Forms.RadioButton Opt2;
        public System.Windows.Forms.RadioButton Opt3;
        public System.Windows.Forms.RadioButton Opt4;
    }
}