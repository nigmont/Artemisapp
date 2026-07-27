namespace Artemisapp_UX
{
    partial class FormTurnero
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
            this.components = new System.ComponentModel.Container();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlNumero = new System.Windows.Forms.Panel();
            this.lblNumeroTurno = new System.Windows.Forms.Label();
            this.lblEsperaTitulo = new System.Windows.Forms.Label();
            this.lblHorarioTurno = new System.Windows.Forms.Label();
            this.lblAtendidos = new System.Windows.Forms.Label();
            this.lblEnEspera = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlNumero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrent
            // 
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCurrent.Location = new System.Drawing.Point(131, 32);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(100, 23);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Atendiendo Ahora";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(98, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(188, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Número de Turno";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNumero
            // 
            this.pnlNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNumero.Controls.Add(this.lblNumeroTurno);
            this.pnlNumero.Location = new System.Drawing.Point(23, 119);
            this.pnlNumero.Name = "pnlNumero";
            this.pnlNumero.Size = new System.Drawing.Size(331, 166);
            this.pnlNumero.TabIndex = 2;
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTurno.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNumeroTurno.Location = new System.Drawing.Point(82, 26);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(125, 106);
            this.lblNumeroTurno.TabIndex = 0;
            this.lblNumeroTurno.Text = "—";
            this.lblNumeroTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEsperaTitulo
            // 
            this.lblEsperaTitulo.AutoSize = true;
            this.lblEsperaTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperaTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblEsperaTitulo.Location = new System.Drawing.Point(131, 297);
            this.lblEsperaTitulo.Name = "lblEsperaTitulo";
            this.lblEsperaTitulo.Size = new System.Drawing.Size(113, 20);
            this.lblEsperaTitulo.TabIndex = 3;
            this.lblEsperaTitulo.Text = "Hora del Turno";
            this.lblEsperaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHorarioTurno
            // 
            this.lblHorarioTurno.AutoSize = true;
            this.lblHorarioTurno.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioTurno.ForeColor = System.Drawing.Color.Navy;
            this.lblHorarioTurno.Location = new System.Drawing.Point(151, 337);
            this.lblHorarioTurno.Name = "lblHorarioTurno";
            this.lblHorarioTurno.Size = new System.Drawing.Size(68, 37);
            this.lblHorarioTurno.TabIndex = 4;
            this.lblHorarioTurno.Text = "--:--";
            this.lblHorarioTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAtendidos
            // 
            this.lblAtendidos.AutoSize = true;
            this.lblAtendidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendidos.ForeColor = System.Drawing.Color.Gray;
            this.lblAtendidos.Location = new System.Drawing.Point(44, 410);
            this.lblAtendidos.Name = "lblAtendidos";
            this.lblAtendidos.Size = new System.Drawing.Size(96, 15);
            this.lblAtendidos.TabIndex = 5;
            this.lblAtendidos.Text = "Atendidos hoy: 0";
            this.lblAtendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnEspera
            // 
            this.lblEnEspera.AutoSize = true;
            this.lblEnEspera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnEspera.ForeColor = System.Drawing.Color.Gray;
            this.lblEnEspera.Location = new System.Drawing.Point(44, 450);
            this.lblEnEspera.Name = "lblEnEspera";
            this.lblEnEspera.Size = new System.Drawing.Size(69, 15);
            this.lblEnEspera.TabIndex = 6;
            this.lblEnEspera.Text = "En espera: 0";
            this.lblEnEspera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            // 
            // FormTurnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 511);
            this.Controls.Add(this.lblEnEspera);
            this.Controls.Add(this.lblAtendidos);
            this.Controls.Add(this.lblHorarioTurno);
            this.Controls.Add(this.lblEsperaTitulo);
            this.Controls.Add(this.pnlNumero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCurrent);
            this.Name = "FormTurnero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnero";
            this.Load += new System.EventHandler(this.FormTurnero_Load);
            this.pnlNumero.ResumeLayout(false);
            this.pnlNumero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlNumero;
        private System.Windows.Forms.Label lblNumeroTurno;
        private System.Windows.Forms.Label lblEsperaTitulo;
        private System.Windows.Forms.Label lblHorarioTurno;
        private System.Windows.Forms.Label lblAtendidos;
        private System.Windows.Forms.Label lblEnEspera;
        private System.Windows.Forms.Timer timer1;
    }
}