using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_CapelloBruno
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;

            }
            else
            {
                if (Nvo.Codigo < Primero.Codigo)
                {
                    Nvo.siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    clsNodo Aux = Primero;
                    clsNodo Ant = Primero;

                    while (Aux.Codigo < Nvo.Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.siguiente;
                    }
                    Ant.siguiente = Nvo;
                    Nvo.siguiente = Aux;
                    Aux.Anterior = Nvo;
                    Nvo.Anterior = Ant;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux.Codigo != Codigo)
                    {
                        ant = aux;
                        aux = aux.siguiente;
                    }
                    ant.siguiente = aux.siguiente;
                    aux.siguiente.Anterior = ant;
                }
            }
        }

        public void RecorrerAscendente(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.siguiente;
            }
        }

        public void RecorrerDescendente(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
    }
}
