namespace Artemisapp_UX
{
    partial class FormPermisoUsuario
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
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPermisos
            // 
            this.txtPermisos.Location = new System.Drawing.Point(80, 63);
            this.txtPermisos.Multiline = true;
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPermisos.Size = new System.Drawing.Size(231, 363);
            this.txtPermisos.TabIndex = 0;
            // 
            // FormPermisoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPermisos);
            this.Name = "FormPermisoUsuario";
            this.Text = "FormPermisoUsuario";
            this.Load += new System.EventHandler(this.FormPermisoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPermisos;
    }
}