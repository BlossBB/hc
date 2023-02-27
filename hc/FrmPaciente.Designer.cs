namespace hc
{
    partial class FrmPaciente
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
            this.tbcPaciente = new System.Windows.Forms.TabControl();
            this.tbpDatosPersonales = new System.Windows.Forms.TabPage();
            this.txtNumExpediente = new System.Windows.Forms.TextBox();
            this.lblNumExpediente = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbpDomicilio = new System.Windows.Forms.TabPage();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.mntFechaAlta = new System.Windows.Forms.MonthCalendar();
            this.cmbOcupacion = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.cmbEscolaridad = new System.Windows.Forms.ComboBox();
            this.lblEscolaridad = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.txtNumeroExterior = new System.Windows.Forms.TextBox();
            this.lblNumeroExterior = new System.Windows.Forms.Label();
            this.txtNumeroInterior = new System.Windows.Forms.TextBox();
            this.lblNumeroInterior = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.cmbEtnia = new System.Windows.Forms.ComboBox();
            this.lblEtnia = new System.Windows.Forms.Label();
            this.tbcPaciente.SuspendLayout();
            this.tbpDatosPersonales.SuspendLayout();
            this.tbpDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPaciente
            // 
            this.tbcPaciente.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcPaciente.Controls.Add(this.tbpDatosPersonales);
            this.tbcPaciente.Controls.Add(this.tbpDomicilio);
            this.tbcPaciente.Location = new System.Drawing.Point(13, 13);
            this.tbcPaciente.Multiline = true;
            this.tbcPaciente.Name = "tbcPaciente";
            this.tbcPaciente.SelectedIndex = 0;
            this.tbcPaciente.Size = new System.Drawing.Size(812, 435);
            this.tbcPaciente.TabIndex = 0;
            // 
            // tbpDatosPersonales
            // 
            this.tbpDatosPersonales.Controls.Add(this.cmbEtnia);
            this.tbpDatosPersonales.Controls.Add(this.lblEtnia);
            this.tbpDatosPersonales.Controls.Add(this.cmbEscolaridad);
            this.tbpDatosPersonales.Controls.Add(this.lblEscolaridad);
            this.tbpDatosPersonales.Controls.Add(this.cmbEstadoCivil);
            this.tbpDatosPersonales.Controls.Add(this.lblEstadoCivil);
            this.tbpDatosPersonales.Controls.Add(this.cmbOcupacion);
            this.tbpDatosPersonales.Controls.Add(this.lblOcupacion);
            this.tbpDatosPersonales.Controls.Add(this.mntFechaAlta);
            this.tbpDatosPersonales.Controls.Add(this.lblFechaAlta);
            this.tbpDatosPersonales.Controls.Add(this.cmbGenero);
            this.tbpDatosPersonales.Controls.Add(this.lblGenero);
            this.tbpDatosPersonales.Controls.Add(this.txtTelefono);
            this.tbpDatosPersonales.Controls.Add(this.lblTelefono);
            this.tbpDatosPersonales.Controls.Add(this.txtNombre);
            this.tbpDatosPersonales.Controls.Add(this.lblNombre);
            this.tbpDatosPersonales.Controls.Add(this.txtNumExpediente);
            this.tbpDatosPersonales.Controls.Add(this.lblNumExpediente);
            this.tbpDatosPersonales.Controls.Add(this.txtId);
            this.tbpDatosPersonales.Controls.Add(this.lblId);
            this.tbpDatosPersonales.Location = new System.Drawing.Point(25, 4);
            this.tbpDatosPersonales.Name = "tbpDatosPersonales";
            this.tbpDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosPersonales.Size = new System.Drawing.Size(783, 427);
            this.tbpDatosPersonales.TabIndex = 0;
            this.tbpDatosPersonales.Text = "Datos Personales";
            this.tbpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // txtNumExpediente
            // 
            this.txtNumExpediente.Location = new System.Drawing.Point(152, 58);
            this.txtNumExpediente.Name = "txtNumExpediente";
            this.txtNumExpediente.Size = new System.Drawing.Size(100, 22);
            this.txtNumExpediente.TabIndex = 3;
            // 
            // lblNumExpediente
            // 
            this.lblNumExpediente.AutoSize = true;
            this.lblNumExpediente.Location = new System.Drawing.Point(13, 64);
            this.lblNumExpediente.Name = "lblNumExpediente";
            this.lblNumExpediente.Size = new System.Drawing.Size(126, 16);
            this.lblNumExpediente.TabIndex = 2;
            this.lblNumExpediente.Text = "Numero Expediente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(117, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // tbpDomicilio
            // 
            this.tbpDomicilio.Controls.Add(this.txtColonia);
            this.tbpDomicilio.Controls.Add(this.lblColonia);
            this.tbpDomicilio.Controls.Add(this.txtNumeroExterior);
            this.tbpDomicilio.Controls.Add(this.lblNumeroExterior);
            this.tbpDomicilio.Controls.Add(this.txtNumeroInterior);
            this.tbpDomicilio.Controls.Add(this.lblNumeroInterior);
            this.tbpDomicilio.Controls.Add(this.txtCalle);
            this.tbpDomicilio.Controls.Add(this.lblCalle);
            this.tbpDomicilio.Location = new System.Drawing.Point(25, 4);
            this.tbpDomicilio.Name = "tbpDomicilio";
            this.tbpDomicilio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDomicilio.Size = new System.Drawing.Size(783, 427);
            this.tbpDomicilio.TabIndex = 1;
            this.tbpDomicilio.Text = "Domicilio";
            this.tbpDomicilio.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(153, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(80, 120);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 92);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(86, 148);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(153, 144);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 24);
            this.cmbGenero.TabIndex = 9;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(330, 34);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(71, 16);
            this.lblFechaAlta.TabIndex = 10;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // mntFechaAlta
            // 
            this.mntFechaAlta.Location = new System.Drawing.Point(412, 35);
            this.mntFechaAlta.Name = "mntFechaAlta";
            this.mntFechaAlta.TabIndex = 11;
            // 
            // cmbOcupacion
            // 
            this.cmbOcupacion.FormattingEnabled = true;
            this.cmbOcupacion.Location = new System.Drawing.Point(153, 172);
            this.cmbOcupacion.Name = "cmbOcupacion";
            this.cmbOcupacion.Size = new System.Drawing.Size(121, 24);
            this.cmbOcupacion.TabIndex = 13;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(69, 176);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(72, 16);
            this.lblOcupacion.TabIndex = 12;
            this.lblOcupacion.Text = "Ocupacion";
            // 
            // cmbEscolaridad
            // 
            this.cmbEscolaridad.FormattingEnabled = true;
            this.cmbEscolaridad.Location = new System.Drawing.Point(153, 230);
            this.cmbEscolaridad.Name = "cmbEscolaridad";
            this.cmbEscolaridad.Size = new System.Drawing.Size(121, 24);
            this.cmbEscolaridad.TabIndex = 17;
            // 
            // lblEscolaridad
            // 
            this.lblEscolaridad.AutoSize = true;
            this.lblEscolaridad.Location = new System.Drawing.Point(60, 234);
            this.lblEscolaridad.Name = "lblEscolaridad";
            this.lblEscolaridad.Size = new System.Drawing.Size(80, 16);
            this.lblEscolaridad.TabIndex = 16;
            this.lblEscolaridad.Text = "Escolaridad";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(153, 202);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(121, 24);
            this.cmbEstadoCivil.TabIndex = 15;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(62, 206);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(78, 16);
            this.lblEstadoCivil.TabIndex = 14;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(132, 101);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 22);
            this.txtColonia.TabIndex = 15;
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(25, 106);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(53, 16);
            this.lblColonia.TabIndex = 14;
            this.lblColonia.Text = "Colonia";
            // 
            // txtNumeroExterior
            // 
            this.txtNumeroExterior.Location = new System.Drawing.Point(132, 73);
            this.txtNumeroExterior.Name = "txtNumeroExterior";
            this.txtNumeroExterior.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroExterior.TabIndex = 13;
            // 
            // lblNumeroExterior
            // 
            this.lblNumeroExterior.AutoSize = true;
            this.lblNumeroExterior.Location = new System.Drawing.Point(25, 78);
            this.lblNumeroExterior.Name = "lblNumeroExterior";
            this.lblNumeroExterior.Size = new System.Drawing.Size(103, 16);
            this.lblNumeroExterior.TabIndex = 12;
            this.lblNumeroExterior.Text = "Numero Exterior";
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.Location = new System.Drawing.Point(132, 44);
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroInterior.TabIndex = 11;
            // 
            // lblNumeroInterior
            // 
            this.lblNumeroInterior.AutoSize = true;
            this.lblNumeroInterior.Location = new System.Drawing.Point(25, 49);
            this.lblNumeroInterior.Name = "lblNumeroInterior";
            this.lblNumeroInterior.Size = new System.Drawing.Size(98, 16);
            this.lblNumeroInterior.TabIndex = 10;
            this.lblNumeroInterior.Text = "Numero Interior";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(132, 16);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 22);
            this.txtCalle.TabIndex = 9;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(25, 21);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 16);
            this.lblCalle.TabIndex = 8;
            this.lblCalle.Text = "Calle";
            // 
            // cmbEtnia
            // 
            this.cmbEtnia.FormattingEnabled = true;
            this.cmbEtnia.Location = new System.Drawing.Point(153, 258);
            this.cmbEtnia.Name = "cmbEtnia";
            this.cmbEtnia.Size = new System.Drawing.Size(121, 24);
            this.cmbEtnia.TabIndex = 19;
            // 
            // lblEtnia
            // 
            this.lblEtnia.AutoSize = true;
            this.lblEtnia.Location = new System.Drawing.Point(102, 262);
            this.lblEtnia.Name = "lblEtnia";
            this.lblEtnia.Size = new System.Drawing.Size(37, 16);
            this.lblEtnia.TabIndex = 18;
            this.lblEtnia.Text = "Etnia";
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 568);
            this.Controls.Add(this.tbcPaciente);
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            this.tbcPaciente.ResumeLayout(false);
            this.tbpDatosPersonales.ResumeLayout(false);
            this.tbpDatosPersonales.PerformLayout();
            this.tbpDomicilio.ResumeLayout(false);
            this.tbpDomicilio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPaciente;
        private System.Windows.Forms.TabPage tbpDatosPersonales;
        private System.Windows.Forms.TabPage tbpDomicilio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNumExpediente;
        private System.Windows.Forms.Label lblNumExpediente;
        private System.Windows.Forms.ComboBox cmbEscolaridad;
        private System.Windows.Forms.Label lblEscolaridad;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbOcupacion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.MonthCalendar mntFechaAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.TextBox txtNumeroExterior;
        private System.Windows.Forms.Label lblNumeroExterior;
        private System.Windows.Forms.TextBox txtNumeroInterior;
        private System.Windows.Forms.Label lblNumeroInterior;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.ComboBox cmbEtnia;
        private System.Windows.Forms.Label lblEtnia;
    }
}