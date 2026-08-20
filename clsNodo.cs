using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryED_CapelloBruno
{
    internal class clsNodo
    {
        private Int32 codigo;
        private string nombre;
        private string tramite;
        
        //Creación del nodo
        public clsNodo siguiente;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tramite { get => tramite; set => tramite = value; }
    }
}
