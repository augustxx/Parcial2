using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoForms.BO
{
    class SYS_USUARIOS
    {
        long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        string nombre_completo;

        public string Nombre_completo
        {
            get { return nombre_completo; }
            set { nombre_completo = value; }
        }
        string tipo_usuario;

        public string Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }

        string edad;

        public string Edad
        {
            get { return edad;}
            set { edad = value; }
        }
    }
}
