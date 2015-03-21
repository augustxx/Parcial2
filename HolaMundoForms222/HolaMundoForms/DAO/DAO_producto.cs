
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

{     class DAO_producto     
{  
        //PROPIEDADES         
    ConexionMYSQL oBasedeDatos = new ConexionMYSQL();       
    DataSet dsProductos = null;        
    string instruccionSQL;     
    MySqlCommand comandoMySQL;       
    MySqlDataAdapter datAdapterMySQL;  
        //METODO PARA INSERTAR UN NUEVO REGISTRO EN LA BASE DE DATOS  
    public int agregarNuevoRegistro(object elNuevoRegistro)      
    {            
        //convertimos nuestro objeto generico a uno de la clase             
       CAT_PRODUCTO objetoTablaProducto = (CAT_PRODUCTO)elNuevoRegistro;  
           
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
        instruccionSQL = "INSERT INTO cat_productos (" +      
            "cod_producto, nombre_completo, precio, costo, fecha_ingreso" +    
            ") VALUES ( " +            
            pcs(objetoTablaProducto.Cod_producto) + "," +   
            pcs(objetoTablaProducto.Nombre_completo) + "," +       
            objetoTablaProducto.Precio.ToString() + "," +          
            objetoTablaProducto.Costo.ToString() + "," +            
            " CURDATE() " +             
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
    } } 