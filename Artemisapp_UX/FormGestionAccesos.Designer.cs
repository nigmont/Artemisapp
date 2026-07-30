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
            this.label6 = new System.Windows.Forms.Label();
            this.treeUsuariosRolesPermisos = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.treeRolesPermisos = new System.Windows.Forms.TreeView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombrePermiso = new System.Windows.Forms.TextBox();
            this.btnCrearPermiso = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizarArboles = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(13, 65);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(140, 251);
            this.lstUsuarios.TabIndex = 0;
            this.lstUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstUsuarios_SelectedIndexChanged);
            // 
            // lstRoles
            // 
            this.lstRoles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.Location = new System.Drawing.Point(169, 65);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(147, 251);
            this.lstRoles.TabIndex = 1;
            this.lstRoles.SelectedIndexChanged += new System.EventHandler(this.lstRoles_SelectedIndexChanged);
            // 
            // lstPermisos
            // 
            this.lstPermisos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPermisos.FormattingEnabled = true;
            this.lstPermisos.Location = new System.Drawing.Point(335, 65);
            this.lstPermisos.Name = "lstPermisos";
            this.lstPermisos.Size = new System.Drawing.Size(147, 251);
            this.lstPermisos.TabIndex = 2;
            this.lstPermisos.SelectedIndexChanged += new System.EventHandler(this.lstPermisos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Roles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 41);
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
            this.txtNombreRol.Location = new System.Drawing.Point(11, 41);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(228, 25);
            this.txtNombreRol.TabIndex = 7;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRol.Location = new System.Drawing.Point(11, 99);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(111, 43);
            this.btnCrearRol.TabIndex = 8;
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCrearPermiso);
            this.groupBox1.Controls.Add(this.txtNombrePermiso);
            this.groupBox1.Controls.Add(this.btnCrearRol);
            this.groupBox1.Controls.Add(this.txtNombreRol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(550, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 158);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Creación de Roles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiarCampos);
            this.groupBox2.Controls.Add(this.btnEliminarUsuario);
            this.groupBox2.Controls.Add(this.btnModificarUsuario);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnCrearUsuario);
            this.groupBox2.Controls.Add(this.chbxEncriptar);
            this.groupBox2.Controls.Add(this.txtNuevoDni);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNuevaPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNuevoUsuario);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 158);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Creación de Usuario";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCrearUsuario.Location = new System.Drawing.Point(19, 99);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(110, 45);
            this.btnCrearUsuario.TabIndex = 6;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // chbxEncriptar
            // 
            this.chbxEncriptar.AutoSize = true;
            this.chbxEncriptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxEncriptar.Location = new System.Drawing.Point(19, 72);
            this.chbxEncriptar.Name = "chbxEncriptar";
            this.chbxEncriptar.Size = new System.Drawing.Size(158, 21);
            this.chbxEncriptar.TabIndex = 6;
            this.chbxEncriptar.Text = "Encriptar/Desencriptar";
            this.chbxEncriptar.UseVisualStyleBackColor = true;
            this.chbxEncriptar.CheckedChanged += new System.EventHandler(this.chbxEncriptar_CheckedChanged);
            // 
            // txtNuevoDni
            // 
            this.txtNuevoDni.Location = new System.Drawing.Point(257, 41);
            this.txtNuevoDni.Name = "txtNuevoDni";
            this.txtNuevoDni.Size = new System.Drawing.Size(111, 25);
            this.txtNuevoDni.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(254, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "DNI:";
            // 
            // txtNuevaPassword
            // 
            this.txtNuevaPassword.Location = new System.Drawing.Point(139, 41);
            this.txtNuevaPassword.Name = "txtNuevaPassword";
            this.txtNuevaPassword.Size = new System.Drawing.Size(112, 25);
            this.txtNuevaPassword.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contraseña:";
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(19, 41);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(111, 25);
            this.txtNuevoUsuario.TabIndex = 1;
            // 
            // btnAsignarPermisoRol
            // 
            this.btnAsignarPermisoRol.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermisoRol.Location = new System.Drawing.Point(335, 321);
            this.btnAsignarPermisoRol.Name = "btnAsignarPermisoRol";
            this.btnAsignarPermisoRol.Size = new System.Drawing.Size(147, 36);
            this.btnAsignarPermisoRol.TabIndex = 14;
            this.btnAsignarPermisoRol.Text = "Asignar Permiso al Rol";
            this.btnAsignarPermisoRol.UseVisualStyleBackColor = true;
            this.btnAsignarPermisoRol.Click += new System.EventHandler(this.btnAsignarPermisoRol_Click);
            // 
            // btnAsignarRolUsuario
            // 
            this.btnAsignarRolUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRolUsuario.Location = new System.Drawing.Point(13, 322);
            this.btnAsignarRolUsuario.Name = "btnAsignarRolUsuario";
            this.btnAsignarRolUsuario.Size = new System.Drawing.Size(303, 35);
            this.btnAsignarRolUsuario.TabIndex = 16;
            this.btnAsignarRolUsuario.Text = "Asignarle a un Usuario un Rol →";
            this.btnAsignarRolUsuario.UseVisualStyleBackColor = true;
            this.btnAsignarRolUsuario.Click += new System.EventHandler(this.btnAsignarRolUsuario_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 58);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 30);
            this.label10.TabIndex = 0;
            this.label10.Text = "👨 Gestión de Accesos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizarArboles);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1026, 375);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Control y Distribución de Accesos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Roles y Permisos User";
            // 
            // treeUsuariosRolesPermisos
            // 
            this.treeUsuariosRolesPermisos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeUsuariosRolesPermisos.Location = new System.Drawing.Point(777, 65);
            this.treeUsuariosRolesPermisos.Name = "treeUsuariosRolesPermisos";
            this.treeUsuariosRolesPermisos.Size = new System.Drawing.Size(225, 292);
            this.treeUsuariosRolesPermisos.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Jerarquia de Roles y Permisos";
            // 
            // treeRolesPermisos
            // 
            this.treeRolesPermisos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeRolesPermisos.Location = new System.Drawing.Point(538, 65);
            this.treeRolesPermisos.Name = "treeRolesPermisos";
            this.treeRolesPermisos.Size = new System.Drawing.Size(225, 292);
            this.treeRolesPermisos.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Usuario";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.Orange;
            this.btnModificarUsuario.Location = new System.Drawing.Point(135, 101);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(111, 43);
            this.btnModificarUsuario.TabIndex = 8;
            this.btnModificarUsuario.Text = "Editar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.ForeColor = System.Drawing.Color.Crimson;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(252, 100);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(111, 44);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(128, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modif. Rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(245, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "Eliminar Rol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNombrePermiso
            // 
            this.txtNombrePermiso.Location = new System.Drawing.Point(467, 41);
            this.txtNombrePermiso.Name = "txtNombrePermiso";
            this.txtNombrePermiso.ReadOnly = true;
            this.txtNombrePermiso.Size = new System.Drawing.Size(120, 25);
            this.txtNombrePermiso.TabIndex = 9;
            this.txtNombrePermiso.Visible = false;
            // 
            // btnCrearPermiso
            // 
            this.btnCrearPermiso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPermiso.Location = new System.Drawing.Point(467, 100);
            this.btnCrearPermiso.Name = "btnCrearPermiso";
            this.btnCrearPermiso.Size = new System.Drawing.Size(111, 41);
            this.btnCrearPermiso.TabIndex = 11;
            this.btnCrearPermiso.Text = "Crear Permiso";
            this.btnCrearPermiso.UseVisualStyleBackColor = true;
            this.btnCrearPermiso.Visible = false;
            this.btnCrearPermiso.Click += new System.EventHandler(this.btnCrearPermiso_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(387, 41);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(65, 25);
            this.btnLimpiarCampos.TabIndex = 23;
            this.btnLimpiarCampos.Text = "Limpiar";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnActualizarArboles
            // 
            this.btnActualizarArboles.Location = new System.Drawing.Point(909, 14);
            this.btnActualizarArboles.Name = "btnActualizarArboles";
            this.btnActualizarArboles.Size = new System.Drawing.Size(93, 31);
            this.btnActualizarArboles.TabIndex = 21;
            this.btnActualizarArboles.Text = "Actualizar";
            this.btnActualizarArboles.UseVisualStyleBackColor = true;
            this.btnActualizarArboles.Click += new System.EventHandler(this.btnActualizarArboles_Click);
            // 
            // FormGestionAccesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGestionAccesos";
            this.Text = "Artemisapp - Gestión de Accesos";
            this.Load += new System.EventHandler(this.FormGestionAccesos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeRolesPermisos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeUsuariosRolesPermisos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearPermiso;
        private System.Windows.Forms.TextBox txtNombrePermiso;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizarArboles;
    }
}