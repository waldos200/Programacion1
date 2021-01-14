using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBonificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            int horasnormales, horasextras;
            byte nhijos;
            double pagohnormal, pagohextra, sbruto, sneto, bonificacion;
            //inicializar
            bonificacion = 0.0;

            //entrada de datos
            try
            {
                horasnormales = Convert.ToInt32(txthoranormal.Text);
                horasextras = Convert.ToInt32(txthorasextras.Text);
                pagohnormal = Convert.ToDouble(txtpagohnormal.Text);
                pagohextra = Convert.ToDouble(txtpagohextra.Text);
                nhijos = Convert.ToByte(nudHijos.Value);
              
                //Proceso
                sbruto = horasnormales * pagohnormal + horasextras * pagohextra;

                //calculo de bonificación
                if (chkBono.Checked == true)
                {
                    bonificacion = nhijos * 20;
                }
                sneto = sbruto + bonificacion;

                //salida de la información
                txtsbruto.Text = "$ " + Convert.ToString(sbruto);
                txtbonificacion.Text = "$ " + Convert.ToString(bonificacion);
                txtsneto.Text = "$ " + Convert.ToString(sneto);
            }
            catch
            {
                MessageBox.Show("Error, datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txthoranormal.Clear();
            txthorasextras.Clear();
            txtpagohextra.Clear();
            txtpagohnormal.Clear();
            txtbonificacion.Clear();
            txtsbruto.Clear();
            txtsneto.Clear();
            nudHijos.Value = 0;
            chkbonificacion.Checked = false;
            txthoranormal.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txthoranormal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

