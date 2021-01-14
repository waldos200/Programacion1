using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCarne.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtGuia.Clear();
            txtLaboratorio.Clear();
            txtParcial.Clear();
            txtCarneComp.Clear();
            txtNombreComp.Clear();
            txtResultado.Clear();
            grpDatosObtenidos.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            grpDatosObtenidos.Visible = true;
            string nombre, apellido, carnet;
            double guia, laboratorio, parcial, promedio;

            carnet = txtCarne.Text;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            try
            {
                guia = Convert.ToDouble(txtGuia.Text);
                laboratorio = Convert.ToDouble(txtLaboratorio.Text);
                parcial = Convert.ToDouble(txtParcial.Text);

                promedio = guia * .20 + laboratorio * .15 + parcial * .65;
                lblAprob.Visible = false;
                lblReprob.Visible = false;
                if (promedio >= 7)
                {
                    lblAprob.Visible = true;
                }
                else
                {
                    lblReprob.Visible = true;
                }
                txtCarneComp.Text = carnet;
                txtNombreComp.Text = nombre + " " + apellido;
                txtResultado.Text = Convert.ToString(promedio);
            }
            catch
            {
                grpDatosObtenidos.Visible = false;
                MessageBox.Show("Error datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
