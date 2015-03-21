using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class CAT_PRODUCTO
    {
        long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        string cod_producto;

        public string Cod_producto
        {
            get { return cod_producto; }
            set { cod_producto = value; }
        }
        string nombre_completo;

        public string Nombre_completo
        {
            get { return nombre_completo; }
            set { nombre_completo = value; }
        }
        double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        double costo;

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        DateTime fecha_ingreso;

        public DateTime Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }
    }
}
