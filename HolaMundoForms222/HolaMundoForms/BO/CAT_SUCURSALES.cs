using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class CAT_SUCURSALES
    {
        long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string nombre_sucursal;

        public string Nombre_sucursal
        {
            get { return nombre_sucursal; }
            set { nombre_sucursal = value; }
        }
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        string responsable;

        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }
    }
   
}
