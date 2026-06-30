namespace Artemisapp_UX
{
    partial class _05Turnos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDniTurno = new System.Windows.Forms.TextBox();
            this.btnBuscarClienteTurno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteTurno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarBusquedaTurno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarNuevoCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMotivoCita = new System.Windows.Forms.ComboBox();
            this.txtClienteTurnoCita = new System.Windows.Forms.TextBox();
            this.txtTurnoCita = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHorarioCita = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbProfesional = new System.Windows.Forms.ComboBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDniCita = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgvAgendaTurnos = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnConfirmarCita = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblResumenTurno = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgendaTurnos)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // txtDniTurno
            // 
            this.txtDniTurno.Location = new System.Drawing.Point(8, 44);
            this.txtDniTurno.Name = "txtDniTurno";
            this.txtDniTurno.Size = new System.Drawing.Size(122, 21);
            this.txtDniTurno.TabIndex = 2;
            // 
            // btnBuscarClienteTurno
            // 
            this.btnBuscarClienteTurno.Location = new System.Drawing.Point(136, 44);
            this.btnBuscarClienteTurno.Name = "btnBuscarClienteTurno";
            this.btnBuscarClienteTurno.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarClienteTurno.TabIndex = 3;
            this.btnBuscarClienteTurno.Text = "🔎";
            this.btnBuscarClienteTurno.UseVisualStyleBackColor = true;
            this.btnBuscarClienteTurno.Click += new System.EventHandler(this.btnBuscarClienteTurno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(167, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // txtClienteTurno
            // 
            this.txtClienteTurno.Location = new System.Drawing.Point(173, 42);
            this.txtClienteTurno.Name = "txtClienteTurno";
            this.txtClienteTurno.ReadOnly = true;
            this.txtClienteTurno.Size = new System.Drawing.Size(184, 21);
            this.txtClienteTurno.TabIndex = 5;
            this.txtClienteTurno.TextChanged += new System.EventHandler(this.txtClienteTurno_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarBusquedaTurno);
            this.groupBox1.Controls.Add(this.txtClienteTurno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscarClienteTurno);
            this.groupBox1.Controls.Add(this.txtDniTurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(9, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Buscar Cliente";
            // 
            // btnLimpiarBusquedaTurno
            // 
            this.btnLimpiarBusquedaTurno.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaTurno.Location = new System.Drawing.Point(248, 69);
            this.btnLimpiarBusquedaTurno.Name = "btnLimpiarBusquedaTurno";
            this.btnLimpiarBusquedaTurno.Size = new System.Drawing.Size(109, 23);
            this.btnLimpiarBusquedaTurno.TabIndex = 6;
            this.btnLimpiarBusquedaTurno.Text = "🧽 Limpiar";
            this.btnLimpiarBusquedaTurno.UseVisualStyleBackColor = true;
            this.btnLimpiarBusquedaTurno.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnAgregarNuevoCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(387, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 91);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "👨 Nuevo Cliente";
            // 
            // btnAgregarNuevoCliente
            // 
            this.btnAgregarNuevoCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarNuevoCliente.Location = new System.Drawing.Point(17, 60);
            this.btnAgregarNuevoCliente.Name = "btnAgregarNuevoCliente";
            this.btnAgregarNuevoCliente.Size = new System.Drawing.Size(223, 24);
            this.btnAgregarNuevoCliente.TabIndex = 1;
            this.btnAgregarNuevoCliente.Text = "👤➕ Agregar Nuevo Cliente";
            this.btnAgregarNuevoCliente.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoCliente.Click += new System.EventHandler(this.btnAgregarNuevoCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "El cliente no existe en el sistema";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMotivoCita);
            this.groupBox4.Controls.Add(this.txtClienteTurnoCita);
            this.groupBox4.Controls.Add(this.txtTurnoCita);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbHorarioCita);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cbProfesional);
            this.groupBox4.Controls.Add(this.dtpFechaCita);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtDniCita);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(9, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 317);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2. Datos del Turno";
            // 
            // cbMotivoCita
            // 
            this.cbMotivoCita.FormattingEnabled = true;
            this.cbMotivoCita.Location = new System.Drawing.Point(10, 98);
            this.cbMotivoCita.Name = "cbMotivoCita";
            this.cbMotivoCita.Size = new System.Drawing.Size(347, 23);
            this.cbMotivoCita.TabIndex = 21;
            // 
            // txtClienteTurnoCita
            // 
            this.txtClienteTurnoCita.Location = new System.Drawing.Point(10, 43);
            this.txtClienteTurnoCita.Name = "txtClienteTurnoCita";
            this.txtClienteTurnoCita.ReadOnly = true;
            this.txtClienteTurnoCita.Size = new System.Drawing.Size(208, 21);
            this.txtClienteTurnoCita.TabIndex = 7;
            // 
            // txtTurnoCita
            // 
            this.txtTurnoCita.Location = new System.Drawing.Point(118, 277);
            this.txtTurnoCita.Name = "txtTurnoCita";
            this.txtTurnoCita.ReadOnly = true;
            this.txtTurnoCita.Size = new System.Drawing.Size(239, 21);
            this.txtTurnoCita.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(13, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Turno N° ";
            // 
            // cbHorarioCita
            // 
            this.cbHorarioCita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarioCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHorarioCita.FormattingEnabled = true;
            this.cbHorarioCita.Location = new System.Drawing.Point(260, 224);
            this.cbHorarioCita.Name = "cbHorarioCita";
            this.cbHorarioCita.Size = new System.Drawing.Size(97, 23);
            this.cbHorarioCita.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(257, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Horario";
            // 
            // cbProfesional
            // 
            this.cbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProfesional.FormattingEnabled = true;
            this.cbProfesional.Location = new System.Drawing.Point(11, 163);
            this.cbProfesional.Name = "cbProfesional";
            this.cbProfesional.Size = new System.Drawing.Size(346, 23);
            this.cbProfesional.TabIndex = 17;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(11, 224);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(237, 21);
            this.dtpFechaCita.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(8, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "👨‍⚕️ Profesional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(7, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motivo - Consulta";
            // 
            // txtDniCita
            // 
            this.txtDniCita.Location = new System.Drawing.Point(230, 44);
            this.txtDniCita.Name = "txtDniCita";
            this.txtDniCita.Size = new System.Drawing.Size(127, 21);
            this.txtDniCita.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(227, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "👨 Cliente";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgvAgendaTurnos);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(387, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(678, 346);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4. Agenda de Turnos";
            // 
            // dtgvAgendaTurnos
            // 
            this.dtgvAgendaTurnos.AllowUserToAddRows = false;
            this.dtgvAgendaTurnos.AllowUserToDeleteRows = false;
            this.dtgvAgendaTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAgendaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAgendaTurnos.Location = new System.Drawing.Point(6, 22);
            this.dtgvAgendaTurnos.Name = "dtgvAgendaTurnos";
            this.dtgvAgendaTurnos.ReadOnly = true;
            this.dtgvAgendaTurnos.RowHeadersVisible = false;
            this.dtgvAgendaTurnos.Size = new System.Drawing.Size(666, 318);
            this.dtgvAgendaTurnos.TabIndex = 22;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCancelarCita);
            this.groupBox6.Controls.Add(this.btnConfirmarCita);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Location = new System.Drawing.Point(9, 467);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 66);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3. Acciones del Turno";
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarCita.Location = new System.Drawing.Point(173, 28);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(184, 32);
            this.btnCancelarCita.TabIndex = 2;
            this.btnCancelarCita.Text = "❌ Cancelar";
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            this.btnCancelarCita.Click += new System.EventHandler(this.btnCancelarCita_Click);
            // 
            // btnConfirmarCita
            // 
            this.btnConfirmarCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnConfirmarCita.Location = new System.Drawing.Point(11, 28);
            this.btnConfirmarCita.Name = "btnConfirmarCita";
            this.btnConfirmarCita.Size = new System.Drawing.Size(156, 32);
            this.btnConfirmarCita.TabIndex = 0;
            this.btnConfirmarCita.Text = "✅ Confirmar";
            this.btnConfirmarCita.UseVisualStyleBackColor = true;
            this.btnConfirmarCita.Click += new System.EventHandler(this.btnConfirmarCita_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(15, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(163, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Rol";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pictureBox1);
            this.groupBox8.Controls.Add(this.lblResumenTurno);
            this.groupBox8.Location = new System.Drawing.Point(650, 38);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(415, 154);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Resumen de la Operación";
            // 
            // lblResumenTurno
            // 
            this.lblResumenTurno.AutoSize = true;
            this.lblResumenTurno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenTurno.Location = new System.Drawing.Point(13, 25);
            this.lblResumenTurno.Name = "lblResumenTurno";
            this.lblResumenTurno.Size = new System.Drawing.Size(113, 16);
            this.lblResumenTurno.TabIndex = 0;
            this.lblResumenTurno.Text = "Sin turno asignado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Artemisapp_UX.Properties.Resources.esquina;
            this.pictureBox1.Location = new System.Drawing.Point(310, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // _05Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 553);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "_05Turnos";
            this.Text = "_05Turnos";
            this.Load += new System.EventHandler(this._05Turnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAgendaTurnos)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDniTurno;
        private System.Windows.Forms.Button btnBuscarClienteTurno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteTurno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarBusquedaTurno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarNuevoCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDniCita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProfesional;
        private System.Windows.Forms.TextBox txtTurnoCita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbHorarioCita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgvAgendaTurnos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Button btnConfirmarCita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtClienteTurnoCita;
        private System.Windows.Forms.ComboBox cbMotivoCita;
        private System.Windows.Forms.Label lblResumenTurno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}