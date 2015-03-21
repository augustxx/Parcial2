using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolaMundoForms.DB;
using HolaMundoForms.GUI.Menu;

namespace HolaMundoForms
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            //this.Close(); o Application.Exit();
            Application.Exit();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        //Revisar el usuario registrado

        public void REVISA_USUARIO_REGISTRADO()
        { 
            
        }

        public bool VERIFICA_USUARIO_PASSWORD()
        {
            bool validar = true;
            //Valiar que el usuario no sea espacio en blanco
            if(this.textuser.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese usuario, por favor");
                validar = false;
                return validar;
            }

            //Valiar que la contraseña no sea espacio en blanco
            if (this.textpassword.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese password, por favor");
                validar = false;
                return validar;
            }

            //Si el usuario es incorrecto
            //if (this.textuser.Text.Trim() != "admin")
            //{
                //MessageBox.Show("Ingrese usuario válido, por favor");
               // validar = false;
              //  return validar;
            //}
            //Si el usuario es incorrecto
            //if (this.textpassword.Text.Trim() != "contraseña")
           // {
               // MessageBox.Show("Ingrese password válido, por favor");
                //validar = false;
              //  return validar;
            //}//
            //CREAR EL OBJETO QUE ME CONECTA A LA BASE DE DATOS...
            ConexionMYSQL objetoODBC = new ConexionMYSQL();

            //CREAMOS LA SENTENCIA SQL QUE ME DEVUELVE LOS DATOS QUE CONCUERDAN CON LA CONDICION "WHERE"
            string SentenciaSQL;
            SentenciaSQL = "select usuario from sys_usuario where usuario= '" + textuser.Text + "' and contrasena = '" + textpassword.Text + "'";
            //VALIDAR QUE LA COMBINACION DE USUARIO Y CONTRASEÑA EXISTA
            if (!objetoODBC.MYSQL_EXISTE_DATO(SentenciaSQL))
            {
                //SI NO EXISTE ESA COMBINACION, LOS DATOS SON INCORRECTOS
                MessageBox.Show("DATOS DE ACCESO INCORRECTOS!", "ERROR");
                validar = false;
                return validar;
            }

            return validar;

            return true;
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            if (this.VERIFICA_USUARIO_PASSWORD())
            {
                MessageBox.Show("Ingreso correcto");
                
                this.Hide();



                FrmMenu miVentana = new FrmMenu();

                miVentana.ShowDialog();

            }
        }

        private void textuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             
             * if (e.KeyChar == 13)
            { 
            }
            
             */

           
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("Espacios no permitidos");
                e.Handled = true;   
            }

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            NuevoUsuario miVentana = new NuevoUsuario();
            miVentana.ShowDialog();
            miVentana.Dispose();
      


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
