namespace Artemisapp_UX
{
    partial class FormMenuInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTurnos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoriaClinica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCobrarConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaseDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.manuCambiarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicio,
            this.menuUsuarios,
            this.menuProductos,
            this.menuClientes,
            this.menuTurnos,
            this.menuHistoriaClinica,
            this.menuCobrarConsulta,
            this.menuBaseDatos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuInicio
            // 
            this.menuInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuCambiarUsuario,
            this.menuSalir});
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(48, 20);
            this.menuInicio.Text = "Inicio";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.menuUsuarios.Tag = "Gestionar Usuarios";
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(73, 20);
            this.menuProductos.Tag = "gestionar Productos";
            this.menuProductos.Text = "Productos";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(61, 20);
            this.menuClientes.Tag = "Gestionar Clientes";
            this.menuClientes.Text = "Clientes";
            // 
            // menuTurnos
            // 
            this.menuTurnos.Name = "menuTurnos";
            this.menuTurnos.Size = new System.Drawing.Size(55, 20);
            this.menuTurnos.Tag = "Gestionar Turnos";
            this.menuTurnos.Text = "Turnos";
            // 
            // menuHistoriaClinica
            // 
            this.menuHistoriaClinica.Name = "menuHistoriaClinica";
            this.menuHistoriaClinica.Size = new System.Drawing.Size(99, 20);
            this.menuHistoriaClinica.Tag = "Gestionar Historia Clinica";
            this.menuHistoriaClinica.Text = "Historia Clinica";
            // 
            // menuCobrarConsulta
            // 
            this.menuCobrarConsulta.Name = "menuCobrarConsulta";
            this.menuCobrarConsulta.Size = new System.Drawing.Size(105, 20);
            this.menuCobrarConsulta.Tag = "Cobrar Consulta";
            this.menuCobrarConsulta.Text = "Cobrar Consulta";
            // 
            // menuBaseDatos
            // 
            this.menuBaseDatos.Name = "menuBaseDatos";
            this.menuBaseDatos.Size = new System.Drawing.Size(92, 20);
            this.menuBaseDatos.Tag = "Gestionar Roles y Permisos";
            this.menuBaseDatos.Text = "Gestión BBDD";
            // 
            // manuCambiarUsuario
            // 
            this.manuCambiarUsuario.Name = "manuCambiarUsuario";
            this.manuCambiarUsuario.Size = new System.Drawing.Size(180, 22);
            this.manuCambiarUsuario.Text = "Cambiar Usuario";
            this.manuCambiarUsuario.Click += new System.EventHandler(this.manuCambiarUsuario_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(180, 22);
            this.menuSalir.Text = "Salir →";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // FormMenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuInicio";
            this.Text = "FormMenuInicio";
            this.Load += new System.EventHandler(this.FormMenuInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuInicio;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuTurnos;
        private System.Windows.Forms.ToolStripMenuItem menuHistoriaClinica;
        private System.Windows.Forms.ToolStripMenuItem menuCobrarConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuBaseDatos;
        private System.Windows.Forms.ToolStripMenuItem manuCambiarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
    }
}