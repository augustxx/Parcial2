using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.DAO;
using HolaMundoForms.BO;

namespace HolaMundoForms.Catalogos
{
    public partial class Clientes : Form
    {
        private bool HAY_DATOS_VACIOS_EN_TEXTBOXES()
        {
            bool HAY_TEXTBOX_VACIOS = false;
            foreach (Control ctrl in this.Controls)
            //PARA CADA CONTROL DENTRO DEL FORMULARIO             
            {
                if ((object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                    & (!HAY_TEXTBOX_VACIOS))
                {
                    if (ctrl.Text.Trim() == String.Empty)
                    {
                        HAY_TEXTBOX_VACIOS = true;
                        break;
                    }
                }
            }
            return HAY_TEXTBOX_VACIOS;
        }
        public void VALIDA_CARACTERES_EN_TEXTBOXES(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case
                '\'': //COMILLA SENCILLA                     
                    e.Handled = true;
                    break;
                case '\\':// DIAGONAL INVERTIDA                     
                    e.Handled = true;
                    break;
                case
                'à':
                    e.Handled = true;
                    break;
                case
                'È':
                    e.Handled = true;
                    break;
                case
                '`':
                    e.Handled = true;
                    break;
                case
                '´':
                    e.Handled = true;
                    break;
                case
                '&':
                    e.Handled = true;
                    break;
                case
                'û':
                    e.Handled = true;
                    break;
                case
                '^':
                    e.Handled = true;
                    break;
                case
                '|':
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }
        public void ENVIAR_DATOS_NUEVO_REGISTRO()
        {
            int i = 0;
            //NUEVO OBJETO DE LA CLASE PRODUCTO de la carpeta BO (Cat_productos)
            cat_clientes oCliente = new cat_clientes();

            //Nuevo OBJETO DE LA CLASE DAO_producto de la carpeta DAO             
            DAO_cliente oClienteDAO = new DAO_cliente();

            //LLENAR PROPIEDADES DEL OBJETO PRODUCTO, CON CADA DATO CAPTURADO EN LA PANTALLA             
            //Objeto.Propiedad = Pantalla.ComponenteVisual.Valor;

            oCliente.Razon_social = this.txt_Razon_social.Text.Trim();
            oCliente.Rfc = this.txt_Rfc.Text.Trim();
            oCliente.Calle = this.txt_Calle.Text.Trim();
            oCliente.Numero_exterior = this.txt_Numero_exterior.Text.Trim();
            oCliente.Numero_interior = this.txt_Numero_interior.Text.Trim();
            oCliente.Referencia = this.txt_Referencia.Text.Trim();
            oCliente.Colonia = this.txt_Colonia.Text.Trim();
            oCliente.Codigopostal = this.txt_Codigopostal.Text.Trim();
            oCliente.Municipio = this.txt_Municipio.Text.Trim();
            oCliente.Estado = this.txt_Estado.Text.Trim();
            oCliente.Telefono = this.txt_Telefono.Text.Trim();
            oCliente.Correo = this.txt_Correo.Text.Trim();

            //LLAMAMOS AL METODO DE LA CLASE DAO QUE HACE EL INSERT, le enviamos como parametro el objeto oProducto que             
            //ya llenamos con los valores de la pantalla             
            i = oClienteDAO.agregarNuevoRegistro(oCliente);
            //VERIFICAMOS SI SE HA EJECUTADO CORRECTAMENTE LA ACCION SOLICITADA             
            if (i == 0)
            {
                MessageBox.Show("El proceso no se pudo realizar");
            }
            else
            {
                MessageBox.Show("El proceso se genero con éxito");
            }
            //MATAMOS A LOS OBJETOS UTILIZADOS             
            oCliente = null;
            oClienteDAO = null;
        }  
        public Clientes()
        {
            InitializeComponent();
        }

        private void NuevoUsusario_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (HAY_DATOS_VACIOS_EN_TEXTBOXES())
            //SI FALTA POR CAPTURAR UN DATO             
            {
                MessageBox.Show("Hay datos sin capturar, favor de revisar su pantalla de datos.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult dr = MessageBox.Show("¿Desea continuar y agregar un nuevo registro?.",
                    "Agregar Nuevo Registro", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        ENVIAR_DATOS_NUEVO_REGISTRO();
                        this.Close();
                        break;
                    case DialogResult.No:
                        break;
                }
            } 
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
