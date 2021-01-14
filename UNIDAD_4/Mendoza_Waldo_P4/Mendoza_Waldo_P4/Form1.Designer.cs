namespace Mendoza_Waldo_P4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCapturaDatos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.grpSalidadeDatos = new System.Windows.Forms.GroupBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtSalidaNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblSalidaGenero = new System.Windows.Forms.Label();
            this.txtSalidaGenero = new System.Windows.Forms.TextBox();
            this.lblSalidaSalario = new System.Windows.Forms.Label();
            this.txtSalidaSalario = new System.Windows.Forms.TextBox();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblISSS = new System.Windows.Forms.Label();
            this.txtISSS = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.lblAFP = new System.Windows.Forms.Label();
            this.lblRenta = new System.Windows.Forms.Label();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.grpCapturaDatos.SuspendLayout();
            this.grpSalidadeDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCapturaDatos
            // 
            this.grpCapturaDatos.Controls.Add(this.txtSalarioBase);
            this.grpCapturaDatos.Controls.Add(this.lblSalarioBase);
            this.grpCapturaDatos.Controls.Add(this.radFemenino);
            this.grpCapturaDatos.Controls.Add(this.radMasculino);
            this.grpCapturaDatos.Controls.Add(this.lblGenero);
            this.grpCapturaDatos.Controls.Add(this.lblNombre);
            this.grpCapturaDatos.Controls.Add(this.txtNombre);
            this.grpCapturaDatos.Location = new System.Drawing.Point(12, 12);
            this.grpCapturaDatos.Name = "grpCapturaDatos";
            this.grpCapturaDatos.Size = new System.Drawing.Size(329, 242);
            this.grpCapturaDatos.TabIndex = 0;
            this.grpCapturaDatos.TabStop = false;
            this.grpCapturaDatos.Text = "Captura de Datos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(27, 103);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(75, 21);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Genero:";
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(137, 101);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(92, 21);
            this.radMasculino.TabIndex = 4;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(137, 128);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(91, 21);
            this.radFemenino.TabIndex = 5;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Location = new System.Drawing.Point(27, 181);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(115, 21);
            this.lblSalarioBase.TabIndex = 6;
            this.lblSalarioBase.Text = "Salario Base:";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(137, 178);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(164, 22);
            this.txtSalarioBase.TabIndex = 7;
            // 
            // grpSalidadeDatos
            // 
            this.grpSalidadeDatos.Controls.Add(this.txtSalarioNeto);
            this.grpSalidadeDatos.Controls.Add(this.lblSalarioNeto);
            this.grpSalidadeDatos.Controls.Add(this.txtRenta);
            this.grpSalidadeDatos.Controls.Add(this.lblRenta);
            this.grpSalidadeDatos.Controls.Add(this.lblAFP);
            this.grpSalidadeDatos.Controls.Add(this.txtAFP);
            this.grpSalidadeDatos.Controls.Add(this.txtISSS);
            this.grpSalidadeDatos.Controls.Add(this.lblISSS);
            this.grpSalidadeDatos.Controls.Add(this.lblDescuentos);
            this.grpSalidadeDatos.Controls.Add(this.txtSalidaSalario);
            this.grpSalidadeDatos.Controls.Add(this.lblSalidaSalario);
            this.grpSalidadeDatos.Controls.Add(this.txtSalidaGenero);
            this.grpSalidadeDatos.Controls.Add(this.lblSalidaGenero);
            this.grpSalidadeDatos.Controls.Add(this.txtSalidaNombreEmpleado);
            this.grpSalidadeDatos.Controls.Add(this.lblNombreEmpleado);
            this.grpSalidadeDatos.Location = new System.Drawing.Point(385, 12);
            this.grpSalidadeDatos.Name = "grpSalidadeDatos";
            this.grpSalidadeDatos.Size = new System.Drawing.Size(362, 442);
            this.grpSalidadeDatos.TabIndex = 1;
            this.grpSalidadeDatos.TabStop = false;
            this.grpSalidadeDatos.Text = "Salida de Datos";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(34, 42);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(161, 21);
            this.lblNombreEmpleado.TabIndex = 0;
            this.lblNombreEmpleado.Text = "Nombre Empleado:";
            // 
            // txtSalidaNombreEmpleado
            // 
            this.txtSalidaNombreEmpleado.Location = new System.Drawing.Point(75, 66);
            this.txtSalidaNombreEmpleado.Name = "txtSalidaNombreEmpleado";
            this.txtSalidaNombreEmpleado.Size = new System.Drawing.Size(221, 22);
            this.txtSalidaNombreEmpleado.TabIndex = 1;
            // 
            // lblSalidaGenero
            // 
            this.lblSalidaGenero.AutoSize = true;
            this.lblSalidaGenero.Location = new System.Drawing.Point(34, 103);
            this.lblSalidaGenero.Name = "lblSalidaGenero";
            this.lblSalidaGenero.Size = new System.Drawing.Size(75, 21);
            this.lblSalidaGenero.TabIndex = 2;
            this.lblSalidaGenero.Text = "Genero:";
            // 
            // txtSalidaGenero
            // 
            this.txtSalidaGenero.Location = new System.Drawing.Point(75, 128);
            this.txtSalidaGenero.Name = "txtSalidaGenero";
            this.txtSalidaGenero.Size = new System.Drawing.Size(221, 22);
            this.txtSalidaGenero.TabIndex = 3;
            // 
            // lblSalidaSalario
            // 
            this.lblSalidaSalario.AutoSize = true;
            this.lblSalidaSalario.Location = new System.Drawing.Point(34, 185);
            this.lblSalidaSalario.Name = "lblSalidaSalario";
            this.lblSalidaSalario.Size = new System.Drawing.Size(115, 21);
            this.lblSalidaSalario.TabIndex = 4;
            this.lblSalidaSalario.Text = "Salario Base:";
            // 
            // txtSalidaSalario
            // 
            this.txtSalidaSalario.Location = new System.Drawing.Point(75, 220);
            this.txtSalidaSalario.Name = "txtSalidaSalario";
            this.txtSalidaSalario.Size = new System.Drawing.Size(105, 22);
            this.txtSalidaSalario.TabIndex = 5;
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(34, 257);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(156, 21);
            this.lblDescuentos.TabIndex = 6;
            this.lblDescuentos.Text = "Descuentos de ley";
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Location = new System.Drawing.Point(53, 290);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(53, 21);
            this.lblISSS.TabIndex = 7;
            this.lblISSS.Text = "ISSS:";
            // 
            // txtISSS
            // 
            this.txtISSS.Location = new System.Drawing.Point(172, 286);
            this.txtISSS.Name = "txtISSS";
            this.txtISSS.Size = new System.Drawing.Size(117, 22);
            this.txtISSS.TabIndex = 8;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(172, 324);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(117, 22);
            this.txtAFP.TabIndex = 9;
            // 
            // lblAFP
            // 
            this.lblAFP.AutoSize = true;
            this.lblAFP.Location = new System.Drawing.Point(53, 327);
            this.lblAFP.Name = "lblAFP";
            this.lblAFP.Size = new System.Drawing.Size(43, 21);
            this.lblAFP.TabIndex = 10;
            this.lblAFP.Text = "AFP";
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(53, 365);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(46, 17);
            this.lblRenta.TabIndex = 11;
            this.lblRenta.Text = "Renta";
            // 
            // txtRenta
            // 
            this.txtRenta.Location = new System.Drawing.Point(172, 362);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(117, 22);
            this.txtRenta.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(42, 298);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(42, 356);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(42, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Location = new System.Drawing.Point(53, 408);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(113, 21);
            this.lblSalarioNeto.TabIndex = 5;
            this.lblSalarioNeto.Text = "Salario Neto:";
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(172, 405);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(117, 22);
            this.txtSalarioNeto.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 492);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpSalidadeDatos);
            this.Controls.Add(this.grpCapturaDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCapturaDatos.ResumeLayout(false);
            this.grpCapturaDatos.PerformLayout();
            this.grpSalidadeDatos.ResumeLayout(false);
            this.grpSalidadeDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCapturaDatos;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpSalidadeDatos;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Label lblAFP;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtISSS;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.TextBox txtSalidaSalario;
        private System.Windows.Forms.Label lblSalidaSalario;
        private System.Windows.Forms.TextBox txtSalidaGenero;
        private System.Windows.Forms.Label lblSalidaGenero;
        private System.Windows.Forms.TextBox txtSalidaNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.Label lblSalarioNeto;
    }
}

