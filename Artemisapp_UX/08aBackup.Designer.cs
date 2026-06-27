namespace Artemisapp_UX
{
    partial class _08aBackup
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
            this.btnRealizarBackup = new System.Windows.Forms.Button();
            this.lblResultadoBackup = new System.Windows.Forms.Label();
            this.dgvBackups = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdUsuarioBackup = new System.Windows.Forms.TextBox();
            this.txtUsuarioBackup = new System.Windows.Forms.TextBox();
            this.btnLimpiarBackup = new System.Windows.Forms.Button();
            this.btnSalirBackup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackups)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRealizarBackup
            // 
            this.btnRealizarBackup.Location = new System.Drawing.Point(4, 16);
            this.btnRealizarBackup.Name = "btnRealizarBackup";
            this.btnRealizarBackup.Size = new System.Drawing.Size(255, 42);
            this.btnRealizarBackup.TabIndex = 0;
            this.btnRealizarBackup.Text = "Realizar Backup";
            this.btnRealizarBackup.UseVisualStyleBackColor = true;
            this.btnRealizarBackup.Click += new System.EventHandler(this.btnRealizarBackup_Click);
            // 
            // lblResultadoBackup
            // 
            this.lblResultadoBackup.AutoSize = true;
            this.lblResultadoBackup.Location = new System.Drawing.Point(131, 77);
            this.lblResultadoBackup.Name = "lblResultadoBackup";
            this.lblResultadoBackup.Size = new System.Drawing.Size(128, 13);
            this.lblResultadoBackup.TabIndex = 1;
            this.lblResultadoBackup.Text = "Listo para realizar backup";
            // 
            // dgvBackups
            // 
            this.dgvBackups.AllowUserToAddRows = false;
            this.dgvBackups.AllowUserToDeleteRows = false;
            this.dgvBackups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackups.Location = new System.Drawing.Point(36, 67);
            this.dgvBackups.Name = "dgvBackups";
            this.dgvBackups.ReadOnly = true;
            this.dgvBackups.RowHeadersVisible = false;
            this.dgvBackups.Size = new System.Drawing.Size(301, 335);
            this.dgvBackups.TabIndex = 2;
            this.dgvBackups.SelectionChanged += new System.EventHandler(this.dgvBackups_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Historial de Backups ⌚";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuarioBackup);
            this.groupBox1.Controls.Add(this.txtIdUsuarioBackup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(353, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del usuario que realizó el backup:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuario";
            // 
            // txtIdUsuarioBackup
            // 
            this.txtIdUsuarioBackup.Location = new System.Drawing.Point(101, 63);
            this.txtIdUsuarioBackup.Name = "txtIdUsuarioBackup";
            this.txtIdUsuarioBackup.ReadOnly = true;
            this.txtIdUsuarioBackup.Size = new System.Drawing.Size(149, 20);
            this.txtIdUsuarioBackup.TabIndex = 2;
            // 
            // txtUsuarioBackup
            // 
            this.txtUsuarioBackup.Location = new System.Drawing.Point(101, 97);
            this.txtUsuarioBackup.Name = "txtUsuarioBackup";
            this.txtUsuarioBackup.ReadOnly = true;
            this.txtUsuarioBackup.Size = new System.Drawing.Size(149, 20);
            this.txtUsuarioBackup.TabIndex = 3;
            // 
            // btnLimpiarBackup
            // 
            this.btnLimpiarBackup.Location = new System.Drawing.Point(6, 65);
            this.btnLimpiarBackup.Name = "btnLimpiarBackup";
            this.btnLimpiarBackup.Size = new System.Drawing.Size(96, 37);
            this.btnLimpiarBackup.TabIndex = 5;
            this.btnLimpiarBackup.Text = "Limpiar Campos";
            this.btnLimpiarBackup.UseVisualStyleBackColor = true;
            this.btnLimpiarBackup.Click += new System.EventHandler(this.btnLimpiarBackup_Click);
            // 
            // btnSalirBackup
            // 
            this.btnSalirBackup.Location = new System.Drawing.Point(160, 14);
            this.btnSalirBackup.Name = "btnSalirBackup";
            this.btnSalirBackup.Size = new System.Drawing.Size(96, 25);
            this.btnSalirBackup.TabIndex = 6;
            this.btnSalirBackup.Text = "Salir";
            this.btnSalirBackup.UseVisualStyleBackColor = true;
            this.btnSalirBackup.Click += new System.EventHandler(this.btnSalirBackup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiarBackup);
            this.groupBox2.Controls.Add(this.btnRealizarBackup);
            this.groupBox2.Controls.Add(this.lblResultadoBackup);
            this.groupBox2.Location = new System.Drawing.Point(353, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalirBackup);
            this.groupBox3.Location = new System.Drawing.Point(356, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 45);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // _08aBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBackups);
            this.Name = "_08aBackup";
            this.Text = "_08aBackup";
            this.Load += new System.EventHandler(this._08aBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackups)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRealizarBackup;
        private System.Windows.Forms.Label lblResultadoBackup;
        private System.Windows.Forms.DataGridView dgvBackups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioBackup;
        private System.Windows.Forms.TextBox txtIdUsuarioBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarBackup;
        private System.Windows.Forms.Button btnSalirBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}