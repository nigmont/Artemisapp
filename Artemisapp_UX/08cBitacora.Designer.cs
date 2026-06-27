namespace Artemisapp_UX
{
    partial class _08cBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUsuarioBitacora = new System.Windows.Forms.TextBox();
            this.txtUsuarioBitacora = new System.Windows.Forms.TextBox();
            this.rbSoloBackups = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSoloRestores = new System.Windows.Forms.RadioButton();
            this.btnRecargarBitacora = new System.Windows.Forms.Button();
            this.btnExitBitacora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Eventos 🐾";
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBitacora.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBitacora.Location = new System.Drawing.Point(20, 112);
            this.dgvBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.Size = new System.Drawing.Size(345, 389);
            this.dgvBitacora.TabIndex = 1;
            this.dgvBitacora.SelectionChanged += new System.EventHandler(this.dgvBitacora_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Artemisapp_UX.Properties.Resources.esquina;
            this.pictureBox1.Location = new System.Drawing.Point(300, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario";
            // 
            // txtIdUsuarioBitacora
            // 
            this.txtIdUsuarioBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuarioBitacora.Location = new System.Drawing.Point(74, 45);
            this.txtIdUsuarioBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdUsuarioBitacora.Name = "txtIdUsuarioBitacora";
            this.txtIdUsuarioBitacora.ReadOnly = true;
            this.txtIdUsuarioBitacora.Size = new System.Drawing.Size(212, 26);
            this.txtIdUsuarioBitacora.TabIndex = 6;
            // 
            // txtUsuarioBitacora
            // 
            this.txtUsuarioBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioBitacora.Location = new System.Drawing.Point(74, 102);
            this.txtUsuarioBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuarioBitacora.Name = "txtUsuarioBitacora";
            this.txtUsuarioBitacora.ReadOnly = true;
            this.txtUsuarioBitacora.Size = new System.Drawing.Size(212, 26);
            this.txtUsuarioBitacora.TabIndex = 7;
            // 
            // rbSoloBackups
            // 
            this.rbSoloBackups.AutoSize = true;
            this.rbSoloBackups.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSoloBackups.Location = new System.Drawing.Point(4, 30);
            this.rbSoloBackups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSoloBackups.Name = "rbSoloBackups";
            this.rbSoloBackups.Size = new System.Drawing.Size(137, 21);
            this.rbSoloBackups.TabIndex = 8;
            this.rbSoloBackups.TabStop = true;
            this.rbSoloBackups.Text = "Listar solo Backups";
            this.rbSoloBackups.UseVisualStyleBackColor = true;
            this.rbSoloBackups.CheckedChanged += new System.EventHandler(this.rbSoloBackups_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtUsuarioBitacora);
            this.groupBox1.Controls.Add(this.txtIdUsuarioBitacora);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(369, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 172);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Usuario Seleccionado";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnExitBitacora);
            this.groupBox2.Controls.Add(this.btnRecargarBitacora);
            this.groupBox2.Controls.Add(this.rbSoloRestores);
            this.groupBox2.Controls.Add(this.rbSoloBackups);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(369, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(301, 183);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // rbSoloRestores
            // 
            this.rbSoloRestores.AutoSize = true;
            this.rbSoloRestores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSoloRestores.Location = new System.Drawing.Point(145, 30);
            this.rbSoloRestores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSoloRestores.Name = "rbSoloRestores";
            this.rbSoloRestores.Size = new System.Drawing.Size(141, 21);
            this.rbSoloRestores.TabIndex = 9;
            this.rbSoloRestores.TabStop = true;
            this.rbSoloRestores.Text = "Listar solo Restores";
            this.rbSoloRestores.UseVisualStyleBackColor = true;
            this.rbSoloRestores.CheckedChanged += new System.EventHandler(this.rbSoloRestores_CheckedChanged);
            // 
            // btnRecargarBitacora
            // 
            this.btnRecargarBitacora.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRecargarBitacora.Location = new System.Drawing.Point(4, 65);
            this.btnRecargarBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecargarBitacora.Name = "btnRecargarBitacora";
            this.btnRecargarBitacora.Size = new System.Drawing.Size(282, 29);
            this.btnRecargarBitacora.TabIndex = 10;
            this.btnRecargarBitacora.Text = "Recargar Bitácora";
            this.btnRecargarBitacora.UseVisualStyleBackColor = true;
            this.btnRecargarBitacora.Click += new System.EventHandler(this.btnRecargarBitacora_Click);
            // 
            // btnExitBitacora
            // 
            this.btnExitBitacora.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExitBitacora.Location = new System.Drawing.Point(241, 151);
            this.btnExitBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitBitacora.Name = "btnExitBitacora";
            this.btnExitBitacora.Size = new System.Drawing.Size(56, 28);
            this.btnExitBitacora.TabIndex = 11;
            this.btnExitBitacora.Text = "Salir";
            this.btnExitBitacora.UseVisualStyleBackColor = true;
            this.btnExitBitacora.Click += new System.EventHandler(this.btnExitBitacora_Click);
            // 
            // _08cBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "_08cBitacora";
            this.Text = "_08cBitacora";
            this.Load += new System.EventHandler(this._08cBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdUsuarioBitacora;
        private System.Windows.Forms.TextBox txtUsuarioBitacora;
        private System.Windows.Forms.RadioButton rbSoloBackups;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSoloRestores;
        private System.Windows.Forms.Button btnExitBitacora;
        private System.Windows.Forms.Button btnRecargarBitacora;
    }
}