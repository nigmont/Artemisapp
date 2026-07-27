namespace Artemisapp_UX
{
    partial class HistoriaClinica
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtIdHistoria = new System.Windows.Forms.TextBox();
            this.txtEstudios = new System.Windows.Forms.TextBox();
            this.txtInternaciones = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDarAltaMedica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNombreMascota = new System.Windows.Forms.Label();
            this.dtgvListadoMascotas = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarMontoParcial = new System.Windows.Forms.Button();
            this.lblMontoParcialConsulta = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOtroMonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPrecioConsulta = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.clbAdicionales = new System.Windows.Forms.ListBox();
            this.lblDatosMascota = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombreMascota1 = new System.Windows.Forms.Label();
            this.btnModificarConsulta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListadoMascotas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(75, 54);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(214, 20);
            this.txtDni.TabIndex = 0;
            // 
            // txtIdHistoria
            // 
            this.txtIdHistoria.Location = new System.Drawing.Point(75, 86);
            this.txtIdHistoria.Name = "txtIdHistoria";
            this.txtIdHistoria.Size = new System.Drawing.Size(247, 20);
            this.txtIdHistoria.TabIndex = 1;
            // 
            // txtEstudios
            // 
            this.txtEstudios.Location = new System.Drawing.Point(18, 128);
            this.txtEstudios.Name = "txtEstudios";
            this.txtEstudios.Size = new System.Drawing.Size(304, 20);
            this.txtEstudios.TabIndex = 2;
            // 
            // txtInternaciones
            // 
            this.txtInternaciones.Location = new System.Drawing.Point(342, 128);
            this.txtInternaciones.Name = "txtInternaciones";
            this.txtInternaciones.Size = new System.Drawing.Size(236, 20);
            this.txtInternaciones.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(18, 167);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(560, 20);
            this.txtObservaciones.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(653, 9);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(295, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 21);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "🔎";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(606, 468);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(241, 46);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Guardar Consulta";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDarAltaMedica
            // 
            this.btnDarAltaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAltaMedica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDarAltaMedica.Location = new System.Drawing.Point(740, 396);
            this.btnDarAltaMedica.Name = "btnDarAltaMedica";
            this.btnDarAltaMedica.Size = new System.Drawing.Size(107, 23);
            this.btnDarAltaMedica.TabIndex = 9;
            this.btnDarAltaMedica.Text = "Dar Alta Medica";
            this.btnDarAltaMedica.UseVisualStyleBackColor = true;
            this.btnDarAltaMedica.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id Historia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Estudios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Internaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Historia Clinica";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(88, 19);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 17;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Location = new System.Drawing.Point(18, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 145);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historia Clinica";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Location = new System.Drawing.Point(538, 86);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(40, 28);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "🧽";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNombreMascota
            // 
            this.lblNombreMascota.AutoSize = true;
            this.lblNombreMascota.Location = new System.Drawing.Point(339, 86);
            this.lblNombreMascota.Name = "lblNombreMascota";
            this.lblNombreMascota.Size = new System.Drawing.Size(88, 13);
            this.lblNombreMascota.TabIndex = 20;
            this.lblNombreMascota.Text = "Nombre Mascota";
            // 
            // dtgvListadoMascotas
            // 
            this.dtgvListadoMascotas.AllowUserToAddRows = false;
            this.dtgvListadoMascotas.AllowUserToDeleteRows = false;
            this.dtgvListadoMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListadoMascotas.Location = new System.Drawing.Point(15, 373);
            this.dtgvListadoMascotas.Name = "dtgvListadoMascotas";
            this.dtgvListadoMascotas.ReadOnly = true;
            this.dtgvListadoMascotas.Size = new System.Drawing.Size(563, 152);
            this.dtgvListadoMascotas.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Listado de todas las mascotas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarMontoParcial);
            this.groupBox2.Controls.Add(this.lblMontoParcialConsulta);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtOtroMonto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblPrecioConsulta);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.clbAdicionales);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(601, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 284);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cierre consulta";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAgregarMontoParcial
            // 
            this.btnAgregarMontoParcial.Location = new System.Drawing.Point(11, 241);
            this.btnAgregarMontoParcial.Name = "btnAgregarMontoParcial";
            this.btnAgregarMontoParcial.Size = new System.Drawing.Size(235, 26);
            this.btnAgregarMontoParcial.TabIndex = 8;
            this.btnAgregarMontoParcial.Text = "Agregar Monto";
            this.btnAgregarMontoParcial.UseVisualStyleBackColor = true;
            this.btnAgregarMontoParcial.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblMontoParcialConsulta
            // 
            this.lblMontoParcialConsulta.AutoSize = true;
            this.lblMontoParcialConsulta.Location = new System.Drawing.Point(65, 177);
            this.lblMontoParcialConsulta.Name = "lblMontoParcialConsulta";
            this.lblMontoParcialConsulta.Size = new System.Drawing.Size(47, 17);
            this.lblMontoParcialConsulta.TabIndex = 7;
            this.lblMontoParcialConsulta.Text = "Monto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Total";
            // 
            // txtOtroMonto
            // 
            this.txtOtroMonto.Location = new System.Drawing.Point(139, 129);
            this.txtOtroMonto.Name = "txtOtroMonto";
            this.txtOtroMonto.Size = new System.Drawing.Size(107, 25);
            this.txtOtroMonto.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Otro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Adicional:";
            // 
            // lblPrecioConsulta
            // 
            this.lblPrecioConsulta.AutoSize = true;
            this.lblPrecioConsulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioConsulta.Location = new System.Drawing.Point(156, 38);
            this.lblPrecioConsulta.Name = "lblPrecioConsulta";
            this.lblPrecioConsulta.Size = new System.Drawing.Size(90, 17);
            this.lblPrecioConsulta.TabIndex = 2;
            this.lblPrecioConsulta.Text = "Precio 10000$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Consulta:";
            // 
            // clbAdicionales
            // 
            this.clbAdicionales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAdicionales.FormattingEnabled = true;
            this.clbAdicionales.ItemHeight = 17;
            this.clbAdicionales.Items.AddRange(new object[] {
            "Castración: 90000 $",
            "Vacunación 20000$",
            "Desparacitación: 15000$"});
            this.clbAdicionales.Location = new System.Drawing.Point(99, 86);
            this.clbAdicionales.Name = "clbAdicionales";
            this.clbAdicionales.Size = new System.Drawing.Size(147, 21);
            this.clbAdicionales.TabIndex = 0;
            this.clbAdicionales.SelectedIndexChanged += new System.EventHandler(this.clbAdicionales_SelectedIndexChanged);
            // 
            // lblDatosMascota
            // 
            this.lblDatosMascota.AutoSize = true;
            this.lblDatosMascota.Location = new System.Drawing.Point(609, 360);
            this.lblDatosMascota.Name = "lblDatosMascota";
            this.lblDatosMascota.Size = new System.Drawing.Size(76, 13);
            this.lblDatosMascota.TabIndex = 24;
            this.lblDatosMascota.Text = "DatosMascota";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(425, 54);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(153, 20);
            this.txtNumeroCliente.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nro. Cte.";
            // 
            // lblNombreMascota1
            // 
            this.lblNombreMascota1.AutoSize = true;
            this.lblNombreMascota1.Location = new System.Drawing.Point(433, 86);
            this.lblNombreMascota1.Name = "lblNombreMascota1";
            this.lblNombreMascota1.Size = new System.Drawing.Size(16, 13);
            this.lblNombreMascota1.TabIndex = 27;
            this.lblNombreMascota1.Text = "...";
            // 
            // btnModificarConsulta
            // 
            this.btnModificarConsulta.Location = new System.Drawing.Point(740, 425);
            this.btnModificarConsulta.Name = "btnModificarConsulta";
            this.btnModificarConsulta.Size = new System.Drawing.Size(107, 24);
            this.btnModificarConsulta.TabIndex = 28;
            this.btnModificarConsulta.Text = "Modificar";
            this.btnModificarConsulta.UseVisualStyleBackColor = true;
            // 
            // HistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 537);
            this.Controls.Add(this.btnModificarConsulta);
            this.Controls.Add(this.lblDatosMascota);
            this.Controls.Add(this.lblNombreMascota1);
            this.Controls.Add(this.btnDarAltaMedica);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgvListadoMascotas);
            this.Controls.Add(this.lblNombreMascota);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtInternaciones);
            this.Controls.Add(this.txtEstudios);
            this.Controls.Add(this.txtIdHistoria);
            this.Controls.Add(this.txtDni);
            this.Name = "HistoriaClinica";
            this.Text = "PruebaHistoriaClinica";
            this.Load += new System.EventHandler(this.PruebaHistoriaClinica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListadoMascotas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtIdHistoria;
        private System.Windows.Forms.TextBox txtEstudios;
        private System.Windows.Forms.TextBox txtInternaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnDarAltaMedica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNombreMascota;
        private System.Windows.Forms.DataGridView dtgvListadoMascotas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox clbAdicionales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregarMontoParcial;
        private System.Windows.Forms.Label lblMontoParcialConsulta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOtroMonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPrecioConsulta;
        private System.Windows.Forms.Label lblDatosMascota;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNombreMascota1;
        private System.Windows.Forms.Button btnModificarConsulta;
    }
}