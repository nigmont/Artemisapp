namespace Artemisapp_UX
{
    partial class FormAgregarMascota
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoAnimal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMedicado = new System.Windows.Forms.CheckBox();
            this.chkVacunado = new System.Windows.Forms.CheckBox();
            this.chkCastrado = new System.Windows.Forms.CheckBox();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNroClienteMascota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Mascotas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Artemisapp_UX.Properties.Resources.esquina;
            this.pictureBox1.Location = new System.Drawing.Point(219, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Mascota:";
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(12, 104);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(167, 20);
            this.txtNombreMascota.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(12, 167);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(167, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(12, 228);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(167, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Peso";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(12, 290);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(167, 20);
            this.txtRaza.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Raza";
            // 
            // cmbTipoAnimal
            // 
            this.cmbTipoAnimal.FormattingEnabled = true;
            this.cmbTipoAnimal.Location = new System.Drawing.Point(12, 44);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(167, 21);
            this.cmbTipoAnimal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTipoAnimal);
            this.groupBox1.Controls.Add(this.txtRaza);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreMascota);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(17, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 364);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Principales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMedicado);
            this.groupBox2.Controls.Add(this.chkVacunado);
            this.groupBox2.Controls.Add(this.chkCastrado);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(219, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 106);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Médicos";
            // 
            // chkMedicado
            // 
            this.chkMedicado.AutoSize = true;
            this.chkMedicado.Location = new System.Drawing.Point(6, 74);
            this.chkMedicado.Name = "chkMedicado";
            this.chkMedicado.Size = new System.Drawing.Size(84, 17);
            this.chkMedicado.TabIndex = 2;
            this.chkMedicado.Text = "Medicado/a";
            this.chkMedicado.UseVisualStyleBackColor = true;
            // 
            // chkVacunado
            // 
            this.chkVacunado.AutoSize = true;
            this.chkVacunado.Location = new System.Drawing.Point(6, 48);
            this.chkVacunado.Name = "chkVacunado";
            this.chkVacunado.Size = new System.Drawing.Size(86, 17);
            this.chkVacunado.TabIndex = 1;
            this.chkVacunado.Text = "Vacunado/a";
            this.chkVacunado.UseVisualStyleBackColor = true;
            // 
            // chkCastrado
            // 
            this.chkCastrado.AutoSize = true;
            this.chkCastrado.Location = new System.Drawing.Point(6, 25);
            this.chkCastrado.Name = "chkCastrado";
            this.chkCastrado.Size = new System.Drawing.Size(79, 17);
            this.chkCastrado.TabIndex = 0;
            this.chkCastrado.Text = "Castrado/a";
            this.chkCastrado.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Location = new System.Drawing.Point(219, 346);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(167, 38);
            this.btnGuardarDatos.TabIndex = 14;
            this.btnGuardarDatos.Text = "Guardar Mascota";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNroClienteMascota
            // 
            this.lblNroClienteMascota.AutoSize = true;
            this.lblNroClienteMascota.Location = new System.Drawing.Point(26, 46);
            this.lblNroClienteMascota.Name = "lblNroClienteMascota";
            this.lblNroClienteMascota.Size = new System.Drawing.Size(54, 13);
            this.lblNroClienteMascota.TabIndex = 16;
            this.lblNroClienteMascota.Text = "N° Cliente";
            // 
            // FormAgregarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.lblNroClienteMascota);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarMascota";
            this.Text = "AgregarMascota";
            this.Load += new System.EventHandler(this.FormAgregarMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoAnimal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMedicado;
        private System.Windows.Forms.CheckBox chkVacunado;
        private System.Windows.Forms.CheckBox chkCastrado;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNroClienteMascota;
    }
}