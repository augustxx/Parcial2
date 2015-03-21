using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using HolaMundoForms.BO;
using HolaMundoForms.DB;


namespace HolaMundoForms.DAO
{
    class DAO_proveedores
    {
        //PROPIEDADES         
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsProveedores = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;
        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS  
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            //convertimos nuestro objeto generico a uno de la clase             
            CAT_PROVEEDORES objetoTablaProveedor = (CAT_PROVEEDORES)elNuevoRegistro;

            //preparamos el commando de MySQL    
            comandoMySQL = new MySqlCommand();

            //preparar el dataset     
            dsProveedores = new DataSet();

            //preparar el dataAdapter...       
            datAdapterMySQL = new MySqlDataAdapter();

            //Establecer la conexion            
            comandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //ARMAR la instruccion MYSQL: insert           
            instruccionSQL = "INSERT INTO cat_proveedores (" +
                "razon_social, rfc, calle, numero_exterior, numero_interior, referencia, colonia, codigo_postal, contacto, municipio, estado, telefono, correo" +
                ") VALUES ( " +
                pcs(objetoTablaProveedor.Razon_social) + "," +
                pcs(objetoTablaProveedor.Rfc) + "," +
                pcs(objetoTablaProveedor.Calle) + "," +
                pcs(objetoTablaProveedor.Numero_exterior) + "," +
                pcs(objetoTablaProveedor.Numero_interior) + "," +
                pcs(objetoTablaProveedor.Referencia) + "," +
                pcs(objetoTablaProveedor.Colonia) + "," +
                pcs(objetoTablaProveedor.Codigopostal) + "," +
                pcs(objetoTablaProveedor.Contacto) + "," +
                pcs(objetoTablaProveedor.Municipio) + "," +
                pcs(objetoTablaProveedor.Estado) + "," +
                pcs(objetoTablaProveedor.Telefono) + "," +
                pcs(objetoTablaProveedor.Correo) +



                " ) ";

            comandoMySQL.CommandText = instruccionSQL;
            int resultadodelComando = comandoMySQL.ExecuteNonQuery();

            if (resultadodelComando <= 0)
            {
                return 0;

                //HAY UN ERROR         
            }
            return 1;
        }
        public String pcs(string Valor)
        {
            return
                "'" + Valor + "'";
        }
    }
}