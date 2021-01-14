namespace FrmEjercicio1
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
            this.grpValores = new System.Windows.Forms.GroupBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.grpResultados = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.pbxEcuacion = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpValores.SuspendLayout();
            this.grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEcuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // grpValores
            // 
            this.grpValores.Controls.Add(this.lblC);
            this.grpValores.Controls.Add(this.lblB);
            this.grpValores.Controls.Add(this.lblA);
            this.grpValores.Controls.Add(this.txtC);
            this.grpValores.Controls.Add(this.txtB);
            this.grpValores.Controls.Add(this.txtA);
            this.grpValores.ForeColor = System.Drawing.Color.White;
            this.grpValores.Location = new System.Drawing.Point(12, 23);
            this.grpValores.Name = "grpValores";
            this.grpValores.Size = new System.Drawing.Size(648, 126);
            this.grpValores.TabIndex = 0;
            this.grpValores.TabStop = false;
            this.grpValores.Text = "Valores Ecuación";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.ForeColor = System.Drawing.Color.White;
            this.lblC.Location = new System.Drawing.Point(446, 55);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(36, 25);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "c :";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.ForeColor = System.Drawing.Color.White;
            this.lblB.Location = new System.Drawing.Point(229, 55);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(37, 25);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "b :";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(21, 57);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(37, 25);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a :";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(488, 56);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(104, 26);
            this.txtC.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(272, 56);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(104, 26);
            this.txtB.TabIndex = 1;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(64, 56);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(104, 26);
            this.txtA.TabIndex = 0;
            // 
            // grpResultados
            // 
            this.grpResultados.Controls.Add(this.label5);
            this.grpResultados.Controls.Add(this.txtX2);
            this.grpResultados.Controls.Add(this.label4);
            this.grpResultados.Controls.Add(this.txtX1);
            this.grpResultados.ForeColor = System.Drawing.Color.White;
            this.grpResultados.Location = new System.Drawing.Point(12, 290);
            this.grpResultados.Name = "grpResultados";
            this.grpResultados.Size = new System.Drawing.Size(320, 133);
            this.grpResultados.TabIndex = 1;
            this.grpResultados.TabStop = false;
            this.grpResultados.Text = "Resultados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "X2 :";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(93, 85);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(104, 26);
            this.txtX2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "X1 :";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(93, 42);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(104, 26);
            this.txtX1.TabIndex = 4;
            // 
            // pbxEcuacion
            // 
            this.pbxEcuacion.Image = global::FrmEjercicio1.Properties.Resources.EcuacionCuadratica;
            this.pbxEcuacion.Location = new System.Drawing.Point(190, 181);
            this.pbxEcuacion.Name = "pbxEcuacion";
            this.pbxEcuacion.Size = new System.Drawing.Size(288, 92);
            this.pbxEcuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEcuacion.TabIndex = 2;
            this.pbxEcuacion.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(543, 306);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 50);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(543, 375);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 50);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEcuacionCuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pbxEcuacion);
            this.Controls.Add(this.grpResultados);
            this.Controls.Add(this.grpValores);
            this.Name = "frmEcuacionCuadratica";
            this.Text = "Ecuación Cuadratica";
            this.grpValores.ResumeLayout(false);
            this.grpValores.PerformLayout();
            this.grpResultados.ResumeLayout(false);
            this.grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEcuacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpValores;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.PictureBox pbxEcuacion;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

