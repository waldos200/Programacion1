using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declaración de variables
            double a = Double.Parse(txtA.Text);
            double b = Double.Parse(txtB.Text);
            double c = Double.Parse(txtC.Text);

            double X1, X2;
            double bCuadrado, Divisor, Radical;

            try
            {

                //Proceso
                bCuadrado = Math.Pow(b, 2);
                Divisor = (2 * a);
                Radical = bCuadrado - (4 * a * c);

                //Validaciones
                if (Radical < 0)
                {
                    MessageBox.Show("El radical no puede ser Negativo, ingrese de nuevo los valores","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtA.Focus();
                    return;
                }

                if (Divisor == 0)
                {
                    MessageBox.Show("La division no puede entre cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtA.Focus();
                    return;
                }

                //Calculo la de la ecuacion
                X1 = (-b + Math.Sqrt(Radical)) / Divisor;
                X2 = (-b - Math.Sqrt(Radical)) / Divisor;

                //Salida
                txtX1.Text = Convert.ToString(X1);
                txtX2.Text = Convert.ToString(X2);
            }
            catch
            {
                MessageBox.Show("Error, Datos no validos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtX1.Clear();
            txtX2.Clear();
        }
    }
}
