namespace Artemisapp_UX
{
    partial class _08bRestore
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
            this.lstBackups = new System.Windows.Forms.ListBox();
            this.btnRealizarRestore = new System.Windows.Forms.Button();
            this.btnRecargarBackups = new System.Windows.Forms.Button();
            this.btnSalirRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backups disponibles para realizar Restore";
            // 
            // lstBackups
            // 
            this.lstBackups.FormattingEnabled = true;
            this.lstBackups.Location = new System.Drawing.Point(23, 57);
            this.lstBackups.Name = "lstBackups";
            this.lstBackups.Size = new System.Drawing.Size(294, 277);
            this.lstBackups.TabIndex = 1;
            // 
            // btnRealizarRestore
            // 
            this.btnRealizarRestore.Location = new System.Drawing.Point(23, 340);
            this.btnRealizarRestore.Name = "btnRealizarRestore";
            this.btnRealizarRestore.Size = new System.Drawing.Size(126, 38);
            this.btnRealizarRestore.TabIndex = 2;
            this.btnRealizarRestore.Text = "Realizar Restore";
            this.btnRealizarRestore.UseVisualStyleBackColor = true;
            this.btnRealizarRestore.Click += new System.EventHandler(this.btnRealizarRestore_Click);
            // 
            // btnRecargarBackups
            // 
            this.btnRecargarBackups.Location = new System.Drawing.Point(192, 340);
            this.btnRecargarBackups.Name = "btnRecargarBackups";
            this.btnRecargarBackups.Size = new System.Drawing.Size(126, 38);
            this.btnRecargarBackups.TabIndex = 3;
            this.btnRecargarBackups.Text = "Recargar Datos";
            this.btnRecargarBackups.UseVisualStyleBackColor = true;
            this.btnRecargarBackups.Click += new System.EventHandler(this.btnRecargarBackups_Click);
            // 
            // btnSalirRestore
            // 
            this.btnSalirRestore.Location = new System.Drawing.Point(244, 413);
            this.btnSalirRestore.Name = "btnSalirRestore";
            this.btnSalirRestore.Size = new System.Drawing.Size(74, 25);
            this.btnSalirRestore.TabIndex = 4;
            this.btnSalirRestore.Text = "Salir";
            this.btnSalirRestore.UseVisualStyleBackColor = true;
            this.btnSalirRestore.Click += new System.EventHandler(this.btnSalirRestore_Click);
            // 
            // _08bRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.btnSalirRestore);
            this.Controls.Add(this.btnRecargarBackups);
            this.Controls.Add(this.btnRealizarRestore);
            this.Controls.Add(this.lstBackups);
            this.Controls.Add(this.label1);
            this.Name = "_08bRestore";
            this.Text = "_08bRestore";
            this.Load += new System.EventHandler(this._08bRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBackups;
        private System.Windows.Forms.Button btnRealizarRestore;
        private System.Windows.Forms.Button btnRecargarBackups;
        private System.Windows.Forms.Button btnSalirRestore;
    }
}