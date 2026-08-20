using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_CapelloBruno
{
    internal class clsCola
    {
        private clsNodo primero;
        private clsNodo ultimo;

        internal clsNodo Primero { get => primero; set => primero = value; }
        internal clsNodo Ultimo { get => ultimo; set => ultimo = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        //ListBox es lo que voy a recibir, lbLista es el nombre que le voy a dar al ListBox que recibo
        public void Recorrer(ListBox lbListado)
        {
            clsNodo aux = Primero;

            lbListado.Items.Clear();

            while (aux != null)
            {
                lbListado.Items.Add(aux.Codigo + " " + aux.Nombre + ", " + aux.Tramite);
                aux = aux.siguiente;
            }
        }
    }
}
