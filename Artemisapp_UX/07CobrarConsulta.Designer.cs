namespace Artemisapp_UX
{
    partial class _07CobrarConsulta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClienteNumero = new System.Windows.Forms.Label();
            this.btnBuscarNroCte = new System.Windows.Forms.Button();
            this.lstbProductos = new System.Windows.Forms.ListBox();
            this.txtClienteFacturacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblTotalParcial = new System.Windows.Forms.Label();
            this.gbMediosDePago = new System.Windows.Forms.GroupBox();
            this.rbMercadoPago = new System.Windows.Forms.RadioButton();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.txtNumeroDeTarjeta = new System.Windows.Forms.TextBox();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.rbTarjetaDeCredito = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.btnCobrarYFinalizar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.lblMontoPendiente = new System.Windows.Forms.Label();
            this.lblTotalACobrar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescuentoIva = new System.Windows.Forms.TextBox();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.txtTotalParcial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gbMediosDePago.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblClienteNumero);
            this.groupBox1.Controls.Add(this.btnBuscarNroCte);
            this.groupBox1.Controls.Add(this.txtClienteFacturacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente y Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(186, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente n°:";
            // 
            // lblClienteNumero
            // 
            this.lblClienteNumero.AutoSize = true;
            this.lblClienteNumero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNumero.Location = new System.Drawing.Point(256, 31);
            this.lblClienteNumero.Name = "lblClienteNumero";
            this.lblClienteNumero.Size = new System.Drawing.Size(16, 15);
            this.lblClienteNumero.TabIndex = 9;
            this.lblClienteNumero.Text = "...";
            // 
            // btnBuscarNroCte
            // 
            this.btnBuscarNroCte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNroCte.Location = new System.Drawing.Point(212, 81);
            this.btnBuscarNroCte.Name = "btnBuscarNroCte";
            this.btnBuscarNroCte.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNroCte.TabIndex = 8;
            this.btnBuscarNroCte.Text = "Buscar";
            this.btnBuscarNroCte.UseVisualStyleBackColor = true;
            this.btnBuscarNroCte.Click += new System.EventHandler(this.btnBuscarNroCte_Click);
            // 
            // lstbProductos
            // 
            this.lstbProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbProductos.FormattingEnabled = true;
            this.lstbProductos.ItemHeight = 17;
            this.lstbProductos.Location = new System.Drawing.Point(16, 42);
            this.lstbProductos.Name = "lstbProductos";
            this.lstbProductos.Size = new System.Drawing.Size(533, 157);
            this.lstbProductos.TabIndex = 7;
            this.lstbProductos.SelectedIndexChanged += new System.EventHandler(this.lstbProductos_SelectedIndexChanged_1);
            // 
            // txtClienteFacturacion
            // 
            this.txtClienteFacturacion.Location = new System.Drawing.Point(6, 49);
            this.txtClienteFacturacion.Name = "txtClienteFacturacion";
            this.txtClienteFacturacion.Size = new System.Drawing.Size(282, 29);
            this.txtClienteFacturacion.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(16, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Elegir las opciones con un click:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIva.Location = new System.Drawing.Point(6, 144);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(51, 16);
            this.lblIva.TabIndex = 9;
            this.lblIva.Text = "IVA (%)";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDescuentos.Location = new System.Drawing.Point(6, 97);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(79, 16);
            this.lblDescuentos.TabIndex = 8;
            this.lblDescuentos.Text = "Descuentos";
            // 
            // lblTotalParcial
            // 
            this.lblTotalParcial.AutoSize = true;
            this.lblTotalParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParcial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalParcial.Location = new System.Drawing.Point(6, 50);
            this.lblTotalParcial.Name = "lblTotalParcial";
            this.lblTotalParcial.Size = new System.Drawing.Size(83, 16);
            this.lblTotalParcial.TabIndex = 7;
            this.lblTotalParcial.Text = "Total Parcial";
            // 
            // gbMediosDePago
            // 
            this.gbMediosDePago.Controls.Add(this.rbMercadoPago);
            this.gbMediosDePago.Controls.Add(this.rbTransferencia);
            this.gbMediosDePago.Controls.Add(this.txtNumeroDeTarjeta);
            this.gbMediosDePago.Controls.Add(this.txtEfectivo);
            this.gbMediosDePago.Controls.Add(this.rbTarjetaDeCredito);
            this.gbMediosDePago.Controls.Add(this.rbEfectivo);
            this.gbMediosDePago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMediosDePago.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbMediosDePago.Location = new System.Drawing.Point(10, 344);
            this.gbMediosDePago.Name = "gbMediosDePago";
            this.gbMediosDePago.Size = new System.Drawing.Size(305, 202);
            this.gbMediosDePago.TabIndex = 3;
            this.gbMediosDePago.TabStop = false;
            this.gbMediosDePago.Text = "Pago y cierre";
            // 
            // rbMercadoPago
            // 
            this.rbMercadoPago.AutoSize = true;
            this.rbMercadoPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMercadoPago.Location = new System.Drawing.Point(18, 97);
            this.rbMercadoPago.Name = "rbMercadoPago";
            this.rbMercadoPago.Size = new System.Drawing.Size(113, 21);
            this.rbMercadoPago.TabIndex = 9;
            this.rbMercadoPago.TabStop = true;
            this.rbMercadoPago.Text = "Mercado Pago";
            this.rbMercadoPago.UseVisualStyleBackColor = true;
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTransferencia.Location = new System.Drawing.Point(18, 68);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(227, 21);
            this.rbTransferencia.TabIndex = 8;
            this.rbTransferencia.TabStop = true;
            this.rbTransferencia.Text = "Trasferencia: Alias (ArtemisappVet)";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // txtNumeroDeTarjeta
            // 
            this.txtNumeroDeTarjeta.Location = new System.Drawing.Point(189, 120);
            this.txtNumeroDeTarjeta.Name = "txtNumeroDeTarjeta";
            this.txtNumeroDeTarjeta.Size = new System.Drawing.Size(98, 25);
            this.txtNumeroDeTarjeta.TabIndex = 7;
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(189, 37);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(98, 25);
            this.txtEfectivo.TabIndex = 6;
            // 
            // rbTarjetaDeCredito
            // 
            this.rbTarjetaDeCredito.AutoSize = true;
            this.rbTarjetaDeCredito.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTarjetaDeCredito.Location = new System.Drawing.Point(18, 124);
            this.rbTarjetaDeCredito.Name = "rbTarjetaDeCredito";
            this.rbTarjetaDeCredito.Size = new System.Drawing.Size(173, 21);
            this.rbTarjetaDeCredito.TabIndex = 1;
            this.rbTarjetaDeCredito.TabStop = true;
            this.rbTarjetaDeCredito.Text = "Tarjeta de credito/Débito";
            this.rbTarjetaDeCredito.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbEfectivo.Location = new System.Drawing.Point(18, 40);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(71, 21);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEmitirFactura);
            this.groupBox5.Controls.Add(this.btnCobrarYFinalizar);
            this.groupBox5.Location = new System.Drawing.Point(620, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 268);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acciones de cierre";
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirFactura.Location = new System.Drawing.Point(18, 214);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(222, 37);
            this.btnEmitirFactura.TabIndex = 1;
            this.btnEmitirFactura.Text = "Emitir Factura (A/B/C/x)";
            this.btnEmitirFactura.UseVisualStyleBackColor = true;
            // 
            // btnCobrarYFinalizar
            // 
            this.btnCobrarYFinalizar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnCobrarYFinalizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarYFinalizar.Location = new System.Drawing.Point(18, 36);
            this.btnCobrarYFinalizar.Name = "btnCobrarYFinalizar";
            this.btnCobrarYFinalizar.Size = new System.Drawing.Size(222, 94);
            this.btnCobrarYFinalizar.TabIndex = 0;
            this.btnCobrarYFinalizar.Text = "Cobrar y Finalizar";
            this.btnCobrarYFinalizar.UseVisualStyleBackColor = false;
            this.btnCobrarYFinalizar.Click += new System.EventHandler(this.btnCobrarYFinalizar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackgroundImage = global::Artemisapp_UX.Properties.Resources.Fondo_patitas;
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Controls.Add(this.lblTotalACobrar);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(321, 233);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(293, 268);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resumen de cobro Final";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblVuelto);
            this.panel1.Controls.Add(this.lblMontoPendiente);
            this.panel1.Location = new System.Drawing.Point(23, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 109);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vuelto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto Pendiente";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Location = new System.Drawing.Point(103, 72);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(16, 13);
            this.lblVuelto.TabIndex = 1;
            this.lblVuelto.Text = "...";
            // 
            // lblMontoPendiente
            // 
            this.lblMontoPendiente.AutoSize = true;
            this.lblMontoPendiente.Location = new System.Drawing.Point(112, 26);
            this.lblMontoPendiente.Name = "lblMontoPendiente";
            this.lblMontoPendiente.Size = new System.Drawing.Size(16, 13);
            this.lblMontoPendiente.TabIndex = 0;
            this.lblMontoPendiente.Text = "...";
            // 
            // lblTotalACobrar
            // 
            this.lblTotalACobrar.AutoSize = true;
            this.lblTotalACobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalACobrar.ForeColor = System.Drawing.Color.Black;
            this.lblTotalACobrar.Location = new System.Drawing.Point(150, 90);
            this.lblTotalACobrar.Name = "lblTotalACobrar";
            this.lblTotalACobrar.Size = new System.Drawing.Size(98, 15);
            this.lblTotalACobrar.TabIndex = 10;
            this.lblTotalACobrar.Text = "💲 Pendiente...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 30);
            this.label9.TabIndex = 5;
            this.label9.Text = "TOTAL A COBRAR";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(14, 498);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(840, 27);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(754, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Artemisapp 🐱";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Rol:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Usuario: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescuentoIva);
            this.groupBox3.Controls.Add(this.txtDescuentos);
            this.groupBox3.Controls.Add(this.txtTotalParcial);
            this.groupBox3.Controls.Add(this.lblIva);
            this.groupBox3.Controls.Add(this.lblDescuentos);
            this.groupBox3.Controls.Add(this.lblTotalParcial);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales y Resumen";
            // 
            // txtDescuentoIva
            // 
            this.txtDescuentoIva.Location = new System.Drawing.Point(105, 137);
            this.txtDescuentoIva.Name = "txtDescuentoIva";
            this.txtDescuentoIva.Size = new System.Drawing.Size(162, 29);
            this.txtDescuentoIva.TabIndex = 12;
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.Location = new System.Drawing.Point(105, 93);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.Size = new System.Drawing.Size(162, 29);
            this.txtDescuentos.TabIndex = 11;
            // 
            // txtTotalParcial
            // 
            this.txtTotalParcial.Location = new System.Drawing.Point(105, 49);
            this.txtTotalParcial.Name = "txtTotalParcial";
            this.txtTotalParcial.Size = new System.Drawing.Size(162, 29);
            this.txtTotalParcial.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstbProductos);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 214);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar adicionales";
            // 
            // _07CobrarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbMediosDePago);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "_07CobrarConsulta";
            this.Text = "_07CobrarConsulta";
            this.Load += new System.EventHandler(this._07CobrarConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMediosDePago.ResumeLayout(false);
            this.gbMediosDePago.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbMediosDePago;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteFacturacion;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblTotalParcial;
        private System.Windows.Forms.RadioButton rbMercadoPago;
        private System.Windows.Forms.RadioButton rbTransferencia;
        private System.Windows.Forms.TextBox txtNumeroDeTarjeta;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.RadioButton rbTarjetaDeCredito;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.Button btnEmitirFactura;
        private System.Windows.Forms.Button btnCobrarYFinalizar;
        private System.Windows.Forms.Label lblTotalACobrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstbProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.Label lblMontoPendiente;
        private System.Windows.Forms.Button btnBuscarNroCte;
        private System.Windows.Forms.Label lblClienteNumero;
        private System.Windows.Forms.TextBox txtDescuentoIva;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.TextBox txtTotalParcial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}