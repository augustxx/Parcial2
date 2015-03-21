using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace HolaMundoForms.DB
{
    class ConexionMYSQL
    {
        //PROPIEDAD
        public MySqlConnection miConectorNET = new MySqlConnection();
        public ADODB._Connection miConectorODBC = new ADODB.Connection();

        public string MYSQL_CONEXION_NET = "Server=localhost; User ID=vendedor; Password = vendedor;" + "Persist Security Info=true; Database=pvpatolin";

        public string MYSQL_CONEXION_ODBC = "Driver={MySQL ODBC 5.3 ANSI Driver};"+ "Server=localhost;" + "User=vendedor; Password=vendedor; Database=pvpatolin;" + "Option=3";

        //METODO CONSTRUCTOR
        public ConexionMYSQL()
        {
        
        }
        //METODO PARA CONECTAR PARA LA LIBRERIA .DATA
        public void establecerConexionNET()
        {
            miConectorNET.ConnectionString = MYSQL_CONEXION_NET;
            miConectorNET.Open();
        }

        public void  cerrarConexionNET()
        {
            miConectorNET.Close();
        }
        //METODO PARA CONECARNOS CON LA IBRERIA ADODB
        public void establecerConexionODBC()
        {
            miConectorODBC.ConnectionString = MYSQL_CONEXION_ODBC;
            miConectorODBC.Open(null, null, null, 0);
        }

        public void cerrarConexionODBC()
        {
            miConectorODBC.Close();
        }

        //METODO QUE VERIFIQUE UNA INFORMACION E LA BASE DE DATOS
        public bool MYSQL_EXISTE_DATO(string instruccionSQL)
        {

            establecerConexionODBC();
            bool functionReturnValue = false;
            ADODB.Recordset rst = new ADODB.Recordset();
            rst.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            try
            {

                rst.Open(instruccionSQL, this.MYSQL_CONEXION_ODBC, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockReadOnly, -1);

                if (!rst.EOF)
                {

                    functionReturnValue = true;

                }

                else
                {

                    functionReturnValue = false;

                }

                rst.Close();

            }

            catch (System.Exception ex)
            {

                MessageBox.Show("ERROR: " + ex.Message);

            }

            rst = null;

            this.cerrarConexionODBC();

            return functionReturnValue;

        }


    }
}
