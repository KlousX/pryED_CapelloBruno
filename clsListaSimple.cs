using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_CapelloBruno
{
    internal class clsListaSimple
    {
        private clsNodo primero;

        public clsNodo Primero { get => primero; set => primero = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux != null && Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.siguiente;
                    }

                    ant.siguiente = Nuevo;
                    Nuevo.siguiente = aux;
                }
            }
        }

        public void Recorrer(DataGridView grilla)
        {
            clsNodo aux = Primero;
            grilla.Rows.Clear();
        }
    }
}
