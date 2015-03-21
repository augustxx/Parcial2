using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class ALMACENES
    {
        long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        int num_almacen;

        public int Num_almacen
        {
            get { return num_almacen; }
            set { num_almacen = value; }
        }
        string cod_producto;

        public string Cod_producto
        {
            get { return cod_producto; }
            set { cod_producto = value; }
        }
        double cantidad;

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        double stock_minimo;

        public double Stock_minimo
        {
            get { return stock_minimo; }
            set { stock_minimo = value; }
        }
    }
}
