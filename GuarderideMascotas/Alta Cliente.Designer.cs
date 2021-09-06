namespace GuarderideMascotas
{
    partial class Alta_Cliente
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoTel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cmbDNI = new System.Windows.Forms.ComboBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(478, 168);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(91, 29);
            this.txtAltura.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 25);
            this.label12.TabIndex = 70;
            this.label12.Text = "Altura";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(712, 404);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 40);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevoTel
            // 
            this.btnNuevoTel.Location = new System.Drawing.Point(620, 344);
            this.btnNuevoTel.Name = "btnNuevoTel";
            this.btnNuevoTel.Size = new System.Drawing.Size(86, 40);
            this.btnNuevoTel.TabIndex = 66;
            this.btnNuevoTel.Text = "Nuevo";
            this.btnNuevoTel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(591, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 65;
            this.label10.Text = "Telefonos";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(596, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 100);
            this.listBox1.TabIndex = 64;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(140, 343);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(205, 29);
            this.txtDNI.TabIndex = 9;
            // 
            // cmbDNI
            // 
            this.cmbDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDNI.FormattingEnabled = true;
            this.cmbDNI.Location = new System.Drawing.Point(140, 301);
            this.cmbDNI.Name = "cmbDNI";
            this.cmbDNI.Size = new System.Drawing.Size(105, 32);
            this.cmbDNI.TabIndex = 8;
            // 
            // cmbProv
            // 
            this.cmbProv.AllowDrop = true;
            this.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProv.Location = new System.Drawing.Point(140, 210);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(408, 32);
            this.cmbProv.TabIndex = 6;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            this.cmbProv.SelectionChangeCommitted += new System.EventHandler(this.cmbProv_SelectionChangeCommitted);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(140, 253);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(408, 32);
            this.cmbCiudad.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Ciudad";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(730, 168);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(85, 29);
            this.txtCP.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Código Postal";
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(140, 168);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(244, 29);
            this.txtDire.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(140, 124);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(244, 29);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(244, 29);
            this.txtNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Nro DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tipo DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Provincia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Apellido/s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Complete todos los datos del nuevo cliente y presione Guardar para crearlo.";
            // 
            // Alta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 468);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevoTel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.cmbDNI);
            this.Controls.Add(this.cmbProv);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Alta_Cliente";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.Alta_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevoTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ComboBox cmbDNI;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}