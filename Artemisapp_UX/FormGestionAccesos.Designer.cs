namespace Artemisapp_UX
{
    partial class FormGestionAccesos
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
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.lstRoles = new System.Windows.Forms.ListBox();
            this.lstPermisos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.txtNombrePermiso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearPermiso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.chbxEncriptar = new System.Windows.Forms.CheckBox();
            this.txtNuevoDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNuevaPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.btnAsignarPermisoRol = new System.Windows.Forms.Button();
            this.btnAsignarRolUsuario = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeRolesPermisos = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.treeUsuariosRolesPermisos = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(11, 65);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(147, 368);
            this.lstUsuarios.TabIndex = 0;
            // 
            // lstRoles
            // 
            this.lstRoles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.Location = new System.Drawing.Point(183, 65);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(147, 368);
            this.lstRoles.TabIndex = 1;
            // 
            // lstPermisos
            // 
            this.lstPermisos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPermisos.FormattingEnabled = true;
            this.lstPermisos.Location = new System.Drawing.Point(348, 67);
            this.lstPermisos.Name = "lstPermisos";
            this.lstPermisos.Size = new System.Drawing.Size(147, 368);
            this.lstPermisos.TabIndex = 2;
            this.lstPermisos.SelectedIndexChanged += new System.EventHandler(this.lstPermisos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Roles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permisos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre de Rol";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(6, 50);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(171, 25);
            this.txtNombreRol.TabIndex = 7;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRol.Location = new System.Drawing.Point(6, 81);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(172, 30);
            this.btnCrearRol.TabIndex = 8;
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // txtNombrePermiso
            // 
            this.txtNombrePermiso.Location = new System.Drawing.Point(7, 138);
            this.txtNombrePermiso.Name = "txtNombrePermiso";
            this.txtNombrePermiso.ReadOnly = true;
            this.txtNombrePermiso.Size = new System.Drawing.Size(171, 25);
            this.txtNombrePermiso.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(7, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre del Permiso";
            // 
            // btnCrearPermiso
            // 
            this.btnCrearPermiso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPermiso.Location = new System.Drawing.Point(7, 169);
            this.btnCrearPermiso.Name = "btnCrearPermiso";
            this.btnCrearPermiso.Size = new System.Drawing.Size(171, 30);
            this.btnCrearPermiso.TabIndex = 11;
            this.btnCrearPermiso.Text = "Crear Permiso";
            this.btnCrearPermiso.UseVisualStyleBackColor = true;
            this.btnCrearPermiso.Click += new System.EventHandler(this.btnCrearPermiso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearPermiso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombrePermiso);
            this.groupBox1.Controls.Add(this.btnCrearRol);
            this.groupBox1.Controls.Add(this.txtNombreRol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(20, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 217);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Roles y Permisos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCrearUsuario);
            this.groupBox2.Controls.Add(this.chbxEncriptar);
            this.groupBox2.Controls.Add(this.txtNuevoDni);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNuevaPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNuevoUsuario);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 244);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre de usuario";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(6, 180);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(172, 30);
            this.btnCrearUsuario.TabIndex = 6;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // chbxEncriptar
            // 
            this.chbxEncriptar.AutoSize = true;
            this.chbxEncriptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxEncriptar.Location = new System.Drawing.Point(19, 105);
            this.chbxEncriptar.Name = "chbxEncriptar";
            this.chbxEncriptar.Size = new System.Drawing.Size(158, 21);
            this.chbxEncriptar.TabIndex = 6;
            this.chbxEncriptar.Text = "Encriptar/Desencriptar";
            this.chbxEncriptar.UseVisualStyleBackColor = true;
            this.chbxEncriptar.CheckedChanged += new System.EventHandler(this.chbxEncriptar_CheckedChanged);
            // 
            // txtNuevoDni
            // 
            this.txtNuevoDni.Location = new System.Drawing.Point(7, 149);
            this.txtNuevoDni.Name = "txtNuevoDni";
            this.txtNuevoDni.Size = new System.Drawing.Size(171, 25);
            this.txtNuevoDni.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "DNI:";
            // 
            // txtNuevaPassword
            // 
            this.txtNuevaPassword.Location = new System.Drawing.Point(6, 74);
            this.txtNuevaPassword.Name = "txtNuevaPassword";
            this.txtNuevaPassword.Size = new System.Drawing.Size(171, 25);
            this.txtNuevaPassword.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contraseña:";
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(6, 25);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(171, 25);
            this.txtNuevoUsuario.TabIndex = 1;
            // 
            // btnAsignarPermisoRol
            // 
            this.btnAsignarPermisoRol.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermisoRol.Location = new System.Drawing.Point(280, 25);
            this.btnAsignarPermisoRol.Name = "btnAsignarPermisoRol";
            this.btnAsignarPermisoRol.Size = new System.Drawing.Size(117, 36);
            this.btnAsignarPermisoRol.TabIndex = 14;
            this.btnAsignarPermisoRol.Text = "Asignar Permiso al Rol";
            this.btnAsignarPermisoRol.UseVisualStyleBackColor = true;
            this.btnAsignarPermisoRol.Click += new System.EventHandler(this.btnAsignarPermisoRol_Click);
            // 
            // btnAsignarRolUsuario
            // 
            this.btnAsignarRolUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRolUsuario.Location = new System.Drawing.Point(110, 24);
            this.btnAsignarRolUsuario.Name = "btnAsignarRolUsuario";
            this.btnAsignarRolUsuario.Size = new System.Drawing.Size(117, 38);
            this.btnAsignarRolUsuario.TabIndex = 16;
            this.btnAsignarRolUsuario.Text = "Asignar Rol a Usuario";
            this.btnAsignarRolUsuario.UseVisualStyleBackColor = true;
            this.btnAsignarRolUsuario.Click += new System.EventHandler(this.btnAsignarRolUsuario_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 58);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gestión de Accesos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.treeUsuariosRolesPermisos);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.treeRolesPermisos);
            this.groupBox3.Controls.Add(this.btnAsignarPermisoRol);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lstPermisos);
            this.groupBox3.Controls.Add(this.lstRoles);
            this.groupBox3.Controls.Add(this.btnAsignarRolUsuario);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lstUsuarios);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(215, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(903, 464);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control y Distribución de Accesos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Artemisapp_UX.Properties.Resources.Fondo_MenuStrip;
            this.pictureBox1.Location = new System.Drawing.Point(900, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // treeRolesPermisos
            // 
            this.treeRolesPermisos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeRolesPermisos.Location = new System.Drawing.Point(539, 67);
            this.treeRolesPermisos.Name = "treeRolesPermisos";
            this.treeRolesPermisos.Size = new System.Drawing.Size(181, 368);
            this.treeRolesPermisos.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Jerarquia de Roles y Permisos";
            // 
            // treeUsuariosRolesPermisos
            // 
            this.treeUsuariosRolesPermisos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeUsuariosRolesPermisos.Location = new System.Drawing.Point(726, 67);
            this.treeUsuariosRolesPermisos.Name = "treeUsuariosRolesPermisos";
            this.treeUsuariosRolesPermisos.Size = new System.Drawing.Size(168, 369);
            this.treeUsuariosRolesPermisos.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(726, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Roles y Permisos User";
            // 
            // FormGestionAccesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionAccesos";
            this.Text = "FormGestionAccesos";
            this.Load += new System.EventHandler(this.FormGestionAccesos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.ListBox lstRoles;
        private System.Windows.Forms.ListBox lstPermisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.TextBox txtNombrePermiso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearPermiso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox txtNuevoDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNuevaPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Button btnAsignarPermisoRol;
        private System.Windows.Forms.Button btnAsignarRolUsuario;
        private System.Windows.Forms.CheckBox chbxEncriptar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeRolesPermisos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeUsuariosRolesPermisos;
    }
}