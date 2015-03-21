using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoForms
{
    public partial class frmPrincipal : Form
    {
        //propiedades de la clase
        private double numero1, numero2, resultado; 
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_1.SelectedIndex = 1; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bsumar_Click(object sender, EventArgs e)
        {
            //Convertir los Value
            numero1 = Convert.ToDouble(nudnumero1.Value);
            numero2 = (double)nudnumero2.Value;

            if (CB_1.SelectedIndex == 0)
            {
                resultado = numero1 + numero2;
            }
            if (CB_1.SelectedIndex == 1)
            {
                resultado = numero1 - numero2;
            }
            if (CB_1.SelectedIndex == 2)
            {
                resultado = numero1 * numero2;
            }
            if (CB_1.SelectedIndex == 3)
            {
                if (numero2 <= 0)
                { 
                    
                }
                resultado = numero1 / numero2;
                
            }
            MessageBox.Show("El resultado es: " + resultado);
        }

        private void CB_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_1.SelectedIndex == 3)
            {
                if (nudnumero2.Value == 0)
                {
                    bsumar.Enabled = false;
                }
            }
            else
            {
                bsumar.Enabled = true;
            }
        }

        private void nudnumero2_ValueChanged(object sender, EventArgs e)
        {
            if (CB_1.SelectedIndex == 3)
            {
                if (nudnumero2.Value == 0)
                {
                    bsumar.Enabled = false;
                }
                else
                {
                    bsumar.Enabled = true;   
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
