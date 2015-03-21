using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using HolaMundoForms.DB;

using HolaMundoForms.BO;

using MySql.Data;

using MySql.Data.MySqlClient;

using System.Data;




namespace HolaMundoForms.DAO
{

    class DAO_Almacenes
    { //PROPIEDADES         

        ConexionMYSQL oBasedeDatos = new ConexionMYSQL();

        DataSet dsProductos = null;

        string instruccionSQL;

        MySqlCommand comandoMySQL;

        MySqlDataAdapter datAdapterMySQL;

        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS  

        public int agregarNuevoRegistro(object elNuevoRegistro)
        {

            //convertimos nuestro objeto generico a uno de la clase             

            ALMACENES objetoTablaProducto = (ALMACENES)elNuevoRegistro;

            //preparamos el commando de MySQL    

            comandoMySQL = new MySqlCommand();

            //preparar el dataset     

            dsProductos = new DataSet();

            //preparar el dataAdapter...       

            datAdapterMySQL = new MySqlDataAdapter();

            //Establecer la conexion            

            comandoMySQL.Connection = oBasedeDatos.miConectorNET;

            oBasedeDatos.establecerConexionNET();

            //ARMAR la instruccion MYSQL: insert           

            instruccionSQL = "INSERT INTO ALMACENES (" +
                "cod_producto, num_almacen, cantidad, stock_minimo" +
                ") VALUES ( " +

                pcs(objetoTablaProducto.Cod_producto) + "," +

                (objetoTablaProducto.Num_almacen) + "," +

                objetoTablaProducto.Cantidad.ToString() + "," +

                objetoTablaProducto.Stock_minimo.ToString() + 
                
                " ) ";




            comandoMySQL.CommandText = instruccionSQL;

            int resultadodelComando = comandoMySQL.ExecuteNonQuery();

            if (resultadodelComando <= 0)
            {

                return 0; //HAY UN ERROR

            }

            return 1;

        }

        public String pcs(string Valor)
        {

            return "'" + Valor + "'";

        }

    }

}