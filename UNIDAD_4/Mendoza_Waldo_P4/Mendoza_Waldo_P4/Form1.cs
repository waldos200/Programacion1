using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mendoza_Waldo_P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre;
            bool genero;
            double salario, sueldoNeto = 0, isss, afp, renta = 0;

            nombre = txtNombre.Text;
            if(genero = radMasculino.Checked = true)
            {
                txtSalidaGenero.Text = "Masculino";
            } else if (genero = radFemenino.Checked = true)
            {
                txtSalidaGenero.Text = "Femenino";
            }
            try
            {
                salario = Convert.ToDouble(txtSalarioBase.Text);
                isss = salario * 0.03;
                afp = salario * 0.0725;
                if (salario <= 472.00)
                {
                    renta = salario * 1;
                    sueldoNeto = salario - isss - afp;
                    txtISSS.Text = isss.ToString();
                    txtAFP.Text = afp.ToString();
                    txtRenta.Text = renta.ToString();
                    txtSalarioNeto.Text = sueldoNeto.ToString();
                    MessageBox.Show("sin retencion de renta");
                } 
                else if(salario <= 895.24)
                {
                    renta = (salario - 472) * 0.10 + 17.67;
                    sueldoNeto = salario - renta - isss - afp;
                    txtISSS.Text = isss.ToString();
                    txtAFP.Text = afp.ToString();
                    txtRenta.Text = renta.ToString();
                    txtSalarioNeto.Text = sueldoNeto.ToString();
                }
                else if(salario <= 2038.10)
                {
                    renta = (salario - 895.24) * 0.20 + 60.00;
                    sueldoNeto = salario - renta - isss - afp;
                    txtISSS.Text = isss.ToString();
                    txtAFP.Text = afp.ToString();
                    txtRenta.Text = renta.ToString();
                    txtSalarioNeto.Text = sueldoNeto.ToString();
                }
                else
                {
                    renta = (salario - 2038.10) * 0.30 + 288.57;
                    sueldoNeto = salario - renta - isss - afp;
                    txtISSS.Text = isss.ToString();
                    txtAFP.Text = afp.ToString();
                    txtRenta.Text = renta.ToString();
                    txtSalarioNeto.Text = sueldoNeto.ToString();
                }
                txtSalidaNombreEmpleado.Text = nombre;
                txtSalidaSalario.Text = salario.ToString();
            }
            catch
            {
                MessageBox.Show("Error datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            radMasculino.Checked = false;
            radFemenino.Checked = false;
            txtSalarioBase.Clear();
            txtSalidaNombreEmpleado.Clear();
            txtSalidaGenero.Clear();
            txtSalidaSalario.Clear();
            txtISSS.Clear();
            txtAFP.Clear();
            txtRenta.Clear();
            txtSalarioNeto.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
