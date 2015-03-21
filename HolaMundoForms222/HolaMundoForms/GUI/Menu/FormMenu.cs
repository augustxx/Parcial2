using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.Catalogos;

namespace HolaMundoForms.GUI.Menu
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
         Application.Exit();
        
        }

        private void b_Click(object sender, EventArgs e)
        {
            Productos Ventana = new Productos();
            Ventana.ShowDialog(); Ventana.Dispose();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Clientes Ventana = new Clientes();
            Ventana.ShowDialog(); Ventana.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proveedores Ventana = new Proveedores();
            Ventana.ShowDialog(); Ventana.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Almacen Ventana = new Almacen();
            Ventana.ShowDialog(); Ventana.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sucursales Ventana = new Sucursales();
            Ventana.ShowDialog(); Ventana.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Usuario Ventana = new Usuario();
            Ventana.ShowDialog(); Ventana.Dispose();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
