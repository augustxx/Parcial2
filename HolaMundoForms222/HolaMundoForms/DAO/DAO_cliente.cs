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
    class DAO_cliente
    {
        //PROPIEDADES         
        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();
        DataSet dsClientes = null;
        string instruccionSQL;
        MySqlCommand comandoMySQL;
        MySqlDataAdapter datAdapterMySQL;
        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS  
        public int agregarNuevoRegistro(object elNuevoRegistro)
        {
            //convertimos nuestro objeto generico a uno de la clase             
            cat_clientes objetoTablaCliente = (cat_clientes)elNuevoRegistro;

            //preparamos el commando de MySQL    
            comandoMySQL = new MySqlCommand();

            //preparar el dataset     
            dsClientes = new DataSet();

            //preparar el dataAdapter...       
            datAdapterMySQL = new MySqlDataAdapter();

            //Establecer la conexion            
            comandoMySQL.Connection = oBasedeDatos.miConectorNET;
            oBasedeDatos.establecerConexionNET();

            //ARMAR la instruccion MYSQL: insert           
            instruccionSQL = "INSERT INTO cat_clientes (" +
                "razon_social, rfc, calle, numero_exterior, numero_interior, referencia, colonia, codigo_postal, localidad, municipio, estado, telefono, correo" +
                ") VALUES ( " +
                pcs(objetoTablaCliente.Razon_social) + "," +
                pcs(objetoTablaCliente.Rfc) + "," +
                pcs(objetoTablaCliente.Calle) + "," +
                pcs(objetoTablaCliente.Numero_exterior) + "," +
                pcs(objetoTablaCliente.Numero_interior) + "," +
                pcs(objetoTablaCliente.Referencia) + "," +
                pcs(objetoTablaCliente.Colonia) + "," +
                pcs(objetoTablaCliente.Codigopostal) + "," +
                pcs(objetoTablaCliente.Localidad) + "," +
                pcs(objetoTablaCliente.Municipio) + "," +
                pcs(objetoTablaCliente.Estado) + "," +
                pcs(objetoTablaCliente.Telefono) + "," +
                pcs(objetoTablaCliente.Correo) + 


               
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