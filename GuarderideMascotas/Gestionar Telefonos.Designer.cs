namespace GuarderideMascotas
{
    partial class Gestionar_Telefonos
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txt_codarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codcli = new System.Windows.Forms.TextBox();
            this.dvgmasc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmasc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(183, 135);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(279, 29);
            this.txtnumero.TabIndex = 63;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(284, 609);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(216, 42);
            this.btnGuardar.TabIndex = 62;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(271, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(223, 54);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(223, 54);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txt_codarea
            // 
            this.txt_codarea.Location = new System.Drawing.Point(42, 135);
            this.txt_codarea.Name = "txt_codarea";
            this.txt_codarea.Size = new System.Drawing.Size(75, 29);
            this.txt_codarea.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cod. de área:";
            // 
            // txt_codcli
            // 
            this.txt_codcli.Enabled = false;
            this.txt_codcli.Location = new System.Drawing.Point(225, 42);
            this.txt_codcli.Name = "txt_codcli";
            this.txt_codcli.Size = new System.Drawing.Size(100, 29);
            this.txt_codcli.TabIndex = 56;
            // 
            // dvgmasc
            // 
            this.dvgmasc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgmasc.Enabled = false;
            this.dvgmasc.Location = new System.Drawing.Point(42, 292);
            this.dvgmasc.Name = "dvgmasc";
            this.dvgmasc.RowTemplate.Height = 31;
            this.dvgmasc.Size = new System.Drawing.Size(458, 286);
            this.dvgmasc.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Código de Cliente:";
            // 
            // Gestionar_Telefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 694);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt_codarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codcli);
            this.Controls.Add(this.dvgmasc);
            this.Controls.Add(this.label1);
            this.Name = "Gestionar_Telefonos";
            this.Text = "Gestionar_Telefonos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgmasc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txt_codarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codcli;
        private System.Windows.Forms.DataGridView dvgmasc;
        private System.Windows.Forms.Label label1;
    }
}